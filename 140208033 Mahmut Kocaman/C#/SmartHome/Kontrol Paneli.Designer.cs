namespace SmartHome
{
    partial class PANEL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.knt_btn1 = new System.Windows.Forms.Button();
            this.knt_btn2 = new System.Windows.Forms.Button();
            this.knt_cmb1 = new System.Windows.Forms.ComboBox();
            this.knt_cmb2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // knt_btn1
            // 
            this.knt_btn1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.knt_btn1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.knt_btn1.ForeColor = System.Drawing.Color.Maroon;
            this.knt_btn1.Location = new System.Drawing.Point(46, 37);
            this.knt_btn1.Name = "knt_btn1";
            this.knt_btn1.Size = new System.Drawing.Size(288, 117);
            this.knt_btn1.TabIndex = 0;
            this.knt_btn1.Text = "CONNECTED TO SYSTEM";
            this.knt_btn1.UseVisualStyleBackColor = false;
            this.knt_btn1.Click += new System.EventHandler(this.knt_btn1_Click);
            // 
            // knt_btn2
            // 
            this.knt_btn2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.knt_btn2.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.knt_btn2.ForeColor = System.Drawing.Color.Maroon;
            this.knt_btn2.Location = new System.Drawing.Point(381, 37);
            this.knt_btn2.Name = "knt_btn2";
            this.knt_btn2.Size = new System.Drawing.Size(288, 117);
            this.knt_btn2.TabIndex = 1;
            this.knt_btn2.Text = "STOP CONNECTION TO SYSTEM";
            this.knt_btn2.UseVisualStyleBackColor = false;
            this.knt_btn2.Click += new System.EventHandler(this.knt_btn2_Click);
            // 
            // knt_cmb1
            // 
            this.knt_cmb1.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.knt_cmb1.FormattingEnabled = true;
            this.knt_cmb1.Location = new System.Drawing.Point(46, 197);
            this.knt_cmb1.Name = "knt_cmb1";
            this.knt_cmb1.Size = new System.Drawing.Size(204, 36);
            this.knt_cmb1.TabIndex = 2;
            this.knt_cmb1.SelectedIndexChanged += new System.EventHandler(this.knt_cmb1_SelectedIndexChanged);
            // 
            // knt_cmb2
            // 
            this.knt_cmb2.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.knt_cmb2.FormattingEnabled = true;
            this.knt_cmb2.Location = new System.Drawing.Point(381, 197);
            this.knt_cmb2.Name = "knt_cmb2";
            this.knt_cmb2.Size = new System.Drawing.Size(204, 36);
            this.knt_cmb2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(252, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(251, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(542, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 24);
            this.label3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(374, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 38);
            this.label4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(41, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Doorbell Status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(41, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "Garrage Status:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(376, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 26);
            this.label7.TabIndex = 10;
            this.label7.Text = "Raın Status:";
            // 
            // PANEL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(810, 475);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.knt_cmb2);
            this.Controls.Add(this.knt_cmb1);
            this.Controls.Add(this.knt_btn2);
            this.Controls.Add(this.knt_btn1);
            this.Name = "PANEL";
            this.Text = "PANEL";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Kontrol_Paneli_FormClosed);
            this.Load += new System.EventHandler(this.Kontrol_Paneli_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button knt_btn1;
        private System.Windows.Forms.Button knt_btn2;
        private System.Windows.Forms.ComboBox knt_cmb1;
        private System.Windows.Forms.ComboBox knt_cmb2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}