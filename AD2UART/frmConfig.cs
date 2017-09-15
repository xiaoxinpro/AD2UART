using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using INIFILE;
using System.IO;

namespace AD2UART
{
    public partial class frmConfig : Form
    {
        frmMain FormMain;

        public frmConfig()
        {
            InitializeComponent();
        }

        //初始化
        private void frmConfig_Load_1(object sender, EventArgs e)
        {
            FormMain = new frmMain();
            INIFILE.Profile.LoadProfile();//加载所有

            // 预置波特率
            switch (Profile.G_BAUDRATE)
            {
                case "1200":
                    cbBaudRate.SelectedIndex = 0;
                    break;
                case "2400":
                    cbBaudRate.SelectedIndex = 1;
                    break;
                case "4800":
                    cbBaudRate.SelectedIndex = 2;
                    break;
                case "7200":
                    cbBaudRate.SelectedIndex = 3;
                    break;
                case "9600":
                    cbBaudRate.SelectedIndex = 4;
                    break;
                case "14400":
                    cbBaudRate.SelectedIndex = 5;
                    break;
                case "19200":
                    cbBaudRate.SelectedIndex = 6;
                    break;
                case "38400":
                    cbBaudRate.SelectedIndex = 7;
                    break;
                case "115200":
                    cbBaudRate.SelectedIndex = 8;
                    break;
                case "128000":
                    cbBaudRate.SelectedIndex = 9;
                    break;
                default:
                    {
                        MessageBox.Show("波特率预置参数错误。");
                        return;
                    }
            }

            //预置波特率
            switch (Profile.G_DATABITS)
            {
                case "5":
                    cbDataBits.SelectedIndex = 0;
                    break;
                case "6":
                    cbDataBits.SelectedIndex = 1;
                    break;
                case "7":
                    cbDataBits.SelectedIndex = 2;
                    break;
                case "8":
                    cbDataBits.SelectedIndex = 3;
                    break;
                default:
                    {
                        MessageBox.Show("数据位预置参数错误。");
                        return;
                    }

            }
            //预置停止位
            switch (Profile.G_STOP)
            {
                case "1":
                    cbStop.SelectedIndex = 0;
                    break;
                case "1.5":
                    cbStop.SelectedIndex = 1;
                    break;
                case "2":
                    cbStop.SelectedIndex = 2;
                    break;
                default:
                    {
                        MessageBox.Show("停止位预置参数错误。");
                        return;
                    }
            }

            //预置校验位
            switch (Profile.G_PARITY)
            {
                case "NONE":
                    cbParity.SelectedIndex = 0;
                    break;
                case "ODD":
                    cbParity.SelectedIndex = 1;
                    break;
                case "EVEN":
                    cbParity.SelectedIndex = 2;
                    break;
                default:
                    {
                        MessageBox.Show("校验位预置参数错误。");
                        return;
                    }
            }

            //预置输出路径
            txtOutPath.Text = (Profile.G_AD_PATH == "NONE") ? "" : Profile.G_AD_PATH;

            //预置是否输出AD值
            switch (Profile.G_AD_OUTAD)
            {
                case "TRUE":
                    cbADValue.Checked = true;
                    break;
                case "FALSE":
                    cbADValue.Checked = false;
                    break;
                default:
                    MessageBox.Show("预置是否输出AD值参数错误。");
                    return;
            }

            //预置是否输出电压
            switch (Profile.G_AD_OUTVOL)
            {
                case "TRUE":
                    cbVoltageValue.Checked = true;
                    break;
                case "FALSE":
                    cbVoltageValue.Checked = false;
                    break;
                default:
                    MessageBox.Show("预置是否输出电压参数错误。");
                    return;
            }

            //预置基准电压
            txtBasicVoltage.Text = Profile.G_AD_VOLTAGE;

            //预置比例系数
            txtADGain.Text = Profile.G_AD_GAIN;

            //预置AD数据位
            switch (Profile.G_AD_DATABIT)
            {
                case "8":
                    cbADDataBit.SelectedIndex = 0;
                    break;
                case "10":
                    cbADDataBit.SelectedIndex = 1;
                    break;
                case "12":
                    cbADDataBit.SelectedIndex = 2;
                    break;
                case "16":
                    cbADDataBit.SelectedIndex = 3;
                    break;
                default:
                    MessageBox.Show("预置AD数据位参数错误。");
                    return;
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SaveSerialData();
            if (!File.Exists(Profile.G_AD_PATH))
            {
                MessageBox.Show("请先选择输出路径。", "路径不存在", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                btnSelectPath_Click(null, null);
                return;
            }
            this.Hide();
            this.timSerial.Enabled = false;
            if (FormMain.ShowDialog() == DialogResult.OK)
            {
                this.timSerial.Enabled = true;
                this.Show();
            }
            else
            {
                this.timSerial.Enabled = false;
                FormMain.Show();
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            SaveSerialData();
            if (btnEnd.Text == "退出")
            {
                System.Environment.Exit(0);
            }
            else
            {
                this.Hide();
            }
        }

        private void timSerial_Tick(object sender, EventArgs e)
        {
            //获取串口列表
            string[] arrSerialPortNames = SerialPort.GetPortNames();

            //检查是否含有串口
            if (arrSerialPortNames.Length == 0)
            {
                btnSerial.Enabled = false;
                btnOK.Enabled = false;
                if (cbSerial.Items.Count > 0)
                {
                    this.Focus(); //使下拉列表失去焦点后清空列表
                    cbSerial.Items.Clear();
                    MessageBox.Show("串口设备出现异常，请重新连接。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                return;
            }

            //获取现有串口列表
            List<string> SerialList = new List<string>(); 
            for (int i = 0; i < cbSerial.Items.Count; i++)
            {
                SerialList.Add(cbSerial.Items[i].ToString());
            }

            //判断现有串口和获取的串口列表是否相同
            if (CompareArray(SerialList.ToArray(), arrSerialPortNames) == false)
            {
                //清除串口列表
                this.Focus(); //使下拉列表失去焦点后清空列表
                cbSerial.Items.Clear();

                //添加串口项目
                int defaultPortNameItem = 0;
                foreach (string s in arrSerialPortNames)
                {
                    cbSerial.Items.Add(s);
                    if ((SerialList.Count == 0)&&(s == Profile.G_PORTNAME))
                    {
                        defaultPortNameItem = cbSerial.Items.Count - 1;
                    }
                }

                //串口设置默认选择项
                cbSerial.SelectedIndex = defaultPortNameItem;
                btnSerial.Enabled = true;
                btnOK.Enabled = true;
            }

        }

        private void frmConfig_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSerialData();
        }

        //判断两个字符串数组是否相同
        private static bool CompareArray(string[] arr1,string[] arr2)
        {
            var q = from a in arr1 join b in arr2 on a equals b select a;
            bool flag = arr1.Length == arr2.Length && q.Count() == arr1.Length;
            return flag;//内容相同返回true,反之返回false。
        }

        //保存串口信息
        private void SaveSerialData()
        {
            //设置各“串口设置”
            string strBaudRate = cbBaudRate.Text;
            string strDateBits = cbDataBits.Text;
            string strStopBits = cbStop.Text;
            Int32 iBaudRate = Convert.ToInt32(strBaudRate);
            Int32 iDateBits = Convert.ToInt32(strDateBits);
            Profile.G_PORTNAME = cbSerial.Text;        //串口名
            Profile.G_BAUDRATE = iBaudRate + "";       //波特率
            Profile.G_DATABITS = iDateBits + "";       //数据位
            switch (cbStop.Text)            //停止位
            {
                case "1":
                    Profile.G_STOP = "1";
                    break;
                case "1.5":
                    Profile.G_STOP = "1.5";
                    break;
                case "2":
                    Profile.G_STOP = "2";
                    break;
                default:
                    MessageBox.Show("Error：参数不正确!", "Error");
                    break;
            }
            switch (cbParity.Text)             //校验位
            {
                case "无":
                    Profile.G_PARITY = "NONE";
                    break;
                case "奇校验":
                    Profile.G_PARITY = "ODD";
                    break;
                case "偶校验":
                    Profile.G_PARITY = "EVEN";
                    break;
                default:
                    MessageBox.Show("Error：参数不正确!", "Error");
                    break;
            }

            Profile.G_AD_PATH = (txtOutPath.Text == "") ? "NONE" : txtOutPath.Text;

            Profile.G_AD_OUTAD = cbADValue.Checked ? "TRUE" : "FALSE";

            Profile.G_AD_OUTVOL = cbVoltageValue.Checked ? "TRUE" : "FALSE";

            Profile.G_AD_VOLTAGE = Convert.ToString(Convert.ToDouble(txtBasicVoltage.Text));

            Profile.G_AD_GAIN = Convert.ToString(Convert.ToDouble(txtADGain.Text));

            Profile.G_AD_DATABIT = cbADDataBit.Text;

            Profile.SaveProfile();
        }

        private void btnSerial_Click(object sender, EventArgs e)
        {
            cbBaudRate.SelectedIndex = 7;
            cbParity.SelectedIndex = 0;
            cbDataBits.SelectedIndex = 3;
            cbStop.SelectedIndex = 0;
        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "表格格式|*.xls|文本格式|*.txt|所有格式|*.*";
            save.RestoreDirectory = true;
            save.FilterIndex = 1;
            if (save.ShowDialog() == DialogResult.OK)
            {
                string str = save.FileName;
                try
                {
                    using (StreamWriter sw = new StreamWriter(str, false, Encoding.GetEncoding("gb2312")))
                    {
                        sw.Write("");
                        sw.Flush();
                        sw.Close();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("文件保存失败，请重新选择。");
                    return;
                }
                txtOutPath.Text = str;
            }
        }

        private void btnAD_Click(object sender, EventArgs e)
        {
            cbADValue.Checked = true;
            cbVoltageValue.Checked = true;
            txtBasicVoltage.Text = "5.0";
            txtADGain.Text = "1.0";
            cbADDataBit.SelectedIndex = 2;
        }
    }
}
