namespace finalProject.Forms
{
    partial class Notlarım
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
            pnlMainNotlarım = new Panel();
            btnNotGörüntüle = new Button();
            label1 = new Label();
            panel1 = new Panel();
            lblBaşlık = new Label();
            txtBaslik = new TextBox();
            btnNotKaydet = new Button();
            label2 = new Label();
            label4 = new Label();
            pnlTextNotlar = new Panel();
            lblNotGiriniz = new Label();
            txtIcerik = new TextBox();
            pnlMainNotlarım.SuspendLayout();
            panel1.SuspendLayout();
            pnlTextNotlar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMainNotlarım
            // 
            pnlMainNotlarım.BackColor = Color.FromArgb(25, 28, 55);
            pnlMainNotlarım.Controls.Add(btnNotGörüntüle);
            pnlMainNotlarım.Controls.Add(label1);
            pnlMainNotlarım.Controls.Add(panel1);
            pnlMainNotlarım.Controls.Add(btnNotKaydet);
            pnlMainNotlarım.Controls.Add(label2);
            pnlMainNotlarım.Controls.Add(label4);
            pnlMainNotlarım.Controls.Add(pnlTextNotlar);
            pnlMainNotlarım.Dock = DockStyle.Fill;
            pnlMainNotlarım.Location = new Point(0, 0);
            pnlMainNotlarım.Name = "pnlMainNotlarım";
            pnlMainNotlarım.Size = new Size(984, 537);
            pnlMainNotlarım.TabIndex = 0;
            // 
            // btnNotGörüntüle
            // 
            btnNotGörüntüle.BackColor = Color.FromArgb(60, 60, 80);
            btnNotGörüntüle.FlatAppearance.BorderSize = 0;
            btnNotGörüntüle.FlatStyle = FlatStyle.Flat;
            btnNotGörüntüle.ForeColor = Color.Gainsboro;
            btnNotGörüntüle.Location = new Point(101, 412);
            btnNotGörüntüle.Name = "btnNotGörüntüle";
            btnNotGörüntüle.Size = new Size(163, 45);
            btnNotGörüntüle.TabIndex = 14;
            btnNotGörüntüle.Text = "Kayıtlı Notları Gör";
            btnNotGörüntüle.UseVisualStyleBackColor = false;
            btnNotGörüntüle.Click += btnNotGörüntüle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(414, 30);
            label1.Name = "label1";
            label1.Size = new Size(157, 34);
            label1.TabIndex = 13;
            label1.Text = "Not Ekleme";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 45, 70);
            panel1.Controls.Add(lblBaşlık);
            panel1.Controls.Add(txtBaslik);
            panel1.Location = new Point(98, 105);
            panel1.Name = "panel1";
            panel1.Size = new Size(788, 30);
            panel1.TabIndex = 12;
            // 
            // lblBaşlık
            // 
            lblBaşlık.AutoSize = true;
            lblBaşlık.BackColor = Color.FromArgb(45, 45, 70);
            lblBaşlık.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblBaşlık.ForeColor = Color.Gainsboro;
            lblBaşlık.Location = new Point(6, 4);
            lblBaşlık.Name = "lblBaşlık";
            lblBaşlık.Size = new Size(95, 20);
            lblBaşlık.TabIndex = 2;
            lblBaşlık.Text = "Başlık giriniz.";
            // 
            // txtBaslik
            // 
            txtBaslik.BackColor = Color.FromArgb(45, 45, 70);
            txtBaslik.BorderStyle = BorderStyle.FixedSingle;
            txtBaslik.Dock = DockStyle.Fill;
            txtBaslik.ForeColor = Color.WhiteSmoke;
            txtBaslik.Location = new Point(0, 0);
            txtBaslik.Name = "txtBaslik";
            txtBaslik.Size = new Size(788, 27);
            txtBaslik.TabIndex = 0;
            txtBaslik.Click += textBox1_Clicked;
            // 
            // btnNotKaydet
            // 
            btnNotKaydet.BackColor = Color.FromArgb(70, 70, 100);
            btnNotKaydet.FlatAppearance.BorderSize = 0;
            btnNotKaydet.FlatStyle = FlatStyle.Flat;
            btnNotKaydet.ForeColor = Color.WhiteSmoke;
            btnNotKaydet.Location = new Point(723, 412);
            btnNotKaydet.Name = "btnNotKaydet";
            btnNotKaydet.Size = new Size(163, 45);
            btnNotKaydet.TabIndex = 11;
            btnNotKaydet.Text = "Kaydet";
            btnNotKaydet.UseVisualStyleBackColor = false;
            btnNotKaydet.Click += btnNotKaydet_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(90, 373);
            label2.Name = "label2";
            label2.Size = new Size(804, 17);
            label2.TabIndex = 10;
            label2.Text = "-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.Yellow;
            label4.Location = new Point(92, 143);
            label4.Name = "label4";
            label4.Size = new Size(804, 17);
            label4.TabIndex = 9;
            label4.Text = "-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";
            // 
            // pnlTextNotlar
            // 
            pnlTextNotlar.BackColor = Color.FromArgb(55, 55, 80);
            pnlTextNotlar.Controls.Add(lblNotGiriniz);
            pnlTextNotlar.Controls.Add(txtIcerik);
            pnlTextNotlar.Location = new Point(98, 164);
            pnlTextNotlar.Name = "pnlTextNotlar";
            pnlTextNotlar.Size = new Size(788, 209);
            pnlTextNotlar.TabIndex = 0;
            // 
            // lblNotGiriniz
            // 
            lblNotGiriniz.AutoSize = true;
            lblNotGiriniz.BackColor = Color.FromArgb(45, 45, 70);
            lblNotGiriniz.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblNotGiriniz.ForeColor = Color.Gainsboro;
            lblNotGiriniz.Location = new Point(3, 3);
            lblNotGiriniz.Name = "lblNotGiriniz";
            lblNotGiriniz.Size = new Size(205, 23);
            lblNotGiriniz.TabIndex = 1;
            lblNotGiriniz.Text = "Notlarınızı buraya yazınız.";
            // 
            // txtIcerik
            // 
            txtIcerik.BackColor = Color.FromArgb(45, 45, 70);
            txtIcerik.BorderStyle = BorderStyle.FixedSingle;
            txtIcerik.Dock = DockStyle.Fill;
            txtIcerik.ForeColor = Color.WhiteSmoke;
            txtIcerik.Location = new Point(0, 0);
            txtIcerik.Multiline = true;
            txtIcerik.Name = "txtIcerik";
            txtIcerik.ScrollBars = ScrollBars.Horizontal;
            txtIcerik.Size = new Size(788, 209);
            txtIcerik.TabIndex = 0;
            txtIcerik.Click += tboxNotlarım_Clicked;
            // 
            // Notlarım
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 537);
            Controls.Add(pnlMainNotlarım);
            Name = "Notlarım";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Notlarım";
            pnlMainNotlarım.ResumeLayout(false);
            pnlMainNotlarım.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlTextNotlar.ResumeLayout(false);
            pnlTextNotlar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMainNotlarım;
        private Panel pnlTextNotlar;
        protected TextBox txtIcerik;
        private Label lblNotGiriniz;
        private Label label4;
        private Button btnNotKaydet;
        private Label label2;
        private Panel panel1;
        private TextBox txtBaslik;
        private Label lblBaşlık;
        private Label label1;
        private Button btnNotGörüntüle;
    }
}