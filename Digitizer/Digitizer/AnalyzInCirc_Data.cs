﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitizer_ver1
{
    class AnalyzInCirc_Data
    {

        int _Number;
        [DisplayName("Number")]
        public int p_Number { get { return _Number; }  }

        string _Value1;
        [DisplayName("Value 1")]
        public string p_Value1 { get { return _Value1; } }

        string _Value2;
        [DisplayName("Value 2")]
        public string p_Value2 { get { return _Value2; } }

        string _Value3;
        [DisplayName("Value 3")]
        public string p_Value3 { get { return _Value3; } }

        string _Value4;
        [DisplayName("Value 4")]
        public string p_Value4 { get { return _Value4; } }

        string _Value5;
        [DisplayName("Value 5")]
        public string p_Value5 { get { return _Value5; } }

        string _Value6;
        [DisplayName("Value 6")]
        public string p_Value6 { get { return _Value6; } }


        public AnalyzInCirc_Data(int number) 
        {


            _Number = number;

        }

        public void AddData(int index, string data) 
        {

            switch (index) 
            {
                case 0:
                    _Value1 = data;
                    break;

                case 1:
                    _Value2 = data;
                    break;

                case 2:
                    _Value3 = data;
                    break;

                case 3:
                    _Value4 = data;
                    break;

                case 4:
                    _Value5 = data;
                    break;

                case 5:
                    _Value6 = data;
                    break;

                default:
                    break;
            }
        }

    }
}
