﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using INIFILE;
using DocDetector.Core.Extensions;
using System.IO;
using System.Collections;
using System.Threading;

namespace AD2UART
{
    public partial class frmMain : Form
    {
        public SerialPort sp1 = new SerialPort();
        public Queue DQueue = Queue.Synchronized(new Queue());
        public Thread thRecDataProcess;
        public long StartTimeNum;
        public static System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();

        public bool isFormTool = false;
        public frmMain()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            isFormTool = false;
        }

        public frmMain(string cmd, string text)
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            isFormTool = true;
            if (cmd == "chart")
            {
                if (funcXlsToJs(text))
                {
                    string strPath = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "chart.html";
                    System.Diagnostics.Process.Start(strPath);
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //初始化接收处理线程
            thRecDataProcess = new Thread(new ThreadStart(ThreadRecDataProcess));
            thRecDataProcess.IsBackground = true; //后台运行，主窗体关闭后，可退出程序
            thRecDataProcess.Start();

            //设置富文本高度
            rtCmd.Height = statusMain.Top - rtCmd.Top - 10;

            //检测图表文件是否存在
            if(!File.Exists(System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "chart.html"))
            {
                btnChart.Enabled = false;
            }
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            //加载报文配置
            Cmd.LoadCmd();
            menuShowLogCmd.Checked = Cmd.C_SHOW_LOG == "TRUE" ? true : false;
            menuShowRcvData.Checked = Cmd.C_SHOW_RCV == "TRUE" ? true : false;
            menuShowSendData.Checked = Cmd.C_SHOW_SEND == "TRUE" ? true : false;
            menuShowCmdHead.Checked = Cmd.C_SHOW_HEAD == "TRUE" ? true : false;
            menuShowCmdTime.Checked = Cmd.C_SHOW_TIME == "TRUE" ? true : false;
            FontConverter fc = new FontConverter();
            try
            {
                rtCmd.Font = (Font)fc.ConvertFromInvariantString(Cmd.C_FONT);
            }
            catch (NotSupportedException)
            {
                Cmd.C_FONT = fc.ConvertToInvariantString(rtCmd.Font);
                Console.WriteLine("读取字体异常，已恢复：" + Cmd.C_FONT);
                throw;
            }

            //串口配置初始化
            sp1 = new SerialPort();
            Control.CheckForIllegalCrossThreadCalls = false;    //这个类中我们不检查跨线程的调用是否合法(因为.net 2.0以后加强了安全机制,，不允许在winform中直接跨线程访问控件的属性)
            sp1.DataReceived += new SerialDataReceivedEventHandler(sp1_DataReceived);           
            sp1.DtrEnable = true;
            sp1.RtsEnable = true;
            sp1.Close();

            rtCmd.Clear();
            funcOutputLog("准备就绪，等待串口开启。");

            if (isFormTool)
            {
                return;
            }

            //打开串口
            funcOpenSerialPort();
        }

        private void rtCmd_TextChanged(object sender, EventArgs e)
        {
            rtCmd.SelectionStart = rtCmd.Text.Length;
            rtCmd.SelectionLength = 0;
            rtCmd.ScrollToCaret();
        }

        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            funcCloseSerialPort();
            this.Hide();
            this.DialogResult = DialogResult.OK;
        }

        private void menuFunction_Click(object sender, EventArgs e)
        {

        }

        frmAbout FormAbout = new frmAbout();
        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            funcSaveConfig();
            thRecDataProcess.Abort();
            if (this.DialogResult != DialogResult.OK)
            {
                System.Environment.Exit(0);
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            funcSaveConfig();
            thRecDataProcess.Abort();
            System.Environment.Exit(0);
        }

        private void 打开端口ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (menuOpenSerial.Text == "打开串口")
            {
                //打开串口
                funcOpenSerialPort();
            }
            else
            {
                //关闭串口
                funcCloseSerialPort();
            }
        }

        void sp1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (sp1.IsOpen)
            {
                try
                {
                    byte[] readBuffer = new byte[sp1.BytesToRead];
                    int count = sp1.Read(readBuffer, 0, readBuffer.Length);

                    for (int i = 0; i < count; i++)
                    {
                        DQueue.Enqueue(readBuffer[i]);
                    }
                }
                catch (Exception ex)
                {
                    funcOutputLog("【接收出错】" + ex.Message, "错误");
                    throw ex;
                }
                ////输出当前时间
                //string strTextBuff = "";

                //byte[] byteRead = new byte[sp1.BytesToRead];    //BytesToRead:sp1接收的字符个数
                //if (Profile.G_DATA_RCVSTR == "TRUE")            //接收字符串格式
                //{
                //    try
                //    {
                //        strTextBuff += sp1.ReadLine();
                //        sp1.DiscardInBuffer();                  //清空SerialPort控件的Buffer 
                //    }
                //    catch (System.Exception ex)
                //    {
                //        funcOutputLog("【接收出错】" + ex.Message, "错误");
                //        return;
                //    }
                //}
                //else                                            //接收16进制格式
                //{
                //    try
                //    {
                //        Byte[] receivedData = new Byte[sp1.BytesToRead];        //创建接收字节数组
                //        sp1.Read(receivedData, 0, receivedData.Length);         //读取数据
                //        sp1.DiscardInBuffer();                                  //清空SerialPort控件的Buffer
                //        RcvDataProcess(receivedData);                           //接收数据处理
                //        if(receivedData.Length <= 0)
                //        {
                //            return;
                //        }
                //        string strRcv = null;
                //        for (int i = 0; i < receivedData.Length; i++)
                //        {
                //            strRcv += (i > 0) ? " " : "";
                //            strRcv += receivedData[i].ToString("X2");           //16进制显示
                //        }
                //        strTextBuff += strRcv;

                //    }
                //    catch (System.Exception ex)
                //    {
                //        funcOutputLog("【接收出错】" + ex.Message, "错误");
                //        return;
                //    }
                //}
                //funcOutputLog(strTextBuff, " ");
            }
            else
            {
                funcOutputLog("【串口出错】串口没有被打开。", "错误");
            }
        }

        void sp1_DataSend(string strBuff)
        {
            if (sp1.IsOpen)
            {
                //输出当前时间
                string strTextBuff = "";

                if (Profile.G_DATA_SENDSTR == "TRUE")    //字符串格式发送
                {
                    sp1.WriteLine(strBuff);
                    strTextBuff += strBuff;
                }
                else                                    //16进制格式发送
                {
                    string strBuffHex = strBuff;
                    strBuffHex = strBuffHex.Trim();     //去除前后空字符
                    strBuffHex = strBuffHex.Replace(',', ' ');  //去掉英文逗号
                    strBuffHex = strBuffHex.Replace('，', ' '); //去掉中文逗号
                    strBuffHex = strBuffHex.Replace("0x", "");  //去掉0x
                    strBuffHex = strBuffHex.Replace("0X", "");  //去掉0X
                    string[] strArray = strBuffHex.Split(' ');
                    int byteBufferLength = strArray.Length;
                    for (int i = 0; i < strArray.Length; i++)
                    {
                        if (strArray[i] == "")
                        {
                            byteBufferLength--;
                        }
                    }
                    byte[] byteBuffer = new byte[byteBufferLength];
                    int ii = 0;
                    for (int i = 0; i < strArray.Length; i++)        //对获取的字符做相加运算
                    {

                        Byte[] bytesOfStr = Encoding.Default.GetBytes(strArray[i]);

                        int decNum = 0;
                        if (strArray[i] == "")
                        {
                            continue;
                        }
                        else
                        {
                            decNum = Convert.ToInt32(strArray[i], 16); //atrArray[i] == 12时，temp == 18 
                        }

                        try    //防止输错，使其只能输入一个字节的字符
                        {
                            byteBuffer[ii] = Convert.ToByte(decNum);
                        }
                        catch (System.Exception)
                        {
                            funcOutputLog("【发送出错】字节越界，请逐个字节输入！", "错误");
                            return;
                        }
                        ii++;
                    }
                    try
                    {
                        sp1.Write(byteBuffer, 0, byteBuffer.Length);
                    }
                    catch (Exception)
                    {
                        funcCloseSerialPort();
                        MessageBox.Show("串口设备出现异常，请重新连接。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    strTextBuff += strBuffHex;
                }
                funcOutputLog(strTextBuff, "发送");
            }
        }

        public void funcOpenSerialPort()
        {
            if (!sp1.IsOpen)
            {
                StartTimeNum = Uart.GetTimeStamp();
                dataCnt = 8; //复位数据起始指针
                if (Profile.G_AD_OUTAD == "TRUE" && Profile.G_AD_OUTVOL == "TRUE")
                {
                    funcOutFile("\r\n时间(毫秒)\tAD1\t电压1\tAD2\t电压2\tAD3\t电压3\tAD4\t电压4\t");
                }
                else if (Profile.G_AD_OUTAD == "FALSE" && Profile.G_AD_OUTVOL == "TRUE")
                {
                    funcOutFile("\r\n时间(毫秒)\t电压1\t电压2\t电压3\t电压4\t");
                }
                else if (Profile.G_AD_OUTAD == "TRUE" && Profile.G_AD_OUTVOL == "FALSE")
                {
                    funcOutFile("\r\n时间(毫秒)\tAD1\tAD2\tAD3\tAD4\t");
                }
                else
                {
                    funcOutFile("\r\n无输出\r\n");
                }

                try
                {
                    sp1.PortName = Profile.G_PORTNAME;
                    sp1.BaudRate = Convert.ToInt32(Profile.G_BAUDRATE);
                    sp1.DataBits = Convert.ToInt32(Profile.G_DATABITS);
                    switch (Profile.G_STOP)
                    {
                        case "1":
                            sp1.StopBits = StopBits.One;
                            break;
                        case "1.5":
                            sp1.StopBits = StopBits.OnePointFive;
                            break;
                        case "2":
                            sp1.StopBits = StopBits.Two;
                            break;
                        default:
                            MessageBox.Show("Error：参数不正确!", "Error");
                            break;
                    }
                    switch (Profile.G_PARITY)             //校验位
                    {
                        case "NONE":
                            sp1.Parity = Parity.None;
                            break;
                        case "ODD":
                            sp1.Parity = Parity.Odd;
                            break;
                        case "EVEN":
                            sp1.Parity = Parity.Even;
                            break;
                        default:
                            MessageBox.Show("Error：参数不正确!", "Error");
                            break;
                    }
                    if (sp1.IsOpen == true)//如果打开状态，则先关闭一下
                    {
                        sp1.Close();
                    }
                    sp1.Open();     //打开串口
                    menuOpenSerial.Text = "关闭串口";
                    tsSerial.Text = "串口：" + Profile.G_PORTNAME;
                    funcOutputLog("串口" + Profile.G_PORTNAME + "已经开启");
                    funcCloseUart();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message + "\r\n请重新连接串口设备或点击串口设置重新选择串口", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    funcCloseUart();
                    menuOpenSerial.Text = "打开串口";
                    tsSerial.Text = "串口：关闭";
                    return;
                }
            }
            else
            {
                MessageBox.Show("端口已被打开", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        public void funcCloseSerialPort()
        {
            funcCloseUart();
            menuOpenSerial.Text = "打开串口";
            funcOutputLog("串口" + Profile.G_PORTNAME + "已经关闭");
            tsSerial.Text = "串口：关闭";

            try
            {
                sp1.Close();
            }
            catch
            {
                return;
            }

        }

        public void funcOpenUart()
        {
            if (sp1.IsOpen)
            {
                timUart.Interval = 500;
                timUart.Enabled = true;
                funcOutputLog("通信功能已开启");
            }
            else
            {
                funcCloseUart();
            }
        }

        public void funcCloseUart()
        {
            //cbAPP.SelectedIndex = 0;
            //cbRH.SelectedIndex = 0;
            timUart.Enabled = false;
        }

        public void funcSaveConfig()
        {
            //报文配置
            Cmd.C_SHOW_HEAD = menuShowCmdHead.Checked ? "TRUE" : "FALSE";
            Cmd.C_SHOW_TIME = menuShowCmdTime.Checked ? "TRUE" : "FALSE";
            Cmd.C_SHOW_LOG = menuShowLogCmd.Checked ? "TRUE" : "FALSE";
            Cmd.C_SHOW_SEND = menuShowSendData.Checked ? "TRUE" : "FALSE";
            Cmd.C_SHOW_RCV = menuShowRcvData.Checked ? "TRUE" : "FALSE";
            FontConverter fc = new FontConverter();
            Cmd.C_FONT = fc.ConvertToInvariantString(rtCmd.Font);
            Cmd.SaveCmd();
        }

        public void funcOutputLog(string strLog,string strHead = "提示")
        {
            if ((strHead == "提示") || (strHead == "错误") || (strHead == "警告") || (strHead == "状态"))
            {
                tsStatus.Text = "状态：" + strLog;
                if (!menuShowLogCmd.Checked || (strHead == "状态"))
                {
                    return;
                }
            }

            Color color = Color.Black;
            switch (strHead)
            {
                case " ":
                    rtCmd.AppendTextColorful(strLog + " ", Color.Green, false);
                    return;
                case "提示":
                    color = Color.Black;
                    break;
                case "发送":
                    color = Color.Blue;
                    if (!menuShowSendData.Checked) return;
                    break;
                case "接收":
                    color = Color.Green;
                    if (!menuShowRcvData.Checked) return;
                    break;
                case "错误":
                    color = Color.Red;
                    break;
                case "警告":
                    color = Color.Orange;
                    break;
                default:
                    return;
            }

            string strTime = "";
            if (menuShowCmdTime.Checked)
            {
                strTime = DateTime.Now.ToString() + " -> ";
            }

            if (menuShowCmdHead.Checked)
            {
                strHead = "【" + strHead + "】";
            }
            else
            {
                strHead = "";
            }

            rtCmd.AppendTextColorful(strHead + strTime + strLog, color);

            if (menuOutputCmd.Checked && (strHead=="【发送】" || strHead=="【接收】"))
            {
                try
                {
                    StreamWriter swOutputCmd = File.AppendText(strOutputCmd);
                    swOutputCmd.WriteLine(strHead + strTime + strLog);
                    swOutputCmd.Flush();
                    swOutputCmd.Close();
                }
                catch
                {
                    menuOutputCmd.Checked = false;
                    MessageBox.Show("动态输出文件无法写入，已关闭。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }

        }

        private void ThreadRecDataProcess()
        {
            while (true)
            {
                byte[] buff = new byte[DQueue.Count];
                try
                {
                    if(buff.Length > 0)
                    {
                        for (int i = 0; i < buff.Length; i++)
                        {
                            buff[i] = (byte)DQueue.Dequeue();
                        }
                    }
                    else
                    {
                        System.Threading.Thread.Sleep(1);
                        continue;
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }

                //输出显示
                string strRcv = null;
                for (int i = 0; i < buff.Length; i++)
                {
                    strRcv += (i > 0) ? " " : "";
                    strRcv += buff[i].ToString("X2");           //16进制显示
                }
                funcOutputLog(strRcv, " ");

                //接收数据处理
                RcvDataProcess(buff);
            }
        }

        private byte dataH = 0x00;
        private bool is0x13 = false;
        private int dataCnt = 8;
        private void RcvDataProcess(byte[] byteBuff)
        {
            StringBuilder strData = new StringBuilder();
            if(byteBuff.Length > 0)
            {
                for (int i = 0; i < byteBuff.Length; i++) 
                {
                    Double adMax = Math.Pow(2, (Convert.ToInt32(Profile.arrADDataBit[dataCnt / 2 % 4])));
                    if (++dataCnt >= 10)
                    {
                        if(is0x13 == true && byteBuff[i] == 0x10)
                        {
                            if (Profile.G_AD_OUTAD == "TRUE" || Profile.G_AD_OUTVOL == "TRUE")
                            {
                                strData.Append("\r\n");
                            }
                            dataCnt = 0;
                        }
                        else
                        {
                            dataCnt = 8;
                        }
                        continue;
                    }
                    else if (dataCnt == 9)
                    {
                        if(byteBuff[i] == 0x13)
                        {
                            is0x13 = true;
                        }
                        else
                        {
                            dataCnt = 8;
                        }
                        continue;
                    }
                    else if(dataCnt % 2 == 1)
                    {
                        if(dataCnt == 1)
                        {
                            strData.Append((Uart.GetTimeStamp() - StartTimeNum) + "\t");
                        }
                        dataH = byteBuff[i];
                        if(Profile.G_AD_OUTAD == "TRUE")
                        {
                            strData.Append(byteBuff[i].ToString("X2"));
                        }
                    }
                    else
                    {
                        if (Profile.G_AD_OUTAD == "TRUE")
                        {
                            strData.Append(byteBuff[i].ToString("X2") + "\t");
                        }
                        if (Profile.G_AD_OUTVOL == "TRUE")
                        {
                            Double adValue = Convert.ToUInt32(dataH) * 256 + Convert.ToUInt32(byteBuff[i]);
                            if(adValue > adMax)
                            {
                                strData.Append("\r\n");
                                dataCnt = 8;
                                continue;
                            }
                            //Double vol = Convert.ToDouble(Profile.arrADGain[(dataCnt - 1) / 2 % 4]) * Convert.ToDouble(Profile.arrADVoltage[(dataCnt - 1) / 2 % 4]) * adValue / adMax;
                            string vol = "=" + (Profile.arrADGain[(dataCnt - 1) / 2 % 4]) + "*" + (Profile.arrADVoltage[(dataCnt - 1) / 2 % 4]) + "*" + adValue + "/" + adMax;
                            strData.Append(vol + "\t");
                        }
                    }
                }
                funcOutFile(strData.ToString());
                //Console.Write(strData.ToString());
            }
        }

        private void funcOutFile(string buff)
        {
            try
            {
                //StreamWriter swOutputCmd = File.AppendText(Profile.G_AD_PATH);
                using (StreamWriter swOutputCmd = new StreamWriter(Profile.G_AD_PATH, true, Encoding.GetEncoding("gb2312")))
                {
                    swOutputCmd.Write(buff);
                    swOutputCmd.Flush();
                    swOutputCmd.Close();
                }
            }
            catch
            {
                menuOutputCmd.Checked = false;
                MessageBox.Show("动态输出文件无法写入，已关闭。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                funcCloseSerialPort();
            }
        }

        private static int intCharNum = 0;
        private void timUart_Tick(object sender, EventArgs e)
        {
           
            byte[] byteSendData = { 0x01, 0x11, 0x02, 0x22, 0x03, 0x33, 0x04, 0x44, 0x13, 0x10 };

            Random ro = new Random();

            byteSendData[0] = Convert.ToByte(ro.Next(3));
            byteSendData[1] = Convert.ToByte(ro.Next(255));
            byteSendData[2] = Convert.ToByte(ro.Next(3));
            byteSendData[3] = Convert.ToByte(ro.Next(255));

            sp1_DataSend(Uart.byteToHexStr(byteSendData));

            if (++intCharNum > 3)
            {
                intCharNum = 1;
            }
            funcOutputLog("串口通信中" + new string('.', intCharNum), "状态");
        }

        private void timTime_Tick(object sender, EventArgs e)
        {
            //刷新时间显示
            tsTime.Text =  DateTime.Now.ToString() + " ";

            //检测波特率和串口是否变化
            tsBaudRate.Text = "波特率：" + Profile.G_BAUDRATE + " ";
            if(menuOpenSerial.Text == "打开串口")
            {
                funcOutputLog("串口" + Profile.G_PORTNAME + "已经关闭", "状态");
            }

        }

        private void menuClearCmd_Click(object sender, EventArgs e)
        {
            rtCmd.Clear();
        }

        private void menuSaveCmd_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "文本格式|*.txt|所有格式|*.*";
            save.RestoreDirectory = true;
            save.FilterIndex = 1;
            if (save.ShowDialog() == DialogResult.OK)
            {
                funcOutputLog("报文保存中。。。", "状态");
                string str = save.FileName;
                StreamWriter sw = File.CreateText(str);
                sw.Write(this.rtCmd.Text.Replace("\n", "\r\n"));
                sw.Flush();
                sw.Close();
                funcOutputLog("报文保存完成", "状态");
            }
        }

        private static string strOutputCmd = "";
        private void menuOutputCmd_Click(object sender, EventArgs e)
        {
            if (menuOutputCmd.Checked)
            {
                menuOutputCmd.Checked = false;
                return;
            }
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "文本格式|*.txt|所有格式|*.*";
            save.RestoreDirectory = true;
            save.FilterIndex = 1;
            if (save.ShowDialog() == DialogResult.OK)
            {
                strOutputCmd = save.FileName;
                StreamWriter swOutputCmd = File.CreateText(strOutputCmd);
                swOutputCmd.Write("");
                swOutputCmd.Flush();
                swOutputCmd.Close();
                funcOutputLog("开启报文动态输出", "状态");
                menuOutputCmd.Checked = true;
            }
        }

        private void menuFontCmd_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            font.Font = rtCmd.Font;
            if(font.ShowDialog() == DialogResult.OK)
            {
                rtCmd.Font = font.Font;
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            funcCloseSerialPort();
            System.Diagnostics.Process.Start(Profile.G_AD_PATH);
        }

        private void btnDbg_Click(object sender, EventArgs e)
        {
            if(btnDbg.Text == "开启调试")
            {
                btnDbg.Text = "关闭调试";
                timUart.Enabled = true;
            }
            else
            {
                btnDbg.Text = "开启调试";
                timUart.Enabled = false;
            }
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            funcCloseSerialPort();
            btnChart.Enabled = false;
            watch.Start();
            if (funcXlsToJs(Profile.G_AD_PATH))
            {
                System.Diagnostics.Process.Start(System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "chart.html");
            }
            watch.Stop();
            Console.WriteLine("输出图表耗时：" + watch.Elapsed);
            btnChart.Enabled = true;
        }

        public static bool IsInt(string value)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(value, @"^[+-]?\d*$");
        }

        public bool funcXlsToJs(string xlsPath)
        {
            if (!File.Exists(xlsPath))
            {
                MessageBox.Show("表格文件不存在。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            try
            {
                string strDirectory = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
                StreamReader sr = new StreamReader(xlsPath, Encoding.GetEncoding("gb2312"));
                StreamWriter sw0 = new StreamWriter(strDirectory + "ChartAD0.js", false, Encoding.GetEncoding("gb2312"));
                StreamWriter sw1 = new StreamWriter(strDirectory + "ChartAD1.js", false, Encoding.GetEncoding("gb2312"));
                StreamWriter sw2 = new StreamWriter(strDirectory + "ChartAD2.js", false, Encoding.GetEncoding("gb2312"));
                int i = 0;
                string line;
                sw0.Write("var data0 = new Array(0");
                sw1.Write("var data1 = new Array(0");
                sw2.Write("var data2 = new Array(0");
                while ((line = sr.ReadLine()) != null)
                {
                    i++;
                    string[] strArray = line.Trim().Split('\t');
                    if (strArray.Length == 9 && IsInt(strArray[0])) 
                    {
                        sw0.Write("," + new System.Data.DataTable().Compute(strArray[0].Replace("=", ""), ""));
                        sw1.Write("," + new System.Data.DataTable().Compute(strArray[2].Replace("=", ""), ""));
                        sw2.Write("," + new System.Data.DataTable().Compute(strArray[4].Replace("=", ""), ""));
                    }
                    else
                    {
                        continue;
                    }
                }
                sw0.Write(");");
                sw1.Write(");");
                sw2.Write(");");
                sw0.Flush();
                sw1.Flush();
                sw2.Flush();
                sw0.Close();
                sw1.Close();
                sw2.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

    }
}
