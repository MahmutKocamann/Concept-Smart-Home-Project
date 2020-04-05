namespace SmartHome
{
    partial class DOOR_PANEL
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
            this.kap_cmb1 = new System.Windows.Forms.ComboBox();
            this.kap_cmb2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kap_pcr2 = new System.Windows.Forms.PictureBox();
            this.kap_pcr1 = new System.Windows.Forms.PictureBox();
            this.kap_btn1 = new System.Windows.Forms.Button();
            this.kap_btn2 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kap_pcr2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kap_pcr1)).BeginInit();
            this.SuspendLayout();
            // 
            // kap_cmb1
            // 
            this.kap_cmb1.FormattingEnabled = true;
            this.kap_cmb1.Location = new System.Drawing.Point(16, 28);
            this.kap_cmb1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kap_cmb1.Name = "kap_cmb1";
            this.kap_cmb1.Size = new System.Drawing.Size(125, 21);
            this.kap_cmb1.TabIndex = 0;
            // 
            // kap_cmb2
            // 
            this.kap_cmb2.FormattingEnabled = true;
            this.kap_cmb2.Location = new System.Drawing.Point(16, 68);
            this.kap_cmb2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kap_cmb2.Name = "kap_cmb2";
            this.kap_cmb2.Size = new System.Drawing.Size(125, 21);
            this.kap_cmb2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(136, 312);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(580, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "SOMEONE IS RINGING DOOR BELL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // kap_pcr2
            // 
            this.kap_pcr2.Location = new System.Drawing.Point(16, 113);
            this.kap_pcr2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kap_pcr2.Name = "kap_pcr2";
            this.kap_pcr2.Size = new System.Drawing.Size(135, 139);
            this.kap_pcr2.TabIndex = 3;
            this.kap_pcr2.TabStop = false;
            // 
            // kap_pcr1
            // 
            this.kap_pcr1.Location = new System.Drawing.Point(200, 28);
            this.kap_pcr1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kap_pcr1.Name = "kap_pcr1";
            this.kap_pcr1.Size = new System.Drawing.Size(406, 236);
            this.kap_pcr1.TabIndex = 4;
            this.kap_pcr1.TabStop = false;
            // 
            // kap_btn1
            // 
            this.kap_btn1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.kap_btn1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kap_btn1.ForeColor = System.Drawing.Color.Maroon;
            this.kap_btn1.Location = new System.Drawing.Point(182, 352);
            this.kap_btn1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kap_btn1.Name = "kap_btn1";
            this.kap_btn1.Size = new System.Drawing.Size(172, 68);
            this.kap_btn1.TabIndex = 5;
            this.kap_btn1.Text = "OPEN THE DOOR";
            this.kap_btn1.UseVisualStyleBackColor = false;
            this.kap_btn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kap_btn2
            // 
            this.kap_btn2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.kap_btn2.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kap_btn2.ForeColor = System.Drawing.Color.Maroon;
            this.kap_btn2.Location = new System.Drawing.Point(424, 352);
            this.kap_btn2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kap_btn2.Name = "kap_btn2";
            this.kap_btn2.Size = new System.Drawing.Size(200, 68);
            this.kap_btn2.TabIndex = 6;
            this.kap_btn2.Text = "CLOSE THE DOOR";
            this.kap_btn2.UseVisualStyleBackColor = false;
            this.kap_btn2.Click += new System.EventHandler(this.kap_btn2_Click);
            // 
            // DOOR_PANEL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(776, 430);
            this.Controls.Add(this.kap_btn2);
            this.Controls.Add(this.kap_btn1);
            this.Controls.Add(this.kap_pcr1);
            this.Controls.Add(this.kap_pcr2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kap_cmb2);
            this.Controls.Add(this.kap_cmb1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DOOR_PANEL";
            this.Text = "DOOR BELL PANEL";
            this.Load += new System.EventHandler(this.Kapı_Paneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kap_pcr2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kap_pcr1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox kap_cmb1;
        private System.Windows.Forms.ComboBox kap_cmb2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox kap_pcr2;
        private System.Windows.Forms.PictureBox kap_pcr1;
        private System.Windows.Forms.Button kap_btn1;
        private System.Windows.Forms.Button kap_btn2;
        private System.IO.Ports.SerialPort serialPort1;
    }
}