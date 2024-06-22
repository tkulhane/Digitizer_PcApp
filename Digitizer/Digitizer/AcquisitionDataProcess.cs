﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Digitizer_ver1
{
    class AcquisitionDataProcess
    {

        public DataGridView dataGridView_Events;
        public Chart chart_data;
        public CheckBox checkBox_SaveToRam;
        public CheckBox checkBox_SaveToFile;

        public CheckBox checkBox_EventsLastAutoSelect;
        public CheckBox checkBox_EventsLastAutoAnalyze;
        public CheckBox checkBox_EventsMaxCount;
        public CheckBox checkBox_EventsAutoLoad;
        public NumericUpDown numericUpDown_EventsMaxCount;

        public PictureBox pictureBox_EventAnalyze;


        BindingList<AcquisitionDataProcess_Data> List_EventsData = new BindingList<AcquisitionDataProcess_Data>();

        AcquisitionDataProcess_Data ActualEventData;

        UInt32 EventsCount_Started = 0;
        UInt32 EventsCount_Completed = 0;
        UInt32 PacketCounter = 0;
        int FrameInPacketCounter = 0;

        int frameOrder_Last;
        int frameOrder;

        bool SavingInRam = false;
        bool SavingInFile = false;

        public int ErrorCounter = 0;

        public void SetAcquisitionDataProcess() 
        {
            dataGridView_Events.DataSource = List_EventsData;

            for (int i = 0; i < dataGridView_Events.Columns.Count; i++)
            {
                dataGridView_Events.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            dataGridView_Events.SelectionChanged += new System.EventHandler(GridSelectedChange);

        }

        private void GridSelectedChange(object sender, EventArgs e)
        {
            if (checkBox_EventsAutoLoad.Checked) 
            {
                LoadEventResults();
            }
        }

        public void ExecuteData(byte[] data)
        {

            string logStr = string.Empty;
            string logErr = string.Empty;

            if (data[0] == 0xFA) //Event head - actualing Number Of Event
            {
                if (EventsCount_Completed != EventsCount_Started)
                {
                    //error
                    ErrorCounter++;
                    logErr += "Event Counts ";
                    logErr += "S=" + EventsCount_Started.ToString();
                    logErr += " C=" + EventsCount_Completed.ToString();
                }
                EventsCount_Started++;

                int eventNumber = data[3] + (data[2] << 8) + ((data[1] & 0x0F) << 16); 

                ActualEventData = null;
                ActualEventData = new AcquisitionDataProcess_Data(eventNumber);

                logStr += "Event Head; Event Num = " + ActualEventData.p_eventNum.ToString();

            }

            else if (data[0] == 0xFB) //Event tail - store event
            {
                int packetTotCount = data[3] + (data[2] << 8) + ((data[1] & 0x0F) << 16);

                if (PacketCounter != packetTotCount) 
                {
                    //error
                    ErrorCounter++;
                    logErr += "Packet Order ";
                }
                PacketCounter = 0;

                EventsCount_Completed++;
                if(EventsCount_Completed != EventsCount_Started) 
                {
                    //Error
                    ErrorCounter++;
                    logErr += "Event Counts ";
                    logErr += "S=" + EventsCount_Started.ToString();
                    logErr += " C=" + EventsCount_Completed.ToString();
                }

                SaveEventData();
                ActualEventData = null;


                logStr += "Event Tail; Packet Count = " + packetTotCount.ToString();
                logStr += Environment.NewLine;
            }

            else if (data[0] == 0xFC) //Packet head
            {
                PacketCounter++;

                logStr += "Packet Head; Packet Num = " + data[3].ToString();
            }

            else if (data[0] == 0xFD) //Packet tail
            {
                int packetNum = data[3] + (data[2] << 8) + ((data[1] & 0x0F) << 16);

                if (FrameInPacketCounter != packetNum) 
                {
                    //error
                    ErrorCounter++;
                    logErr += "Frame Count ";
                }
                FrameInPacketCounter = 0;

                logStr += "Packet Tail; Frames Count = " + data[3].ToString();
            }

            else if ((data[0] & 0x80) >> 7 == 0) // data frame
            {
                
                frameOrder_Last = frameOrder;
                frameOrder = data[0];

                if(FrameInPacketCounter == 0) 
                {
                    if(frameOrder != 0) 
                    {
                        //error
                        ErrorCounter++;
                        logErr += "Frame Order 0 ";
                    }
                }

                else if(frameOrder != frameOrder_Last + 1) 
                {
                    //error
                    ErrorCounter++;
                    logErr += "Frame Order ";
                    logErr += "C=" + frameOrder.ToString();
                    logErr += " L=" + frameOrder_Last.ToString();
                }

                FrameInPacketCounter++;

                
                int sample1 = data[3] + ((data[2] & 0x0F) << 8);
                int sample2 = ((data[2] & 0xF0) >> 4) + (data[1] << 4);

                if(ActualEventData != null)
                {
                    ActualEventData.AddSampleAndSize(sample1);
                    ActualEventData.AddSampleAndSize(sample2);
                }


                logStr += "Frame = " + frameOrder.ToString();
                logStr += "; Sample 1 = " + sample1.ToString();
                logStr += "; Sample 2 = " + sample2.ToString();

               
            }
            
            logStr += Environment.NewLine;


            if (checkBox_SaveToFile.Checked) 
            {
                using (StreamWriter writer = File.AppendText("log_Communication_data.txt"))
                {
                    writer.Write(logStr);
                }
            }


        }

        public void LoadEventResults() 
        {
            chart_EventTime_Click(null, null);
            pictureBox_EventAnalyze_Click(null, null);
        }


        private void SaveEventData() 
        {
            if (ActualEventData == null) return;
            
            if (SavingInRam) 
            {
                List_EventsData.Add(ActualEventData);
                dataGridView_Events.Update();
                AutoLoadEvent();
            }
            if (SavingInFile) 
            {
                

            }
        }

        private void AutoLoadEvent() 
        {
            if (checkBox_EventsLastAutoSelect.Checked || checkBox_EventsLastAutoAnalyze.Checked) 
            {
                int count = List_EventsData.Count;
                for(int i = 0; i< count; i++) 
                {
                    dataGridView_Events.Rows[i].Selected = false;
                }
                
                dataGridView_Events.Rows[count - 1].Selected = true;

                if(checkBox_EventsLastAutoSelect.Checked) chart_EventTime_Click(null, null);
                if (checkBox_EventsLastAutoAnalyze.Checked) AnalyzeAdcStart();

            }
        }


        public void UpdateSaving() 
        {
            SavingInRam = checkBox_SaveToRam.Checked;
            SavingInFile = checkBox_SaveToFile.Checked;
        }

        public void chart_EventTime_Click(object sender, EventArgs e)
        {
            Thread thread_paint = new Thread(this.ChartPaintTask);
            thread_paint.Start();
        }

        public void pictureBox_EventAnalyze_Click(object sender, EventArgs e) 
        {
            int selectedRows = dataGridView_Events.SelectedRows.Count;

            int selectedIndex = dataGridView_Events.SelectedRows[selectedRows-1].Index;
            AcquisitionDataProcess_Data ActualEventData = List_EventsData[selectedIndex];
            int eventNum = ActualEventData.p_eventNum;

            string fname = Environment.CurrentDirectory + @"\Results\Event_" + eventNum.ToString() + ".png";

            using(FileStream fs = new System.IO.FileStream(fname, FileMode.Open, FileAccess.Read)) 
            {
                pictureBox_EventAnalyze.Image = Image.FromStream(fs);
                fs.Close();
            }
            
        }

        private void ChartPaintTask()
        {
            if (chart_data.InvokeRequired) 
            {
                chart_data.Invoke(new MethodInvoker(DataChartPaint));
            }
            else 
            {
                DataChartPaint();
            }
        }

        private void DataChartPaint() 
        {
            int selectedRows = dataGridView_Events.SelectedRows.Count;

            if (selectedRows == 0)
            {
                return;
            }

            chart_data.Series.Clear();

            for (int r = 0; r < selectedRows; r++)
            {
                int selectedIndex = dataGridView_Events.SelectedRows[r].Index;
                AcquisitionDataProcess_Data ActualEventData = List_EventsData[selectedIndex];

                chart_data.Series.Add(r.ToString());
                chart_data.Series[r.ToString()].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart_data.Series[r.ToString()].LegendText = ActualEventData.p_eventNum.ToString();
                chart_data.Series[r.ToString()].BorderWidth = 3;

                for (int i = 0; i < ActualEventData.List_SampleData.Count; i++)
                {
                    chart_data.Series[r.ToString()].Points.AddY(ActualEventData.List_SampleData[i]);
                }
            }

            chart_data.DataBind();
        }


        public void ClearEventsList() 
        {
            List_EventsData.Clear();
        }

        public void SaveEvent()
        {
            int selectedRows = dataGridView_Events.SelectedRows.Count;

            if (selectedRows == 0)
            {
                return;
            }


            String fname = String.Empty;
            using (SaveFileDialog ofd = new SaveFileDialog())
            {
                ofd.Filter = "Soubory dat (*.txt)|*.txt|Vsechny|*.*";
                if (DialogResult.OK == ofd.ShowDialog())
                {
                    fname = ofd.FileName;
                }
                else
                {
                    return;
                }
                if (String.IsNullOrEmpty(fname))
                {
                    return;
                }
            }
            if (String.IsNullOrEmpty(fname))
            {
                return;
            }

            string[] file_parts = fname.Split('.');

            if (file_parts.Length != 2)
            {
                return;
            }


            for (int r = 0; r < selectedRows; r++)
            {

                int selectedIndex = dataGridView_Events.SelectedRows[r].Index;
                // EventInfo SelectedEvent = list_events[selectedIndex];
                AcquisitionDataProcess_Data ActualEventData = List_EventsData[selectedIndex];
                String fname_new = file_parts[0] + "_EVENT_" + ActualEventData.p_eventNum.ToString() + "." + file_parts[1];
                SaveEventData(ActualEventData, fname_new);
            }

        }


        private void SaveEventData(AcquisitionDataProcess_Data EventData, string file) 
        {
            if (File.Exists(file))
            {
                File.Delete(file);
            }


            using (FileStream fs = File.OpenWrite(file)) 
            {
                for (int i = 0; i < EventData.List_SampleData.Count; i++)
                {
                   
                    string s = EventData.List_SampleData[i].ToString();

                    if(i != EventData.List_SampleData.Count - 1) 
                    {
                        s = s + " ";
                    }

                    byte[] b = Encoding.ASCII.GetBytes(s);
                    fs.Write(b, 0, b.Length);
                }

            }

        }


        public void AnalyzeAdcStart() 
        {
            Thread thread_analyze = new Thread(this.AnalyzeAdc);
            thread_analyze.Start();
        }



        private void AnalyzeAdc() 
        {

            int selectedRows = dataGridView_Events.SelectedRows.Count;

            if (selectedRows != 1)
            {
                MessageBox.Show("Select only one event!!!");
                return;
            }

            int selectedIndex = dataGridView_Events.SelectedRows[0].Index;
            AcquisitionDataProcess_Data ActualEventData = List_EventsData[selectedIndex];

            string resultName = "Event_"+ ActualEventData.p_eventNum.ToString();
            string fname = @"DataForAnalysis\Event_"+ ActualEventData.p_eventNum.ToString() + ".txt";

            SaveEventData(ActualEventData, fname);

            string cmd = @"C:\Users\Tomáš\AppData\Local\Programs\Python\Python310\python.exe";

            string script = Environment.CurrentDirectory + @"\Scripts\ADC.py" ;
            string file = Environment.CurrentDirectory + @"\" + fname;

            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = cmd;
            start.Arguments = script +" "+file+" "+ resultName;
            start.CreateNoWindow = true;
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            start.RedirectStandardError = true;

            using (Process process = Process.Start(start))
            {
                string errors = process.StandardError.ReadToEnd();
                string result = process.StandardOutput.ReadToEnd();

                //MessageBox.Show(errors);
                if(errors != string.Empty) 
                {
                    MessageBox.Show(errors, "Error");
                }

                else if (result != string.Empty)
                {
                    //MessageBox.Show(result);
                }

            }

        }


    }
}
