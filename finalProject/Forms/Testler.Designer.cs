namespace finalProject.Forms
{
    partial class Testler
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
            pnlTestler = new Panel();
            btnChoiseTopics = new FontAwesome.Sharp.IconButton();
            pnlKonuMenu = new Panel();
            bntopsosyalMuhendislik = new Button();
            btnzararliYazilimlar = new Button();
            btnTopAgBilgisi = new Button();
            btnTopSiberGuvenligeGiris = new Button();
            pnlTest = new Panel();
            pnlTestler.SuspendLayout();
            pnlKonuMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTestler
            // 
            pnlTestler.BackColor = Color.FromArgb(0, 60, 15);
            pnlTestler.Controls.Add(btnChoiseTopics);
            pnlTestler.Dock = DockStyle.Top;
            pnlTestler.Location = new Point(0, 0);
            pnlTestler.Name = "pnlTestler";
            pnlTestler.Size = new Size(1209, 54);
            pnlTestler.TabIndex = 0;
            // 
            // btnChoiseTopics
            // 
            btnChoiseTopics.Dock = DockStyle.Left;
            btnChoiseTopics.FlatAppearance.BorderSize = 0;
            btnChoiseTopics.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 40, 5);
            btnChoiseTopics.FlatStyle = FlatStyle.Flat;
            btnChoiseTopics.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnChoiseTopics.ForeColor = Color.WhiteSmoke;
            btnChoiseTopics.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            btnChoiseTopics.IconColor = Color.WhiteSmoke;
            btnChoiseTopics.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnChoiseTopics.IconSize = 22;
            btnChoiseTopics.ImageAlign = ContentAlignment.MiddleRight;
            btnChoiseTopics.Location = new Point(0, 0);
            btnChoiseTopics.Name = "btnChoiseTopics";
            btnChoiseTopics.Padding = new Padding(10, 0, 10, 0);
            btnChoiseTopics.Size = new Size(172, 54);
            btnChoiseTopics.TabIndex = 0;
            btnChoiseTopics.Text = "Konu Seçin ";
            btnChoiseTopics.UseVisualStyleBackColor = true;
            btnChoiseTopics.Click += btnChoiseTopics_Click;
            // 
            // pnlKonuMenu
            // 
            pnlKonuMenu.AutoSize = true;
            pnlKonuMenu.BackColor = Color.FromArgb(0, 45, 0);
            pnlKonuMenu.Controls.Add(bntopsosyalMuhendislik);
            pnlKonuMenu.Controls.Add(btnzararliYazilimlar);
            pnlKonuMenu.Controls.Add(btnTopAgBilgisi);
            pnlKonuMenu.Controls.Add(btnTopSiberGuvenligeGiris);
            pnlKonuMenu.Location = new Point(2, 54);
            pnlKonuMenu.Name = "pnlKonuMenu";
            pnlKonuMenu.Size = new Size(170, 200);
            pnlKonuMenu.TabIndex = 1;
            pnlKonuMenu.Visible = false;
            // 
            // bntopsosyalMuhendislik
            // 
            bntopsosyalMuhendislik.Dock = DockStyle.Top;
            bntopsosyalMuhendislik.FlatAppearance.BorderSize = 0;
            bntopsosyalMuhendislik.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 35, 5);
            bntopsosyalMuhendislik.FlatStyle = FlatStyle.Flat;
            bntopsosyalMuhendislik.ForeColor = Color.WhiteSmoke;
            bntopsosyalMuhendislik.Location = new Point(0, 150);
            bntopsosyalMuhendislik.Name = "bntopsosyalMuhendislik";
            bntopsosyalMuhendislik.Size = new Size(170, 50);
            bntopsosyalMuhendislik.TabIndex = 3;
            bntopsosyalMuhendislik.Text = "Sosyal Mühendislik";
            bntopsosyalMuhendislik.UseVisualStyleBackColor = true;
            bntopsosyalMuhendislik.Click += bntopsosyalMuhendislik_Click;
            // 
            // btnzararliYazilimlar
            // 
            btnzararliYazilimlar.Dock = DockStyle.Top;
            btnzararliYazilimlar.FlatAppearance.BorderSize = 0;
            btnzararliYazilimlar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 35, 5);
            btnzararliYazilimlar.FlatStyle = FlatStyle.Flat;
            btnzararliYazilimlar.ForeColor = Color.WhiteSmoke;
            btnzararliYazilimlar.Location = new Point(0, 100);
            btnzararliYazilimlar.Name = "btnzararliYazilimlar";
            btnzararliYazilimlar.Size = new Size(170, 50);
            btnzararliYazilimlar.TabIndex = 2;
            btnzararliYazilimlar.Text = "Zararlı Yazılımlar";
            btnzararliYazilimlar.UseVisualStyleBackColor = true;
            btnzararliYazilimlar.Click += btnzararliYazilimlar_Click;
            // 
            // btnTopAgBilgisi
            // 
            btnTopAgBilgisi.Dock = DockStyle.Top;
            btnTopAgBilgisi.FlatAppearance.BorderSize = 0;
            btnTopAgBilgisi.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 35, 5);
            btnTopAgBilgisi.FlatStyle = FlatStyle.Flat;
            btnTopAgBilgisi.ForeColor = Color.WhiteSmoke;
            btnTopAgBilgisi.Location = new Point(0, 50);
            btnTopAgBilgisi.Name = "btnTopAgBilgisi";
            btnTopAgBilgisi.Size = new Size(170, 50);
            btnTopAgBilgisi.TabIndex = 1;
            btnTopAgBilgisi.Text = "Ağ Bilgisi";
            btnTopAgBilgisi.UseVisualStyleBackColor = true;
            btnTopAgBilgisi.Click += btnTopAgBilgisi_Click;
            // 
            // btnTopSiberGuvenligeGiris
            // 
            btnTopSiberGuvenligeGiris.Dock = DockStyle.Top;
            btnTopSiberGuvenligeGiris.FlatAppearance.BorderSize = 0;
            btnTopSiberGuvenligeGiris.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 35, 5);
            btnTopSiberGuvenligeGiris.FlatStyle = FlatStyle.Flat;
            btnTopSiberGuvenligeGiris.ForeColor = Color.WhiteSmoke;
            btnTopSiberGuvenligeGiris.Location = new Point(0, 0);
            btnTopSiberGuvenligeGiris.Name = "btnTopSiberGuvenligeGiris";
            btnTopSiberGuvenligeGiris.Size = new Size(170, 50);
            btnTopSiberGuvenligeGiris.TabIndex = 0;
            btnTopSiberGuvenligeGiris.Text = "Siber Güvenliğe Giriş";
            btnTopSiberGuvenligeGiris.UseVisualStyleBackColor = true;
            btnTopSiberGuvenligeGiris.Click += btnTopSiberGuvenligeGiris_Click;
            // 
            // pnlTest
            // 
            pnlTest.Dock = DockStyle.Fill;
            pnlTest.Location = new Point(0, 0);
            pnlTest.Name = "pnlTest";
            pnlTest.Size = new Size(1209, 714);
            pnlTest.TabIndex = 2;
            // 
            // Testler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 28, 55);
            ClientSize = new Size(1209, 714);
            Controls.Add(pnlKonuMenu);
            Controls.Add(pnlTestler);
            Controls.Add(pnlTest);
            Name = "Testler";
            ShowIcon = false;
            Text = "Testler";
            pnlTestler.ResumeLayout(false);
            pnlKonuMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTestler;
        private FontAwesome.Sharp.IconButton btnChoiseTopics;
        private Panel pnlKonuMenu;
        private Button bntopsosyalMuhendislik;
        private Button btnzararliYazilimlar;
        private Button btnTopAgBilgisi;
        private Button btnTopSiberGuvenligeGiris;
        private Panel pnlTest;
    }
}