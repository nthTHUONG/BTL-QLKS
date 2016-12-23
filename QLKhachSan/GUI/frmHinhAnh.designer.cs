namespace GUI
{
    partial class frmHinhAnh
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
            this.btP001 = new System.Windows.Forms.Button();
            this.lbHH = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picV = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picV)).BeginInit();
            this.SuspendLayout();
            // 
            // btP001
            // 
            this.btP001.BackColor = System.Drawing.Color.DarkGray;
            this.btP001.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btP001.Location = new System.Drawing.Point(12, 137);
            this.btP001.Name = "btP001";
            this.btP001.Size = new System.Drawing.Size(91, 38);
            this.btP001.TabIndex = 0;
            this.btP001.Text = "P001";
            this.btP001.UseVisualStyleBackColor = false;
            this.btP001.Click += new System.EventHandler(this.btP001_Click);
            // 
            // lbHH
            // 
            this.lbHH.BackColor = System.Drawing.Color.DarkGray;
            this.lbHH.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHH.ForeColor = System.Drawing.Color.Maroon;
            this.lbHH.Location = new System.Drawing.Point(0, 0);
            this.lbHH.Name = "lbHH";
            this.lbHH.Size = new System.Drawing.Size(644, 74);
            this.lbHH.TabIndex = 1;
            this.lbHH.Text = " HÌNH ẢNH PHÒNG";
            this.lbHH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picV
            // 
            this.picV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picV.Dock = System.Windows.Forms.DockStyle.Right;
            this.picV.Location = new System.Drawing.Point(147, 74);
            this.picV.Name = "picV";
            this.picV.Size = new System.Drawing.Size(497, 364);
            this.picV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picV.TabIndex = 2;
            this.picV.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(7, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã phòng:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmHinhAnh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(644, 438);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picV);
            this.Controls.Add(this.lbHH);
            this.Controls.Add(this.btP001);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmHinhAnh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHinhAnh";
            this.Load += new System.EventHandler(this.frmHinhAnh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btP001;
        private System.Windows.Forms.Label lbHH;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picV;
        private System.Windows.Forms.Label label1;
    }
}