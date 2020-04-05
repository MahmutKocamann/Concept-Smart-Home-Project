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
using AForge.Video;
using AForge.Video.DirectShow;
using AForge;
namespace SmartHome
{
    public partial class DOOR_PANEL : Form
    {
        private FilterInfoCollection VideoCaptureDevices;

        private VideoCaptureDevice FinalVideo;
        public DOOR_PANEL()
        {
            InitializeComponent();
            #region Get attached cameras
            VideoCaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo VideoCaptureDevice in VideoCaptureDevices)
            {
                kap_cmb1.Items.Add(VideoCaptureDevice.Name);
            }
            kap_cmb1.Visible = false;
            kap_cmb2.Visible = false;
            kap_cmb1.SelectedIndex = 1;
            #endregion

            #region Gets supported modes

            FinalVideo = new VideoCaptureDevice(VideoCaptureDevices[kap_cmb1.SelectedIndex].MonikerString);
            foreach (var capability in FinalVideo.VideoCapabilities)
            {
                kap_cmb2.Items.Add(capability.FrameSize.ToString() + ":" + capability.MaximumFrameRate.ToString() + ":" + capability.BitCount.ToString());

            }
            kap_cmb2.SelectedIndex = 9;
            #endregion
            FinalVideo.NewFrame += new NewFrameEventHandler(FinalVideo_NewFrame);
        }
        private void FinalVideo_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            if (kap_pcr1.Image != null)
            {
                kap_pcr1.Image.Dispose();
            }
            Bitmap tempBitmap = (Bitmap)eventArgs.Frame.Clone();
            kap_pcr1.Image = tempBitmap;

        }
        private void Kapı_Paneli_Load(object sender, EventArgs e)
        {
            FinalVideo.VideoResolution = FinalVideo.VideoCapabilities[kap_cmb2.SelectedIndex];
            this.Width = FinalVideo.VideoResolution.FrameSize.Width + 150;
            this.Height = FinalVideo.VideoResolution.FrameSize.Height + 170;
            this.kap_pcr1.Width = FinalVideo.VideoResolution.FrameSize.Width - 270;
            this.kap_pcr1.Height = FinalVideo.VideoResolution.FrameSize.Height - 70;
            FinalVideo.Start();
            kap_pcr2.SizeMode = PictureBoxSizeMode.StretchImage;
            kap_pcr2.Image = Image.FromFile(@"C:\Users\gürcan\Desktop\zill.jpg");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                serialPort1.PortName = "COM6";
                serialPort1.BaudRate = 9600;
                serialPort1.StopBits = StopBits.One;
                serialPort1.DataBits = 8;
                serialPort1.Parity = Parity.None;
                serialPort1.Handshake = Handshake.None;
                serialPort1.Open();
                serialPort1.Write("5");
                serialPort1.Close();
            }
        }

        private void kap_btn2_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                serialPort1.PortName = "COM6";
                serialPort1.BaudRate = 9600;
                serialPort1.StopBits = StopBits.One;
                serialPort1.DataBits = 8;
                serialPort1.Parity = Parity.None;
                serialPort1.Handshake = Handshake.None;
                serialPort1.Open();
                serialPort1.Write("4");
                serialPort1.Close();
            }
        }
    }
}
