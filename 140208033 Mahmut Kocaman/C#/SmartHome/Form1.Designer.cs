namespace SmartHome
{
    partial class LOGIN
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.acc_txt1 = new System.Windows.Forms.TextBox();
            this.acc_btn1 = new System.Windows.Forms.Button();
            this.acc_pcrb1 = new System.Windows.Forms.PictureBox();
            this.acc_txt2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.acc_pcrb1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(45, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "USER NAME:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(45, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "PASSWORD:";
            // 
            // acc_txt1
            // 
            this.acc_txt1.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.acc_txt1.Location = new System.Drawing.Point(244, 73);
            this.acc_txt1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.acc_txt1.Name = "acc_txt1";
            this.acc_txt1.Size = new System.Drawing.Size(169, 30);
            this.acc_txt1.TabIndex = 2;
            this.acc_txt1.DragLeave += new System.EventHandler(this.acc_txt1_DragLeave);
            // 
            // acc_btn1
            // 
            this.acc_btn1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.acc_btn1.Location = new System.Drawing.Point(197, 219);
            this.acc_btn1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.acc_btn1.Name = "acc_btn1";
            this.acc_btn1.Size = new System.Drawing.Size(178, 56);
            this.acc_btn1.TabIndex = 4;
            this.acc_btn1.Text = "LOGIN";
            this.acc_btn1.UseVisualStyleBackColor = true;
            this.acc_btn1.Click += new System.EventHandler(this.acc_btn1_Click);
            this.acc_btn1.DragLeave += new System.EventHandler(this.acc_txt1_DragLeave);
            // 
            // acc_pcrb1
            // 
            this.acc_pcrb1.Location = new System.Drawing.Point(468, 27);
            this.acc_pcrb1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.acc_pcrb1.Name = "acc_pcrb1";
            this.acc_pcrb1.Size = new System.Drawing.Size(157, 198);
            this.acc_pcrb1.TabIndex = 5;
            this.acc_pcrb1.TabStop = false;
            // 
            // acc_txt2
            // 
            this.acc_txt2.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.acc_txt2.Location = new System.Drawing.Point(244, 128);
            this.acc_txt2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.acc_txt2.Name = "acc_txt2";
            this.acc_txt2.Size = new System.Drawing.Size(169, 30);
            this.acc_txt2.TabIndex = 6;
            this.acc_txt2.UseSystemPasswordChar = true;
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(646, 339);
            this.Controls.Add(this.acc_txt2);
            this.Controls.Add(this.acc_pcrb1);
            this.Controls.Add(this.acc_btn1);
            this.Controls.Add(this.acc_txt1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LOGIN";
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.ACCOUNT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.acc_pcrb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox acc_txt1;
        private System.Windows.Forms.Button acc_btn1;
        private System.Windows.Forms.PictureBox acc_pcrb1;
        private System.Windows.Forms.TextBox acc_txt2;
    }
}

