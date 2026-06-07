using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.IO.Ports;
using System.Collections.Concurrent;
using System.Windows.Forms.DataVisualization.Charting;

namespace FFT_Monitor_STM32
{
    public partial class Form1 : Form
    {

        static int Samples = 256;

        // ADC 샘플링 주파수(Hz). Fundamental Freq 계산에 사용. 펌웨어 설정에 맞게 변경하세요.
        private const double Fs = 5500;

        // ===== 시리얼 수신 → 파싱 → 표시 파이프라인 (Producer-Consumer) =====
        private readonly BlockingCollection<byte[]> _rx = new BlockingCollection<byte[]>();
        private Thread _parser;
        private volatile bool _running;
        private int[] _rawSnap = new int[0];
        private float[] _fftSnap = new float[0];
        private readonly object _lock = new object();

        private const byte SYNC0 = 0x03, SYNC1 = 0x15, ID_RAW = 0x01, ID_FFT = 0x02;
        private enum St { Sync0, Sync1, Id, LenHi, LenLo, Payload }

        public Form1()
        {
            InitializeComponent();
            //serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ScanSerialPorts();

            // ===== TimeDomain(chart1) 축 설정 =====
            var axRaw = chart1.ChartAreas[0].AxisX;
            axRaw.Minimum = 0;
            axRaw.Maximum = 254;
            axRaw.Interval = 50;
            var ayRaw = chart1.ChartAreas[0].AxisY;
            ayRaw.Minimum = 0;
            ayRaw.Maximum = 64;
            ayRaw.Interval = 20;
            ayRaw.LabelStyle.Format = "0";   // Y축 라벨 정수 표시

            // ===== FFT(chart2) 축 설정 (자동 스케일 비활성화 → 오버플로 방지) =====
            var axFft = chart2.ChartAreas[0].AxisX;
            axFft.Minimum = 0;
            axFft.Maximum = 127;
            axFft.Interval = 20;
            var ayFft = chart2.ChartAreas[0].AxisY;
            ayFft.Minimum = 0;
            ayFft.Maximum = 3500;
            ayFft.Interval = 1000;
            ayFft.LabelStyle.Format = "0";   // Y축 라벨 정수 표시

            // 마우스를 올린 상태에서 휠로 Y축 Maximum 가변 조절 (확대/축소)
            chart1.MouseEnter += (s, ev) => chart1.Focus();   // hover 시 휠 입력을 받도록 포커스
            chart1.MouseWheel += chart1_MouseWheel;
            chart2.MouseEnter += (s, ev) => chart2.Focus();
            chart2.MouseWheel += chart2_MouseWheel;
        }

        // 차트 Y축 Maximum을 휠로 확대/축소하는 공통 처리
        private void ZoomChartY(Chart chart, int delta, double baseMax, double baseInterval, double upperLimit)
        {
            var ay = chart.ChartAreas[0].AxisY;
            double max = ay.Maximum;
            if (double.IsNaN(max) || max <= 0) max = baseMax;

            if (delta > 0) max *= 0.9;        // 휠 위로: 확대 (Maximum 감소)
            else if (delta < 0) max /= 0.9;   // 휠 아래로: 축소 (Maximum 증가)

            if (max < 10) max = 10;                 // 하한
            if (max > upperLimit) max = upperLimit; // 상한

            ay.Minimum = 0;
            ay.Maximum = Math.Round(max);
            // 분할 수를 일정하게 유지(라벨 폭주로 인한 오버플로 방지). Interval은 정수로 반올림.
            ay.Interval = Math.Max(1, Math.Round(baseInterval * ay.Maximum / baseMax));
        }

        private void chart1_MouseWheel(object sender, MouseEventArgs e)
        {
            ZoomChartY(chart1, e.Delta, 64, 10, 255);
        }

        private void chart2_MouseWheel(object sender, MouseEventArgs e)
        {
            ZoomChartY(chart2, e.Delta, 3500, 1000, 100000);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("프로그램을 종료 하시겠습니까?", "Zhenyu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                try
                {
                    if (serialPort1.IsOpen)
                    {
                        StopParser();
                        serialPort1.DiscardOutBuffer();
                        serialPort1.Dispose();
                        serialPort1.Close();
                        serialPort1 = null;
                        e.Cancel = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                return;
            }
        }
        /* =====================================*/
        /*                         COM Port Control Setting                         */
        /* =====================================*/
        private void Btn_OPEN_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = CBoxCOMPORT.Text;
                serialPort1.BaudRate = Convert.ToInt32(CBoxBaudRate.Text);
                serialPort1.DataBits = Convert.ToInt32(CBoxDataBits.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), CBoxStopBits.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), CBoxParityBits.Text);
                serialPort1.ReadTimeout = 3000;

                serialPort1.Open();
                StartParser();
                Btn_OPEN.Enabled = false;
                Btn_CLOSE.Enabled = true;

                progressBar1.Value = 100;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            ScanSerialPorts();
        }

        private void Btn_CLOSE_Click(object sender, EventArgs e)
        {
            //try
            //{
            if (serialPort1.IsOpen)
            {
                StopParser();
                serialPort1.DiscardOutBuffer();
                serialPort1.Dispose();
                serialPort1.Close();
            }
            Btn_OPEN.Enabled = true;
            Btn_CLOSE.Enabled = false;
            CBoxCOMPORT.Enabled = true;
            CBoxBaudRate.Enabled = true;

            progressBar1.Value = 0;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error : " + ex.Message, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        void ScanSerialPorts()
        {
            try
            {
                CBoxCOMPORT.Items.Clear();
                foreach (string serialName in SerialPort.GetPortNames())
                {
                    CBoxCOMPORT.Items.Add(serialName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                int n = serialPort1.BytesToRead;
                if (n <= 0) return;
                var buf = new byte[n];
                int read = serialPort1.Read(buf, 0, n);
                if (read < n) Array.Resize(ref buf, read);
                if (read > 0)
                {
                    _rx.Add(buf);
                }
            }
            catch { }
        }

        private void StartParser()
        {
            _running = true;
            _parser = new Thread(ParserLoop) { IsBackground = true };
            _parser.Start();
        }

        private void StopParser()
        {
            _running = false;
            _rx.CompleteAdding();
            _parser?.Join(500);
        }

        private void ParserLoop()
        {
            var st = St.Sync0;
            byte id = 0; int len = 0, got = 0; byte[] pl = null;
            try
            {
                foreach (var chunk in _rx.GetConsumingEnumerable())
                    for (int i = 0; i < chunk.Length && _running; i++)
                    {
                        byte b = chunk[i];
                        switch (st)
                        {
                            case St.Sync0: st = b == SYNC0 ? St.Sync1 : St.Sync0; break;
                            case St.Sync1: st = b == SYNC1 ? St.Id : b == SYNC0 ? St.Sync1 : St.Sync0; break;
                            case St.Id: id = b; st = St.LenHi; break;
                            case St.LenHi: len = b << 8; st = St.LenLo; break;
                            case St.LenLo:
                                len |= b;
                                if (len <= 0 || len > 8192) { st = St.Sync0; break; }
                                pl = new byte[len]; got = 0; st = St.Payload; break;
                            case St.Payload:
                                pl[got++] = b;
                                if (got == len) { Dispatch(id, pl); st = St.Sync0; }
                                break;
                        }
                    }
            }
            catch { }
        }

        private void Dispatch(byte id, byte[] pl)
        {
            if (id == ID_RAW)
            {
                // Raw(Time Domain): 1바이트 = 1샘플 (256개, 0~255)
                int c = pl.Length;
                var r = new int[c];
                for (int i = 0; i < c; i++) r[i] = pl[i];
                lock (_lock) _rawSnap = r;
            }
            else if (id == ID_FFT)
            {
                // FFT(Freq Domain): float32 × N (1024바이트 = 256개)
                if (pl.Length % 4 != 0) return; // 4의 배수가 아니면 정렬이 깨진 손상 패킷 → 버림
                int c = pl.Length / 4;
                var f = new float[c];
                for (int i = 0; i < c; i++) f[i] = BitConverter.ToSingle(pl, i * 4);
                lock (_lock) _fftSnap = f;
            }
        }

        /* =====================================*/
        /*                               Rx Control Setting                              */
        /* =====================================*/

        private void Form1_Resize(object sender, EventArgs e)
        {
            chart1.Height = panel2.Height/4;
            chart2.Height = panel2.Height-200;

        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            if(timer1.Enabled == false)
            {
                timer1.Start();
            }

            if (timer2.Enabled == false)
            {
                timer2.Start();
            }
        }

        private void Btn_Stop_Click(object sender, EventArgs e)
        {
            if(timer1.Enabled)
            {
                timer1.Stop();
            }
            if (timer2.Enabled)
            {
                timer2.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int[] r; lock (_lock) r = _rawSnap;
            var s = chart1.Series["Series1"]; s.Points.Clear();
            int n = Math.Min(Samples, r.Length);
            for (int i = 0; i < n; i++) s.Points.AddXY(i, r[i]);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            float[] f; lock (_lock) f = _fftSnap;
            var s = chart2.Series["Series1"]; s.Points.Clear();
            int half = Math.Min(Samples / 2, f.Length);
            // FastLine이 값→정수 픽셀로 변환할 때 오버플로(Overflow error.)가 나지 않도록,
            // 축(0~3500) 대비 비현실적으로 큰 garbage 값은 제외한다. 정상 FFT 크기는 이보다 훨씬 작다.
            const float PlotLimit = 1.0e7f;

            int peakIdx = -1;
            float peakMag = 0f;
            for (int i = 2; i < half; i++)
            {
                float v = f[i];
                // NaN / Infinity 또는 비현실적으로 큰 값(픽셀 변환 오버플로 유발)은 제외
                if (float.IsNaN(v) || float.IsInfinity(v) || Math.Abs(v) > PlotLimit) continue;
                s.Points.AddXY(i, v);

                // 최대 크기 빈 = 기본 주파수
                float mag = Math.Abs(v);
                if (mag > peakMag) { peakMag = mag; peakIdx = i; }
            }

            // Fundamental Freq 표시 (freq = peak × fs / N)
            if (peakIdx > 0)
            {
                double freq = peakIdx * Fs / Samples;
                label2.Text = freq.ToString("0.0") + " Hz";
            }
            else
            {
                label2.Text = "-";
            }
        }
    }
}
