using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace INIFILE
{
    class Profile
    {
        public static void LoadProfile()
        {
            string strPath = AppDomain.CurrentDomain.BaseDirectory;
            _file = new IniFile(strPath + "Cfg.ini");
            G_PORTNAME = _file.ReadString("CONFIG", "PortName", "NONE");    //读数据，下同
            G_BAUDRATE = _file.ReadString("CONFIG", "BaudRate", "38400");
            G_DATABITS = _file.ReadString("CONFIG", "DataBits", "8");
            G_STOP = _file.ReadString("CONFIG", "StopBits", "1");
            G_PARITY = _file.ReadString("CONFIG", "Parity", "NONE");
            G_DATA_SENDSTR = _file.ReadString("CONFIG", "DataSendStr", "FALSE");
            G_DATA_RCVSTR = _file.ReadString("CONFIG", "DataRcvStr", "FALSE");
            G_AD_PATH = _file.ReadString("AD", "OutPath", "NONE");
            G_AD_OUTAD = _file.ReadString("AD", "OutAD", "TRUE");
            G_AD_OUTVOL = _file.ReadString("AD", "OutVol", "TRUE");
            G_AD_VOLTAGE = _file.ReadString("AD", "Voltage", "5.0");
            G_AD_GAIN = _file.ReadString("AD", "Gain", "1.0");
            G_AD_DATABIT = _file.ReadString("AD", "DataBit", "12");
        }

        public static void SaveProfile()
        {
            string strPath = AppDomain.CurrentDomain.BaseDirectory;
            _file = new IniFile(strPath + "Cfg.ini");
            _file.WriteString("CONFIG", "PortName", G_PORTNAME);            //写数据，下同
            _file.WriteString("CONFIG", "BaudRate", G_BAUDRATE);
            _file.WriteString("CONFIG", "DataBits", G_DATABITS);
            _file.WriteString("CONFIG", "StopBits", G_STOP);
            _file.WriteString("CONFIG", "Parity", G_PARITY);
            _file.WriteString("CONFIG", "DataSendStr", G_DATA_SENDSTR);
            _file.WriteString("CONFIG", "DataRcvStr", G_DATA_RCVSTR);
            _file.WriteString("AD", "OutPath", G_AD_PATH);
            _file.WriteString("AD", "OutAD", G_AD_OUTAD);
            _file.WriteString("AD", "OutVol", G_AD_OUTVOL);
            _file.WriteString("AD", "Voltage", G_AD_VOLTAGE);
            _file.WriteString("AD", "Gain", G_AD_GAIN);
            _file.WriteString("AD", "DataBit", G_AD_DATABIT);
        }

        private static IniFile _file;//内置了一个对象

        public static string G_PORTNAME = "NONE";//给ini文件赋新值，并且影响界面下拉框的显示
        public static string G_BAUDRATE = "38400";
        public static string G_DATABITS = "8";
        public static string G_STOP = "1";
        public static string G_PARITY = "NONE";
        public static string G_DATA_SENDSTR = "FALSE";
        public static string G_DATA_RCVSTR = "FALSE";

        public static string G_AD_PATH = "";
        public static string G_AD_OUTAD = "TRUE";
        public static string G_AD_OUTVOL = "TRUE";
        public static string G_AD_VOLTAGE = "5.0";
        public static string G_AD_GAIN = "1.0";
        public static string G_AD_DATABIT = "12";

    }
}
