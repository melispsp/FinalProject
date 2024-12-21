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
            pnlTopics = new Panel();
            bntopsosyalMuhendislik = new Button();
            btnzararliYazilimlar = new Button();
            btnTopAgBilgisi = new Button();
            btnTopSiberGuvenligeGiris = new Button();
            pnlTestler.SuspendLayout();
            pnlTopics.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTestler
            // 
            pnlTestler.BackColor = Color.FromArgb(0, 50, 10);
            pnlTestler.Controls.Add(btnChoiseTopics);
            pnlTestler.Dock = DockStyle.Top;
            pnlTestler.Location = new Point(0, 0);
            pnlTestler.Name = "pnlTestler";
            pnlTestler.Size = new Size(1234, 54);
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
            // pnlTopics
            // 
            pnlTopics.AutoSize = true;
            pnlTopics.BackColor = Color.FromArgb(0, 45, 0);
            pnlTopics.Controls.Add(bntopsosyalMuhendislik);
            pnlTopics.Controls.Add(btnzararliYazilimlar);
            pnlTopics.Controls.Add(btnTopAgBilgisi);
            pnlTopics.Controls.Add(btnTopSiberGuvenligeGiris);
            pnlTopics.Location = new Point(2, 54);
            pnlTopics.Name = "pnlTopics";
            pnlTopics.Size = new Size(170, 200);
            pnlTopics.TabIndex = 1;
            pnlTopics.Visible = false;
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
            // 
            // Testler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 28, 55);
            ClientSize = new Size(1234, 682);
            Controls.Add(pnlTopics);
            Controls.Add(pnlTestler);
            Name = "Testler";
            ShowIcon = false;
            Text = "Testler";
            pnlTestler.ResumeLayout(false);
            pnlTopics.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTestler;
        private FontAwesome.Sharp.IconButton btnChoiseTopics;
        private Panel pnlTopics;
        private Button bntopsosyalMuhendislik;
        private Button btnzararliYazilimlar;
        private Button btnTopAgBilgisi;
        private Button btnTopSiberGuvenligeGiris;
    }
}