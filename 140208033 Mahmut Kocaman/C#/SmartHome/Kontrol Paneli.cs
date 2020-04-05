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
    public partial class PANEL : Form
    {
        string[] portlar = SerialPort.GetPortNames();
       
        public PANEL()
        {
            InitializeComponent();
        }
        public static string data;
        public static string data2;
        public static string data3;
        public static int s = 0;
        private void knt_cmb1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Kontrol_Paneli_Load(object sender, EventArgs e)
        {
            foreach (string port in portlar)
            {
                knt_cmb1.Items.Add(port);
                knt_cmb1.SelectedIndex = 0;

            }
            knt_cmb2.Items.Add("4800");
            knt_cmb2.Items.Add("9600");
            knt_cmb2.SelectedIndex = 1;
            label4.Text = "Connection Close";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                // string sonuc = serialPort1.ReadExisting();
                string res = serialPort1.ReadLine();
                string[] value = res.Split('*');

                label1.Text = value[0];
                label2.Text = value[1];
                label3.Text = value[2];
                serialPort1.DiscardInBuffer();

                GARAGE_PANEL Garage = new GARAGE_PANEL();
                DOOR_PANEL Door = new DOOR_PANEL();
                RAIN_PANEL Raın = new RAIN_PANEL();
                data = value[0];
             int sonuc2 = Convert.ToInt16(data);
                if (sonuc2 == 1)
                {
                    Door.Show();
                    timer1.Stop();
                   serialPort1.Close();

                }           
                data2 = value[1];
                int sonuc3 = Convert.ToInt16(data2);
                if (sonuc3 < 10)
                {
                    Garage.Show();
                    timer1.Stop();
                  serialPort1.Close();

                }
                data3 = value[2];
                int sonuc4 = Convert.ToInt16(data3);
                if (sonuc4 < 350)
                {
                    if (s == 0)
                    {
                        Raın.Show();
                        timer1.Stop();
                        serialPort1.Close();
                        s++;
                    }
                }



            }
            catch (Exception)
            {
                timer1.Stop();
                

            }
        }

        private void knt_btn1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if(serialPort1.IsOpen == false)
            {
                if (knt_cmb1.Text == "")
                    return;
                serialPort1.PortName = knt_cmb1.Text;
                serialPort1.BaudRate = Convert.ToInt16(knt_cmb2.Text);
                try
                {
                    serialPort1.Open();
                    label4.Text = "Preparing Connection";

                }
                catch (Exception hata)
                {
                    MessageBox.Show("Error" + hata.Message);


                }
            }
            else
            {
                label4.Text = "Connection Established";

            }
        }

        private void knt_btn2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();
                label4.Text = "Connection Closed";
            }
        }

        private void Kontrol_Paneli_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();
            }
        }
    }
    }

