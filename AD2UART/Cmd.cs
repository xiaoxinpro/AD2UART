using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace INIFILE
{
    class Cmd
    {
        public static void LoadCmd()
        {
            string strPath = AppDomain.CurrentDomain.BaseDirectory;
            _file = new IniFile(strPath + "Cfg.ini");
            C_SHOW_LOG  = _file.ReadString("CMD", "ShowLog", "FALSE");    //读数据，下同
            C_SHOW_SEND = _file.ReadString("CMD", "ShowSend", "FALSE");
            C_SHOW_RCV  = _file.ReadString("CMD", "ShowRcv", "FALSE");
            C_SHOW_TIME = _file.ReadString("CMD", "ShowTime", "FALSE");
            C_SHOW_HEAD = _file.ReadString("CMD", "ShowHead", "FALSE");
            C_FONT      = _file.ReadString("CMD", "Font", "");
        }

        public static void SaveCmd()
        {
            string strPath = AppDomain.CurrentDomain.BaseDirectory;
            _file = new IniFile(strPath + "Cfg.ini");
            _file.WriteString("CMD", "ShowLog", C_SHOW_LOG);            //写数据，下同
            _file.WriteString("CMD", "ShowSend", C_SHOW_SEND);
            _file.WriteString("CMD", "ShowRcv", C_SHOW_RCV);
            _file.WriteString("CMD", "ShowTime", C_SHOW_TIME);
            _file.WriteString("CMD", "ShowHead", C_SHOW_HEAD);
            _file.WriteString("CMD", "Font", C_FONT);
        }

        private static IniFile _file;//内置了一个对象

        public static string C_SHOW_LOG = "FALSE";
        public static string C_SHOW_SEND = "FALSE";
        public static string C_SHOW_RCV = "FALSE";
        public static string C_SHOW_TIME = "FALSE";
        public static string C_SHOW_HEAD = "FALSE";
        public static string C_FONT = "";

    }
}

