namespace finalProject.Forms
{
    partial class Profilim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profilim));
            pnlBack = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            panel1 = new Panel();
            PicUserProfile = new PictureBox();
            panel3 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel5 = new Panel();
            pnlBack.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicUserProfile).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBack
            // 
            pnlBack.BackColor = Color.FromArgb(28, 25, 55);
            pnlBack.Controls.Add(panel2);
            pnlBack.Controls.Add(panel1);
            pnlBack.Dock = DockStyle.Fill;
            pnlBack.Location = new Point(0, 0);
            pnlBack.Name = "pnlBack";
            pnlBack.Size = new Size(1209, 684);
            pnlBack.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel5);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(1209, 628);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(45, 45, 70);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(panel3);
            panel4.Controls.Add(PicUserProfile);
            panel4.Location = new Point(417, 16);
            panel4.Name = "panel4";
            panel4.Size = new Size(424, 580);
            panel4.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1209, 56);
            panel1.TabIndex = 0;
            // 
            // PicUserProfile
            // 
            PicUserProfile.Dock = DockStyle.Top;
            PicUserProfile.Image = (Image)resources.GetObject("PicUserProfile.Image");
            PicUserProfile.Location = new Point(0, 0);
            PicUserProfile.Name = "PicUserProfile";
            PicUserProfile.Size = new Size(422, 154);
            PicUserProfile.SizeMode = PictureBoxSizeMode.Zoom;
            PicUserProfile.TabIndex = 5;
            PicUserProfile.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(30, 30, 50);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(42, 153);
            panel3.Name = "panel3";
            panel3.Size = new Size(339, 397);
            panel3.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(14, 129);
            label5.Name = "label5";
            label5.Size = new Size(268, 26);
            label5.TabIndex = 8;
            label5.Text = "Okul:  Amasya Üniversitesi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(14, 175);
            label4.Name = "label4";
            label4.Size = new Size(311, 26);
            label4.TabIndex = 7;
            label4.Text = "Bölüm:  Bilgisayar Mühendisliği";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(14, 217);
            label3.Name = "label3";
            label3.Size = new Size(86, 26);
            label3.TabIndex = 6;
            label3.Text = "Sınıf:  2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(100, 33);
            label1.Name = "label1";
            label1.Size = new Size(136, 26);
            label1.TabIndex = 5;
            label1.Text = "Melisa Köklü";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(10, 0, 8);
            panel5.Location = new Point(411, 11);
            panel5.Name = "panel5";
            panel5.Size = new Size(435, 590);
            panel5.TabIndex = 4;
            // 
            // Profilim
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 684);
            Controls.Add(pnlBack);
            Name = "Profilim";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profilim";
            pnlBack.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PicUserProfile).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBack;
        private Panel panel2;
        private Panel panel1;
        private Panel panel4;
        private Panel panel3;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private PictureBox PicUserProfile;
        private Panel panel5;
    }
}