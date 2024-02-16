﻿
namespace Digitizer_ver1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelXXX = new System.Windows.Forms.Label();
            this.label_dataErrors = new System.Windows.Forms.Label();
            this.label_AcqState = new System.Windows.Forms.Label();
            this.timerRequest = new System.Windows.Forms.Timer(this.components);
            this.tabRegisters = new System.Windows.Forms.TabPage();
            this.tabControl_RegistersSetting = new System.Windows.Forms.TabControl();
            this.tabPage_ADC = new System.Windows.Forms.TabPage();
            this.dataGridView_ADCReg = new System.Windows.Forms.DataGridView();
            this.tabPage_HMC = new System.Windows.Forms.TabPage();
            this.dataGridView_HMCReg = new System.Windows.Forms.DataGridView();
            this.tabPage_LMX1 = new System.Windows.Forms.TabPage();
            this.dataGridView_LMX1Reg = new System.Windows.Forms.DataGridView();
            this.tabPage_LMX2 = new System.Windows.Forms.TabPage();
            this.dataGridView_LMX2Reg = new System.Windows.Forms.DataGridView();
            this.tabPage_TestReg = new System.Windows.Forms.TabPage();
            this.dataGridView_TestReg = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButton_RegAddrHEX = new System.Windows.Forms.RadioButton();
            this.radioButton_RegAddrDEC = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButton_RegValHEX = new System.Windows.Forms.RadioButton();
            this.radioButton_RegValDEC = new System.Windows.Forms.RadioButton();
            this.button_RegAddrFind = new System.Windows.Forms.Button();
            this.textBox_RegAddress = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_RegValue = new System.Windows.Forms.TextBox();
            this.groupBox_RegBits = new System.Windows.Forms.GroupBox();
            this.checkBox_RegBitSet0 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_RegDescription = new System.Windows.Forms.Label();
            this.label_RegRW = new System.Windows.Forms.Label();
            this.button_RegUpdateFromExtFile = new System.Windows.Forms.Button();
            this.button_RegWriteAll = new System.Windows.Forms.Button();
            this.button_RegReadAll = new System.Windows.Forms.Button();
            this.button_RegSaveToFile = new System.Windows.Forms.Button();
            this.button_RegSaveAs = new System.Windows.Forms.Button();
            this.button_RegLoadFromFile = new System.Windows.Forms.Button();
            this.tabControl_MAIN = new System.Windows.Forms.TabControl();
            this.tabMeasurement_Setting = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.checkBox_TestGeneratorEnable = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button_OpenDataFile = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_DataFilePath = new System.Windows.Forms.TextBox();
            this.checkBox_SaveToFile = new System.Windows.Forms.CheckBox();
            this.checkBox_SaveToRam = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_CountersClearAll = new System.Windows.Forms.Button();
            this.button_CountersClearInRun = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label_CounterInRunEvents = new System.Windows.Forms.Label();
            this.button_CountersClearProcessed = new System.Windows.Forms.Button();
            this.button_CountersClearIncoming = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label_CounterProcessedEvents = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label_CounterIncomingEvents = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.button_AcqStartStop = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.numericUpDown_AcqThreshold = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.numericUpDown_NumOfSamples = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_AcqRepeats = new System.Windows.Forms.NumericUpDown();
            this.checkBox_Repeats = new System.Windows.Forms.CheckBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown_NumOfEvents = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Time = new System.Windows.Forms.NumericUpDown();
            this.radioButton_AcqTime = new System.Windows.Forms.RadioButton();
            this.radioButton_AcqNumEvents = new System.Windows.Forms.RadioButton();
            this.radioButton_AcqInfinite = new System.Windows.Forms.RadioButton();
            this.tabMeasurementData = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView_events = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button_EventsListClear = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.chart_data = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabGpio = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView_GpioOutputs = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_GpioInputs = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_ClearRisingFalling = new System.Windows.Forms.Button();
            this.tabReset = new System.Windows.Forms.TabPage();
            this.dataGridView_Resets = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button_Reset = new System.Windows.Forms.Button();
            this.button_ResetClearAll = new System.Windows.Forms.Button();
            this.tabConfiguration = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView_MultipleConfigFiles = new System.Windows.Forms.DataGridView();
            this.dataGridView_ConfigFile = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button_RemoveConfig = new System.Windows.Forms.Button();
            this.button_AddNewConfig = new System.Windows.Forms.Button();
            this.button_ConfigFileLoadFromFile = new System.Windows.Forms.Button();
            this.button_ConfigFileSaveToFile = new System.Windows.Forms.Button();
            this.button_ConfigFileSaveAs = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.button_ConfigRun = new System.Windows.Forms.Button();
            this.button_ConfigStop = new System.Windows.Forms.Button();
            this.tabSetting = new System.Windows.Forms.TabPage();
            this.label_InQ = new System.Windows.Forms.Label();
            this.checkBox_cmdQuestions = new System.Windows.Forms.CheckBox();
            this.label_RecvBytes = new System.Windows.Forms.Label();
            this.label_xRead = new System.Windows.Forms.Label();
            this.button_xSend = new System.Windows.Forms.Button();
            this.textBox_xSendByte0 = new System.Windows.Forms.TextBox();
            this.textBox_xSendByte1 = new System.Windows.Forms.TextBox();
            this.textBox_xSendByte2 = new System.Windows.Forms.TextBox();
            this.textBox_xSendByte3 = new System.Windows.Forms.TextBox();
            this.label_Test = new System.Windows.Forms.Label();
            this.button_Test = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.dataGridView_RegistersFiles = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_OpenCloseCommunication = new System.Windows.Forms.Button();
            this.button_ScanCommunication = new System.Windows.Forms.Button();
            this.comboBox_Communication = new System.Windows.Forms.ComboBox();
            this.radioButton_PCIe = new System.Windows.Forms.RadioButton();
            this.radioButton_USB = new System.Windows.Forms.RadioButton();
            this.radioButton_UART = new System.Windows.Forms.RadioButton();
            this.tabQuickSetup = new System.Windows.Forms.TabPage();
            this.groupBox_LMXSync = new System.Windows.Forms.GroupBox();
            this.checkBox_QS_FcalEn2 = new System.Windows.Forms.CheckBox();
            this.checkBox_QS_FcalEn1 = new System.Windows.Forms.CheckBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label_QS_CHDIV2 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label_QS_INC_DIV2 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label_QS_PLL_DEN2 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label_QS_CHDIV1 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label_QS_INC_DIV1 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label_QS_PLL_DEN1 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label_QS_Phase2 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label_QS_Phase1 = new System.Windows.Forms.Label();
            this.button_QS_Sync = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.numericUpDown_QS_Seed2 = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDown_QS_Seed1 = new System.Windows.Forms.NumericUpDown();
            this.timerForm = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.tabRegisters.SuspendLayout();
            this.tabControl_RegistersSetting.SuspendLayout();
            this.tabPage_ADC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ADCReg)).BeginInit();
            this.tabPage_HMC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HMCReg)).BeginInit();
            this.tabPage_LMX1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LMX1Reg)).BeginInit();
            this.tabPage_LMX2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LMX2Reg)).BeginInit();
            this.tabPage_TestReg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TestReg)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox_RegBits.SuspendLayout();
            this.tabControl_MAIN.SuspendLayout();
            this.tabMeasurement_Setting.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AcqThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NumOfSamples)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AcqRepeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NumOfEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Time)).BeginInit();
            this.tabMeasurementData.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_events)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_data)).BeginInit();
            this.tabGpio.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GpioOutputs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GpioInputs)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabReset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Resets)).BeginInit();
            this.panel6.SuspendLayout();
            this.tabConfiguration.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MultipleConfigFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ConfigFile)).BeginInit();
            this.panel5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.tabSetting.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RegistersFiles)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabQuickSetup.SuspendLayout();
            this.groupBox_LMXSync.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_QS_Seed2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_QS_Seed1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelXXX);
            this.panel1.Controls.Add(this.label_dataErrors);
            this.panel1.Controls.Add(this.label_AcqState);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1248, 39);
            this.panel1.TabIndex = 0;
            // 
            // labelXXX
            // 
            this.labelXXX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelXXX.Location = new System.Drawing.Point(583, 9);
            this.labelXXX.Name = "labelXXX";
            this.labelXXX.Size = new System.Drawing.Size(110, 21);
            this.labelXXX.TabIndex = 29;
            this.labelXXX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_dataErrors
            // 
            this.label_dataErrors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_dataErrors.Location = new System.Drawing.Point(381, 8);
            this.label_dataErrors.Name = "label_dataErrors";
            this.label_dataErrors.Size = new System.Drawing.Size(83, 21);
            this.label_dataErrors.TabIndex = 28;
            this.label_dataErrors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_AcqState
            // 
            this.label_AcqState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_AcqState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_AcqState.Location = new System.Drawing.Point(225, 6);
            this.label_AcqState.Name = "label_AcqState";
            this.label_AcqState.Size = new System.Drawing.Size(123, 24);
            this.label_AcqState.TabIndex = 9;
            this.label_AcqState.Text = "........";
            this.label_AcqState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerRequest
            // 
            this.timerRequest.Enabled = true;
            this.timerRequest.Interval = 500;
            this.timerRequest.Tick += new System.EventHandler(this.timerRequest_Tick);
            // 
            // tabRegisters
            // 
            this.tabRegisters.Controls.Add(this.tabControl_RegistersSetting);
            this.tabRegisters.Controls.Add(this.panel3);
            this.tabRegisters.Location = new System.Drawing.Point(4, 22);
            this.tabRegisters.Margin = new System.Windows.Forms.Padding(2);
            this.tabRegisters.Name = "tabRegisters";
            this.tabRegisters.Padding = new System.Windows.Forms.Padding(2);
            this.tabRegisters.Size = new System.Drawing.Size(1240, 601);
            this.tabRegisters.TabIndex = 4;
            this.tabRegisters.Text = "Registers";
            this.tabRegisters.UseVisualStyleBackColor = true;
            // 
            // tabControl_RegistersSetting
            // 
            this.tabControl_RegistersSetting.Controls.Add(this.tabPage_ADC);
            this.tabControl_RegistersSetting.Controls.Add(this.tabPage_HMC);
            this.tabControl_RegistersSetting.Controls.Add(this.tabPage_LMX1);
            this.tabControl_RegistersSetting.Controls.Add(this.tabPage_LMX2);
            this.tabControl_RegistersSetting.Controls.Add(this.tabPage_TestReg);
            this.tabControl_RegistersSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_RegistersSetting.Location = new System.Drawing.Point(266, 2);
            this.tabControl_RegistersSetting.Name = "tabControl_RegistersSetting";
            this.tabControl_RegistersSetting.SelectedIndex = 0;
            this.tabControl_RegistersSetting.Size = new System.Drawing.Size(972, 597);
            this.tabControl_RegistersSetting.TabIndex = 2;
            // 
            // tabPage_ADC
            // 
            this.tabPage_ADC.Controls.Add(this.dataGridView_ADCReg);
            this.tabPage_ADC.Location = new System.Drawing.Point(4, 22);
            this.tabPage_ADC.Name = "tabPage_ADC";
            this.tabPage_ADC.Size = new System.Drawing.Size(964, 571);
            this.tabPage_ADC.TabIndex = 0;
            this.tabPage_ADC.Text = "ADC";
            this.tabPage_ADC.UseVisualStyleBackColor = true;
            // 
            // dataGridView_ADCReg
            // 
            this.dataGridView_ADCReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ADCReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_ADCReg.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_ADCReg.MultiSelect = false;
            this.dataGridView_ADCReg.Name = "dataGridView_ADCReg";
            this.dataGridView_ADCReg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_ADCReg.Size = new System.Drawing.Size(964, 571);
            this.dataGridView_ADCReg.TabIndex = 0;
            this.dataGridView_ADCReg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_AllRegistersGrids_CellContentClick);
            this.dataGridView_ADCReg.SelectionChanged += new System.EventHandler(this.dataGridView_AllRegistersGrids_SelectedChanged);
            // 
            // tabPage_HMC
            // 
            this.tabPage_HMC.Controls.Add(this.dataGridView_HMCReg);
            this.tabPage_HMC.Location = new System.Drawing.Point(4, 22);
            this.tabPage_HMC.Name = "tabPage_HMC";
            this.tabPage_HMC.Size = new System.Drawing.Size(964, 571);
            this.tabPage_HMC.TabIndex = 1;
            this.tabPage_HMC.Text = "HMC";
            this.tabPage_HMC.UseVisualStyleBackColor = true;
            // 
            // dataGridView_HMCReg
            // 
            this.dataGridView_HMCReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_HMCReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_HMCReg.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_HMCReg.MultiSelect = false;
            this.dataGridView_HMCReg.Name = "dataGridView_HMCReg";
            this.dataGridView_HMCReg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_HMCReg.Size = new System.Drawing.Size(964, 571);
            this.dataGridView_HMCReg.TabIndex = 1;
            this.dataGridView_HMCReg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_AllRegistersGrids_CellContentClick);
            this.dataGridView_HMCReg.SelectionChanged += new System.EventHandler(this.dataGridView_AllRegistersGrids_SelectedChanged);
            // 
            // tabPage_LMX1
            // 
            this.tabPage_LMX1.Controls.Add(this.dataGridView_LMX1Reg);
            this.tabPage_LMX1.Location = new System.Drawing.Point(4, 22);
            this.tabPage_LMX1.Name = "tabPage_LMX1";
            this.tabPage_LMX1.Size = new System.Drawing.Size(964, 571);
            this.tabPage_LMX1.TabIndex = 2;
            this.tabPage_LMX1.Text = "LMX1";
            this.tabPage_LMX1.UseVisualStyleBackColor = true;
            // 
            // dataGridView_LMX1Reg
            // 
            this.dataGridView_LMX1Reg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_LMX1Reg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_LMX1Reg.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_LMX1Reg.MultiSelect = false;
            this.dataGridView_LMX1Reg.Name = "dataGridView_LMX1Reg";
            this.dataGridView_LMX1Reg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_LMX1Reg.Size = new System.Drawing.Size(964, 571);
            this.dataGridView_LMX1Reg.TabIndex = 2;
            this.dataGridView_LMX1Reg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_AllRegistersGrids_CellContentClick);
            this.dataGridView_LMX1Reg.SelectionChanged += new System.EventHandler(this.dataGridView_AllRegistersGrids_SelectedChanged);
            // 
            // tabPage_LMX2
            // 
            this.tabPage_LMX2.Controls.Add(this.dataGridView_LMX2Reg);
            this.tabPage_LMX2.Location = new System.Drawing.Point(4, 22);
            this.tabPage_LMX2.Name = "tabPage_LMX2";
            this.tabPage_LMX2.Size = new System.Drawing.Size(964, 571);
            this.tabPage_LMX2.TabIndex = 3;
            this.tabPage_LMX2.Text = "LMX2";
            this.tabPage_LMX2.UseVisualStyleBackColor = true;
            // 
            // dataGridView_LMX2Reg
            // 
            this.dataGridView_LMX2Reg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_LMX2Reg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_LMX2Reg.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_LMX2Reg.MultiSelect = false;
            this.dataGridView_LMX2Reg.Name = "dataGridView_LMX2Reg";
            this.dataGridView_LMX2Reg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_LMX2Reg.Size = new System.Drawing.Size(964, 571);
            this.dataGridView_LMX2Reg.TabIndex = 2;
            this.dataGridView_LMX2Reg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_AllRegistersGrids_CellContentClick);
            this.dataGridView_LMX2Reg.SelectionChanged += new System.EventHandler(this.dataGridView_AllRegistersGrids_SelectedChanged);
            // 
            // tabPage_TestReg
            // 
            this.tabPage_TestReg.Controls.Add(this.dataGridView_TestReg);
            this.tabPage_TestReg.Location = new System.Drawing.Point(4, 22);
            this.tabPage_TestReg.Name = "tabPage_TestReg";
            this.tabPage_TestReg.Size = new System.Drawing.Size(964, 571);
            this.tabPage_TestReg.TabIndex = 4;
            this.tabPage_TestReg.Text = "TestRegisters";
            this.tabPage_TestReg.UseVisualStyleBackColor = true;
            // 
            // dataGridView_TestReg
            // 
            this.dataGridView_TestReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TestReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_TestReg.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_TestReg.MultiSelect = false;
            this.dataGridView_TestReg.Name = "dataGridView_TestReg";
            this.dataGridView_TestReg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_TestReg.Size = new System.Drawing.Size(964, 571);
            this.dataGridView_TestReg.TabIndex = 3;
            this.dataGridView_TestReg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_AllRegistersGrids_CellContentClick);
            this.dataGridView_TestReg.SelectionChanged += new System.EventHandler(this.dataGridView_AllRegistersGrids_SelectedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox10);
            this.panel3.Controls.Add(this.button_RegUpdateFromExtFile);
            this.panel3.Controls.Add(this.button_RegWriteAll);
            this.panel3.Controls.Add(this.button_RegReadAll);
            this.panel3.Controls.Add(this.button_RegSaveToFile);
            this.panel3.Controls.Add(this.button_RegSaveAs);
            this.panel3.Controls.Add(this.button_RegLoadFromFile);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(2, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(264, 597);
            this.panel3.TabIndex = 1;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.flowLayoutPanel2);
            this.groupBox10.Controls.Add(this.flowLayoutPanel1);
            this.groupBox10.Controls.Add(this.button_RegAddrFind);
            this.groupBox10.Controls.Add(this.textBox_RegAddress);
            this.groupBox10.Controls.Add(this.button2);
            this.groupBox10.Controls.Add(this.button1);
            this.groupBox10.Controls.Add(this.textBox_RegValue);
            this.groupBox10.Controls.Add(this.groupBox_RegBits);
            this.groupBox10.Controls.Add(this.label10);
            this.groupBox10.Controls.Add(this.label6);
            this.groupBox10.Controls.Add(this.label5);
            this.groupBox10.Controls.Add(this.label3);
            this.groupBox10.Controls.Add(this.label_RegDescription);
            this.groupBox10.Controls.Add(this.label_RegRW);
            this.groupBox10.Location = new System.Drawing.Point(9, 284);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(245, 306);
            this.groupBox10.TabIndex = 9;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Selected Line";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.radioButton_RegAddrHEX);
            this.flowLayoutPanel2.Controls.Add(this.radioButton_RegAddrDEC);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(142, 67);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(98, 22);
            this.flowLayoutPanel2.TabIndex = 11;
            // 
            // radioButton_RegAddrHEX
            // 
            this.radioButton_RegAddrHEX.AutoSize = true;
            this.radioButton_RegAddrHEX.Checked = true;
            this.radioButton_RegAddrHEX.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton_RegAddrHEX.Location = new System.Drawing.Point(3, 3);
            this.radioButton_RegAddrHEX.Name = "radioButton_RegAddrHEX";
            this.radioButton_RegAddrHEX.Size = new System.Drawing.Size(42, 16);
            this.radioButton_RegAddrHEX.TabIndex = 14;
            this.radioButton_RegAddrHEX.TabStop = true;
            this.radioButton_RegAddrHEX.Text = "HEX";
            this.radioButton_RegAddrHEX.UseVisualStyleBackColor = true;
            this.radioButton_RegAddrHEX.CheckedChanged += new System.EventHandler(this.radioButton_RegAddr_CheckedChanged);
            // 
            // radioButton_RegAddrDEC
            // 
            this.radioButton_RegAddrDEC.AutoSize = true;
            this.radioButton_RegAddrDEC.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton_RegAddrDEC.Location = new System.Drawing.Point(51, 3);
            this.radioButton_RegAddrDEC.Name = "radioButton_RegAddrDEC";
            this.radioButton_RegAddrDEC.Size = new System.Drawing.Size(43, 16);
            this.radioButton_RegAddrDEC.TabIndex = 15;
            this.radioButton_RegAddrDEC.Text = "DEC";
            this.radioButton_RegAddrDEC.UseVisualStyleBackColor = true;
            this.radioButton_RegAddrDEC.CheckedChanged += new System.EventHandler(this.radioButton_RegAddr_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.radioButton_RegValHEX);
            this.flowLayoutPanel1.Controls.Add(this.radioButton_RegValDEC);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(142, 89);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(98, 22);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // radioButton_RegValHEX
            // 
            this.radioButton_RegValHEX.AutoSize = true;
            this.radioButton_RegValHEX.Checked = true;
            this.radioButton_RegValHEX.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton_RegValHEX.Location = new System.Drawing.Point(3, 3);
            this.radioButton_RegValHEX.Name = "radioButton_RegValHEX";
            this.radioButton_RegValHEX.Size = new System.Drawing.Size(42, 16);
            this.radioButton_RegValHEX.TabIndex = 14;
            this.radioButton_RegValHEX.TabStop = true;
            this.radioButton_RegValHEX.Text = "HEX";
            this.radioButton_RegValHEX.UseVisualStyleBackColor = true;
            this.radioButton_RegValHEX.CheckedChanged += new System.EventHandler(this.radioButton_RegVal_CheckedChanged);
            // 
            // radioButton_RegValDEC
            // 
            this.radioButton_RegValDEC.AutoSize = true;
            this.radioButton_RegValDEC.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton_RegValDEC.Location = new System.Drawing.Point(51, 3);
            this.radioButton_RegValDEC.Name = "radioButton_RegValDEC";
            this.radioButton_RegValDEC.Size = new System.Drawing.Size(43, 16);
            this.radioButton_RegValDEC.TabIndex = 15;
            this.radioButton_RegValDEC.Text = "DEC";
            this.radioButton_RegValDEC.UseVisualStyleBackColor = true;
            this.radioButton_RegValDEC.CheckedChanged += new System.EventHandler(this.radioButton_RegVal_CheckedChanged);
            // 
            // button_RegAddrFind
            // 
            this.button_RegAddrFind.Location = new System.Drawing.Point(12, 145);
            this.button_RegAddrFind.Margin = new System.Windows.Forms.Padding(2);
            this.button_RegAddrFind.Name = "button_RegAddrFind";
            this.button_RegAddrFind.Size = new System.Drawing.Size(69, 24);
            this.button_RegAddrFind.TabIndex = 13;
            this.button_RegAddrFind.Text = "Find Addr.";
            this.button_RegAddrFind.UseVisualStyleBackColor = true;
            this.button_RegAddrFind.Click += new System.EventHandler(this.button_RegAddrFind_Click);
            // 
            // textBox_RegAddress
            // 
            this.textBox_RegAddress.Location = new System.Drawing.Point(69, 67);
            this.textBox_RegAddress.Name = "textBox_RegAddress";
            this.textBox_RegAddress.Size = new System.Drawing.Size(67, 20);
            this.textBox_RegAddress.TabIndex = 12;
            this.textBox_RegAddress.TextChanged += new System.EventHandler(this.textBox_RegAddress_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 214);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 24);
            this.button2.TabIndex = 11;
            this.button2.Text = "Write";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 186);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 24);
            this.button1.TabIndex = 10;
            this.button1.Text = "Read";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox_RegValue
            // 
            this.textBox_RegValue.Location = new System.Drawing.Point(69, 90);
            this.textBox_RegValue.Name = "textBox_RegValue";
            this.textBox_RegValue.Size = new System.Drawing.Size(67, 20);
            this.textBox_RegValue.TabIndex = 8;
            this.textBox_RegValue.TextChanged += new System.EventHandler(this.textBox_RegValue_TextChanged);
            // 
            // groupBox_RegBits
            // 
            this.groupBox_RegBits.Controls.Add(this.checkBox_RegBitSet0);
            this.groupBox_RegBits.Controls.Add(this.checkBox10);
            this.groupBox_RegBits.Controls.Add(this.checkBox11);
            this.groupBox_RegBits.Controls.Add(this.checkBox12);
            this.groupBox_RegBits.Controls.Add(this.checkBox13);
            this.groupBox_RegBits.Controls.Add(this.checkBox14);
            this.groupBox_RegBits.Controls.Add(this.checkBox15);
            this.groupBox_RegBits.Controls.Add(this.checkBox16);
            this.groupBox_RegBits.Controls.Add(this.checkBox1);
            this.groupBox_RegBits.Controls.Add(this.checkBox2);
            this.groupBox_RegBits.Controls.Add(this.checkBox3);
            this.groupBox_RegBits.Controls.Add(this.checkBox4);
            this.groupBox_RegBits.Controls.Add(this.checkBox5);
            this.groupBox_RegBits.Controls.Add(this.checkBox6);
            this.groupBox_RegBits.Controls.Add(this.checkBox7);
            this.groupBox_RegBits.Controls.Add(this.checkBox8);
            this.groupBox_RegBits.Location = new System.Drawing.Point(95, 124);
            this.groupBox_RegBits.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_RegBits.Name = "groupBox_RegBits";
            this.groupBox_RegBits.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_RegBits.Size = new System.Drawing.Size(136, 175);
            this.groupBox_RegBits.TabIndex = 3;
            this.groupBox_RegBits.TabStop = false;
            this.groupBox_RegBits.Text = "Bit Setting";
            // 
            // checkBox_RegBitSet0
            // 
            this.checkBox_RegBitSet0.AutoSize = true;
            this.checkBox_RegBitSet0.Location = new System.Drawing.Point(79, 149);
            this.checkBox_RegBitSet0.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_RegBitSet0.Name = "checkBox_RegBitSet0";
            this.checkBox_RegBitSet0.Size = new System.Drawing.Size(32, 17);
            this.checkBox_RegBitSet0.TabIndex = 17;
            this.checkBox_RegBitSet0.Tag = "0";
            this.checkBox_RegBitSet0.Text = "0";
            this.checkBox_RegBitSet0.UseVisualStyleBackColor = true;
            this.checkBox_RegBitSet0.CheckedChanged += new System.EventHandler(this.checkBox_RegBitSet_CheckedChanged);
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(79, 130);
            this.checkBox10.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(32, 17);
            this.checkBox10.TabIndex = 16;
            this.checkBox10.Tag = "1";
            this.checkBox10.Text = "1";
            this.checkBox10.UseVisualStyleBackColor = true;
            this.checkBox10.CheckedChanged += new System.EventHandler(this.checkBox_RegBitSet_CheckedChanged);
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(79, 21);
            this.checkBox11.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(32, 17);
            this.checkBox11.TabIndex = 15;
            this.checkBox11.Tag = "7";
            this.checkBox11.Text = "7";
            this.checkBox11.UseVisualStyleBackColor = true;
            this.checkBox11.CheckedChanged += new System.EventHandler(this.checkBox_RegBitSet_CheckedChanged);
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(79, 39);
            this.checkBox12.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(32, 17);
            this.checkBox12.TabIndex = 14;
            this.checkBox12.Tag = "6";
            this.checkBox12.Text = "6";
            this.checkBox12.UseVisualStyleBackColor = true;
            this.checkBox12.CheckedChanged += new System.EventHandler(this.checkBox_RegBitSet_CheckedChanged);
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Location = new System.Drawing.Point(79, 58);
            this.checkBox13.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(32, 17);
            this.checkBox13.TabIndex = 13;
            this.checkBox13.Tag = "5";
            this.checkBox13.Text = "5";
            this.checkBox13.UseVisualStyleBackColor = true;
            this.checkBox13.CheckedChanged += new System.EventHandler(this.checkBox_RegBitSet_CheckedChanged);
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Location = new System.Drawing.Point(79, 76);
            this.checkBox14.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(32, 17);
            this.checkBox14.TabIndex = 12;
            this.checkBox14.Tag = "4";
            this.checkBox14.Text = "4";
            this.checkBox14.UseVisualStyleBackColor = true;
            this.checkBox14.CheckedChanged += new System.EventHandler(this.checkBox_RegBitSet_CheckedChanged);
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Location = new System.Drawing.Point(79, 94);
            this.checkBox15.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(32, 17);
            this.checkBox15.TabIndex = 11;
            this.checkBox15.Tag = "3";
            this.checkBox15.Text = "3";
            this.checkBox15.UseVisualStyleBackColor = true;
            this.checkBox15.CheckedChanged += new System.EventHandler(this.checkBox_RegBitSet_CheckedChanged);
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.Location = new System.Drawing.Point(79, 112);
            this.checkBox16.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(32, 17);
            this.checkBox16.TabIndex = 10;
            this.checkBox16.Tag = "2";
            this.checkBox16.Text = "2";
            this.checkBox16.UseVisualStyleBackColor = true;
            this.checkBox16.CheckedChanged += new System.EventHandler(this.checkBox_RegBitSet_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(23, 149);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(32, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Tag = "8";
            this.checkBox1.Text = "8";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox_RegBitSet_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(23, 130);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(32, 17);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Tag = "9";
            this.checkBox2.Text = "9";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox_RegBitSet_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(23, 21);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(38, 17);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.Tag = "15";
            this.checkBox3.Text = "15";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox_RegBitSet_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(23, 39);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(38, 17);
            this.checkBox4.TabIndex = 6;
            this.checkBox4.Tag = "14";
            this.checkBox4.Text = "14";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox_RegBitSet_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(23, 58);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(38, 17);
            this.checkBox5.TabIndex = 5;
            this.checkBox5.Tag = "13";
            this.checkBox5.Text = "13";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox_RegBitSet_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(23, 76);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(38, 17);
            this.checkBox6.TabIndex = 4;
            this.checkBox6.Tag = "12";
            this.checkBox6.Text = "12";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox_RegBitSet_CheckedChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(23, 94);
            this.checkBox7.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(38, 17);
            this.checkBox7.TabIndex = 3;
            this.checkBox7.Tag = "11";
            this.checkBox7.Text = "11";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox_RegBitSet_CheckedChanged);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(23, 112);
            this.checkBox8.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(38, 17);
            this.checkBox8.TabIndex = 2;
            this.checkBox8.Tag = "10";
            this.checkBox8.Text = "10";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox_RegBitSet_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Description:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "R/W:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Value:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address:";
            // 
            // label_RegDescription
            // 
            this.label_RegDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_RegDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_RegDescription.Location = new System.Drawing.Point(69, 21);
            this.label_RegDescription.Name = "label_RegDescription";
            this.label_RegDescription.Size = new System.Drawing.Size(161, 20);
            this.label_RegDescription.TabIndex = 3;
            this.label_RegDescription.Text = "label3";
            // 
            // label_RegRW
            // 
            this.label_RegRW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_RegRW.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_RegRW.Location = new System.Drawing.Point(69, 44);
            this.label_RegRW.Name = "label_RegRW";
            this.label_RegRW.Size = new System.Drawing.Size(67, 20);
            this.label_RegRW.TabIndex = 2;
            this.label_RegRW.Text = "label3";
            // 
            // button_RegUpdateFromExtFile
            // 
            this.button_RegUpdateFromExtFile.Location = new System.Drawing.Point(13, 180);
            this.button_RegUpdateFromExtFile.Margin = new System.Windows.Forms.Padding(2);
            this.button_RegUpdateFromExtFile.Name = "button_RegUpdateFromExtFile";
            this.button_RegUpdateFromExtFile.Size = new System.Drawing.Size(74, 37);
            this.button_RegUpdateFromExtFile.TabIndex = 8;
            this.button_RegUpdateFromExtFile.Text = "Update from Ext File";
            this.button_RegUpdateFromExtFile.UseVisualStyleBackColor = true;
            this.button_RegUpdateFromExtFile.Click += new System.EventHandler(this.button_RegUpdateFromExtFile_Click);
            // 
            // button_RegWriteAll
            // 
            this.button_RegWriteAll.Location = new System.Drawing.Point(175, 57);
            this.button_RegWriteAll.Margin = new System.Windows.Forms.Padding(2);
            this.button_RegWriteAll.Name = "button_RegWriteAll";
            this.button_RegWriteAll.Size = new System.Drawing.Size(74, 37);
            this.button_RegWriteAll.TabIndex = 7;
            this.button_RegWriteAll.Text = "Write All";
            this.button_RegWriteAll.UseVisualStyleBackColor = true;
            this.button_RegWriteAll.Click += new System.EventHandler(this.button_RegWriteAll_Click);
            // 
            // button_RegReadAll
            // 
            this.button_RegReadAll.Location = new System.Drawing.Point(175, 16);
            this.button_RegReadAll.Margin = new System.Windows.Forms.Padding(2);
            this.button_RegReadAll.Name = "button_RegReadAll";
            this.button_RegReadAll.Size = new System.Drawing.Size(74, 37);
            this.button_RegReadAll.TabIndex = 6;
            this.button_RegReadAll.Text = "Read All";
            this.button_RegReadAll.UseVisualStyleBackColor = true;
            this.button_RegReadAll.Click += new System.EventHandler(this.button_RegReadAll_Click);
            // 
            // button_RegSaveToFile
            // 
            this.button_RegSaveToFile.Location = new System.Drawing.Point(13, 57);
            this.button_RegSaveToFile.Margin = new System.Windows.Forms.Padding(2);
            this.button_RegSaveToFile.Name = "button_RegSaveToFile";
            this.button_RegSaveToFile.Size = new System.Drawing.Size(74, 37);
            this.button_RegSaveToFile.TabIndex = 5;
            this.button_RegSaveToFile.Text = "Save to File";
            this.button_RegSaveToFile.UseVisualStyleBackColor = true;
            this.button_RegSaveToFile.Click += new System.EventHandler(this.button_SaveToFile_Click);
            // 
            // button_RegSaveAs
            // 
            this.button_RegSaveAs.Location = new System.Drawing.Point(13, 98);
            this.button_RegSaveAs.Margin = new System.Windows.Forms.Padding(2);
            this.button_RegSaveAs.Name = "button_RegSaveAs";
            this.button_RegSaveAs.Size = new System.Drawing.Size(74, 37);
            this.button_RegSaveAs.TabIndex = 1;
            this.button_RegSaveAs.Text = "Save As";
            this.button_RegSaveAs.UseVisualStyleBackColor = true;
            this.button_RegSaveAs.Click += new System.EventHandler(this.button_SaveAs_Click);
            // 
            // button_RegLoadFromFile
            // 
            this.button_RegLoadFromFile.Location = new System.Drawing.Point(13, 16);
            this.button_RegLoadFromFile.Margin = new System.Windows.Forms.Padding(2);
            this.button_RegLoadFromFile.Name = "button_RegLoadFromFile";
            this.button_RegLoadFromFile.Size = new System.Drawing.Size(74, 37);
            this.button_RegLoadFromFile.TabIndex = 0;
            this.button_RegLoadFromFile.Text = "Load from File";
            this.button_RegLoadFromFile.UseVisualStyleBackColor = true;
            this.button_RegLoadFromFile.Click += new System.EventHandler(this.button_LoadFromFile_Click);
            // 
            // tabControl_MAIN
            // 
            this.tabControl_MAIN.Controls.Add(this.tabMeasurement_Setting);
            this.tabControl_MAIN.Controls.Add(this.tabMeasurementData);
            this.tabControl_MAIN.Controls.Add(this.tabRegisters);
            this.tabControl_MAIN.Controls.Add(this.tabGpio);
            this.tabControl_MAIN.Controls.Add(this.tabReset);
            this.tabControl_MAIN.Controls.Add(this.tabConfiguration);
            this.tabControl_MAIN.Controls.Add(this.tabSetting);
            this.tabControl_MAIN.Controls.Add(this.tabQuickSetup);
            this.tabControl_MAIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_MAIN.Location = new System.Drawing.Point(0, 39);
            this.tabControl_MAIN.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl_MAIN.Name = "tabControl_MAIN";
            this.tabControl_MAIN.SelectedIndex = 0;
            this.tabControl_MAIN.Size = new System.Drawing.Size(1248, 627);
            this.tabControl_MAIN.TabIndex = 1;
            this.tabControl_MAIN.SelectedIndexChanged += new System.EventHandler(this.tabControl_MAIN_SelectedIndexChanged);
            // 
            // tabMeasurement_Setting
            // 
            this.tabMeasurement_Setting.Controls.Add(this.groupBox6);
            this.tabMeasurement_Setting.Controls.Add(this.groupBox5);
            this.tabMeasurement_Setting.Controls.Add(this.groupBox4);
            this.tabMeasurement_Setting.Controls.Add(this.groupBox3);
            this.tabMeasurement_Setting.Location = new System.Drawing.Point(4, 22);
            this.tabMeasurement_Setting.Name = "tabMeasurement_Setting";
            this.tabMeasurement_Setting.Size = new System.Drawing.Size(1240, 601);
            this.tabMeasurement_Setting.TabIndex = 7;
            this.tabMeasurement_Setting.Text = "Measurement Settings";
            this.tabMeasurement_Setting.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.checkBox_TestGeneratorEnable);
            this.groupBox6.Location = new System.Drawing.Point(512, 251);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(368, 158);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Others";
            // 
            // checkBox_TestGeneratorEnable
            // 
            this.checkBox_TestGeneratorEnable.AutoSize = true;
            this.checkBox_TestGeneratorEnable.Location = new System.Drawing.Point(35, 32);
            this.checkBox_TestGeneratorEnable.Name = "checkBox_TestGeneratorEnable";
            this.checkBox_TestGeneratorEnable.Size = new System.Drawing.Size(133, 17);
            this.checkBox_TestGeneratorEnable.TabIndex = 0;
            this.checkBox_TestGeneratorEnable.Text = "Test Generator Enable";
            this.checkBox_TestGeneratorEnable.UseVisualStyleBackColor = true;
            this.checkBox_TestGeneratorEnable.CheckedChanged += new System.EventHandler(this.checkBox_TestGeneratorEnable_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button_OpenDataFile);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.textBox_DataFilePath);
            this.groupBox5.Controls.Add(this.checkBox_SaveToFile);
            this.groupBox5.Controls.Add(this.checkBox_SaveToRam);
            this.groupBox5.Location = new System.Drawing.Point(47, 362);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(368, 158);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Store Data";
            // 
            // button_OpenDataFile
            // 
            this.button_OpenDataFile.Location = new System.Drawing.Point(268, 106);
            this.button_OpenDataFile.Name = "button_OpenDataFile";
            this.button_OpenDataFile.Size = new System.Drawing.Size(75, 30);
            this.button_OpenDataFile.TabIndex = 4;
            this.button_OpenDataFile.Text = "File";
            this.button_OpenDataFile.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(27, 96);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "File path:";
            // 
            // textBox_DataFilePath
            // 
            this.textBox_DataFilePath.Location = new System.Drawing.Point(23, 112);
            this.textBox_DataFilePath.Name = "textBox_DataFilePath";
            this.textBox_DataFilePath.Size = new System.Drawing.Size(229, 20);
            this.textBox_DataFilePath.TabIndex = 2;
            // 
            // checkBox_SaveToFile
            // 
            this.checkBox_SaveToFile.AutoSize = true;
            this.checkBox_SaveToFile.Location = new System.Drawing.Point(35, 58);
            this.checkBox_SaveToFile.Name = "checkBox_SaveToFile";
            this.checkBox_SaveToFile.Size = new System.Drawing.Size(82, 17);
            this.checkBox_SaveToFile.TabIndex = 1;
            this.checkBox_SaveToFile.Text = "Save to File";
            this.checkBox_SaveToFile.UseVisualStyleBackColor = true;
            // 
            // checkBox_SaveToRam
            // 
            this.checkBox_SaveToRam.AutoSize = true;
            this.checkBox_SaveToRam.Location = new System.Drawing.Point(35, 32);
            this.checkBox_SaveToRam.Name = "checkBox_SaveToRam";
            this.checkBox_SaveToRam.Size = new System.Drawing.Size(90, 17);
            this.checkBox_SaveToRam.TabIndex = 0;
            this.checkBox_SaveToRam.Text = "Save to RAM";
            this.checkBox_SaveToRam.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_CountersClearAll);
            this.groupBox4.Controls.Add(this.button_CountersClearInRun);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label_CounterInRunEvents);
            this.groupBox4.Controls.Add(this.button_CountersClearProcessed);
            this.groupBox4.Controls.Add(this.button_CountersClearIncoming);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label_CounterProcessedEvents);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label_CounterIncomingEvents);
            this.groupBox4.Location = new System.Drawing.Point(512, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(368, 189);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Event Counters";
            // 
            // button_CountersClearAll
            // 
            this.button_CountersClearAll.Location = new System.Drawing.Point(18, 150);
            this.button_CountersClearAll.Name = "button_CountersClearAll";
            this.button_CountersClearAll.Size = new System.Drawing.Size(326, 23);
            this.button_CountersClearAll.TabIndex = 19;
            this.button_CountersClearAll.Text = "Clear All Counters";
            this.button_CountersClearAll.UseVisualStyleBackColor = true;
            // 
            // button_CountersClearInRun
            // 
            this.button_CountersClearInRun.Location = new System.Drawing.Point(303, 107);
            this.button_CountersClearInRun.Name = "button_CountersClearInRun";
            this.button_CountersClearInRun.Size = new System.Drawing.Size(57, 23);
            this.button_CountersClearInRun.TabIndex = 18;
            this.button_CountersClearInRun.Text = "Clear";
            this.button_CountersClearInRun.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(6, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(146, 15);
            this.label13.TabIndex = 17;
            this.label13.Text = "Processed Events in Run:";
            // 
            // label_CounterInRunEvents
            // 
            this.label_CounterInRunEvents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_CounterInRunEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_CounterInRunEvents.Location = new System.Drawing.Point(158, 107);
            this.label_CounterInRunEvents.Name = "label_CounterInRunEvents";
            this.label_CounterInRunEvents.Size = new System.Drawing.Size(135, 23);
            this.label_CounterInRunEvents.TabIndex = 16;
            this.label_CounterInRunEvents.Text = "0";
            this.label_CounterInRunEvents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_CountersClearProcessed
            // 
            this.button_CountersClearProcessed.Location = new System.Drawing.Point(303, 66);
            this.button_CountersClearProcessed.Name = "button_CountersClearProcessed";
            this.button_CountersClearProcessed.Size = new System.Drawing.Size(57, 23);
            this.button_CountersClearProcessed.TabIndex = 15;
            this.button_CountersClearProcessed.Text = "Clear";
            this.button_CountersClearProcessed.UseVisualStyleBackColor = true;
            // 
            // button_CountersClearIncoming
            // 
            this.button_CountersClearIncoming.Location = new System.Drawing.Point(303, 25);
            this.button_CountersClearIncoming.Name = "button_CountersClearIncoming";
            this.button_CountersClearIncoming.Size = new System.Drawing.Size(57, 23);
            this.button_CountersClearIncoming.TabIndex = 14;
            this.button_CountersClearIncoming.Text = "Clear";
            this.button_CountersClearIncoming.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(29, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "Processed Events All:";
            // 
            // label_CounterProcessedEvents
            // 
            this.label_CounterProcessedEvents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_CounterProcessedEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_CounterProcessedEvents.Location = new System.Drawing.Point(158, 66);
            this.label_CounterProcessedEvents.Name = "label_CounterProcessedEvents";
            this.label_CounterProcessedEvents.Size = new System.Drawing.Size(135, 23);
            this.label_CounterProcessedEvents.TabIndex = 12;
            this.label_CounterProcessedEvents.Text = "0";
            this.label_CounterProcessedEvents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(36, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 15);
            this.label11.TabIndex = 11;
            this.label11.Text = "All Incoming Events:";
            // 
            // label_CounterIncomingEvents
            // 
            this.label_CounterIncomingEvents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_CounterIncomingEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_CounterIncomingEvents.Location = new System.Drawing.Point(158, 25);
            this.label_CounterIncomingEvents.Name = "label_CounterIncomingEvents";
            this.label_CounterIncomingEvents.Size = new System.Drawing.Size(135, 23);
            this.label_CounterIncomingEvents.TabIndex = 10;
            this.label_CounterIncomingEvents.Text = "0";
            this.label_CounterIncomingEvents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.button_AcqStartStop);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.numericUpDown_AcqThreshold);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.numericUpDown_NumOfSamples);
            this.groupBox3.Controls.Add(this.numericUpDown_AcqRepeats);
            this.groupBox3.Controls.Add(this.checkBox_Repeats);
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.numericUpDown_NumOfEvents);
            this.groupBox3.Controls.Add(this.numericUpDown_Time);
            this.groupBox3.Controls.Add(this.radioButton_AcqTime);
            this.groupBox3.Controls.Add(this.radioButton_AcqNumEvents);
            this.groupBox3.Controls.Add(this.radioButton_AcqInfinite);
            this.groupBox3.Location = new System.Drawing.Point(47, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(368, 317);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ACQ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label18.Location = new System.Drawing.Point(95, 279);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 15);
            this.label18.TabIndex = 17;
            this.label18.Text = "Threshold:";
            // 
            // button_AcqStartStop
            // 
            this.button_AcqStartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_AcqStartStop.Location = new System.Drawing.Point(17, 34);
            this.button_AcqStartStop.Name = "button_AcqStartStop";
            this.button_AcqStartStop.Size = new System.Drawing.Size(326, 35);
            this.button_AcqStartStop.TabIndex = 5;
            this.button_AcqStartStop.Text = "Start";
            this.button_AcqStartStop.UseVisualStyleBackColor = true;
            this.button_AcqStartStop.Click += new System.EventHandler(this.button_AcqStartStop_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.Location = new System.Drawing.Point(40, 248);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(120, 15);
            this.label17.TabIndex = 16;
            this.label17.Text = "Number of Samples:";
            // 
            // numericUpDown_AcqThreshold
            // 
            this.numericUpDown_AcqThreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_AcqThreshold.Location = new System.Drawing.Point(176, 277);
            this.numericUpDown_AcqThreshold.Maximum = new decimal(new int[] {
            1023,
            0,
            0,
            0});
            this.numericUpDown_AcqThreshold.Name = "numericUpDown_AcqThreshold";
            this.numericUpDown_AcqThreshold.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_AcqThreshold.TabIndex = 15;
            this.numericUpDown_AcqThreshold.ValueChanged += new System.EventHandler(this.numericUpDown_AcqThreshold_ValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(302, 248);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 15);
            this.label16.TabIndex = 14;
            this.label16.Text = "samples";
            // 
            // numericUpDown_NumOfSamples
            // 
            this.numericUpDown_NumOfSamples.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_NumOfSamples.Location = new System.Drawing.Point(176, 244);
            this.numericUpDown_NumOfSamples.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericUpDown_NumOfSamples.Name = "numericUpDown_NumOfSamples";
            this.numericUpDown_NumOfSamples.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_NumOfSamples.TabIndex = 13;
            this.numericUpDown_NumOfSamples.ValueChanged += new System.EventHandler(this.numericUpDown_NumOfSamples_ValueChanged);
            // 
            // numericUpDown_AcqRepeats
            // 
            this.numericUpDown_AcqRepeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_AcqRepeats.Location = new System.Drawing.Point(176, 184);
            this.numericUpDown_AcqRepeats.Name = "numericUpDown_AcqRepeats";
            this.numericUpDown_AcqRepeats.Size = new System.Drawing.Size(71, 22);
            this.numericUpDown_AcqRepeats.TabIndex = 12;
            // 
            // checkBox_Repeats
            // 
            this.checkBox_Repeats.AutoSize = true;
            this.checkBox_Repeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_Repeats.Location = new System.Drawing.Point(98, 186);
            this.checkBox_Repeats.Name = "checkBox_Repeats";
            this.checkBox_Repeats.Size = new System.Drawing.Size(72, 19);
            this.checkBox_Repeats.TabIndex = 11;
            this.checkBox_Repeats.Text = "Repeats";
            this.checkBox_Repeats.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton4.Location = new System.Drawing.Point(176, 86);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(124, 20);
            this.radioButton4.TabIndex = 10;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Events per Time";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(302, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "events";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(302, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "sec";
            // 
            // numericUpDown_NumOfEvents
            // 
            this.numericUpDown_NumOfEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_NumOfEvents.Location = new System.Drawing.Point(176, 119);
            this.numericUpDown_NumOfEvents.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numericUpDown_NumOfEvents.Name = "numericUpDown_NumOfEvents";
            this.numericUpDown_NumOfEvents.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_NumOfEvents.TabIndex = 7;
            this.numericUpDown_NumOfEvents.ValueChanged += new System.EventHandler(this.numericUpDown_NumOfEvents_ValueChanged);
            // 
            // numericUpDown_Time
            // 
            this.numericUpDown_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_Time.Location = new System.Drawing.Point(176, 147);
            this.numericUpDown_Time.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numericUpDown_Time.Name = "numericUpDown_Time";
            this.numericUpDown_Time.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_Time.TabIndex = 6;
            this.numericUpDown_Time.ValueChanged += new System.EventHandler(this.numericUpDown_Time_ValueChanged);
            // 
            // radioButton_AcqTime
            // 
            this.radioButton_AcqTime.AutoSize = true;
            this.radioButton_AcqTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton_AcqTime.Location = new System.Drawing.Point(18, 147);
            this.radioButton_AcqTime.Name = "radioButton_AcqTime";
            this.radioButton_AcqTime.Size = new System.Drawing.Size(142, 20);
            this.radioButton_AcqTime.TabIndex = 2;
            this.radioButton_AcqTime.TabStop = true;
            this.radioButton_AcqTime.Text = "Measurement Time";
            this.radioButton_AcqTime.UseVisualStyleBackColor = true;
            this.radioButton_AcqTime.CheckedChanged += new System.EventHandler(this.radioButton_Acq_CheckedChanged);
            // 
            // radioButton_AcqNumEvents
            // 
            this.radioButton_AcqNumEvents.AutoSize = true;
            this.radioButton_AcqNumEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton_AcqNumEvents.Location = new System.Drawing.Point(18, 119);
            this.radioButton_AcqNumEvents.Name = "radioButton_AcqNumEvents";
            this.radioButton_AcqNumEvents.Size = new System.Drawing.Size(132, 20);
            this.radioButton_AcqNumEvents.TabIndex = 1;
            this.radioButton_AcqNumEvents.TabStop = true;
            this.radioButton_AcqNumEvents.Text = "Number of Events";
            this.radioButton_AcqNumEvents.UseVisualStyleBackColor = true;
            this.radioButton_AcqNumEvents.CheckedChanged += new System.EventHandler(this.radioButton_Acq_CheckedChanged);
            // 
            // radioButton_AcqInfinite
            // 
            this.radioButton_AcqInfinite.AutoSize = true;
            this.radioButton_AcqInfinite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton_AcqInfinite.Location = new System.Drawing.Point(18, 86);
            this.radioButton_AcqInfinite.Name = "radioButton_AcqInfinite";
            this.radioButton_AcqInfinite.Size = new System.Drawing.Size(63, 20);
            this.radioButton_AcqInfinite.TabIndex = 0;
            this.radioButton_AcqInfinite.TabStop = true;
            this.radioButton_AcqInfinite.Text = "Infinite";
            this.radioButton_AcqInfinite.UseVisualStyleBackColor = true;
            this.radioButton_AcqInfinite.CheckedChanged += new System.EventHandler(this.radioButton_Acq_CheckedChanged);
            // 
            // tabMeasurementData
            // 
            this.tabMeasurementData.Controls.Add(this.tableLayoutPanel2);
            this.tabMeasurementData.Location = new System.Drawing.Point(4, 22);
            this.tabMeasurementData.Margin = new System.Windows.Forms.Padding(2);
            this.tabMeasurementData.Name = "tabMeasurementData";
            this.tabMeasurementData.Padding = new System.Windows.Forms.Padding(2);
            this.tabMeasurementData.Size = new System.Drawing.Size(1240, 601);
            this.tabMeasurementData.TabIndex = 1;
            this.tabMeasurementData.Text = "Measurement Data";
            this.tabMeasurementData.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.28328F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.71672F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridView_events, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1236, 597);
            this.tableLayoutPanel2.TabIndex = 20;
            // 
            // dataGridView_events
            // 
            this.dataGridView_events.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_events.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_events.Location = new System.Drawing.Point(859, 3);
            this.dataGridView_events.Name = "dataGridView_events";
            this.dataGridView_events.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_events.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView_events.Size = new System.Drawing.Size(374, 591);
            this.dataGridView_events.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button_EventsListClear);
            this.panel4.Controls.Add(this.button7);
            this.panel4.Controls.Add(this.chart_data);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(850, 591);
            this.panel4.TabIndex = 21;
            // 
            // button_EventsListClear
            // 
            this.button_EventsListClear.Location = new System.Drawing.Point(652, 55);
            this.button_EventsListClear.Name = "button_EventsListClear";
            this.button_EventsListClear.Size = new System.Drawing.Size(135, 30);
            this.button_EventsListClear.TabIndex = 19;
            this.button_EventsListClear.Text = "Clear";
            this.button_EventsListClear.UseVisualStyleBackColor = true;
            this.button_EventsListClear.Click += new System.EventHandler(this.button_EventsListClear_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(174, 36);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(135, 30);
            this.button7.TabIndex = 17;
            this.button7.Text = "Open Data File";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // chart_data
            // 
            this.chart_data.BorderlineColor = System.Drawing.Color.Black;
            this.chart_data.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.Name = "ChartArea1";
            this.chart_data.ChartAreas.Add(chartArea2);
            this.chart_data.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend2.Name = "Legend1";
            this.chart_data.Legends.Add(legend2);
            this.chart_data.Location = new System.Drawing.Point(0, 197);
            this.chart_data.Margin = new System.Windows.Forms.Padding(2);
            this.chart_data.Name = "chart_data";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Data";
            this.chart_data.Series.Add(series2);
            this.chart_data.Size = new System.Drawing.Size(850, 394);
            this.chart_data.TabIndex = 21;
            this.chart_data.Text = "chart_data";
            this.chart_data.Click += new System.EventHandler(this.chart_data_Click);
            // 
            // tabGpio
            // 
            this.tabGpio.Controls.Add(this.tableLayoutPanel1);
            this.tabGpio.Controls.Add(this.panel2);
            this.tabGpio.Location = new System.Drawing.Point(4, 22);
            this.tabGpio.Name = "tabGpio";
            this.tabGpio.Size = new System.Drawing.Size(1240, 601);
            this.tabGpio.TabIndex = 9;
            this.tabGpio.Text = "GPIOs";
            this.tabGpio.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView_GpioOutputs, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView_GpioInputs, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(121, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1119, 601);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // dataGridView_GpioOutputs
            // 
            this.dataGridView_GpioOutputs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_GpioOutputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_GpioOutputs.Location = new System.Drawing.Point(562, 23);
            this.dataGridView_GpioOutputs.Name = "dataGridView_GpioOutputs";
            this.dataGridView_GpioOutputs.ReadOnly = true;
            this.dataGridView_GpioOutputs.Size = new System.Drawing.Size(554, 575);
            this.dataGridView_GpioOutputs.TabIndex = 5;
            this.dataGridView_GpioOutputs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_GpioOutputs_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.label1.Size = new System.Drawing.Size(553, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "INPUTs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(562, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.label2.Size = new System.Drawing.Size(554, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "OUTPUTs";
            // 
            // dataGridView_GpioInputs
            // 
            this.dataGridView_GpioInputs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_GpioInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_GpioInputs.Location = new System.Drawing.Point(3, 23);
            this.dataGridView_GpioInputs.Name = "dataGridView_GpioInputs";
            this.dataGridView_GpioInputs.ReadOnly = true;
            this.dataGridView_GpioInputs.Size = new System.Drawing.Size(553, 575);
            this.dataGridView_GpioInputs.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_ClearRisingFalling);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(121, 601);
            this.panel2.TabIndex = 2;
            // 
            // button_ClearRisingFalling
            // 
            this.button_ClearRisingFalling.Location = new System.Drawing.Point(20, 23);
            this.button_ClearRisingFalling.Margin = new System.Windows.Forms.Padding(2);
            this.button_ClearRisingFalling.Name = "button_ClearRisingFalling";
            this.button_ClearRisingFalling.Size = new System.Drawing.Size(74, 37);
            this.button_ClearRisingFalling.TabIndex = 6;
            this.button_ClearRisingFalling.Text = "Clear Rising Falling";
            this.button_ClearRisingFalling.UseVisualStyleBackColor = true;
            this.button_ClearRisingFalling.Click += new System.EventHandler(this.button_ClearRisingFalling_Click);
            // 
            // tabReset
            // 
            this.tabReset.Controls.Add(this.dataGridView_Resets);
            this.tabReset.Controls.Add(this.label4);
            this.tabReset.Controls.Add(this.panel6);
            this.tabReset.Location = new System.Drawing.Point(4, 22);
            this.tabReset.Name = "tabReset";
            this.tabReset.Size = new System.Drawing.Size(1240, 601);
            this.tabReset.TabIndex = 10;
            this.tabReset.Text = "RESETs";
            this.tabReset.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Resets
            // 
            this.dataGridView_Resets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Resets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Resets.Location = new System.Drawing.Point(446, 21);
            this.dataGridView_Resets.Name = "dataGridView_Resets";
            this.dataGridView_Resets.ReadOnly = true;
            this.dataGridView_Resets.Size = new System.Drawing.Size(794, 580);
            this.dataGridView_Resets.TabIndex = 8;
            this.dataGridView_Resets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Resets_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(446, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "RESETs";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button_Reset);
            this.panel6.Controls.Add(this.button_ResetClearAll);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(446, 601);
            this.panel6.TabIndex = 3;
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(157, 21);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(74, 37);
            this.button_Reset.TabIndex = 9;
            this.button_Reset.Text = "FPGA RESET";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // button_ResetClearAll
            // 
            this.button_ResetClearAll.Location = new System.Drawing.Point(17, 21);
            this.button_ResetClearAll.Margin = new System.Windows.Forms.Padding(2);
            this.button_ResetClearAll.Name = "button_ResetClearAll";
            this.button_ResetClearAll.Size = new System.Drawing.Size(74, 37);
            this.button_ResetClearAll.TabIndex = 8;
            this.button_ResetClearAll.Text = "Clear All Resets";
            this.button_ResetClearAll.UseVisualStyleBackColor = true;
            // 
            // tabConfiguration
            // 
            this.tabConfiguration.Controls.Add(this.tableLayoutPanel3);
            this.tabConfiguration.Location = new System.Drawing.Point(4, 22);
            this.tabConfiguration.Name = "tabConfiguration";
            this.tabConfiguration.Size = new System.Drawing.Size(1240, 601);
            this.tabConfiguration.TabIndex = 8;
            this.tabConfiguration.Text = "Configuration";
            this.tabConfiguration.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 334F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.splitContainer1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1240, 601);
            this.tableLayoutPanel3.TabIndex = 20;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(337, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView_MultipleConfigFiles);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView_ConfigFile);
            this.splitContainer1.Size = new System.Drawing.Size(900, 595);
            this.splitContainer1.SplitterDistance = 450;
            this.splitContainer1.TabIndex = 18;
            // 
            // dataGridView_MultipleConfigFiles
            // 
            this.dataGridView_MultipleConfigFiles.AllowUserToAddRows = false;
            this.dataGridView_MultipleConfigFiles.AllowUserToDeleteRows = false;
            this.dataGridView_MultipleConfigFiles.AllowUserToResizeColumns = false;
            this.dataGridView_MultipleConfigFiles.AllowUserToResizeRows = false;
            this.dataGridView_MultipleConfigFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_MultipleConfigFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_MultipleConfigFiles.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_MultipleConfigFiles.MultiSelect = false;
            this.dataGridView_MultipleConfigFiles.Name = "dataGridView_MultipleConfigFiles";
            this.dataGridView_MultipleConfigFiles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_MultipleConfigFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_MultipleConfigFiles.Size = new System.Drawing.Size(450, 595);
            this.dataGridView_MultipleConfigFiles.TabIndex = 17;
            this.dataGridView_MultipleConfigFiles.SelectionChanged += new System.EventHandler(this.dataGridView_MultipleConfigFiles_SelectionChanged);
            // 
            // dataGridView_ConfigFile
            // 
            this.dataGridView_ConfigFile.AllowUserToAddRows = false;
            this.dataGridView_ConfigFile.AllowUserToDeleteRows = false;
            this.dataGridView_ConfigFile.AllowUserToResizeColumns = false;
            this.dataGridView_ConfigFile.AllowUserToResizeRows = false;
            this.dataGridView_ConfigFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ConfigFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_ConfigFile.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_ConfigFile.MultiSelect = false;
            this.dataGridView_ConfigFile.Name = "dataGridView_ConfigFile";
            this.dataGridView_ConfigFile.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_ConfigFile.Size = new System.Drawing.Size(446, 595);
            this.dataGridView_ConfigFile.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox7);
            this.panel5.Controls.Add(this.groupBox9);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(328, 595);
            this.panel5.TabIndex = 19;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button_RemoveConfig);
            this.groupBox7.Controls.Add(this.button_AddNewConfig);
            this.groupBox7.Controls.Add(this.button_ConfigFileLoadFromFile);
            this.groupBox7.Controls.Add(this.button_ConfigFileSaveToFile);
            this.groupBox7.Controls.Add(this.button_ConfigFileSaveAs);
            this.groupBox7.Location = new System.Drawing.Point(21, 25);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(228, 230);
            this.groupBox7.TabIndex = 12;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Configuration File";
            // 
            // button_RemoveConfig
            // 
            this.button_RemoveConfig.Location = new System.Drawing.Point(122, 32);
            this.button_RemoveConfig.Margin = new System.Windows.Forms.Padding(2);
            this.button_RemoveConfig.Name = "button_RemoveConfig";
            this.button_RemoveConfig.Size = new System.Drawing.Size(74, 37);
            this.button_RemoveConfig.TabIndex = 17;
            this.button_RemoveConfig.Text = "Remove";
            this.button_RemoveConfig.UseVisualStyleBackColor = true;
            this.button_RemoveConfig.Click += new System.EventHandler(this.button_RemoveConfig_Click);
            // 
            // button_AddNewConfig
            // 
            this.button_AddNewConfig.Location = new System.Drawing.Point(31, 32);
            this.button_AddNewConfig.Margin = new System.Windows.Forms.Padding(2);
            this.button_AddNewConfig.Name = "button_AddNewConfig";
            this.button_AddNewConfig.Size = new System.Drawing.Size(74, 37);
            this.button_AddNewConfig.TabIndex = 16;
            this.button_AddNewConfig.Text = "Add New";
            this.button_AddNewConfig.UseVisualStyleBackColor = true;
            this.button_AddNewConfig.Click += new System.EventHandler(this.button_AddNewConfig_Click);
            // 
            // button_ConfigFileLoadFromFile
            // 
            this.button_ConfigFileLoadFromFile.Location = new System.Drawing.Point(31, 91);
            this.button_ConfigFileLoadFromFile.Margin = new System.Windows.Forms.Padding(2);
            this.button_ConfigFileLoadFromFile.Name = "button_ConfigFileLoadFromFile";
            this.button_ConfigFileLoadFromFile.Size = new System.Drawing.Size(74, 37);
            this.button_ConfigFileLoadFromFile.TabIndex = 9;
            this.button_ConfigFileLoadFromFile.Text = "Load from File";
            this.button_ConfigFileLoadFromFile.UseVisualStyleBackColor = true;
            this.button_ConfigFileLoadFromFile.Click += new System.EventHandler(this.button_ConfigFileLoadFromFile_Click);
            // 
            // button_ConfigFileSaveToFile
            // 
            this.button_ConfigFileSaveToFile.Location = new System.Drawing.Point(31, 173);
            this.button_ConfigFileSaveToFile.Margin = new System.Windows.Forms.Padding(2);
            this.button_ConfigFileSaveToFile.Name = "button_ConfigFileSaveToFile";
            this.button_ConfigFileSaveToFile.Size = new System.Drawing.Size(74, 37);
            this.button_ConfigFileSaveToFile.TabIndex = 11;
            this.button_ConfigFileSaveToFile.Text = "Save to File";
            this.button_ConfigFileSaveToFile.UseVisualStyleBackColor = true;
            this.button_ConfigFileSaveToFile.Click += new System.EventHandler(this.button_ConfigFileSaveToFile_Click);
            // 
            // button_ConfigFileSaveAs
            // 
            this.button_ConfigFileSaveAs.Location = new System.Drawing.Point(122, 173);
            this.button_ConfigFileSaveAs.Margin = new System.Windows.Forms.Padding(2);
            this.button_ConfigFileSaveAs.Name = "button_ConfigFileSaveAs";
            this.button_ConfigFileSaveAs.Size = new System.Drawing.Size(74, 37);
            this.button_ConfigFileSaveAs.TabIndex = 10;
            this.button_ConfigFileSaveAs.Text = "Save As";
            this.button_ConfigFileSaveAs.UseVisualStyleBackColor = true;
            this.button_ConfigFileSaveAs.Click += new System.EventHandler(this.button_ConfigFileSaveAs_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.button_ConfigRun);
            this.groupBox9.Controls.Add(this.button_ConfigStop);
            this.groupBox9.Location = new System.Drawing.Point(21, 277);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(228, 94);
            this.groupBox9.TabIndex = 16;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Sequence Action";
            // 
            // button_ConfigRun
            // 
            this.button_ConfigRun.Location = new System.Drawing.Point(31, 32);
            this.button_ConfigRun.Margin = new System.Windows.Forms.Padding(2);
            this.button_ConfigRun.Name = "button_ConfigRun";
            this.button_ConfigRun.Size = new System.Drawing.Size(74, 37);
            this.button_ConfigRun.TabIndex = 13;
            this.button_ConfigRun.Text = "Config Run";
            this.button_ConfigRun.UseVisualStyleBackColor = true;
            this.button_ConfigRun.Click += new System.EventHandler(this.button_ConfigRun_Click);
            // 
            // button_ConfigStop
            // 
            this.button_ConfigStop.Location = new System.Drawing.Point(122, 32);
            this.button_ConfigStop.Margin = new System.Windows.Forms.Padding(2);
            this.button_ConfigStop.Name = "button_ConfigStop";
            this.button_ConfigStop.Size = new System.Drawing.Size(74, 37);
            this.button_ConfigStop.TabIndex = 14;
            this.button_ConfigStop.Text = "Config Stop";
            this.button_ConfigStop.UseVisualStyleBackColor = true;
            this.button_ConfigStop.Click += new System.EventHandler(this.button_ConfigStop_Click);
            // 
            // tabSetting
            // 
            this.tabSetting.Controls.Add(this.label_InQ);
            this.tabSetting.Controls.Add(this.checkBox_cmdQuestions);
            this.tabSetting.Controls.Add(this.label_RecvBytes);
            this.tabSetting.Controls.Add(this.label_xRead);
            this.tabSetting.Controls.Add(this.button_xSend);
            this.tabSetting.Controls.Add(this.textBox_xSendByte0);
            this.tabSetting.Controls.Add(this.textBox_xSendByte1);
            this.tabSetting.Controls.Add(this.textBox_xSendByte2);
            this.tabSetting.Controls.Add(this.textBox_xSendByte3);
            this.tabSetting.Controls.Add(this.label_Test);
            this.tabSetting.Controls.Add(this.button_Test);
            this.tabSetting.Controls.Add(this.groupBox8);
            this.tabSetting.Controls.Add(this.groupBox1);
            this.tabSetting.Location = new System.Drawing.Point(4, 22);
            this.tabSetting.Name = "tabSetting";
            this.tabSetting.Size = new System.Drawing.Size(1240, 601);
            this.tabSetting.TabIndex = 6;
            this.tabSetting.Text = "System Setting";
            this.tabSetting.UseVisualStyleBackColor = true;
            // 
            // label_InQ
            // 
            this.label_InQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_InQ.Location = new System.Drawing.Point(423, 290);
            this.label_InQ.Name = "label_InQ";
            this.label_InQ.Size = new System.Drawing.Size(83, 21);
            this.label_InQ.TabIndex = 27;
            this.label_InQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox_cmdQuestions
            // 
            this.checkBox_cmdQuestions.AutoSize = true;
            this.checkBox_cmdQuestions.Checked = true;
            this.checkBox_cmdQuestions.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_cmdQuestions.Location = new System.Drawing.Point(81, 343);
            this.checkBox_cmdQuestions.Name = "checkBox_cmdQuestions";
            this.checkBox_cmdQuestions.Size = new System.Drawing.Size(100, 17);
            this.checkBox_cmdQuestions.TabIndex = 26;
            this.checkBox_cmdQuestions.Text = "CMD Questions";
            this.checkBox_cmdQuestions.UseVisualStyleBackColor = true;
            // 
            // label_RecvBytes
            // 
            this.label_RecvBytes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_RecvBytes.Location = new System.Drawing.Point(423, 246);
            this.label_RecvBytes.Name = "label_RecvBytes";
            this.label_RecvBytes.Size = new System.Drawing.Size(83, 21);
            this.label_RecvBytes.TabIndex = 25;
            this.label_RecvBytes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_xRead
            // 
            this.label_xRead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_xRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_xRead.Location = new System.Drawing.Point(337, 409);
            this.label_xRead.Name = "label_xRead";
            this.label_xRead.Size = new System.Drawing.Size(123, 20);
            this.label_xRead.TabIndex = 24;
            this.label_xRead.Text = "........";
            this.label_xRead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_xRead.Click += new System.EventHandler(this.label_xRead_Click);
            // 
            // button_xSend
            // 
            this.button_xSend.Location = new System.Drawing.Point(256, 409);
            this.button_xSend.Name = "button_xSend";
            this.button_xSend.Size = new System.Drawing.Size(75, 21);
            this.button_xSend.TabIndex = 23;
            this.button_xSend.Text = "Send";
            this.button_xSend.UseVisualStyleBackColor = true;
            this.button_xSend.Click += new System.EventHandler(this.button_xSend_Click);
            // 
            // textBox_xSendByte0
            // 
            this.textBox_xSendByte0.Location = new System.Drawing.Point(206, 409);
            this.textBox_xSendByte0.Name = "textBox_xSendByte0";
            this.textBox_xSendByte0.Size = new System.Drawing.Size(44, 20);
            this.textBox_xSendByte0.TabIndex = 22;
            // 
            // textBox_xSendByte1
            // 
            this.textBox_xSendByte1.Location = new System.Drawing.Point(156, 409);
            this.textBox_xSendByte1.Name = "textBox_xSendByte1";
            this.textBox_xSendByte1.Size = new System.Drawing.Size(44, 20);
            this.textBox_xSendByte1.TabIndex = 21;
            // 
            // textBox_xSendByte2
            // 
            this.textBox_xSendByte2.Location = new System.Drawing.Point(106, 409);
            this.textBox_xSendByte2.Name = "textBox_xSendByte2";
            this.textBox_xSendByte2.Size = new System.Drawing.Size(44, 20);
            this.textBox_xSendByte2.TabIndex = 20;
            // 
            // textBox_xSendByte3
            // 
            this.textBox_xSendByte3.Location = new System.Drawing.Point(56, 409);
            this.textBox_xSendByte3.Name = "textBox_xSendByte3";
            this.textBox_xSendByte3.Size = new System.Drawing.Size(44, 20);
            this.textBox_xSendByte3.TabIndex = 19;
            // 
            // label_Test
            // 
            this.label_Test.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Test.Location = new System.Drawing.Point(164, 290);
            this.label_Test.Name = "label_Test";
            this.label_Test.Size = new System.Drawing.Size(83, 21);
            this.label_Test.TabIndex = 4;
            this.label_Test.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Test.Click += new System.EventHandler(this.label_Test_Click);
            // 
            // button_Test
            // 
            this.button_Test.Location = new System.Drawing.Point(81, 290);
            this.button_Test.Name = "button_Test";
            this.button_Test.Size = new System.Drawing.Size(75, 21);
            this.button_Test.TabIndex = 5;
            this.button_Test.Text = "Test";
            this.button_Test.UseVisualStyleBackColor = true;
            this.button_Test.Click += new System.EventHandler(this.button_Test_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.dataGridView_RegistersFiles);
            this.groupBox8.Location = new System.Drawing.Point(775, 24);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(372, 495);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Registers Configuration Files";
            // 
            // dataGridView_RegistersFiles
            // 
            this.dataGridView_RegistersFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_RegistersFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_RegistersFiles.Location = new System.Drawing.Point(3, 16);
            this.dataGridView_RegistersFiles.Name = "dataGridView_RegistersFiles";
            this.dataGridView_RegistersFiles.Size = new System.Drawing.Size(366, 476);
            this.dataGridView_RegistersFiles.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_OpenCloseCommunication);
            this.groupBox1.Controls.Add(this.button_ScanCommunication);
            this.groupBox1.Controls.Add(this.comboBox_Communication);
            this.groupBox1.Controls.Add(this.radioButton_PCIe);
            this.groupBox1.Controls.Add(this.radioButton_USB);
            this.groupBox1.Controls.Add(this.radioButton_UART);
            this.groupBox1.Location = new System.Drawing.Point(47, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Communication";
            // 
            // button_OpenCloseCommunication
            // 
            this.button_OpenCloseCommunication.Location = new System.Drawing.Point(28, 166);
            this.button_OpenCloseCommunication.Name = "button_OpenCloseCommunication";
            this.button_OpenCloseCommunication.Size = new System.Drawing.Size(177, 35);
            this.button_OpenCloseCommunication.TabIndex = 5;
            this.button_OpenCloseCommunication.Text = "Open/Close";
            this.button_OpenCloseCommunication.UseVisualStyleBackColor = true;
            this.button_OpenCloseCommunication.Click += new System.EventHandler(this.button_OpenCloseCommunication_Click);
            // 
            // button_ScanCommunication
            // 
            this.button_ScanCommunication.Location = new System.Drawing.Point(130, 47);
            this.button_ScanCommunication.Name = "button_ScanCommunication";
            this.button_ScanCommunication.Size = new System.Drawing.Size(75, 63);
            this.button_ScanCommunication.TabIndex = 4;
            this.button_ScanCommunication.Text = "Scan";
            this.button_ScanCommunication.UseVisualStyleBackColor = true;
            this.button_ScanCommunication.Click += new System.EventHandler(this.button_ScanCommunication_Click);
            // 
            // comboBox_Communication
            // 
            this.comboBox_Communication.FormattingEnabled = true;
            this.comboBox_Communication.Location = new System.Drawing.Point(28, 130);
            this.comboBox_Communication.Name = "comboBox_Communication";
            this.comboBox_Communication.Size = new System.Drawing.Size(177, 21);
            this.comboBox_Communication.TabIndex = 3;
            // 
            // radioButton_PCIe
            // 
            this.radioButton_PCIe.AutoSize = true;
            this.radioButton_PCIe.Location = new System.Drawing.Point(28, 93);
            this.radioButton_PCIe.Name = "radioButton_PCIe";
            this.radioButton_PCIe.Size = new System.Drawing.Size(48, 17);
            this.radioButton_PCIe.TabIndex = 2;
            this.radioButton_PCIe.TabStop = true;
            this.radioButton_PCIe.Text = "PCIe";
            this.radioButton_PCIe.UseVisualStyleBackColor = true;
            // 
            // radioButton_USB
            // 
            this.radioButton_USB.AutoSize = true;
            this.radioButton_USB.Location = new System.Drawing.Point(28, 70);
            this.radioButton_USB.Name = "radioButton_USB";
            this.radioButton_USB.Size = new System.Drawing.Size(47, 17);
            this.radioButton_USB.TabIndex = 1;
            this.radioButton_USB.TabStop = true;
            this.radioButton_USB.Text = "USB";
            this.radioButton_USB.UseVisualStyleBackColor = true;
            // 
            // radioButton_UART
            // 
            this.radioButton_UART.AutoSize = true;
            this.radioButton_UART.Location = new System.Drawing.Point(28, 47);
            this.radioButton_UART.Name = "radioButton_UART";
            this.radioButton_UART.Size = new System.Drawing.Size(55, 17);
            this.radioButton_UART.TabIndex = 0;
            this.radioButton_UART.TabStop = true;
            this.radioButton_UART.Text = "UART";
            this.radioButton_UART.UseVisualStyleBackColor = true;
            this.radioButton_UART.CheckedChanged += new System.EventHandler(this.radioButton_Communication_CheckedChanged);
            // 
            // tabQuickSetup
            // 
            this.tabQuickSetup.Controls.Add(this.groupBox_LMXSync);
            this.tabQuickSetup.Location = new System.Drawing.Point(4, 22);
            this.tabQuickSetup.Name = "tabQuickSetup";
            this.tabQuickSetup.Size = new System.Drawing.Size(1240, 601);
            this.tabQuickSetup.TabIndex = 11;
            this.tabQuickSetup.Text = "Quick Setup";
            this.tabQuickSetup.UseVisualStyleBackColor = true;
            // 
            // groupBox_LMXSync
            // 
            this.groupBox_LMXSync.Controls.Add(this.checkBox_QS_FcalEn2);
            this.groupBox_LMXSync.Controls.Add(this.checkBox_QS_FcalEn1);
            this.groupBox_LMXSync.Controls.Add(this.label27);
            this.groupBox_LMXSync.Controls.Add(this.label_QS_CHDIV2);
            this.groupBox_LMXSync.Controls.Add(this.label29);
            this.groupBox_LMXSync.Controls.Add(this.label_QS_INC_DIV2);
            this.groupBox_LMXSync.Controls.Add(this.label31);
            this.groupBox_LMXSync.Controls.Add(this.label_QS_PLL_DEN2);
            this.groupBox_LMXSync.Controls.Add(this.label25);
            this.groupBox_LMXSync.Controls.Add(this.label_QS_CHDIV1);
            this.groupBox_LMXSync.Controls.Add(this.label23);
            this.groupBox_LMXSync.Controls.Add(this.label_QS_INC_DIV1);
            this.groupBox_LMXSync.Controls.Add(this.label22);
            this.groupBox_LMXSync.Controls.Add(this.label_QS_PLL_DEN1);
            this.groupBox_LMXSync.Controls.Add(this.label21);
            this.groupBox_LMXSync.Controls.Add(this.label_QS_Phase2);
            this.groupBox_LMXSync.Controls.Add(this.label20);
            this.groupBox_LMXSync.Controls.Add(this.label_QS_Phase1);
            this.groupBox_LMXSync.Controls.Add(this.button_QS_Sync);
            this.groupBox_LMXSync.Controls.Add(this.label14);
            this.groupBox_LMXSync.Controls.Add(this.numericUpDown_QS_Seed2);
            this.groupBox_LMXSync.Controls.Add(this.label12);
            this.groupBox_LMXSync.Controls.Add(this.numericUpDown_QS_Seed1);
            this.groupBox_LMXSync.Location = new System.Drawing.Point(40, 61);
            this.groupBox_LMXSync.Name = "groupBox_LMXSync";
            this.groupBox_LMXSync.Size = new System.Drawing.Size(383, 320);
            this.groupBox_LMXSync.TabIndex = 0;
            this.groupBox_LMXSync.TabStop = false;
            this.groupBox_LMXSync.Text = "LMX Sync";
            // 
            // checkBox_QS_FcalEn2
            // 
            this.checkBox_QS_FcalEn2.AutoSize = true;
            this.checkBox_QS_FcalEn2.Location = new System.Drawing.Point(248, 286);
            this.checkBox_QS_FcalEn2.Name = "checkBox_QS_FcalEn2";
            this.checkBox_QS_FcalEn2.Size = new System.Drawing.Size(85, 17);
            this.checkBox_QS_FcalEn2.TabIndex = 22;
            this.checkBox_QS_FcalEn2.Text = "FCAL_EN_2";
            this.checkBox_QS_FcalEn2.UseVisualStyleBackColor = true;
            this.checkBox_QS_FcalEn2.CheckedChanged += new System.EventHandler(this.checkBox_QS_FcalEn2_CheckedChanged);
            // 
            // checkBox_QS_FcalEn1
            // 
            this.checkBox_QS_FcalEn1.AutoSize = true;
            this.checkBox_QS_FcalEn1.Location = new System.Drawing.Point(41, 286);
            this.checkBox_QS_FcalEn1.Name = "checkBox_QS_FcalEn1";
            this.checkBox_QS_FcalEn1.Size = new System.Drawing.Size(85, 17);
            this.checkBox_QS_FcalEn1.TabIndex = 21;
            this.checkBox_QS_FcalEn1.Text = "FCAL_EN_1";
            this.checkBox_QS_FcalEn1.UseVisualStyleBackColor = true;
            this.checkBox_QS_FcalEn1.CheckedChanged += new System.EventHandler(this.checkBox_QS_FcalEn1_CheckedChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label27.Location = new System.Drawing.Point(256, 123);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(39, 12);
            this.label27.TabIndex = 20;
            this.label27.Text = "CHDIV:";
            // 
            // label_QS_CHDIV2
            // 
            this.label_QS_CHDIV2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_QS_CHDIV2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_QS_CHDIV2.Location = new System.Drawing.Point(296, 121);
            this.label_QS_CHDIV2.Name = "label_QS_CHDIV2";
            this.label_QS_CHDIV2.Size = new System.Drawing.Size(50, 18);
            this.label_QS_CHDIV2.TabIndex = 19;
            this.label_QS_CHDIV2.Text = "label3";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label29.Location = new System.Drawing.Point(254, 105);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(41, 12);
            this.label29.TabIndex = 18;
            this.label29.Text = "Inc_Div:";
            // 
            // label_QS_INC_DIV2
            // 
            this.label_QS_INC_DIV2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_QS_INC_DIV2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_QS_INC_DIV2.Location = new System.Drawing.Point(296, 103);
            this.label_QS_INC_DIV2.Name = "label_QS_INC_DIV2";
            this.label_QS_INC_DIV2.Size = new System.Drawing.Size(50, 18);
            this.label_QS_INC_DIV2.TabIndex = 17;
            this.label_QS_INC_DIV2.Text = "label3";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label31.Location = new System.Drawing.Point(246, 87);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(49, 12);
            this.label31.TabIndex = 16;
            this.label31.Text = "PLL_DEN:";
            // 
            // label_QS_PLL_DEN2
            // 
            this.label_QS_PLL_DEN2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_QS_PLL_DEN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_QS_PLL_DEN2.Location = new System.Drawing.Point(296, 85);
            this.label_QS_PLL_DEN2.Name = "label_QS_PLL_DEN2";
            this.label_QS_PLL_DEN2.Size = new System.Drawing.Size(50, 18);
            this.label_QS_PLL_DEN2.TabIndex = 15;
            this.label_QS_PLL_DEN2.Text = "label3";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label25.Location = new System.Drawing.Point(49, 123);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(39, 12);
            this.label25.TabIndex = 14;
            this.label25.Text = "CHDIV:";
            // 
            // label_QS_CHDIV1
            // 
            this.label_QS_CHDIV1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_QS_CHDIV1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_QS_CHDIV1.Location = new System.Drawing.Point(89, 121);
            this.label_QS_CHDIV1.Name = "label_QS_CHDIV1";
            this.label_QS_CHDIV1.Size = new System.Drawing.Size(50, 18);
            this.label_QS_CHDIV1.TabIndex = 13;
            this.label_QS_CHDIV1.Text = "label3";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label23.Location = new System.Drawing.Point(47, 105);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(41, 12);
            this.label23.TabIndex = 12;
            this.label23.Text = "Inc_Div:";
            // 
            // label_QS_INC_DIV1
            // 
            this.label_QS_INC_DIV1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_QS_INC_DIV1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_QS_INC_DIV1.Location = new System.Drawing.Point(89, 103);
            this.label_QS_INC_DIV1.Name = "label_QS_INC_DIV1";
            this.label_QS_INC_DIV1.Size = new System.Drawing.Size(50, 18);
            this.label_QS_INC_DIV1.TabIndex = 11;
            this.label_QS_INC_DIV1.Text = "label3";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label22.Location = new System.Drawing.Point(39, 87);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(49, 12);
            this.label22.TabIndex = 10;
            this.label22.Text = "PLL_DEN:";
            // 
            // label_QS_PLL_DEN1
            // 
            this.label_QS_PLL_DEN1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_QS_PLL_DEN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_QS_PLL_DEN1.Location = new System.Drawing.Point(89, 85);
            this.label_QS_PLL_DEN1.Name = "label_QS_PLL_DEN1";
            this.label_QS_PLL_DEN1.Size = new System.Drawing.Size(50, 18);
            this.label_QS_PLL_DEN1.TabIndex = 9;
            this.label_QS_PLL_DEN1.Text = "label3";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(240, 171);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(55, 13);
            this.label21.TabIndex = 8;
            this.label21.Text = "PHASE 2:";
            // 
            // label_QS_Phase2
            // 
            this.label_QS_Phase2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_QS_Phase2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_QS_Phase2.Location = new System.Drawing.Point(243, 191);
            this.label_QS_Phase2.Name = "label_QS_Phase2";
            this.label_QS_Phase2.Size = new System.Drawing.Size(103, 20);
            this.label_QS_Phase2.TabIndex = 7;
            this.label_QS_Phase2.Text = "label3";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(33, 171);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 13);
            this.label20.TabIndex = 6;
            this.label20.Text = "PHASE 1:";
            // 
            // label_QS_Phase1
            // 
            this.label_QS_Phase1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_QS_Phase1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_QS_Phase1.Location = new System.Drawing.Point(36, 191);
            this.label_QS_Phase1.Name = "label_QS_Phase1";
            this.label_QS_Phase1.Size = new System.Drawing.Size(103, 20);
            this.label_QS_Phase1.TabIndex = 5;
            this.label_QS_Phase1.Text = "label3";
            // 
            // button_QS_Sync
            // 
            this.button_QS_Sync.Location = new System.Drawing.Point(36, 234);
            this.button_QS_Sync.Name = "button_QS_Sync";
            this.button_QS_Sync.Size = new System.Drawing.Size(310, 31);
            this.button_QS_Sync.TabIndex = 4;
            this.button_QS_Sync.Text = "SYNC Pulse";
            this.button_QS_Sync.UseVisualStyleBackColor = true;
            this.button_QS_Sync.Click += new System.EventHandler(this.button_QS_Sync_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(240, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "MASH SEED 2:";
            // 
            // numericUpDown_QS_Seed2
            // 
            this.numericUpDown_QS_Seed2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_QS_Seed2.Location = new System.Drawing.Point(243, 50);
            this.numericUpDown_QS_Seed2.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown_QS_Seed2.Name = "numericUpDown_QS_Seed2";
            this.numericUpDown_QS_Seed2.Size = new System.Drawing.Size(103, 26);
            this.numericUpDown_QS_Seed2.TabIndex = 2;
            this.numericUpDown_QS_Seed2.ValueChanged += new System.EventHandler(this.numericUpDown_QS_Seed2_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "MASH SEED 1:";
            // 
            // numericUpDown_QS_Seed1
            // 
            this.numericUpDown_QS_Seed1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_QS_Seed1.Location = new System.Drawing.Point(36, 50);
            this.numericUpDown_QS_Seed1.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown_QS_Seed1.Name = "numericUpDown_QS_Seed1";
            this.numericUpDown_QS_Seed1.Size = new System.Drawing.Size(103, 26);
            this.numericUpDown_QS_Seed1.TabIndex = 0;
            this.numericUpDown_QS_Seed1.ValueChanged += new System.EventHandler(this.numericUpDown_QS_Seed1_ValueChanged);
            // 
            // timerForm
            // 
            this.timerForm.Enabled = true;
            this.timerForm.Interval = 50;
            this.timerForm.Tick += new System.EventHandler(this.timerForm_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 666);
            this.Controls.Add(this.tabControl_MAIN);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1200, 650);
            this.Name = "Form1";
            this.Text = "Ultra High Speed  AdcDAQ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.tabRegisters.ResumeLayout(false);
            this.tabControl_RegistersSetting.ResumeLayout(false);
            this.tabPage_ADC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ADCReg)).EndInit();
            this.tabPage_HMC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HMCReg)).EndInit();
            this.tabPage_LMX1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LMX1Reg)).EndInit();
            this.tabPage_LMX2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LMX2Reg)).EndInit();
            this.tabPage_TestReg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TestReg)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox_RegBits.ResumeLayout(false);
            this.groupBox_RegBits.PerformLayout();
            this.tabControl_MAIN.ResumeLayout(false);
            this.tabMeasurement_Setting.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AcqThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NumOfSamples)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AcqRepeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NumOfEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Time)).EndInit();
            this.tabMeasurementData.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_events)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_data)).EndInit();
            this.tabGpio.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GpioOutputs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GpioInputs)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabReset.ResumeLayout(false);
            this.tabReset.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Resets)).EndInit();
            this.panel6.ResumeLayout(false);
            this.tabConfiguration.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MultipleConfigFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ConfigFile)).EndInit();
            this.panel5.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.tabSetting.ResumeLayout(false);
            this.tabSetting.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RegistersFiles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabQuickSetup.ResumeLayout(false);
            this.groupBox_LMXSync.ResumeLayout(false);
            this.groupBox_LMXSync.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_QS_Seed2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_QS_Seed1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timerRequest;
        private System.Windows.Forms.TabPage tabRegisters;
        private System.Windows.Forms.TabControl tabControl_RegistersSetting;
        private System.Windows.Forms.TabPage tabPage_ADC;
        private System.Windows.Forms.DataGridView dataGridView_ADCReg;
        private System.Windows.Forms.TabPage tabPage_HMC;
        private System.Windows.Forms.DataGridView dataGridView_HMCReg;
        private System.Windows.Forms.TabPage tabPage_LMX1;
        private System.Windows.Forms.DataGridView dataGridView_LMX1Reg;
        private System.Windows.Forms.TabPage tabPage_LMX2;
        private System.Windows.Forms.DataGridView dataGridView_LMX2Reg;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox_RegBits;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.Button button_RegSaveAs;
        private System.Windows.Forms.Button button_RegLoadFromFile;
        private System.Windows.Forms.TabControl tabControl_MAIN;
        private System.Windows.Forms.TabPage tabPage_TestReg;
        private System.Windows.Forms.DataGridView dataGridView_TestReg;
        private System.Windows.Forms.TabPage tabSetting;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_OpenCloseCommunication;
        private System.Windows.Forms.Button button_ScanCommunication;
        private System.Windows.Forms.ComboBox comboBox_Communication;
        private System.Windows.Forms.RadioButton radioButton_PCIe;
        private System.Windows.Forms.RadioButton radioButton_USB;
        private System.Windows.Forms.RadioButton radioButton_UART;
        private System.Windows.Forms.TabPage tabMeasurement_Setting;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown_NumOfEvents;
        private System.Windows.Forms.NumericUpDown numericUpDown_Time;
        private System.Windows.Forms.Button button_AcqStartStop;
        private System.Windows.Forms.RadioButton radioButton_AcqTime;
        private System.Windows.Forms.RadioButton radioButton_AcqNumEvents;
        private System.Windows.Forms.RadioButton radioButton_AcqInfinite;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_CountersClearAll;
        private System.Windows.Forms.Button button_CountersClearInRun;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label_CounterInRunEvents;
        private System.Windows.Forms.Button button_CountersClearProcessed;
        private System.Windows.Forms.Button button_CountersClearIncoming;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_CounterProcessedEvents;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_CounterIncomingEvents;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox checkBox_SaveToRam;
        private System.Windows.Forms.Button button_OpenDataFile;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_DataFilePath;
        private System.Windows.Forms.CheckBox checkBox_SaveToFile;
        private System.Windows.Forms.NumericUpDown numericUpDown_AcqRepeats;
        private System.Windows.Forms.CheckBox checkBox_Repeats;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox checkBox_TestGeneratorEnable;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown numericUpDown_AcqThreshold;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numericUpDown_NumOfSamples;
        private System.Windows.Forms.Label label_AcqState;
        private System.Windows.Forms.TabPage tabConfiguration;
        private System.Windows.Forms.Button button_RegSaveToFile;
        private System.Windows.Forms.Button button_RegWriteAll;
        private System.Windows.Forms.Button button_RegReadAll;
        private System.Windows.Forms.DataGridView dataGridView_ConfigFile;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button_ConfigFileLoadFromFile;
        private System.Windows.Forms.Button button_ConfigFileSaveToFile;
        private System.Windows.Forms.Button button_ConfigFileSaveAs;
        private System.Windows.Forms.Button button_ConfigRun;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.DataGridView dataGridView_RegistersFiles;
        public System.Windows.Forms.Label label_Test;
        private System.Windows.Forms.Button button_Test;
        private System.Windows.Forms.Button button_ConfigStop;
        private System.Windows.Forms.Label label_xRead;
        private System.Windows.Forms.Button button_xSend;
        private System.Windows.Forms.TextBox textBox_xSendByte0;
        private System.Windows.Forms.TextBox textBox_xSendByte1;
        private System.Windows.Forms.TextBox textBox_xSendByte2;
        private System.Windows.Forms.TextBox textBox_xSendByte3;
        private System.Windows.Forms.TabPage tabGpio;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView_GpioOutputs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_GpioInputs;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_ClearRisingFalling;
        public System.Windows.Forms.Label label_RecvBytes;
        private System.Windows.Forms.CheckBox checkBox_cmdQuestions;
        public System.Windows.Forms.Label label_InQ;
        private System.Windows.Forms.Button button_AddNewConfig;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TabPage tabReset;
        private System.Windows.Forms.DataGridView dataGridView_Resets;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Button button_ResetClearAll;
        private System.Windows.Forms.TabPage tabMeasurementData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView_events;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button_EventsListClear;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_data;
        public System.Windows.Forms.Label label_dataErrors;
        private System.Windows.Forms.Button button_RegUpdateFromExtFile;
        private System.Windows.Forms.DataGridView dataGridView_MultipleConfigFiles;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button_RemoveConfig;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label_RegDescription;
        private System.Windows.Forms.Label label_RegRW;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_RegValue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox_RegBitSet0;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.CheckBox checkBox16;
        private System.Windows.Forms.TextBox textBox_RegAddress;
        private System.Windows.Forms.Button button_RegAddrFind;
        private System.Windows.Forms.TabPage tabQuickSetup;
        private System.Windows.Forms.GroupBox groupBox_LMXSync;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label_QS_Phase2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label_QS_Phase1;
        private System.Windows.Forms.Button button_QS_Sync;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numericUpDown_QS_Seed2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericUpDown_QS_Seed1;
        private System.Windows.Forms.Label label_QS_PLL_DEN1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label_QS_CHDIV1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label_QS_INC_DIV1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label_QS_CHDIV2;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label_QS_INC_DIV2;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label_QS_PLL_DEN2;
        private System.Windows.Forms.CheckBox checkBox_QS_FcalEn2;
        private System.Windows.Forms.CheckBox checkBox_QS_FcalEn1;
        private System.Windows.Forms.RadioButton radioButton_RegValDEC;
        private System.Windows.Forms.RadioButton radioButton_RegValHEX;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.RadioButton radioButton_RegAddrHEX;
        private System.Windows.Forms.RadioButton radioButton_RegAddrDEC;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Timer timerForm;
        public System.Windows.Forms.Label labelXXX;
    }
}

