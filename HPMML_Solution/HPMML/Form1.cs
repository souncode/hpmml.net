using S7.Net;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using DirectShowLib;
using System.Threading;
using System.IO.Ports;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Drawing2D;

namespace HPMML
{
    public partial class Dashboard : Form
    {
   
        #region Struct
        struct Video_Device
        {

            public string Device_Name;
            public int Device_ID;
            public Guid Identifier;


            public Video_Device(int ID, string Name, Guid Identity = new Guid())
            {
                Device_ID = ID;
                Device_Name = Name;
                Identifier = Identity;
            }

            public override string ToString()
            {
                return String.Format("[{0}] {1}: {2}", Device_ID, Device_Name, Identifier);
            }
        }
        #endregion

        #region Variables
        SerialPort serialPort = new SerialPort();
        const string plcIP = "192.168.0.11";
        const string arduinoPort = "COM3";
        bool isAlarm;
        bool isPass;
        float failVl;
        float passVl;
        int passCount = 0;
        int failCount = 0;
        int charCount;
        private Plc plc;
        int charLimit;
        bool lockC;
        Bitmap currentFrame;
        Bitmap TempFrame;
        private VideoCapture _capture;
        Rectangle selectionRect = new Rectangle();
        System.Drawing.Point startPoint;
        Video_Device[] WebCams;
        public Dashboard()
        {
            InitializeComponent();
            SetRoundForm();
        }
        #endregion

        #region Function
        private void SetRoundForm()
        {
            GraphicsPath formShape = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            int radius = 20;
            int diameter = radius * 2;

            // Vẽ các góc mềm mại của form
            formShape.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90); // Top left corner
            formShape.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90); // Top right corner
            formShape.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90); // Bottom right corner
            formShape.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90); // Bottom left corner
            formShape.CloseFigure();

            // Gán hình dạng đã tạo cho form
            this.Region = new Region(formShape);
        }
        void getDevice()
        {
            DsDevice[] _SystemCamereas = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);
            WebCams = new Video_Device[_SystemCamereas.Length];
            for (int i = 0; i < _SystemCamereas.Length; i++)
            {
                WebCams[i] = new Video_Device(i, _SystemCamereas[i].Name, _SystemCamereas[i].ClassID);
                cbDevices.Items.Add(WebCams[i].ToString());
            }
            if (cbDevices.Items.Count > 0)
            {
                cbDevices.SelectedIndex = 1;
            }
        }
        void disableBtn(bool en)
        {
            btnProcess.Enabled = !en;
            btnTrigger.Enabled = !en;
            btnStart.Enabled = !en;
            btnHome.Enabled = !en;
            btnMonitor.Enabled = !en;
            btnSetting.Enabled = !en;
            btnControl.Enabled = !en;
        }
        void connectPLC()
        {
            plc = new Plc(CpuType.S71500, plcIP, 0, 0);
            plc.Open();
            string plcIp = plc.IP;
            cbPlc.Text = plcIp;
            if (plc.IsConnected)
            {
                MessageBox.Show("PLC Connected");
            }
            else
            {
                MessageBox.Show("Fail to connect to PLC");
            }
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            getDevice();
            disableBtn(true);
           pbResult.Location = new Point(0, 0);
            pbResult.BackColor = Color.Transparent;


        }
        private void ProcessFrame(object sender, EventArgs e)
        {
            Mat frame = new Mat();
            _capture.Retrieve(frame);
            Image<Rgba, byte> image = frame.ToImage<Rgba, byte>().Flip(Emgu.CV.CvEnum.FlipType.None);
            currentFrame = image.ToBitmap();
        }
        void connectCamera()
        {
            _capture = new VideoCapture(cbDevices.SelectedIndex);
            _capture.SetCaptureProperty(CapProp.FrameWidth, 2560);
            _capture.SetCaptureProperty(CapProp.FrameHeight, 1440);
            _capture.SetCaptureProperty(CapProp.Fps, 100);
            _capture.ImageGrabbed += ProcessFrame;
            _capture.Start();
            if (_capture.IsOpened)
            {
                MessageBox.Show("Camera Connected");
                btnTrigger.Enabled = true;
            }
            else
            {
                MessageBox.Show("Fail to connect to Camera");
            }
        }
        private void saveImage(bool isPass)
        {

            if (isPass)
            {
                try
                {
                    string currentTime = DateTime.Now.ToString("ddMMyy_hhmmss");
                    pbRaw.Image.Save(@"D:\DataFinal\Pass\" + currentTime + "_Raw" + ".jpg");
                    Console.WriteLine("Saved pass image");
                }
                catch (Exception)
                {
                    MessageBox.Show("Fail to save");
                }
            }
            else
            {
                try
                {
                    string currentTime = DateTime.Now.ToString("ddMMyy_hhmmss");
                    pbRaw.Image.Save(@"D:\DataFinal\Fail\" + currentTime + "_Raw" + ".jpg");
                    Console.WriteLine("Saved fail image");
                }
                catch (Exception)
                {
                    MessageBox.Show("Fail to save");
                }
            }
        }
        private bool getResult(float passp, float failp)
        {
            if (passVl > failVl)
            {
                isPass = true;
                passCount++;
                lbPass.Text = passCount.ToString();
                pbResult.Image = Properties.Resources.pass;
                return true;

            }
            else
            {
                isPass = false;
                failCount++;
                lbFail.Text = failCount.ToString();
                //    btnAlarm.PerformClick();
                pbResult.Image = Properties.Resources.fail;
                return false;

            }
        }

        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }
        private bool readFromPlc(string address)
        {
                object M01 = plc.Read(address);
                bool M01c = Convert.ToBoolean(M01);
                Console.WriteLine(M01c);
                if (M01c)
                {
                    return true;
                }
                else
                {
                    return false;
                } 
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
           
        }

        private void btnTrigger_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentFrame != null)
                {
                    pbRaw.Image = currentFrame;
                }
                else
                {
                    MessageBox.Show("Null");
                }
            }
            catch (Exception)
            {

                MessageBox.Show(e.ToString());
            }
            //  plc.Write("M19.2", 1);
            Thread.Sleep(50);
            // plc.Write("M19.2", 0);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //connectPLC();
            connectCamera();
            disableBtn(false);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timerGetTrigger.Start();
            pbStt.Image = Properties.Resources.run;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {

            getResult(passVl,failVl);
            saveImage(isPass);
        }

        private void timerGetTrigger_Tick(object sender, EventArgs e)
        {
            if (plc.IsConnected)
            {
                if (readFromPlc("M19.1"))
                {
                    //600 O
                    Thread.Sleep(100);
                    btnTrigger.PerformClick();
                }
            }
            else
            {
                Console.WriteLine("PLC not connect");
            }
        }
    }
}
