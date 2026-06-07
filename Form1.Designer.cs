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
            this.Gbox_ComPortControl.Size = new System.Drawing.Size(165, 227);
            this.Gbox_ComPortControl.TabIndex = 1;
            this.Gbox_ComPortControl.TabStop = false;
            this.Gbox_ComPortControl.Text = "COM Port Control";
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Refresh.Location = new System.Drawing.Point(6, 151);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(153, 23);
            this.Btn_Refresh.TabIndex = 34;
            this.Btn_Refresh.Text = "Refresh";
            this.Btn_Refresh.UseVisualStyleBackColor = true;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 209);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(155, 10);
            this.progressBar1.TabIndex = 1;
            // 
            // Btn_CLOSE
            // 
            this.Btn_CLOSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CLOSE.Location = new System.Drawing.Point(88, 180);
            this.Btn_CLOSE.Name = "Btn_CLOSE";
            this.Btn_CLOSE.Size = new System.Drawing.Size(70, 23);
            this.Btn_CLOSE.TabIndex = 14;
            this.Btn_CLOSE.Text = "CLOSE";
            this.Btn_CLOSE.UseVisualStyleBackColor = true;
            this.Btn_CLOSE.Click += new System.EventHandler(this.Btn_CLOSE_Click);
            // 
            // Btn_OPEN
            // 
            this.Btn_OPEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_OPEN.Location = new System.Drawing.Point(5, 180);
            this.Btn_OPEN.Name = "Btn_OPEN";
            this.Btn_OPEN.Size = new System.Drawing.Size(70, 23);
            this.Btn_OPEN.TabIndex = 1;
            this.Btn_OPEN.Text = "OPEN";
            this.Btn_OPEN.UseVisualStyleBackColor = true;
            this.Btn_OPEN.Click += new System.EventHandler(this.Btn_OPEN_Click);
            // 
            // Lb_ParityBits
            // 
            this.Lb_ParityBits.AutoSize = true;
            this.Lb_ParityBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_ParityBits.Location = new System.Drawing.Point(2, 127);
            this.Lb_ParityBits.Name = "Lb_ParityBits";
            this.Lb_ParityBits.Size = new System.Drawing.Size(53, 13);
            this.Lb_ParityBits.TabIndex = 9;
            this.Lb_ParityBits.Text = "Parity Bits";
            // 
            // Lb_StopBits
            // 
            this.Lb_StopBits.AutoSize = true;
            this.Lb_StopBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_StopBits.Location = new System.Drawing.Point(3, 100);
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
            this.CBoxParityBits.Location = new System.Drawing.Point(70, 124);
            this.CBoxParityBits.Name = "CBoxParityBits";
            this.CBoxParityBits.Size = new System.Drawing.Size(88, 21);
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
            this.CBoxStopBits.Location = new System.Drawing.Point(70, 98);
            this.CBoxStopBits.Name = "CBoxStopBits";
            this.CBoxStopBits.Size = new System.Drawing.Size(88, 21);
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
            this.CBoxDataBits.Location = new System.Drawing.Point(70, 70);
            this.CBoxDataBits.Name = "CBoxDataBits";
            this.CBoxDataBits.Size = new System.Drawing.Size(88, 21);
            this.CBoxDataBits.TabIndex = 5;
            this.CBoxDataBits.Text = "8";
            // 
            // Lb_DataBits
            // 
            this.Lb_DataBits.AutoSize = true;
            this.Lb_DataBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_DataBits.Location = new System.Drawing.Point(2, 73);
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
            this.CBoxBaudRate.Location = new System.Drawing.Point(70, 43);
            this.CBoxBaudRate.Name = "CBoxBaudRate";
            this.CBoxBaudRate.Size = new System.Drawing.Size(88, 21);
            this.CBoxBaudRate.TabIndex = 3;
            this.CBoxBaudRate.Text = "115200";
            // 
            // Lb_BaudRate
            // 
            this.Lb_BaudRate.AutoSize = true;
            this.Lb_BaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_BaudRate.Location = new System.Drawing.Point(2, 46);
            this.Lb_BaudRate.Name = "Lb_BaudRate";
            this.Lb_BaudRate.Size = new System.Drawing.Size(58, 13);
            this.Lb_BaudRate.TabIndex = 2;
            this.Lb_BaudRate.Text = "Baud Rate";
            // 
            // CBoxCOMPORT
            // 
            this.CBoxCOMPORT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxCOMPORT.FormattingEnabled = true;
            this.CBoxCOMPORT.Location = new System.Drawing.Point(70, 16);
            this.CBoxCOMPORT.Name = "CBoxCOMPORT";
            this.CBoxCOMPORT.Size = new System.Drawing.Size(88, 21);
            this.CBoxCOMPORT.TabIndex = 1;
            // 
            // Lb_ComPort
            // 
            this.Lb_ComPort.AutoSize = true;
            this.Lb_ComPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_ComPort.Location = new System.Drawing.Point(3, 20);
            this.Lb_ComPort.Name = "Lb_ComPort";
            this.Lb_ComPort.Size = new System.Drawing.Size(53, 13);
            this.Lb_ComPort.TabIndex = 0;
            this.Lb_ComPort.Text = "COM Port";
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
            this.panel1.Location = new System.Drawing.Point(10, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 480);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.chart1);
            this.panel2.Controls.Add(this.chart2);
            this.panel2.Location = new System.Drawing.Point(189, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(455, 449);
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
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(450, 193);
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
            this.chart2.Location = new System.Drawing.Point(3, 203);
            this.chart2.Name = "chart2";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(450, 239);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // Btn_Start
            // 
            this.Btn_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Start.Location = new System.Drawing.Point(510, 468);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(64, 25);
            this.Btn_Start.TabIndex = 0;
            this.Btn_Start.Text = "Start";
            this.Btn_Start.UseVisualStyleBackColor = true;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // Btn_Stop
            // 
            this.Btn_Stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Stop.Location = new System.Drawing.Point(579, 468);
            this.Btn_Stop.Name = "Btn_Stop";
            this.Btn_Stop.Size = new System.Drawing.Size(64, 25);
            this.Btn_Stop.TabIndex = 21;
            this.Btn_Stop.Text = "Stop";
            this.Btn_Stop.UseVisualStyleBackColor = true;
            this.Btn_Stop.Click += new System.EventHandler(this.Btn_Stop_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 473);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Fundamental Freq : ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 473);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 506);
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

