namespace SmartHome
{
    partial class GARAGE_PANEL
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
            this.grj_pcr1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grj_btn1 = new System.Windows.Forms.Button();
            this.grj_btn2 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grj_pcr1)).BeginInit();
            this.SuspendLayout();
            // 
            // grj_pcr1
            // 
            this.grj_pcr1.Location = new System.Drawing.Point(25, 32);
            this.grj_pcr1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grj_pcr1.Name = "grj_pcr1";
            this.grj_pcr1.Size = new System.Drawing.Size(152, 158);
            this.grj_pcr1.TabIndex = 0;
            this.grj_pcr1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(225, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "BARRICADE PANEL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // grj_btn1
            // 
            this.grj_btn1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.grj_btn1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grj_btn1.ForeColor = System.Drawing.Color.Maroon;
            this.grj_btn1.Location = new System.Drawing.Point(98, 248);
            this.grj_btn1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grj_btn1.Name = "grj_btn1";
            this.grj_btn1.Size = new System.Drawing.Size(187, 70);
            this.grj_btn1.TabIndex = 2;
            this.grj_btn1.Text = "OPEN THE BARRICADE";
            this.grj_btn1.UseVisualStyleBackColor = false;
            this.grj_btn1.Click += new System.EventHandler(this.grj_btn1_Click);
            // 
            // grj_btn2
            // 
            this.grj_btn2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.grj_btn2.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grj_btn2.ForeColor = System.Drawing.Color.Maroon;
            this.grj_btn2.Location = new System.Drawing.Point(360, 248);
            this.grj_btn2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grj_btn2.Name = "grj_btn2";
            this.grj_btn2.Size = new System.Drawing.Size(187, 70);
            this.grj_btn2.TabIndex = 3;
            this.grj_btn2.Text = "CLOSE THE BARRICADE";
            this.grj_btn2.UseVisualStyleBackColor = false;
            this.grj_btn2.Click += new System.EventHandler(this.grj_btn2_Click);
            // 
            // GARAGE_PANEL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(643, 386);
            this.Controls.Add(this.grj_btn2);
            this.Controls.Add(this.grj_btn1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grj_pcr1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GARAGE_PANEL";
            this.Text = "GARAGE PANEL";
            this.Load += new System.EventHandler(this.Garaj_Paneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grj_pcr1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox grj_pcr1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button grj_btn1;
        private System.Windows.Forms.Button grj_btn2;
        private System.IO.Ports.SerialPort serialPort1;
    }
}