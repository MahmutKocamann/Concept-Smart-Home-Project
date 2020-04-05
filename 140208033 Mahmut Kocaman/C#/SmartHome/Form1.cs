using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartHome
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void ACCOUNT_Load(object sender, EventArgs e)
        {
            acc_pcrb1.SizeMode = PictureBoxSizeMode.StretchImage;
            acc_pcrb1.Image = Image.FromFile(@"C:\Users\gürcan\Desktop\anahtar.png");
            acc_txt1.Focus();

        }

        private void acc_btn1_Click(object sender, EventArgs e)
        {
            if (acc_txt1.Text == "admin" && acc_txt2.Text == "12345")
            {
                PANEL Control  = new PANEL();
                Control.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Enter!!", "Error", MessageBoxButtons.OK);
                acc_txt1.Clear();
                acc_txt2.Clear();
                acc_txt1.Focus();
            }
        }

        private void acc_txt1_DragLeave(object sender, EventArgs e)
        {

        }
    }
}
