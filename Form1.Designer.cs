namespace FFT_Monitor_STM32
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Gbox_ComPortControl = new System.Windows.Forms.GroupBox();
            this.Btn_Refresh = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Btn_CLOSE = new System.Windows.Forms.Button();
            this.Btn_OPEN = new System.Windows.Forms.Button();
            this.Chk_CD = new System.Windows.Forms.CheckBox();
            this.Chk_DSR = new System.Windows.Forms.CheckBox();
            this.Chk_CTS = new System.Windows.Forms.CheckBox();
            this.Chk_RTS = new System.Windows.Forms.CheckBox();
            this.Chk_DTR = new System.Windows.Forms.CheckBox();
            this.Lb_ParityBits = new System.Windows.Forms.Label();
            this.Lb_StopBits = new System.Windows.Forms.Label();
            this.CBoxParityBits = new System.Windows.Forms.ComboBox();
            this.CBoxStopBits = new System.Windows.Forms.ComboBox();
            this.CBoxDataBits = new System.Windows.Forms.ComboBox();
            this.Lb_DataBits = new System.Windows.Forms.Label();
            this.CBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.Lb_BaudRate = new System.Windows.Forms.Label();
            this.CBoxCOMPORT = new System.Windows.Forms.ComboBox();
            this.Lb_ComPort = new System.Windows.Forms.Label();
            this.GBox_RxControl = new System.Windows.Forms.GroupBox();
            this.TBoxDataIN = new System.Windows.Forms.TextBox();
            this.Chk_AddToOldData = new System.Windows.Forms.CheckBox();
            this.Btn_ClearDataIN = new System.Windows.Forms.Button();
            this.Chk_AlwaysUpdate = new System.Windows.Forms.CheckBox();
            this.Lb_RxDataOutLength = new System.Windows.Forms.Label();
            this.Chk_RxHex = new System.Windows.Forms.CheckBox();
            this.Chk_RxASC = new System.Windows.Forms.CheckBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Btn_Start = new System.Windows.Forms.Button();
            this.Btn_Stop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Gbox_ComPortControl.SuspendLayout();
            this.GBox_RxControl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // Gbox_ComPortControl
            // 
            this.Gbox_ComPortControl.BackColor = System.Drawing.SystemColors.Control;
            this.Gbox_ComPortControl.Controls.Add(this.Btn_Refresh);
            this.Gbox_ComPortControl.Controls.Add(this.progressBar1);
            this.Gbox_ComPortControl.Controls.Add(this.Btn_CLOSE);
            this.Gbox_ComPortControl.Controls.Add(this.Btn_OPEN);
            this.Gbox_ComPortControl.Controls.Add(this.Chk_CD);
            this.Gbox_ComPortControl.Controls.Add(this.Chk_DSR);
            this.Gbox_ComPortControl.Controls.Add(this.Chk_CTS);
            this.Gbox_ComPortControl.Controls.Add(this.Chk_RTS);
            this.Gbox_ComPortControl.Controls.Add(this.Chk_DTR);
            this.Gbox_ComPortControl.Controls.Add(this.Lb_ParityBits);
            this.Gbox_ComPortControl.Controls.Add(this.Lb_StopBits);
            this.Gbox_ComPortControl.Controls.Add(this.CBoxParityBits);
            this.Gbox_ComPortControl.Controls.Add(this.CBoxStopBits);
            this.Gbox_ComPortControl.Controls.Add(this.CBoxDataBits);
            this.Gbox_ComPortControl.Controls.Add(this.Lb_DataBits);
            this.Gbox_ComPortControl.Controls.Add(this.CBoxBaudRate);
            this.Gbox_ComPortControl.Controls.Add(this.Lb_BaudRate);
            this.Gbox_ComPortControl.Controls.Add(this.CBoxCOMPORT);
            this.Gbox_ComPortControl.Controls.Add(this.Lb_ComPort);
            this.Gbox_ComPortControl.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Gbox_ComPortControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gbox_ComPortControl.Location = new System.Drawing.Point(3, 3);
            this.Gbox_ComPortControl.Name = "Gbox_ComPortControl";
            this.Gbox_ComPortControl.Size = new System.Drawing.Size(192, 228);
            this.Gbox_ComPortControl.TabIndex = 1;
            this.Gbox_ComPortControl.TabStop = false;
            this.Gbox_ComPortControl.Text = "COM Port Control";
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Refresh.Location = new System.Drawing.Point(118, 157);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(66, 21);
            this.Btn_Refresh.TabIndex = 34;
            this.Btn_Refresh.Text = "Refresh";
            this.Btn_Refresh.UseVisualStyleBackColor = true;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(7, 209);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(181, 9);
            this.progressBar1.TabIndex = 1;
            // 
            // Btn_CLOSE
            // 
            this.Btn_CLOSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CLOSE.Location = new System.Drawing.Point(103, 182);
            this.Btn_CLOSE.Name = "Btn_CLOSE";
            this.Btn_CLOSE.Size = new System.Drawing.Size(82, 21);
            this.Btn_CLOSE.TabIndex = 14;
            this.Btn_CLOSE.Text = "CLOSE";
            this.Btn_CLOSE.UseVisualStyleBackColor = true;
            this.Btn_CLOSE.Click += new System.EventHandler(this.Btn_CLOSE_Click);
            // 
            // Btn_OPEN
            // 
            this.Btn_OPEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_OPEN.Location = new System.Drawing.Point(6, 182);
            this.Btn_OPEN.Name = "Btn_OPEN";
            this.Btn_OPEN.Size = new System.Drawing.Size(82, 21);
            this.Btn_OPEN.TabIndex = 1;
            this.Btn_OPEN.Text = "OPEN";
            this.Btn_OPEN.UseVisualStyleBackColor = true;
            this.Btn_OPEN.Click += new System.EventHandler(this.Btn_OPEN_Click);
            // 
            // Chk_CD
            // 
            this.Chk_CD.AutoSize = true;
            this.Chk_CD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chk_CD.Location = new System.Drawing.Point(66, 161);
            this.Chk_CD.Name = "Chk_CD";
            this.Chk_CD.Size = new System.Drawing.Size(41, 17);
            this.Chk_CD.TabIndex = 13;
            this.Chk_CD.Text = "CD";
            this.Chk_CD.UseVisualStyleBackColor = true;
            // 
            // Chk_DSR
            // 
            this.Chk_DSR.AutoSize = true;
            this.Chk_DSR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chk_DSR.Location = new System.Drawing.Point(6, 161);
            this.Chk_DSR.Name = "Chk_DSR";
            this.Chk_DSR.Size = new System.Drawing.Size(49, 17);
            this.Chk_DSR.TabIndex = 12;
            this.Chk_DSR.Text = "DSR";
            this.Chk_DSR.UseVisualStyleBackColor = true;
            // 
            // Chk_CTS
            // 
            this.Chk_CTS.AutoSize = true;
            this.Chk_CTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chk_CTS.Location = new System.Drawing.Point(124, 139);
            this.Chk_CTS.Name = "Chk_CTS";
            this.Chk_CTS.Size = new System.Drawing.Size(47, 17);
            this.Chk_CTS.TabIndex = 11;
            this.Chk_CTS.Text = "CTS";
            this.Chk_CTS.UseVisualStyleBackColor = true;
            // 
            // Chk_RTS
            // 
            this.Chk_RTS.AutoSize = true;
            this.Chk_RTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chk_RTS.Location = new System.Drawing.Point(65, 139);
            this.Chk_RTS.Name = "Chk_RTS";
            this.Chk_RTS.Size = new System.Drawing.Size(48, 17);
            this.Chk_RTS.TabIndex = 10;
            this.Chk_RTS.Text = "RTS";
            this.Chk_RTS.UseVisualStyleBackColor = true;
            // 
            // Chk_DTR
            // 
            this.Chk_DTR.AutoSize = true;
            this.Chk_DTR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chk_DTR.Location = new System.Drawing.Point(6, 139);
            this.Chk_DTR.Name = "Chk_DTR";
            this.Chk_DTR.Size = new System.Drawing.Size(49, 17);
            this.Chk_DTR.TabIndex = 1;
            this.Chk_DTR.Text = "DTR";
            this.Chk_DTR.UseVisualStyleBackColor = true;
            // 
            // Lb_ParityBits
            // 
            this.Lb_ParityBits.AutoSize = true;
            this.Lb_ParityBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_ParityBits.Location = new System.Drawing.Point(2, 117);
            this.Lb_ParityBits.Name = "Lb_ParityBits";
            this.Lb_ParityBits.Size = new System.Drawing.Size(53, 13);
            this.Lb_ParityBits.TabIndex = 9;
            this.Lb_ParityBits.Text = "Parity Bits";
            // 
            // Lb_StopBits
            // 
            this.Lb_StopBits.AutoSize = true;
            this.Lb_StopBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_StopBits.Location = new System.Drawing.Point(3, 92);
            this.Lb_StopBits.Name = "Lb_StopBits";
            this.Lb_StopBits.Size = new System.Drawing.Size(49, 13);
            this.Lb_StopBits.TabIndex = 8;
            this.Lb_StopBits.Text = "Stop Bits";
            // 
            // CBoxParityBits
            // 
            this.CBoxParityBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxParityBits.FormattingEnabled = true;
            this.CBoxParityBits.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd"});
            this.CBoxParityBits.Location = new System.Drawing.Point(82, 114);
            this.CBoxParityBits.Name = "CBoxParityBits";
            this.CBoxParityBits.Size = new System.Drawing.Size(102, 21);
            this.CBoxParityBits.TabIndex = 7;
            this.CBoxParityBits.Text = "None";
            // 
            // CBoxStopBits
            // 
            this.CBoxStopBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxStopBits.FormattingEnabled = true;
            this.CBoxStopBits.Items.AddRange(new object[] {
            "1",
            "2",
            "1.5"});
            this.CBoxStopBits.Location = new System.Drawing.Point(82, 90);
            this.CBoxStopBits.Name = "CBoxStopBits";
            this.CBoxStopBits.Size = new System.Drawing.Size(102, 21);
            this.CBoxStopBits.TabIndex = 6;
            this.CBoxStopBits.Text = "1";
            // 
            // CBoxDataBits
            // 
            this.CBoxDataBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxDataBits.FormattingEnabled = true;
            this.CBoxDataBits.Items.AddRange(new object[] {
            "8",
            "9"});
            this.CBoxDataBits.Location = new System.Drawing.Point(82, 65);
            this.CBoxDataBits.Name = "CBoxDataBits";
            this.CBoxDataBits.Size = new System.Drawing.Size(102, 21);
            this.CBoxDataBits.TabIndex = 5;
            this.CBoxDataBits.Text = "8";
            // 
            // Lb_DataBits
            // 
            this.Lb_DataBits.AutoSize = true;
            this.Lb_DataBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_DataBits.Location = new System.Drawing.Point(2, 67);
            this.Lb_DataBits.Name = "Lb_DataBits";
            this.Lb_DataBits.Size = new System.Drawing.Size(50, 13);
            this.Lb_DataBits.TabIndex = 4;
            this.Lb_DataBits.Text = "Data Bits";
            // 
            // CBoxBaudRate
            // 
            this.CBoxBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxBaudRate.FormattingEnabled = true;
            this.CBoxBaudRate.Items.AddRange(new object[] {
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "74880",
            "115200",
            "230400",
            "250000",
            "500000",
            "1000000"});
            this.CBoxBaudRate.Location = new System.Drawing.Point(82, 40);
            this.CBoxBaudRate.Name = "CBoxBaudRate";
            this.CBoxBaudRate.Size = new System.Drawing.Size(102, 21);
            this.CBoxBaudRate.TabIndex = 3;
            this.CBoxBaudRate.Text = "115200";
            // 
            // Lb_BaudRate
            // 
            this.Lb_BaudRate.AutoSize = true;
            this.Lb_BaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_BaudRate.Location = new System.Drawing.Point(2, 42);
            this.Lb_BaudRate.Name = "Lb_BaudRate";
            this.Lb_BaudRate.Size = new System.Drawing.Size(58, 13);
            this.Lb_BaudRate.TabIndex = 2;
            this.Lb_BaudRate.Text = "Baud Rate";
            // 
            // CBoxCOMPORT
            // 
            this.CBoxCOMPORT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxCOMPORT.FormattingEnabled = true;
            this.CBoxCOMPORT.Location = new System.Drawing.Point(82, 15);
            this.CBoxCOMPORT.Name = "CBoxCOMPORT";
            this.CBoxCOMPORT.Size = new System.Drawing.Size(102, 21);
            this.CBoxCOMPORT.TabIndex = 1;
            // 
            // Lb_ComPort
            // 
            this.Lb_ComPort.AutoSize = true;
            this.Lb_ComPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_ComPort.Location = new System.Drawing.Point(3, 18);
            this.Lb_ComPort.Name = "Lb_ComPort";
            this.Lb_ComPort.Size = new System.Drawing.Size(53, 13);
            this.Lb_ComPort.TabIndex = 0;
            this.Lb_ComPort.Text = "COM Port";
            // 
            // GBox_RxControl
            // 
            this.GBox_RxControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GBox_RxControl.Controls.Add(this.TBoxDataIN);
            this.GBox_RxControl.Controls.Add(this.Chk_AddToOldData);
            this.GBox_RxControl.Controls.Add(this.Btn_ClearDataIN);
            this.GBox_RxControl.Controls.Add(this.Chk_AlwaysUpdate);
            this.GBox_RxControl.Controls.Add(this.Lb_RxDataOutLength);
            this.GBox_RxControl.Controls.Add(this.Chk_RxHex);
            this.GBox_RxControl.Controls.Add(this.Chk_RxASC);
            this.GBox_RxControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBox_RxControl.Location = new System.Drawing.Point(3, 237);
            this.GBox_RxControl.Name = "GBox_RxControl";
            this.GBox_RxControl.Size = new System.Drawing.Size(192, 203);
            this.GBox_RxControl.TabIndex = 17;
            this.GBox_RxControl.TabStop = false;
            this.GBox_RxControl.Text = "Rx Control";
            // 
            // TBoxDataIN
            // 
            this.TBoxDataIN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TBoxDataIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxDataIN.Location = new System.Drawing.Point(7, 41);
            this.TBoxDataIN.Multiline = true;
            this.TBoxDataIN.Name = "TBoxDataIN";
            this.TBoxDataIN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TBoxDataIN.Size = new System.Drawing.Size(177, 89);
            this.TBoxDataIN.TabIndex = 23;
            // 
            // Chk_AddToOldData
            // 
            this.Chk_AddToOldData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Chk_AddToOldData.AutoSize = true;
            this.Chk_AddToOldData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chk_AddToOldData.Location = new System.Drawing.Point(8, 154);
            this.Chk_AddToOldData.Name = "Chk_AddToOldData";
            this.Chk_AddToOldData.Size = new System.Drawing.Size(106, 17);
            this.Chk_AddToOldData.TabIndex = 22;
            this.Chk_AddToOldData.Text = "Add To Old Data";
            this.Chk_AddToOldData.UseVisualStyleBackColor = true;
            this.Chk_AddToOldData.CheckedChanged += new System.EventHandler(this.Chk_AddToOldData_CheckedChanged);
            // 
            // Btn_ClearDataIN
            // 
            this.Btn_ClearDataIN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_ClearDataIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ClearDataIN.Location = new System.Drawing.Point(8, 177);
            this.Btn_ClearDataIN.Name = "Btn_ClearDataIN";
            this.Btn_ClearDataIN.Size = new System.Drawing.Size(176, 21);
            this.Btn_ClearDataIN.TabIndex = 17;
            this.Btn_ClearDataIN.Text = "Clear Data IN";
            this.Btn_ClearDataIN.UseVisualStyleBackColor = true;
            this.Btn_ClearDataIN.Click += new System.EventHandler(this.Btn_ClearDataIN_Click);
            // 
            // Chk_AlwaysUpdate
            // 
            this.Chk_AlwaysUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Chk_AlwaysUpdate.AutoSize = true;
            this.Chk_AlwaysUpdate.Checked = true;
            this.Chk_AlwaysUpdate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Chk_AlwaysUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chk_AlwaysUpdate.Location = new System.Drawing.Point(8, 134);
            this.Chk_AlwaysUpdate.Name = "Chk_AlwaysUpdate";
            this.Chk_AlwaysUpdate.Size = new System.Drawing.Size(97, 17);
            this.Chk_AlwaysUpdate.TabIndex = 21;
            this.Chk_AlwaysUpdate.Text = "Always Update";
            this.Chk_AlwaysUpdate.UseVisualStyleBackColor = true;
            this.Chk_AlwaysUpdate.CheckedChanged += new System.EventHandler(this.Chk_AlwaysUpdate_CheckedChanged);
            // 
            // Lb_RxDataOutLength
            // 
            this.Lb_RxDataOutLength.AutoSize = true;
            this.Lb_RxDataOutLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_RxDataOutLength.Location = new System.Drawing.Point(154, 18);
            this.Lb_RxDataOutLength.Name = "Lb_RxDataOutLength";
            this.Lb_RxDataOutLength.Size = new System.Drawing.Size(19, 13);
            this.Lb_RxDataOutLength.TabIndex = 19;
            this.Lb_RxDataOutLength.Text = "00";
            // 
            // Chk_RxHex
            // 
            this.Chk_RxHex.AutoSize = true;
            this.Chk_RxHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chk_RxHex.Location = new System.Drawing.Point(78, 18);
            this.Chk_RxHex.Name = "Chk_RxHex";
            this.Chk_RxHex.Size = new System.Drawing.Size(45, 17);
            this.Chk_RxHex.TabIndex = 20;
            this.Chk_RxHex.Text = "Hex";
            this.Chk_RxHex.UseVisualStyleBackColor = true;
            this.Chk_RxHex.CheckedChanged += new System.EventHandler(this.Chk_RxHex_CheckedChanged);
            // 
            // Chk_RxASC
            // 
            this.Chk_RxASC.AutoSize = true;
            this.Chk_RxASC.Checked = true;
            this.Chk_RxASC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Chk_RxASC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chk_RxASC.Location = new System.Drawing.Point(8, 18);
            this.Chk_RxASC.Name = "Chk_RxASC";
            this.Chk_RxASC.Size = new System.Drawing.Size(53, 17);
            this.Chk_RxASC.TabIndex = 19;
            this.Chk_RxASC.Text = "ASCⅡ";
            this.Chk_RxASC.UseVisualStyleBackColor = true;
            this.Chk_RxASC.CheckedChanged += new System.EventHandler(this.Chk_RxASC_CheckedChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.Gbox_ComPortControl);
            this.panel1.Controls.Add(this.GBox_RxControl);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 443);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.chart1);
            this.panel2.Controls.Add(this.chart2);
            this.panel2.Location = new System.Drawing.Point(220, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(531, 414);
            this.panel2.TabIndex = 19;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.Maximum = 100D;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderWidth = 2;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(525, 178);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            this.chart2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.AxisY.Maximum = 3500D;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BackSecondaryColor = System.Drawing.Color.White;
            chartArea2.BorderWidth = 2;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(3, 187);
            this.chart2.Name = "chart2";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(525, 221);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // Btn_Start
            // 
            this.Btn_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Start.Location = new System.Drawing.Point(595, 432);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(75, 23);
            this.Btn_Start.TabIndex = 0;
            this.Btn_Start.Text = "Start";
            this.Btn_Start.UseVisualStyleBackColor = true;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // Btn_Stop
            // 
            this.Btn_Stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Stop.Location = new System.Drawing.Point(676, 432);
            this.Btn_Stop.Name = "Btn_Stop";
            this.Btn_Stop.Size = new System.Drawing.Size(75, 23);
            this.Btn_Stop.TabIndex = 21;
            this.Btn_Stop.Text = "Stop";
            this.Btn_Stop.UseVisualStyleBackColor = true;
            this.Btn_Stop.Click += new System.EventHandler(this.Btn_Stop_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 12);
            this.label1.TabIndex = 22;
            this.label1.Text = "Fundamental Freq : ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 437);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 12);
            this.label2.TabIndex = 23;
            this.label2.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Interval = 2;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 20;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 467);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Stop);
            this.Controls.Add(this.Btn_Start);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "STM32 FFT Monitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.Gbox_ComPortControl.ResumeLayout(false);
            this.Gbox_ComPortControl.PerformLayout();
            this.GBox_RxControl.ResumeLayout(false);
            this.GBox_RxControl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Gbox_ComPortControl;
        private System.Windows.Forms.Button Btn_Refresh;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button Btn_CLOSE;
        private System.Windows.Forms.Button Btn_OPEN;
        private System.Windows.Forms.CheckBox Chk_CD;
        private System.Windows.Forms.CheckBox Chk_DSR;
        private System.Windows.Forms.CheckBox Chk_CTS;
        private System.Windows.Forms.CheckBox Chk_RTS;
        private System.Windows.Forms.CheckBox Chk_DTR;
        private System.Windows.Forms.Label Lb_ParityBits;
        private System.Windows.Forms.Label Lb_StopBits;
        private System.Windows.Forms.ComboBox CBoxParityBits;
        private System.Windows.Forms.ComboBox CBoxStopBits;
        private System.Windows.Forms.ComboBox CBoxDataBits;
        private System.Windows.Forms.Label Lb_DataBits;
        private System.Windows.Forms.ComboBox CBoxBaudRate;
        private System.Windows.Forms.Label Lb_BaudRate;
        private System.Windows.Forms.ComboBox CBoxCOMPORT;
        private System.Windows.Forms.Label Lb_ComPort;
        private System.Windows.Forms.GroupBox GBox_RxControl;
        private System.Windows.Forms.TextBox TBoxDataIN;
        private System.Windows.Forms.CheckBox Chk_AddToOldData;
        private System.Windows.Forms.Button Btn_ClearDataIN;
        private System.Windows.Forms.CheckBox Chk_AlwaysUpdate;
        private System.Windows.Forms.Label Lb_RxDataOutLength;
        private System.Windows.Forms.CheckBox Chk_RxHex;
        private System.Windows.Forms.CheckBox Chk_RxASC;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.Button Btn_Stop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}

