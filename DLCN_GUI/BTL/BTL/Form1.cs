using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using ZedGraph;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Security.Cryptography;

namespace BTL
{
    public partial class Form1 : Form
    {
        double H1,H2,L1,L2;
        double Sensor1, Sensor2, Thermistor;
        string LH1, LL1, LH2, LL2;

        double nhietdo1;
        double nhietdo2;
        double nhietdo3;
        bool chartON = false;
        // Khai báo biến đồ thị
        private GraphPane myPane;
        private LineItem curve1, curve2, curve3;
        private RollingPointPairList list1 = new RollingPointPairList(60000);
        private RollingPointPairList list2 = new RollingPointPairList(60000);
        private RollingPointPairList list3 = new RollingPointPairList(60000);
        private RollingPointPairList Timelist = new RollingPointPairList(60000);
        List<string> Thoi_Gian = new List<string>();
        private double tickStart;

        // Khởi tại Alarm
        double Alarm1H = 91;
        double Alarm1L = 88;

       
        
        private void btChart_Click(object sender, EventArgs e)
        {
            chartON = true;
            InitChart();
            tickStart = Environment.TickCount;
            list1.Add(0, nhietdo1);
            list2.Add(0, nhietdo2);
            list3.Add(0, nhietdo3);
        }

        double Alarm2H = 91;

        private void cb1s_CheckedChanged(object sender, EventArgs e)
        {
            if (cb1s.Checked)
            {
                cb2s.Checked = false;
                cb5s.Checked = false;
                cb10s.Checked = false;
                timer1.Stop();
                timer1.Interval = 100;
                timer1.Start();
            }
        }

        private void cb2s_CheckedChanged(object sender, EventArgs e)
        {
            if (cb2s.Checked)
            {
                cb1s.Checked = false;
                cb5s.Checked = false;
                cb10s.Checked = false;
                timer1.Stop();
                timer1.Interval = 200;
                timer1.Start();
            }
        }

        private void cb5s_CheckedChanged(object sender, EventArgs e)
        {
            if (cb5s.Checked)
            {
                cb1s.Checked = false;
                cb2s.Checked = false;
                cb10s.Checked = false;
                timer1.Stop();
                timer1.Interval = 500;
                timer1.Start();
            }
        }

        private void cb10s_CheckedChanged(object sender, EventArgs e)
        {
            if (cb10s.Checked)
            {
                cb1s.Checked = false;
                cb2s.Checked = false;
                cb5s.Checked = false;
                timer1.Stop();
                timer1.Interval = 1000;
                timer1.Start();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng Excel
            Excel.Application excel = new Excel.Application();

            // Tạo một workbook mới
            Excel.Workbook workbook = excel.Workbooks.Add(Type.Missing);

            // Tạo một worksheet mới
            Excel.Worksheet worksheet = workbook.ActiveSheet;

            // Gán tiêu đề cho các cột dữ liệu
            worksheet.Cells[1, 1] = "Time";
            worksheet.Cells[1, 2] = "Temperature 1";
            worksheet.Cells[1, 3] = "Temperature 2";
            worksheet.Cells[1, 4] = "Temperature Thermistor";

            // Lấy số lượng dòng dữ liệu hiện có
            int rowCount = Thoi_Gian.Count;

            // Ghi dữ liệu từ 2 list vào worksheet
            for (int i = 0; i < rowCount; i++)
            {
                worksheet.Cells[i + 2, 1] = Thoi_Gian[i];
                worksheet.Cells[i + 2, 2] = list1[i].Y;
                worksheet.Cells[i + 2, 3] = list2[i].Y;
                worksheet.Cells[i + 2, 4] = list3[i].Y;
            }

            // Lưu file Excel và đóng workbook và application
            string filePath = "C:\\Users\\Nguyen\\Desktop\\DLCN_L02_BTL\\TemperatureData.xlsx"; 
            workbook.SaveAs(filePath);
            workbook.Close();
            excel.Quit();

            // Hiển thị thông báo khi xuất file Excel thành công
            MessageBox.Show("Data exported to " + filePath, "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        double Alarm2L = 88;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!cb_Enable_Alarm1.Checked) { LH1 = "A0"; LL1 = "B0"; }
            if (!cb_Enable_Alarm2.Checked) { LH2 = "C0"; LL2 = "D0"; }

            serialPort1.Write(LH1 + LL1 + LH2 + LL2);
            nhietdo1 = Sensor1;
            nhietdo2 = Sensor2;
            nhietdo3 = Thermistor;
            Output_1.Text = Sensor1.ToString() + "℃";
            Output_2.Text = Sensor2.ToString() + "℃";
            Data_Received.Text = Thermistor.ToString() + "℃";
            if (chartON)
            {
                // Cập nhật giá trị nhiệt độ mới
                double time = (Environment.TickCount - tickStart) / 1000.0;
                Thoi_Gian.Add(DateTime.Now.ToString());
                list1.Add(time, nhietdo1);
                list2.Add(time, nhietdo2);
                list3.Add(time, nhietdo3);
                if (list1.Count > 60000)
                    list1.RemoveAt(0);
                if (list2.Count > 60000)
                    list2.RemoveAt(0);
                if (list3.Count > 60000)
                    list3.RemoveAt(0);
                // Cập nhật đồ thị
                if (myPane != null && myPane.XAxis != null && myPane.XAxis.Scale != null)
                {
                    myPane.XAxis.Scale.Max = time;
                }
                if (myPane != null && myPane.YAxis != null && myPane.YAxis.Scale != null)
                {
                    myPane.YAxis.Scale.Max = Math.Max(nhietdo1, nhietdo2) + 10;
                }
                zedGraphControl1.AxisChange();
                zedGraphControl1.Invalidate();
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            serialPort1.PortName = "COM7";
            serialPort1.BaudRate = 9600;
            serialPort1.Parity = System.IO.Ports.Parity.None;
            serialPort1.DataBits = 8;
            serialPort1.StopBits = System.IO.Ports.StopBits.One;


        }
        private void OPEN_Click(object sender, EventArgs e)
        {
            cb1s.Checked = true;
            if (serialPort1.IsOpen == false)
            {
                serialPort1.Open();
                OPEN.ForeColor = Color.Green;
                AlarmH1.FillColor = Color.Green;
                AlarmH2.FillColor = Color.Green;
                AlarmL1.FillColor = Color.Green;
                AlarmL2.FillColor = Color.Green;
                timer1.Enabled = true;
                timer1.Interval = 100;
            }
        }

        private void CLOSE_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();
                OPEN.ForeColor = Color.Black;
                AlarmH1.FillColor = Color.Black;
                AlarmH2.FillColor = Color.Black;
                AlarmL1.FillColor = Color.Black;
                AlarmL2.FillColor = Color.Black;
                timer1.Enabled= false;
            }
        }

        private void InitChart()
        {
            // Khởi tạo đồ thị
            myPane = zedGraphControl1.GraphPane;
            myPane.Title.Text = "Đồ thị nhiệt độ theo thời gian";
            myPane.XAxis.Title.Text = "Thời gian (s)";
            myPane.YAxis.Title.Text = "Nhiệt độ (°C)";
            curve1 = myPane.AddCurve("Nhiệt độ 1", list1, System.Drawing.Color.Red, SymbolType.None);
            curve2 = myPane.AddCurve("Nhiệt độ 2", list2, System.Drawing.Color.Blue, SymbolType.None);
            curve3 = myPane.AddCurve("Nhiệt độ 3", list3, System.Drawing.Color.Orange, SymbolType.None);
            myPane.XAxis.Scale.Min = 0;
            myPane.XAxis.Scale.Max = 30;
            myPane.YAxis.Scale.Min = 20;
            myPane.YAxis.Scale.Max = 30;
            zedGraphControl1.AxisChange();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                L1 = double.Parse(ThresL1.Text);
                L2 = double.Parse(ThresL2.Text);
                H1 = double.Parse(ThresH1.Text);
                H2 = double.Parse(ThresH2.Text);
                string Received_Value = serialPort1.ReadLine();
                Console.WriteLine(Received_Value);
                if (Received_Value.Length >= 15)
                {
                    string output_0 = Received_Value.Substring(3, 4);
                    string output_1 = Received_Value.Substring(7, 4);
                    string output_2 = Received_Value.Substring(11, 4);
                    byte[] STX = ASCIIEncoding.ASCII.GetBytes(output_2);
                    if (output_0.Length == 4)
                    {
                        try
                        {
                            double ther25 = 5.0;
                            double beta = 3950.0;
                            double R1 = 5.1;
                            double offset = 1.4;
                            double ther_vol = double.Parse(output_0);
                            ther_vol /= 1000.0;
                            ther_vol -= offset;
                            double ther_res = R1/(5.0/ther_vol - 1);
                            double ther_temp = System.Math.Log(ther_res / ther25)/beta + 1/(25+273.15);
                            ther_temp = 1 / ther_temp - 273.15;
                            Thermistor = Math.Round(ther_temp, 1);
                        }
                        catch { }
                    }
                    if (output_1.Length == 4)
                    {
                        try
                        {
                            Sensor1 = double.Parse(output_1);
                            Sensor1 /= 10.0;
                            Sensor1 -= 53.5;
                        }
                        catch { }
                    }
                    if (output_2.Length == 4)
                    {
                        try
                        {
                            Sensor2 = double.Parse(output_2);
                            Sensor2 /= 10.0;
                            Sensor2 -= 20.0;
                        }
                        catch { }
                    }
                    if (L1 > Sensor1)
                    {
                        if (cb_Enable_Alarm1.Checked)
                        {
                            AlarmL1.FillColor = Color.Red;
                        }
                        else AlarmL1.FillColor = Color.Black;
                        LL1 = "B1";
                    }
                    else
                    {
                        if (cb_Enable_Alarm1.Checked)
                        {
                            AlarmL1.FillColor = Color.Green;
                        }
                        else AlarmL1.FillColor = Color.Black;
                        LL1 = "B0";
                    }
                    if (H2 < Sensor2)
                    {
                        if (cb_Enable_Alarm2.Checked)
                        {
                            AlarmH2.FillColor = Color.Red;
                        }
                        else AlarmH2.FillColor = Color.Black;
                        LH2 = "C1";
                    }
                    else
                    {
                        if (cb_Enable_Alarm2.Checked)
                        {
                            AlarmH2.FillColor = Color.Green;
                        }
                        else AlarmH2.FillColor = Color.Black;
                        LH2 = "C0";
                    }
                    if (L2 > Sensor2)
                    {
                        if (cb_Enable_Alarm2.Checked)
                        {
                            AlarmL2.FillColor = Color.Red;
                        }
                        else AlarmL2.FillColor = Color.Black;
                        LL2 = "D1";
                    }
                    else
                    {
                        if (cb_Enable_Alarm2.Checked)
                        {
                            AlarmL2.FillColor = Color.Green;
                        }
                        else AlarmL2.FillColor = Color.Black;
                        LL2 = "D0";
                    }
                    if (H1 < Sensor1)
                    {
                        if (cb_Enable_Alarm1.Checked)
                        {
                            AlarmH1.FillColor = Color.Red;
                        }
                        else AlarmH1.FillColor = Color.Black;
                        LH1 = "A1";
                    }
                    else
                    {
                        if (cb_Enable_Alarm1.Checked)
                        {
                            AlarmH1.FillColor = Color.Green;
                        }
                        else AlarmH1.FillColor = Color.Black;
                        LH1 = "A0";
                    }
                }
            }
            catch (TimeoutException)
            {
                MessageBox.Show("There was an error!");
            }
        }
    }
}
