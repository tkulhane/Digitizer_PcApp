﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digitizer_ver1
{
    class RegistersSetting_Data
    {

        public enum eReadWrite : byte
        {
            non,
            read_write,
            read,
            write
        }

        int _address;
        [DisplayName("Address")]
        public int p_address { get { return _address; } }

        string _description;
        [DisplayName("Description")]
        public String p_description { get { return _description; } }

        string _StrReadWrite;
        [DisplayName("Read/Write")]
        public String p__StrReadWrite { get { return _StrReadWrite; } }

        string _value;
        [DisplayName("Value")]
        public string p_value { get { return _value; } set { _value = value; } }

        public readonly eReadWrite _ReadWrite;

        public readonly bool dataOk;


        static char[] caSplit = new char[] { ';' };
        public RegistersSetting_Data(String line)
        {
            if (String.IsNullOrEmpty(line) || !line.Contains(";")) 
            {
                dataOk = false;
                return;
            }
                

            String[] line_parts = line.Split(caSplit);

            int temp_intValue;

            if (!int.TryParse(line_parts[0], NumberStyles.HexNumber, null, out _address)) _address = -1;
            if (!int.TryParse(line_parts[3], NumberStyles.HexNumber, null, out temp_intValue)) temp_intValue = -1;

            _value = temp_intValue.ToString("X");

            _ReadWrite = ParseReadWrite(line_parts[2]);
            if (_ReadWrite == eReadWrite.non) _StrReadWrite = "-";
            else if (_ReadWrite == eReadWrite.read) _StrReadWrite = "R";
            else if (_ReadWrite == eReadWrite.read_write) _StrReadWrite = "R/W";
            else if (_ReadWrite == eReadWrite.write) _StrReadWrite = "W";

            _description = line_parts[1];
            

            if (_address < 0 || temp_intValue < 0)
            {
                dataOk = false;
            }
            else
            {
                dataOk = true;
            }

        }

        

        public RegistersSetting_Data(String line, RegistersSetting.eAddressValueSize size)
        {
            if (String.IsNullOrEmpty(line) || !line.Contains(";")) 
            {
                dataOk = false;
                return;
            }
                

            String[] line_parts = line.Split(caSplit);

            int temp_intValue;

            if (!int.TryParse(line_parts[0], NumberStyles.HexNumber, null, out _address)) _address = -1;
            if (!int.TryParse(line_parts[3], NumberStyles.HexNumber, null, out temp_intValue)) temp_intValue = -1 ;


            if (size == RegistersSetting.eAddressValueSize.Address8_Value8)
            {
                if (_address > 0xFF)        _address = -1;
                if (temp_intValue > 0xFF)   temp_intValue = -1;
            }
            else if (size == RegistersSetting.eAddressValueSize.Address16_Value8)
            {
                if (_address > 0xFFFF)      _address = -1;
                if (temp_intValue > 0xFF)   temp_intValue = -1;
            }
            else if (size == RegistersSetting.eAddressValueSize.Address8_Value16)
            {
                if (_address > 0xFF)        _address = -1;
                if (temp_intValue > 0xFFFF) temp_intValue = -1;
            }

            _value = temp_intValue.ToString("X");


            _ReadWrite = ParseReadWrite(line_parts[2]);
            if (_ReadWrite == eReadWrite.non) _StrReadWrite = "-";
            else if (_ReadWrite == eReadWrite.read) _StrReadWrite = "R";
            else if (_ReadWrite == eReadWrite.read_write) _StrReadWrite = "R/W";
            else if (_ReadWrite == eReadWrite.write) _StrReadWrite = "W";

            _description = line_parts[1];



            if (_address < 0 || temp_intValue < 0)
            {
                dataOk = false;
            }
            else 
            {
                dataOk = true;
            }
        }

        public int ParseValue() 
        {
            int value = -1;

            if (!int.TryParse(_value, NumberStyles.HexNumber, null, out value))
            {
                MessageBox.Show("Wrong value when parsing cell text. \nText: " + _value, "Wrong Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

            return value;
        }

        public int ParseValue(RegistersSetting.eAddressValueSize size)
        {
            int value = -1;

            if(!int.TryParse(_value, NumberStyles.HexNumber, null, out value)) value = -1;


            if (size == RegistersSetting.eAddressValueSize.Address8_Value8) 
            {
                if (value > 0xFF) value = - 1;
            }
            else if (size == RegistersSetting.eAddressValueSize.Address16_Value8)
            {
                if (value > 0xFF) value = - 1;
            }
            else if (size == RegistersSetting.eAddressValueSize.Address8_Value16)
            {
                if (value > 0xFFFF) value = - 1;
            }

            if(value < 0) 
            {
                MessageBox.Show("Wrong value when parsing cell text. \nText: " + _value, "Wrong Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = -1;
            }

            return value;
        }

        public eReadWrite ParseReadWrite()
        {
            string s = _StrReadWrite;

            eReadWrite temp_ReadWrite = eReadWrite.non;

            if (string.Equals(s, "R/W", StringComparison.OrdinalIgnoreCase)) temp_ReadWrite = eReadWrite.read_write;
            else if (string.Equals(s, "RW", StringComparison.OrdinalIgnoreCase)) temp_ReadWrite = eReadWrite.read_write;
            else if (string.Equals(s, "R", StringComparison.OrdinalIgnoreCase)) temp_ReadWrite = eReadWrite.read;
            else if (string.Equals(s, "W", StringComparison.OrdinalIgnoreCase)) temp_ReadWrite = eReadWrite.write;

            return temp_ReadWrite;
        }


        public string ReadWriteToString(eReadWrite ReadWrite)
        {
            string StrReadWrite;

            if (ReadWrite == eReadWrite.read) StrReadWrite = "R";
            else if (ReadWrite == eReadWrite.read_write) StrReadWrite = "R/W";
            else if (ReadWrite == eReadWrite.write) StrReadWrite = "W";
            else StrReadWrite = "-";

            return StrReadWrite;
        }

        public string FormatToCSV()
        {
            
            return String.Format("{0:X};{1};{2};{3:X}\n", _address, _description, ReadWriteToString(_ReadWrite), _value);
        }

        public override string ToString()
        {
            return ToString(null, null);

        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            //throw new NotImplementedException();
            return String.Format("A:{0:X} V:{1}", _address, _value);
        }


        private eReadWrite ParseReadWrite(string s)
        {
            eReadWrite temp_ReadWrite = eReadWrite.non;

            if (string.Equals(s, "R/W", StringComparison.OrdinalIgnoreCase)) temp_ReadWrite = eReadWrite.read_write;
            else if (string.Equals(s, "RW", StringComparison.OrdinalIgnoreCase)) temp_ReadWrite = eReadWrite.read_write;
            else if (string.Equals(s, "R", StringComparison.OrdinalIgnoreCase)) temp_ReadWrite = eReadWrite.read;
            else if (string.Equals(s, "W", StringComparison.OrdinalIgnoreCase)) temp_ReadWrite = eReadWrite.write;

            return temp_ReadWrite;
        }
    }
}
