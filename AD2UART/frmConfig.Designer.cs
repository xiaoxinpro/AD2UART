namespace AD2UART
{
    partial class frmConfig
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSerial = new System.Windows.Forms.Button();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.cbStop = new System.Windows.Forms.ComboBox();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.cbDataBits = new System.Windows.Forms.ComboBox();
            this.cbSerial = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbVoltageValue = new System.Windows.Forms.CheckBox();
            this.cbADValue = new System.Windows.Forms.CheckBox();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.txtOutPath = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAD = new System.Windows.Forms.Button();
            this.txtADGain = new System.Windows.Forms.TextBox();
            this.txtBasicVoltage = new System.Windows.Forms.TextBox();
            this.cbADDataBit = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.timSerial = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tcAD = new System.Windows.Forms.TabControl();
            this.tabAD1 = new System.Windows.Forms.TabPage();
            this.tabAD2 = new System.Windows.Forms.TabPage();
            this.tabAD3 = new System.Windows.Forms.TabPage();
            this.tabAD4 = new System.Windows.Forms.TabPage();
            this.pBottom = new System.Windows.Forms.Panel();
            this.btnXls2Chart = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tcAD.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSerial);
            this.groupBox1.Controls.Add(this.cbParity);
            this.groupBox1.Controls.Add(this.cbStop);
            this.groupBox1.Controls.Add(this.cbBaudRate);
            this.groupBox1.Controls.Add(this.cbDataBits);
            this.groupBox1.Controls.Add(this.cbSerial);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.groupBox1.Location = new System.Drawing.Point(17, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(572, 258);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口配置";
            // 
            // btnSerial
            // 
            this.btnSerial.Enabled = false;
            this.btnSerial.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.btnSerial.Location = new System.Drawing.Point(301, 191);
            this.btnSerial.Name = "btnSerial";
            this.btnSerial.Size = new System.Drawing.Size(252, 52);
            this.btnSerial.TabIndex = 10;
            this.btnSerial.Text = "默认配置";
            this.btnSerial.UseVisualStyleBackColor = true;
            this.btnSerial.Click += new System.EventHandler(this.btnSerial_Click);
            // 
            // cbParity
            // 
            this.cbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParity.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Items.AddRange(new object[] {
            "无",
            "奇校验",
            "偶校验"});
            this.cbParity.Location = new System.Drawing.Point(133, 193);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(121, 39);
            this.cbParity.TabIndex = 9;
            // 
            // cbStop
            // 
            this.cbStop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStop.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbStop.FormattingEnabled = true;
            this.cbStop.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.cbStop.Location = new System.Drawing.Point(420, 131);
            this.cbStop.Name = "cbStop";
            this.cbStop.Size = new System.Drawing.Size(121, 39);
            this.cbStop.TabIndex = 8;
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBaudRate.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "7200",
            "9600",
            "14400",
            "19200",
            "38400",
            "115200",
            "128000"});
            this.cbBaudRate.Location = new System.Drawing.Point(420, 69);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(121, 39);
            this.cbBaudRate.TabIndex = 7;
            // 
            // cbDataBits
            // 
            this.cbDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDataBits.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbDataBits.FormattingEnabled = true;
            this.cbDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cbDataBits.Location = new System.Drawing.Point(133, 131);
            this.cbDataBits.Name = "cbDataBits";
            this.cbDataBits.Size = new System.Drawing.Size(121, 39);
            this.cbDataBits.TabIndex = 6;
            // 
            // cbSerial
            // 
            this.cbSerial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSerial.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbSerial.FormattingEnabled = true;
            this.cbSerial.Location = new System.Drawing.Point(133, 69);
            this.cbSerial.Name = "cbSerial";
            this.cbSerial.Size = new System.Drawing.Size(121, 39);
            this.cbSerial.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 39);
            this.label5.TabIndex = 4;
            this.label5.Text = "检验位：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 39);
            this.label4.TabIndex = 3;
            this.label4.Text = "停止位：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "数据位：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "波特率：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "端口号：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbVoltageValue);
            this.groupBox2.Controls.Add(this.cbADValue);
            this.groupBox2.Controls.Add(this.btnSelectPath);
            this.groupBox2.Controls.Add(this.txtOutPath);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.groupBox2.Location = new System.Drawing.Point(13, 288);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(576, 199);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "输出配置";
            // 
            // cbVoltageValue
            // 
            this.cbVoltageValue.AutoSize = true;
            this.cbVoltageValue.Checked = true;
            this.cbVoltageValue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbVoltageValue.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.cbVoltageValue.Location = new System.Drawing.Point(305, 136);
            this.cbVoltageValue.Name = "cbVoltageValue";
            this.cbVoltageValue.Size = new System.Drawing.Size(128, 39);
            this.cbVoltageValue.TabIndex = 11;
            this.cbVoltageValue.Text = "电压值";
            this.cbVoltageValue.UseVisualStyleBackColor = true;
            // 
            // cbADValue
            // 
            this.cbADValue.AutoSize = true;
            this.cbADValue.Checked = true;
            this.cbADValue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbADValue.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.cbADValue.Location = new System.Drawing.Point(170, 136);
            this.cbADValue.Name = "cbADValue";
            this.cbADValue.Size = new System.Drawing.Size(114, 39);
            this.cbADValue.TabIndex = 11;
            this.cbADValue.Text = "AD值";
            this.cbADValue.UseVisualStyleBackColor = true;
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnSelectPath.Location = new System.Drawing.Point(465, 63);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(92, 52);
            this.btnSelectPath.TabIndex = 4;
            this.btnSelectPath.Text = "选择";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // txtOutPath
            // 
            this.txtOutPath.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txtOutPath.Location = new System.Drawing.Point(170, 67);
            this.txtOutPath.Name = "txtOutPath";
            this.txtOutPath.Size = new System.Drawing.Size(288, 39);
            this.txtOutPath.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 135);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 39);
            this.label7.TabIndex = 1;
            this.label7.Text = "保存格式：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 67);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 39);
            this.label6.TabIndex = 1;
            this.label6.Text = "输出路径：";
            // 
            // btnAD
            // 
            this.btnAD.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.btnAD.Location = new System.Drawing.Point(305, 199);
            this.btnAD.Name = "btnAD";
            this.btnAD.Size = new System.Drawing.Size(252, 52);
            this.btnAD.TabIndex = 10;
            this.btnAD.Text = "默认配置";
            this.btnAD.UseVisualStyleBackColor = true;
            this.btnAD.Click += new System.EventHandler(this.btnAD_Click);
            // 
            // txtADGain
            // 
            this.txtADGain.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txtADGain.Location = new System.Drawing.Point(170, 206);
            this.txtADGain.Name = "txtADGain";
            this.txtADGain.Size = new System.Drawing.Size(88, 39);
            this.txtADGain.TabIndex = 3;
            this.txtADGain.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtADGain_KeyPress);
            this.txtADGain.Validated += new System.EventHandler(this.txtADGain_Validated);
            // 
            // txtBasicVoltage
            // 
            this.txtBasicVoltage.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txtBasicVoltage.Location = new System.Drawing.Point(170, 140);
            this.txtBasicVoltage.Name = "txtBasicVoltage";
            this.txtBasicVoltage.Size = new System.Drawing.Size(88, 39);
            this.txtBasicVoltage.TabIndex = 3;
            this.txtBasicVoltage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBasicVoltage_KeyPress);
            this.txtBasicVoltage.Validated += new System.EventHandler(this.txtBasicVoltage_Validated);
            // 
            // cbADDataBit
            // 
            this.cbADDataBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbADDataBit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbADDataBit.FormattingEnabled = true;
            this.cbADDataBit.Items.AddRange(new object[] {
            "8",
            "10",
            "12",
            "16"});
            this.cbADDataBit.Location = new System.Drawing.Point(424, 140);
            this.cbADDataBit.Name = "cbADDataBit";
            this.cbADDataBit.Size = new System.Drawing.Size(121, 39);
            this.cbADDataBit.TabIndex = 7;
            this.cbADDataBit.SelectionChangeCommitted += new System.EventHandler(this.cbADDataBit_SelectionChangeCommitted);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 206);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 39);
            this.label9.TabIndex = 1;
            this.label9.Text = "比例系数：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(298, 138);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 39);
            this.label10.TabIndex = 1;
            this.label10.Text = "数据位：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 138);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 39);
            this.label8.TabIndex = 1;
            this.label8.Text = "基准电压：";
            // 
            // btnEnd
            // 
            this.btnEnd.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.btnEnd.Location = new System.Drawing.Point(437, 792);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(152, 69);
            this.btnEnd.TabIndex = 2;
            this.btnEnd.Text = "退出";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.btnOK.Location = new System.Drawing.Point(260, 792);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(152, 69);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "启动";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // timSerial
            // 
            this.timSerial.Enabled = true;
            this.timSerial.Interval = 500;
            this.timSerial.Tick += new System.EventHandler(this.timSerial_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tcAD);
            this.groupBox3.Controls.Add(this.txtADGain);
            this.groupBox3.Controls.Add(this.cbADDataBit);
            this.groupBox3.Controls.Add(this.txtBasicVoltage);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btnAD);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.groupBox3.Location = new System.Drawing.Point(13, 500);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(576, 276);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "数据配置";
            // 
            // tcAD
            // 
            this.tcAD.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tcAD.Controls.Add(this.tabAD1);
            this.tcAD.Controls.Add(this.tabAD2);
            this.tcAD.Controls.Add(this.tabAD3);
            this.tcAD.Controls.Add(this.tabAD4);
            this.tcAD.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.tcAD.Location = new System.Drawing.Point(19, 62);
            this.tcAD.Name = "tcAD";
            this.tcAD.SelectedIndex = 0;
            this.tcAD.Size = new System.Drawing.Size(538, 53);
            this.tcAD.TabIndex = 0;
            this.tcAD.SelectedIndexChanged += new System.EventHandler(this.tcAD_SelectedIndexChanged);
            // 
            // tabAD1
            // 
            this.tabAD1.Location = new System.Drawing.Point(4, 47);
            this.tabAD1.Name = "tabAD1";
            this.tabAD1.Padding = new System.Windows.Forms.Padding(3);
            this.tabAD1.Size = new System.Drawing.Size(530, 2);
            this.tabAD1.TabIndex = 0;
            this.tabAD1.Text = "AD1";
            this.tabAD1.UseVisualStyleBackColor = true;
            // 
            // tabAD2
            // 
            this.tabAD2.Location = new System.Drawing.Point(4, 47);
            this.tabAD2.Name = "tabAD2";
            this.tabAD2.Size = new System.Drawing.Size(530, 2);
            this.tabAD2.TabIndex = 1;
            this.tabAD2.Text = "AD2";
            this.tabAD2.UseVisualStyleBackColor = true;
            // 
            // tabAD3
            // 
            this.tabAD3.Location = new System.Drawing.Point(4, 47);
            this.tabAD3.Name = "tabAD3";
            this.tabAD3.Size = new System.Drawing.Size(530, 2);
            this.tabAD3.TabIndex = 2;
            this.tabAD3.Text = "AD3";
            this.tabAD3.UseVisualStyleBackColor = true;
            // 
            // tabAD4
            // 
            this.tabAD4.Location = new System.Drawing.Point(4, 47);
            this.tabAD4.Name = "tabAD4";
            this.tabAD4.Size = new System.Drawing.Size(530, 2);
            this.tabAD4.TabIndex = 3;
            this.tabAD4.Text = "AD4";
            this.tabAD4.UseVisualStyleBackColor = true;
            // 
            // pBottom
            // 
            this.pBottom.Location = new System.Drawing.Point(17, 885);
            this.pBottom.Name = "pBottom";
            this.pBottom.Size = new System.Drawing.Size(572, 50);
            this.pBottom.TabIndex = 4;
            // 
            // btnXls2Chart
            // 
            this.btnXls2Chart.Font = new System.Drawing.Font("宋体", 8F);
            this.btnXls2Chart.Location = new System.Drawing.Point(17, 792);
            this.btnXls2Chart.Name = "btnXls2Chart";
            this.btnXls2Chart.Size = new System.Drawing.Size(130, 69);
            this.btnXls2Chart.TabIndex = 5;
            this.btnXls2Chart.Text = "选择表格转为图表";
            this.btnXls2Chart.UseVisualStyleBackColor = true;
            this.btnXls2Chart.Click += new System.EventHandler(this.btnXls2Chart_Click);
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(605, 895);
            this.Controls.Add(this.btnXls2Chart);
            this.Controls.Add(this.pBottom);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "配置参数";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConfig_FormClosing);
            this.Load += new System.EventHandler(this.frmConfig_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tcAD.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSerial;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.ComboBox cbStop;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.ComboBox cbDataBits;
        private System.Windows.Forms.ComboBox cbSerial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Timer timSerial;
        private System.Windows.Forms.CheckBox cbVoltageValue;
        private System.Windows.Forms.CheckBox cbADValue;
        private System.Windows.Forms.Button btnAD;
        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.TextBox txtADGain;
        private System.Windows.Forms.TextBox txtBasicVoltage;
        private System.Windows.Forms.ComboBox cbADDataBit;
        private System.Windows.Forms.TextBox txtOutPath;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabControl tcAD;
        private System.Windows.Forms.TabPage tabAD1;
        private System.Windows.Forms.TabPage tabAD2;
        private System.Windows.Forms.TabPage tabAD3;
        private System.Windows.Forms.TabPage tabAD4;
        private System.Windows.Forms.Panel pBottom;
        private System.Windows.Forms.Button btnXls2Chart;
    }
}