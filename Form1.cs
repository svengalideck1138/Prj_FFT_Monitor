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

namespace FFT_Monitor_STM32
{
    public partial class Form1 : Form
    {

        static string dataIN = "";
        static int dataINLength;

        static int Samples = 256;
        static int[] RawIntDataArray = new int[Samples];
        static int[] FFTIntDataArray = new int[Samples * 4];
        static byte[] FFTByteArray = new byte[Samples * 4];

        static int[] RawIntArray = new int[Samples];
        static float[] FFTFloatArray = new float[Samples];

        public Form1()
        {
            InitializeComponent();
            //serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ScanSerialPorts();
            Chk_CTS.Enabled = true;
            Chk_DSR.Enabled = true;
            Chk_DTR.Enabled = false;
            Chk_RTS.Enabled = false;
            Chk_CD.Enabled = true;
            GBox_RxControl.Enabled = false;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("프로그램을 종료 하시겠습니까?", "RF D&C", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                try
                {
                    if (serialPort1.IsOpen)
                    {
                        Chk_RxASC.Checked = false;
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
                Btn_OPEN.Enabled = false;
                Btn_CLOSE.Enabled = true;
                Chk_CTS.Enabled = false;
                Chk_DSR.Enabled = false;
                Chk_DTR.Enabled = true;
                Chk_RTS.Enabled = true;
                Chk_CD.Enabled = false;
                Chk_RxASC.Checked = true;
                GBox_RxControl.Enabled = true;
                progressBar1.Value = 100;

                if (serialPort1.CtsHolding)
                {
                    Chk_CTS.Checked = true;
                }
                if (serialPort1.DsrHolding)
                {
                    Chk_DSR.Checked = true;
                }
                if (serialPort1.CDHolding)
                {
                    Chk_CD.Checked = true;
                }
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
                Chk_RxASC.Checked = false;
                serialPort1.DiscardOutBuffer();
                serialPort1.Dispose();
                serialPort1.Close();
            }
            Btn_OPEN.Enabled = true;
            Btn_CLOSE.Enabled = false;
            CBoxCOMPORT.Enabled = true;
            CBoxBaudRate.Enabled = true;
            Chk_DTR.Enabled = false;
            Chk_RTS.Enabled = false;
            GBox_RxControl.Enabled = false;
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
            if (serialPort1.IsOpen)
            {
                if (Chk_RxASC.Checked)
                {
                    dataIN = serialPort1.ReadExisting();
                    dataINLength = dataIN.Length;
                    this.BeginInvoke(new EventHandler(ShowData_TBoxDataIN));
                }
                else if (Chk_RxHex.Checked)
                {
                    //기본예제--------------------------------------------------------//
                    //List<int> DataBuffer = new List<int>();

                    //while (serialPort1.BytesToRead > 0)
                    //{
                    //    try
                    //    {
                    //        DataBuffer.Add(serialPort1.ReadByte());
                    //    }
                    //    catch (Exception error)
                    //    {
                    //        MessageBox.Show(error.Message);
                    //    }
                    //}

                    //dataINLength = DataBuffer.Count();
                    ////dataInTemp = new int[dataINLength];
                    //dataInTemp = DataBuffer.ToArray();

                    //dataIN = RxDataFormat(dataInTemp);

                    //this.BeginInvoke(new EventHandler(ShowData_TBoxDataIN));

                    //RawDataParsing(dataInTemp);

                    //옛날에 작업한 내용--------------------------------------------------------//

                    //byte[] array = new byte[2048];
                    //int ReadByteCount;
                    //string str = string.Empty;
                    //ReadByteCount = serialPort1.Read(array, 0, 2048);
                    //for (int i = 0; i < ReadByteCount; i++)
                    //{
                    //    str += string.Format(i + "="+ "{0:x2} ", array[i]);
                    //}
                    //dataIN = str;

                    //this.BeginInvoke(new EventHandler(ShowData_TBoxDataIN));

                    //병현이가 도와준 작업-----------------------------------------------------------//

                    //int[] sync = new int[2];
                    //sync[0] = this.ReadByte(); // 0x03
                    //sync[1] = this.ReadByte(); // 0x15
                    //List<int> DataBuffer = new List<int>();

                    //if (sync[0] == 0x03 && sync[1] == 0x15)
                    //{
                    //    // go
                    //    int id = this.ReadByte();

                    //    int[] raw_size = new int[2];
                    //    raw_size[0] = this.ReadByte();
                    //    raw_size[1] = this.ReadByte();
                    //    int tot_size = (raw_size[0] << 8) | raw_size[1];

                    //    try
                    //    {
                    //        while (tot_size > 0)
                    //        {
                    //            DataBuffer.Add(this.ReadByte());
                    //            tot_size--;
                    //        }
                    //    }
                    //    catch (Exception excep)
                    //    {
                    //        // no data to read
                    //        MessageBox.Show(excep.ToString());
                    //    }
                    //}
                    //else
                    //{
                    //    // do something error
                    //    MessageBox.Show("Sync id not correct.");
                    //}
                    //MessageBox.Show("End");

                    //디스플레이 동시에 파싱------------------------------------------------------//
                    if(serialPort1.BytesToRead > 0)
                    {
                        int[] sync = new int[2];
                        int[] id = new int[1];

                        sync[0] = this.ReadByte(); // 0x03
                        sync[1] = this.ReadByte(); // 0x15
                        id[0] = this.ReadByte(); // 0x01, 0x02

                        List<int> DataBuffer_Raw = new List<int>();
                        List<int> DataBuffer_FFT = new List<int>();

                        if (sync[0] == 0x03 && sync[1] == 0x15)
                        {
                            if(id[0] == 0x01)
                            {
                                int[] raw_size = new int[2];
                                raw_size[0] = this.ReadByte();
                                raw_size[1] = this.ReadByte();
                                int tot_size = (raw_size[0] << 8) | raw_size[1];

                                try
                                {
                                    while (tot_size > 0)
                                    {
                                        DataBuffer_Raw.Add(this.ReadByte());
                                        tot_size--;
                                    }
                                }
                                catch (Exception excep)
                                {
                                    // no data to read
                                    MessageBox.Show(excep.ToString());
                                }
                                RawIntDataArray = DataBuffer_Raw.ToArray();
                            }

                            if(id[0] == 0x02)
                            {
                                int[] raw_size = new int[2];
                                raw_size[0] = this.ReadByte();
                                raw_size[1] = this.ReadByte();
                                int tot_size = (raw_size[0] << 8) | raw_size[1];

                                try
                                {
                                    while (tot_size > 0)
                                    {
                                        DataBuffer_FFT.Add(this.ReadByte());
                                        tot_size--;
                                    }
                                }
                                catch (Exception excep)
                                {
                                    // no data to read
                                    MessageBox.Show(excep.ToString());
                                }
                                FFTIntDataArray = DataBuffer_FFT.ToArray();
                            }
                        }
                        else
                        {
                            // do something error
                            //MessageBox.Show("Sync id not correct.");
                        }
                        //MessageBox.Show("End");
                        //dataIN = RxDataFormat(RawDataArray);
                        //this.BeginInvoke(new EventHandler(ShowData_TBoxDataIN));
                    }
                }
            }
        }

        /* =====================================*/
        /*                               Rx Control Setting                              */
        /* =====================================*/
        private void ShowData_TBoxDataIN(object sneder, EventArgs e)
        {
            try
            {
                Lb_RxDataOutLength.Text = string.Format("{0:00}", dataINLength);

                if (Chk_AlwaysUpdate.Checked)
                {
                    Chk_AddToOldData.Checked = false;
                    TBoxDataIN.Text = dataIN;
                }
                else if (Chk_AddToOldData.Checked)
                {
                    Chk_AlwaysUpdate.Checked = false;
                    TBoxDataIN.AppendText(System.Environment.NewLine);
                    TBoxDataIN.AppendText(dataIN);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Chk_AlwaysUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_AlwaysUpdate.Checked)
            {
                Chk_AlwaysUpdate.Checked = true;
                Chk_AddToOldData.Checked = false;
            }
            else
            {
                Chk_AddToOldData.Checked = true;
            }
        }

        private void Chk_AddToOldData_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_AddToOldData.Checked)
            {
                Chk_AlwaysUpdate.Checked = false;
                Chk_AddToOldData.Checked = true;
            }
            else
            {
                Chk_AlwaysUpdate.Checked = true;
            }
        }

        private void Chk_RxASC_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_RxASC.Checked)
            {
                Chk_RxASC.Checked = true;
                Chk_RxHex.Checked = false;
            }
            else
            {
                Chk_RxHex.Checked = true;
            }
        }

        private void Chk_RxHex_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_RxHex.Checked)
            {
                Chk_RxASC.Checked = false;
                Chk_RxHex.Checked = true;
            }
            else
            {
                Chk_RxASC.Checked = true;
            }
        }

        private void Btn_ClearDataIN_Click(object sender, EventArgs e)
        {
            if (TBoxDataIN.Text != "")
            {
                TBoxDataIN.Text = "";
            }
        }

        private int ReadByte()
        {
            int trial = 50;
            while (trial > 0) // 시도 회수가 아직 남아 잇는지
            {
                if (serialPort1.BytesToRead > 0) // 현재 버퍼에서 읽을 수 있는지
                {
                    return serialPort1.ReadByte(); // 버퍼에서 1바이트 리드
                }
                Thread.Sleep(1);
                trial--; // 시도회수 감소
            }
            if (trial == 0)
            {
                MessageBox.Show("데이터가 없습니다.");
                //throw new Exception("trial has been to zero"); // 시도회수를 모두 썼음에도 읽을 수 없었다면 에러
            }
            return 0;
        }

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
            chart1.Series["Series1"].Points.Clear();

            for (int i = 0; i < Samples; i++)
            {
                RawIntArray[i] = RawIntDataArray[i];
            }

            for (int i = 0; i < Samples; i++)
            {
                chart1.Series["Series1"].Points.AddXY(i, RawIntArray[i]);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            chart2.Series["Series1"].Points.Clear();

            for (int i = 0; i < Samples * 4; i++)
            {
                FFTByteArray[i] = (byte)FFTIntDataArray[i];
            }

            for (int i = 0; i < Samples; i++)
            {
                FFTFloatArray[i] = BitConverter.ToSingle(FFTByteArray, i * 4);
            }

            for (int i = 2; i < Samples / 2; i++)
            {
                chart2.Series["Series1"].Points.AddXY(i, FFTFloatArray[i]);
            }
        }
    }
}
