namespace AD2UART
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDbg = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuOpenSerial = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSerial = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFunction = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCmd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClearCmd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFontCmd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuShowLogCmd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuShowSendData = new System.Windows.Forms.ToolStripMenuItem();
            this.menuShowRcvData = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuShowCmdTime = new System.Windows.Forms.ToolStripMenuItem();
            this.menuShowCmdHead = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuOutputCmd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveCmd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.tsSerial = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsBaudRate = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.timUart = new System.Windows.Forms.Timer(this.components);
            this.rtCmd = new System.Windows.Forms.RichTextBox();
            this.timTime = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.statusMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnDbg);
            this.panel1.Controls.Add(this.btnOpenFile);
            this.panel1.Controls.Add(this.btnEnd);
            this.panel1.Location = new System.Drawing.Point(12, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 66);
            this.panel1.TabIndex = 1;
            // 
            // btnDbg
            // 
            this.btnDbg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDbg.Location = new System.Drawing.Point(715, 3);
            this.btnDbg.Name = "btnDbg";
            this.btnDbg.Size = new System.Drawing.Size(159, 58);
            this.btnDbg.TabIndex = 1;
            this.btnDbg.Text = "开启调试";
            this.btnDbg.UseVisualStyleBackColor = true;
            this.btnDbg.Visible = false;
            this.btnDbg.Click += new System.EventHandler(this.btnDbg_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(3, 5);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(214, 58);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "打开输出文件";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnd.Location = new System.Drawing.Point(880, 3);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(150, 58);
            this.btnEnd.TabIndex = 0;
            this.btnEnd.Text = "退出";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // menuMain
            // 
            this.menuMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpenSerial,
            this.menuSerial,
            this.menuFunction,
            this.menuCmd,
            this.menuAbout});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(1054, 39);
            this.menuMain.TabIndex = 2;
            this.menuMain.Text = "menuStrip1";
            // 
            // menuOpenSerial
            // 
            this.menuOpenSerial.Name = "menuOpenSerial";
            this.menuOpenSerial.ShortcutKeyDisplayString = "";
            this.menuOpenSerial.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.menuOpenSerial.Size = new System.Drawing.Size(122, 35);
            this.menuOpenSerial.Text = "打开串口";
            this.menuOpenSerial.Click += new System.EventHandler(this.打开端口ToolStripMenuItem_Click);
            // 
            // menuSerial
            // 
            this.menuSerial.Name = "menuSerial";
            this.menuSerial.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.menuSerial.Size = new System.Drawing.Size(122, 35);
            this.menuSerial.Text = "工具设置";
            this.menuSerial.Click += new System.EventHandler(this.设置ToolStripMenuItem_Click);
            // 
            // menuFunction
            // 
            this.menuFunction.Name = "menuFunction";
            this.menuFunction.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.menuFunction.Size = new System.Drawing.Size(122, 35);
            this.menuFunction.Text = "功能设置";
            this.menuFunction.Visible = false;
            this.menuFunction.Click += new System.EventHandler(this.menuFunction_Click);
            // 
            // menuCmd
            // 
            this.menuCmd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuClearCmd,
            this.menuFontCmd,
            this.toolStripMenuItem1,
            this.menuShowLogCmd,
            this.menuShowSendData,
            this.menuShowRcvData,
            this.toolStripMenuItem2,
            this.menuShowCmdTime,
            this.menuShowCmdHead,
            this.toolStripMenuItem3,
            this.menuOutputCmd,
            this.menuSaveCmd});
            this.menuCmd.Name = "menuCmd";
            this.menuCmd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.menuCmd.Size = new System.Drawing.Size(122, 35);
            this.menuCmd.Text = "报文选项";
            // 
            // menuClearCmd
            // 
            this.menuClearCmd.Name = "menuClearCmd";
            this.menuClearCmd.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.menuClearCmd.Size = new System.Drawing.Size(256, 38);
            this.menuClearCmd.Text = "清空报文";
            this.menuClearCmd.Click += new System.EventHandler(this.menuClearCmd_Click);
            // 
            // menuFontCmd
            // 
            this.menuFontCmd.Name = "menuFontCmd";
            this.menuFontCmd.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.menuFontCmd.Size = new System.Drawing.Size(256, 38);
            this.menuFontCmd.Text = "报文样式";
            this.menuFontCmd.Click += new System.EventHandler(this.menuFontCmd_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(253, 6);
            // 
            // menuShowLogCmd
            // 
            this.menuShowLogCmd.Checked = true;
            this.menuShowLogCmd.CheckOnClick = true;
            this.menuShowLogCmd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuShowLogCmd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuShowLogCmd.Name = "menuShowLogCmd";
            this.menuShowLogCmd.Size = new System.Drawing.Size(256, 38);
            this.menuShowLogCmd.Text = "显示提示信息";
            // 
            // menuShowSendData
            // 
            this.menuShowSendData.Checked = true;
            this.menuShowSendData.CheckOnClick = true;
            this.menuShowSendData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuShowSendData.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuShowSendData.Name = "menuShowSendData";
            this.menuShowSendData.Size = new System.Drawing.Size(256, 38);
            this.menuShowSendData.Text = "显示发送数据";
            // 
            // menuShowRcvData
            // 
            this.menuShowRcvData.Checked = true;
            this.menuShowRcvData.CheckOnClick = true;
            this.menuShowRcvData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuShowRcvData.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuShowRcvData.Name = "menuShowRcvData";
            this.menuShowRcvData.Size = new System.Drawing.Size(256, 38);
            this.menuShowRcvData.Text = "显示接收数据";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(253, 6);
            // 
            // menuShowCmdTime
            // 
            this.menuShowCmdTime.Checked = true;
            this.menuShowCmdTime.CheckOnClick = true;
            this.menuShowCmdTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuShowCmdTime.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuShowCmdTime.Name = "menuShowCmdTime";
            this.menuShowCmdTime.Size = new System.Drawing.Size(256, 38);
            this.menuShowCmdTime.Text = "显示报文时间";
            // 
            // menuShowCmdHead
            // 
            this.menuShowCmdHead.Checked = true;
            this.menuShowCmdHead.CheckOnClick = true;
            this.menuShowCmdHead.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuShowCmdHead.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuShowCmdHead.Name = "menuShowCmdHead";
            this.menuShowCmdHead.Size = new System.Drawing.Size(256, 38);
            this.menuShowCmdHead.Text = "显示报文头";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(253, 6);
            // 
            // menuOutputCmd
            // 
            this.menuOutputCmd.Name = "menuOutputCmd";
            this.menuOutputCmd.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.menuOutputCmd.Size = new System.Drawing.Size(256, 38);
            this.menuOutputCmd.Text = "动态输出";
            this.menuOutputCmd.Click += new System.EventHandler(this.menuOutputCmd_Click);
            // 
            // menuSaveCmd
            // 
            this.menuSaveCmd.Name = "menuSaveCmd";
            this.menuSaveCmd.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.menuSaveCmd.Size = new System.Drawing.Size(256, 38);
            this.menuSaveCmd.Text = "保存报文";
            this.menuSaveCmd.Click += new System.EventHandler(this.menuSaveCmd_Click);
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.menuAbout.Size = new System.Drawing.Size(74, 35);
            this.menuAbout.Text = "关于";
            this.menuAbout.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // statusMain
            // 
            this.statusMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSerial,
            this.tsBaudRate,
            this.tsTime,
            this.tsStatus});
            this.statusMain.Location = new System.Drawing.Point(0, 789);
            this.statusMain.Name = "statusMain";
            this.statusMain.Size = new System.Drawing.Size(1054, 40);
            this.statusMain.TabIndex = 3;
            this.statusMain.Text = "statusStrip1";
            // 
            // tsSerial
            // 
            this.tsSerial.AutoToolTip = true;
            this.tsSerial.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsSerial.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsSerial.Name = "tsSerial";
            this.tsSerial.Size = new System.Drawing.Size(138, 35);
            this.tsSerial.Text = "串口：关闭";
            this.tsSerial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsBaudRate
            // 
            this.tsBaudRate.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsBaudRate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBaudRate.Name = "tsBaudRate";
            this.tsBaudRate.Size = new System.Drawing.Size(177, 35);
            this.tsBaudRate.Text = "波特率：9600 ";
            // 
            // tsTime
            // 
            this.tsTime.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsTime.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsTime.Name = "tsTime";
            this.tsTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsTime.Size = new System.Drawing.Size(90, 35);
            this.tsTime.Text = "时间：";
            this.tsTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tsStatus
            // 
            this.tsStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsStatus.Name = "tsStatus";
            this.tsStatus.Size = new System.Drawing.Size(230, 35);
            this.tsStatus.Text = "状态：等待开启串口";
            this.tsStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timUart
            // 
            this.timUart.Interval = 1;
            this.timUart.Tick += new System.EventHandler(this.timUart_Tick);
            // 
            // rtCmd
            // 
            this.rtCmd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtCmd.Font = new System.Drawing.Font("宋体", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtCmd.Location = new System.Drawing.Point(12, 131);
            this.rtCmd.Name = "rtCmd";
            this.rtCmd.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtCmd.Size = new System.Drawing.Size(1030, 593);
            this.rtCmd.TabIndex = 4;
            this.rtCmd.Text = "";
            this.rtCmd.TextChanged += new System.EventHandler(this.rtCmd_TextChanged);
            // 
            // timTime
            // 
            this.timTime.Enabled = true;
            this.timTime.Interval = 1000;
            this.timTime.Tick += new System.EventHandler(this.timTime_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1054, 829);
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuMain);
            this.Controls.Add(this.rtCmd);
            this.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.MainMenuStrip = this.menuMain;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1080, 480);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AD采样工具";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.panel1.ResumeLayout(false);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.statusMain.ResumeLayout(false);
            this.statusMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuOpenSerial;
        private System.Windows.Forms.ToolStripMenuItem menuSerial;
        private System.Windows.Forms.ToolStripMenuItem menuFunction;
        private System.Windows.Forms.ToolStripMenuItem menuCmd;
        private System.Windows.Forms.ToolStripMenuItem menuClearCmd;
        private System.Windows.Forms.ToolStripMenuItem menuSaveCmd;
        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.Timer timUart;
        private System.Windows.Forms.RichTextBox rtCmd;
        private System.Windows.Forms.ToolStripStatusLabel tsSerial;
        private System.Windows.Forms.ToolStripStatusLabel tsBaudRate;
        private System.Windows.Forms.ToolStripStatusLabel tsTime;
        private System.Windows.Forms.ToolStripStatusLabel tsStatus;
        private System.Windows.Forms.Timer timTime;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuShowLogCmd;
        private System.Windows.Forms.ToolStripMenuItem menuShowSendData;
        private System.Windows.Forms.ToolStripMenuItem menuShowRcvData;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem menuShowCmdTime;
        private System.Windows.Forms.ToolStripMenuItem menuShowCmdHead;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem menuOutputCmd;
        private System.Windows.Forms.ToolStripMenuItem menuFontCmd;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnDbg;
    }
}

