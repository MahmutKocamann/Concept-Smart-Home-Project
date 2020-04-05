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
namespace SmartHome
{
    public partial class GARAGE_PANEL : Form
    {
        public GARAGE_PANEL()
        {
            InitializeComponent();
        }

        private void grj_btn1_Click(object sender, EventArgs e)
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
                serialPort1.Write("3");
                serialPort1.Close();
            }
        }

        private void Garaj_Paneli_Load(object sender, EventArgs e)
        {
            grj_pcr1.SizeMode = PictureBoxSizeMode.StretchImage;
            grj_pcr1.Image = Image.FromFile(@"C:\Users\gürcan\Desktop\park.jpg");
        }

        private void grj_btn2_Click(object sender, EventArgs e)
        {
            if(!serialPort1.IsOpen)
            {
                serialPort1.PortName = "COM6";
                serialPort1.BaudRate = 9600;
                serialPort1.StopBits = StopBits.One;
                serialPort1.DataBits = 8;
                serialPort1.Parity = Parity.None;
                serialPort1.Handshake = Handshake.None;
                serialPort1.Open();
                serialPort1.Write("2");
                serialPort1.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
