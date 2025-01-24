namespace finalProject.Forms
{
    partial class testSoruları
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            btnSonraki = new Button();
            lblSoru = new Label();
            radioCevap4 = new RadioButton();
            radioCevap2 = new RadioButton();
            radioCevap3 = new RadioButton();
            radioCevap1 = new RadioButton();
            lblSoruNo = new Label();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1191, 123);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 772);
            panel2.Name = "panel2";
            panel2.Size = new Size(1191, 123);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 123);
            panel3.Name = "panel3";
            panel3.Size = new Size(1191, 649);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(30, 40, 70);
            panel4.Controls.Add(btnSonraki);
            panel4.Controls.Add(lblSoru);
            panel4.Controls.Add(radioCevap4);
            panel4.Controls.Add(radioCevap2);
            panel4.Controls.Add(radioCevap3);
            panel4.Controls.Add(radioCevap1);
            panel4.Controls.Add(lblSoruNo);
            panel4.Location = new Point(63, 92);
            panel4.Name = "panel4";
            panel4.Size = new Size(1065, 464);
            panel4.TabIndex = 0;
            // 
            // btnSonraki
            // 
            btnSonraki.BackColor = Color.FromArgb(70, 70, 100);
            btnSonraki.FlatAppearance.BorderSize = 0;
            btnSonraki.FlatStyle = FlatStyle.Flat;
            btnSonraki.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnSonraki.ForeColor = Color.WhiteSmoke;
            btnSonraki.Location = new Point(868, 384);
            btnSonraki.Name = "btnSonraki";
            btnSonraki.Size = new Size(163, 45);
            btnSonraki.TabIndex = 19;
            btnSonraki.Text = " Sonraki";
            btnSonraki.UseVisualStyleBackColor = false;
            btnSonraki.Click += btnSonraki_Click;
            // 
            // lblSoru
            // 
            lblSoru.AutoSize = true;
            lblSoru.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblSoru.ForeColor = Color.White;
            lblSoru.Location = new Point(137, 81);
            lblSoru.Name = "lblSoru";
            lblSoru.Size = new Size(688, 38);
            lblSoru.TabIndex = 18;
            lblSoru.Text = " Aşağıdakilerden hangisi güçlü bir şifre için uygundur?";
            // 
            // radioCevap4
            // 
            radioCevap4.AutoSize = true;
            radioCevap4.Font = new Font("Verdana", 12F, FontStyle.Bold);
            radioCevap4.ForeColor = Color.White;
            radioCevap4.Location = new Point(155, 334);
            radioCevap4.Name = "radioCevap4";
            radioCevap4.Size = new Size(89, 29);
            radioCevap4.TabIndex = 17;
            radioCevap4.TabStop = true;
            radioCevap4.Text = "1905";
            radioCevap4.UseVisualStyleBackColor = true;
            // 
            // radioCevap2
            // 
            radioCevap2.AutoSize = true;
            radioCevap2.Font = new Font("Verdana", 12F, FontStyle.Bold);
            radioCevap2.ForeColor = Color.White;
            radioCevap2.Location = new Point(155, 224);
            radioCevap2.Name = "radioCevap2";
            radioCevap2.Size = new Size(190, 29);
            radioCevap2.TabIndex = 16;
            radioCevap2.TabStop = true;
            radioCevap2.Text = " melisinsifresi";
            radioCevap2.UseVisualStyleBackColor = true;
            // 
            // radioCevap3
            // 
            radioCevap3.AutoSize = true;
            radioCevap3.Font = new Font("Verdana", 12F, FontStyle.Bold);
            radioCevap3.ForeColor = Color.White;
            radioCevap3.Location = new Point(155, 279);
            radioCevap3.Name = "radioCevap3";
            radioCevap3.Size = new Size(139, 29);
            radioCevap3.TabIndex = 15;
            radioCevap3.TabStop = true;
            radioCevap3.Text = " m2.EK_0";
            radioCevap3.UseVisualStyleBackColor = true;
            // 
            // radioCevap1
            // 
            radioCevap1.AutoSize = true;
            radioCevap1.Font = new Font("Verdana", 12F, FontStyle.Bold);
            radioCevap1.ForeColor = Color.White;
            radioCevap1.Location = new Point(155, 169);
            radioCevap1.Name = "radioCevap1";
            radioCevap1.Size = new Size(124, 29);
            radioCevap1.TabIndex = 14;
            radioCevap1.TabStop = true;
            radioCevap1.Text = " 123456";
            radioCevap1.UseVisualStyleBackColor = true;
            // 
            // lblSoruNo
            // 
            lblSoruNo.AutoSize = true;
            lblSoruNo.Font = new Font("Sitka Display", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            lblSoruNo.ForeColor = Color.Gainsboro;
            lblSoruNo.Location = new Point(26, 18);
            lblSoruNo.Name = "lblSoruNo";
            lblSoruNo.Size = new Size(98, 43);
            lblSoruNo.TabIndex = 13;
            lblSoruNo.Text = "Soru 1";
            // 
            // testSoruları
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 28, 55);
            ClientSize = new Size(1191, 895);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "testSoruları";
            Text = "testSoruları";
            Load += testSoruları_Load;
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button btnSonraki;
        private Label lblSoru;
        private RadioButton radioCevap4;
        private RadioButton radioCevap2;
        private RadioButton radioCevap3;
        private RadioButton radioCevap1;
        private Label lblSoruNo;
    }
}