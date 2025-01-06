namespace finalProject.Forms
{
    partial class Dersler
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
            pnlEgitimler = new Panel();
            iconSearch = new FontAwesome.Sharp.IconButton();
            tboxSearch = new TextBox();
            btnListelerim = new FontAwesome.Sharp.IconButton();
            btnEgitimler = new FontAwesome.Sharp.IconButton();
            pnlEgitimlerMenu = new Panel();
            btnSosyalMuhendislik = new Button();
            btnZararliYazilimlar = new Button();
            btnAgBilgisi = new Button();
            btnSiberGuvenligegiris = new Button();
            pnlListelerimMenu = new Panel();
            btnListeEkle = new Button();
            btnFavorilerim = new Button();
            pnlDers = new Panel();
            pnlEgitimler.SuspendLayout();
            pnlEgitimlerMenu.SuspendLayout();
            pnlListelerimMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnlEgitimler
            // 
            pnlEgitimler.BackColor = Color.FromArgb(20, 25, 90);
            pnlEgitimler.Controls.Add(iconSearch);
            pnlEgitimler.Controls.Add(tboxSearch);
            pnlEgitimler.Controls.Add(btnListelerim);
            pnlEgitimler.Controls.Add(btnEgitimler);
            pnlEgitimler.Dock = DockStyle.Top;
            pnlEgitimler.Location = new Point(0, 0);
            pnlEgitimler.Name = "pnlEgitimler";
            pnlEgitimler.Size = new Size(1209, 54);
            pnlEgitimler.TabIndex = 8;
            // 
            // iconSearch
            // 
            iconSearch.FlatAppearance.BorderSize = 0;
            iconSearch.FlatStyle = FlatStyle.Flat;
            iconSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconSearch.IconColor = Color.Gainsboro;
            iconSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconSearch.IconSize = 27;
            iconSearch.Location = new Point(1136, 16);
            iconSearch.Name = "iconSearch";
            iconSearch.Size = new Size(56, 25);
            iconSearch.TabIndex = 3;
            iconSearch.UseVisualStyleBackColor = true;
            // 
            // tboxSearch
            // 
            tboxSearch.BackColor = Color.FromArgb(20, 25, 100);
            tboxSearch.BorderStyle = BorderStyle.FixedSingle;
            tboxSearch.ForeColor = Color.Gainsboro;
            tboxSearch.Location = new Point(1000, 15);
            tboxSearch.Name = "tboxSearch";
            tboxSearch.Size = new Size(197, 27);
            tboxSearch.TabIndex = 2;
            tboxSearch.Text = "  Ara...";
            // 
            // btnListelerim
            // 
            btnListelerim.Dock = DockStyle.Left;
            btnListelerim.FlatAppearance.BorderSize = 0;
            btnListelerim.FlatStyle = FlatStyle.Flat;
            btnListelerim.ForeColor = Color.Gainsboro;
            btnListelerim.IconChar = FontAwesome.Sharp.IconChar.None;
            btnListelerim.IconColor = Color.Black;
            btnListelerim.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnListelerim.Location = new Point(155, 0);
            btnListelerim.Name = "btnListelerim";
            btnListelerim.Size = new Size(155, 54);
            btnListelerim.TabIndex = 1;
            btnListelerim.Text = "Listelerim";
            btnListelerim.UseVisualStyleBackColor = true;
            btnListelerim.Click += btnListelerim_Click;
            // 
            // btnEgitimler
            // 
            btnEgitimler.Dock = DockStyle.Left;
            btnEgitimler.FlatAppearance.BorderSize = 0;
            btnEgitimler.FlatStyle = FlatStyle.Flat;
            btnEgitimler.ForeColor = Color.Gainsboro;
            btnEgitimler.IconChar = FontAwesome.Sharp.IconChar.None;
            btnEgitimler.IconColor = Color.Black;
            btnEgitimler.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEgitimler.Location = new Point(0, 0);
            btnEgitimler.Name = "btnEgitimler";
            btnEgitimler.Size = new Size(155, 54);
            btnEgitimler.TabIndex = 0;
            btnEgitimler.Text = "Eğitimler ";
            btnEgitimler.UseVisualStyleBackColor = true;
            btnEgitimler.Click += btnEgitimler_Click;
            // 
            // pnlEgitimlerMenu
            // 
            pnlEgitimlerMenu.BackColor = Color.FromArgb(0, 0, 10);
            pnlEgitimlerMenu.Controls.Add(btnSosyalMuhendislik);
            pnlEgitimlerMenu.Controls.Add(btnZararliYazilimlar);
            pnlEgitimlerMenu.Controls.Add(btnAgBilgisi);
            pnlEgitimlerMenu.Controls.Add(btnSiberGuvenligegiris);
            pnlEgitimlerMenu.Location = new Point(2, 59);
            pnlEgitimlerMenu.Name = "pnlEgitimlerMenu";
            pnlEgitimlerMenu.Size = new Size(168, 160);
            pnlEgitimlerMenu.TabIndex = 10;
            pnlEgitimlerMenu.Visible = false;
            // 
            // btnSosyalMuhendislik
            // 
            btnSosyalMuhendislik.Dock = DockStyle.Top;
            btnSosyalMuhendislik.FlatAppearance.BorderSize = 0;
            btnSosyalMuhendislik.FlatStyle = FlatStyle.Flat;
            btnSosyalMuhendislik.ForeColor = Color.White;
            btnSosyalMuhendislik.Location = new Point(0, 120);
            btnSosyalMuhendislik.Name = "btnSosyalMuhendislik";
            btnSosyalMuhendislik.Size = new Size(168, 40);
            btnSosyalMuhendislik.TabIndex = 3;
            btnSosyalMuhendislik.Text = "Sosyal Mühendislik";
            btnSosyalMuhendislik.UseVisualStyleBackColor = true;
            btnSosyalMuhendislik.Click += btnSosyalMuhendislik_Click;
            // 
            // btnZararliYazilimlar
            // 
            btnZararliYazilimlar.Dock = DockStyle.Top;
            btnZararliYazilimlar.FlatAppearance.BorderSize = 0;
            btnZararliYazilimlar.FlatStyle = FlatStyle.Flat;
            btnZararliYazilimlar.ForeColor = Color.White;
            btnZararliYazilimlar.Location = new Point(0, 80);
            btnZararliYazilimlar.Name = "btnZararliYazilimlar";
            btnZararliYazilimlar.Size = new Size(168, 40);
            btnZararliYazilimlar.TabIndex = 2;
            btnZararliYazilimlar.Text = "Zararlı Yazılımlar";
            btnZararliYazilimlar.UseVisualStyleBackColor = true;
            btnZararliYazilimlar.Click += btnZararliYazilimlar_Click;
            // 
            // btnAgBilgisi
            // 
            btnAgBilgisi.Dock = DockStyle.Top;
            btnAgBilgisi.FlatAppearance.BorderSize = 0;
            btnAgBilgisi.FlatStyle = FlatStyle.Flat;
            btnAgBilgisi.ForeColor = Color.White;
            btnAgBilgisi.Location = new Point(0, 40);
            btnAgBilgisi.Name = "btnAgBilgisi";
            btnAgBilgisi.Size = new Size(168, 40);
            btnAgBilgisi.TabIndex = 1;
            btnAgBilgisi.Text = "Ağ Bilgisi";
            btnAgBilgisi.UseVisualStyleBackColor = true;
            btnAgBilgisi.Click += btnAgBilgisi_Click;
            // 
            // btnSiberGuvenligegiris
            // 
            btnSiberGuvenligegiris.Dock = DockStyle.Top;
            btnSiberGuvenligegiris.FlatAppearance.BorderSize = 0;
            btnSiberGuvenligegiris.FlatStyle = FlatStyle.Flat;
            btnSiberGuvenligegiris.ForeColor = Color.White;
            btnSiberGuvenligegiris.Location = new Point(0, 0);
            btnSiberGuvenligegiris.Name = "btnSiberGuvenligegiris";
            btnSiberGuvenligegiris.Size = new Size(168, 40);
            btnSiberGuvenligegiris.TabIndex = 0;
            btnSiberGuvenligegiris.Text = "Siber Güvenliğe Giriş";
            btnSiberGuvenligegiris.UseVisualStyleBackColor = true;
            btnSiberGuvenligegiris.Click += btnSiberGuvenligegiris_Click;
            // 
            // pnlListelerimMenu
            // 
            pnlListelerimMenu.BackColor = Color.FromArgb(0, 0, 10);
            pnlListelerimMenu.Controls.Add(btnListeEkle);
            pnlListelerimMenu.Controls.Add(btnFavorilerim);
            pnlListelerimMenu.Location = new Point(161, 59);
            pnlListelerimMenu.Name = "pnlListelerimMenu";
            pnlListelerimMenu.Size = new Size(168, 80);
            pnlListelerimMenu.TabIndex = 12;
            pnlListelerimMenu.Visible = false;
            // 
            // btnListeEkle
            // 
            btnListeEkle.Dock = DockStyle.Top;
            btnListeEkle.FlatAppearance.BorderSize = 0;
            btnListeEkle.FlatStyle = FlatStyle.Flat;
            btnListeEkle.ForeColor = Color.White;
            btnListeEkle.Location = new Point(0, 40);
            btnListeEkle.Name = "btnListeEkle";
            btnListeEkle.Size = new Size(168, 40);
            btnListeEkle.TabIndex = 4;
            btnListeEkle.Text = " + Liste Ekle ";
            btnListeEkle.UseVisualStyleBackColor = true;
            btnListeEkle.Click += btnListeEkle_Click;
            // 
            // btnFavorilerim
            // 
            btnFavorilerim.Dock = DockStyle.Top;
            btnFavorilerim.FlatAppearance.BorderSize = 0;
            btnFavorilerim.FlatStyle = FlatStyle.Flat;
            btnFavorilerim.ForeColor = Color.White;
            btnFavorilerim.Location = new Point(0, 0);
            btnFavorilerim.Name = "btnFavorilerim";
            btnFavorilerim.Size = new Size(168, 40);
            btnFavorilerim.TabIndex = 2;
            btnFavorilerim.Text = "Favorilerim";
            btnFavorilerim.UseVisualStyleBackColor = true;
            btnFavorilerim.Click += btnFavorilerim_Click;
            // 
            // pnlDers
            // 
            pnlDers.Dock = DockStyle.Fill;
            pnlDers.Location = new Point(0, 0);
            pnlDers.Name = "pnlDers";
            pnlDers.Size = new Size(1209, 714);
            pnlDers.TabIndex = 13;
            // 
            // Dersler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 28, 55);
            ClientSize = new Size(1209, 714);
            Controls.Add(pnlEgitimler);
            Controls.Add(pnlListelerimMenu);
            Controls.Add(pnlEgitimlerMenu);
            Controls.Add(pnlDers);
            Name = "Dersler";
            ShowIcon = false;
            Text = "Dersler";
            pnlEgitimler.ResumeLayout(false);
            pnlEgitimler.PerformLayout();
            pnlEgitimlerMenu.ResumeLayout(false);
            pnlListelerimMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlEgitimler;
        private FontAwesome.Sharp.IconButton btnEgitimler;
        private FontAwesome.Sharp.IconButton btnListelerim;
        private Panel pnlEgitimlerMenu;
        private Panel pnlListelerimMenu;
        private TextBox tboxSearch;
        private FontAwesome.Sharp.IconButton iconSearch;
        private Button btnSiberGuvenligegiris;
        private Button btnSosyalMuhendislik;
        private Button btnZararliYazilimlar;
        private Button btnAgBilgisi;
        private Button btnListeEkle;
        private Button btnFavorilerim;
        private Panel pnlDers;
    }
}