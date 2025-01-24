namespace finalProject
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelMenu = new Panel();
            btnSimulations = new FontAwesome.Sharp.IconButton();
            btnTests = new FontAwesome.Sharp.IconButton();
            btnFlashcards = new FontAwesome.Sharp.IconButton();
            btnLessons = new FontAwesome.Sharp.IconButton();
            btnOut = new FontAwesome.Sharp.IconButton();
            PnlUser = new Panel();
            lblAdSoyad = new Label();
            PicUserProfile = new PictureBox();
            pnlTopBar = new Panel();
            lblHosGeldinAd = new Label();
            lblHome = new Label();
            btnSettings = new FontAwesome.Sharp.IconButton();
            btnHome = new FontAwesome.Sharp.IconButton();
            pnlShadow = new Panel();
            pnlDesktop = new Panel();
            lblAnaMetin = new Label();
            pnlKategoriler = new Panel();
            btnKategori16 = new Button();
            btnKategori15 = new Button();
            btnKategori14 = new Button();
            btnKategori13 = new Button();
            btnKategori12 = new Button();
            btnKategori11 = new Button();
            btnKategori10 = new Button();
            btnKategori9 = new Button();
            btnKategori8 = new Button();
            btnKategori7 = new Button();
            btnKategori6 = new Button();
            btnKategori5 = new Button();
            btnKategori4 = new Button();
            btnKategori3 = new Button();
            btnKategori2 = new Button();
            btnKategori1 = new Button();
            pnlSlider = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnProfilim = new FontAwesome.Sharp.IconButton();
            pnlSettinsBar = new Panel();
            btnKategoriler = new FontAwesome.Sharp.IconButton();
            lblCizgi2 = new Label();
            btnNotlarım = new FontAwesome.Sharp.IconButton();
            lblCizgi = new Label();
            btnUygulamaHakkinda = new FontAwesome.Sharp.IconButton();
            sliderTimer = new System.Windows.Forms.Timer(components);
            timer1 = new System.Windows.Forms.Timer(components);
            panelMenu.SuspendLayout();
            PnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicUserProfile).BeginInit();
            pnlTopBar.SuspendLayout();
            pnlDesktop.SuspendLayout();
            pnlKategoriler.SuspendLayout();
            pnlSlider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlSettinsBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(10, 8, 15);
            panelMenu.Controls.Add(btnSimulations);
            panelMenu.Controls.Add(btnTests);
            panelMenu.Controls.Add(btnFlashcards);
            panelMenu.Controls.Add(btnLessons);
            panelMenu.Controls.Add(btnOut);
            panelMenu.Controls.Add(PnlUser);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 799);
            panelMenu.TabIndex = 0;
            // 
            // btnSimulations
            // 
            btnSimulations.Dock = DockStyle.Top;
            btnSimulations.FlatAppearance.BorderSize = 0;
            btnSimulations.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 50);
            btnSimulations.FlatStyle = FlatStyle.Flat;
            btnSimulations.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnSimulations.ForeColor = Color.Red;
            btnSimulations.IconChar = FontAwesome.Sharp.IconChar.ShieldHalved;
            btnSimulations.IconColor = Color.Red;
            btnSimulations.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSimulations.IconSize = 44;
            btnSimulations.ImageAlign = ContentAlignment.MiddleLeft;
            btnSimulations.Location = new Point(0, 295);
            btnSimulations.Name = "btnSimulations";
            btnSimulations.Padding = new Padding(10, 0, 0, 0);
            btnSimulations.Size = new Size(220, 50);
            btnSimulations.TabIndex = 9;
            btnSimulations.Text = "Simülasyonlar";
            btnSimulations.UseVisualStyleBackColor = true;
            btnSimulations.Click += btnSimulations_Click;
            // 
            // btnTests
            // 
            btnTests.Dock = DockStyle.Top;
            btnTests.FlatAppearance.BorderSize = 0;
            btnTests.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 50);
            btnTests.FlatStyle = FlatStyle.Flat;
            btnTests.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnTests.ForeColor = Color.LawnGreen;
            btnTests.IconChar = FontAwesome.Sharp.IconChar.Check;
            btnTests.IconColor = Color.LawnGreen;
            btnTests.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTests.IconSize = 44;
            btnTests.ImageAlign = ContentAlignment.MiddleLeft;
            btnTests.Location = new Point(0, 245);
            btnTests.Name = "btnTests";
            btnTests.Padding = new Padding(10, 0, 0, 0);
            btnTests.Size = new Size(220, 50);
            btnTests.TabIndex = 8;
            btnTests.Text = "Testler";
            btnTests.UseVisualStyleBackColor = true;
            btnTests.Click += btnTests_Click;
            // 
            // btnFlashcards
            // 
            btnFlashcards.Dock = DockStyle.Top;
            btnFlashcards.FlatAppearance.BorderSize = 0;
            btnFlashcards.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 50);
            btnFlashcards.FlatStyle = FlatStyle.Flat;
            btnFlashcards.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnFlashcards.ForeColor = Color.MediumSlateBlue;
            btnFlashcards.IconChar = FontAwesome.Sharp.IconChar.Buffer;
            btnFlashcards.IconColor = Color.MediumSlateBlue;
            btnFlashcards.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFlashcards.IconSize = 44;
            btnFlashcards.ImageAlign = ContentAlignment.MiddleLeft;
            btnFlashcards.Location = new Point(0, 195);
            btnFlashcards.Name = "btnFlashcards";
            btnFlashcards.Padding = new Padding(10, 0, 0, 0);
            btnFlashcards.Size = new Size(220, 50);
            btnFlashcards.TabIndex = 7;
            btnFlashcards.Text = "FlashCards";
            btnFlashcards.UseVisualStyleBackColor = true;
            btnFlashcards.Click += btnFlashcards_Click;
            // 
            // btnLessons
            // 
            btnLessons.Dock = DockStyle.Top;
            btnLessons.FlatAppearance.BorderSize = 0;
            btnLessons.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 50);
            btnLessons.FlatStyle = FlatStyle.Flat;
            btnLessons.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnLessons.ForeColor = Color.Cyan;
            btnLessons.IconChar = FontAwesome.Sharp.IconChar.MortarBoard;
            btnLessons.IconColor = Color.Cyan;
            btnLessons.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLessons.IconSize = 44;
            btnLessons.ImageAlign = ContentAlignment.MiddleLeft;
            btnLessons.Location = new Point(0, 145);
            btnLessons.Name = "btnLessons";
            btnLessons.Padding = new Padding(10, 0, 0, 0);
            btnLessons.Size = new Size(220, 50);
            btnLessons.TabIndex = 6;
            btnLessons.Text = "Dersler";
            btnLessons.UseVisualStyleBackColor = true;
            btnLessons.Click += btnLessons_Click;
            // 
            // btnOut
            // 
            btnOut.BackColor = Color.Black;
            btnOut.BackgroundImageLayout = ImageLayout.None;
            btnOut.Dock = DockStyle.Bottom;
            btnOut.FlatAppearance.BorderSize = 0;
            btnOut.FlatAppearance.MouseDownBackColor = Color.FromArgb(10, 8, 15);
            btnOut.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 50);
            btnOut.FlatStyle = FlatStyle.Flat;
            btnOut.ForeColor = Color.Silver;
            btnOut.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            btnOut.IconColor = Color.Silver;
            btnOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnOut.IconSize = 40;
            btnOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnOut.Location = new Point(0, 749);
            btnOut.Name = "btnOut";
            btnOut.Padding = new Padding(10, 0, 20, 0);
            btnOut.Size = new Size(220, 50);
            btnOut.TabIndex = 5;
            btnOut.Text = "Çıkış Yap";
            btnOut.UseVisualStyleBackColor = false;
            btnOut.Click += btnOut_Click;
            // 
            // PnlUser
            // 
            PnlUser.BackColor = Color.FromArgb(8, 6, 15);
            PnlUser.Controls.Add(lblAdSoyad);
            PnlUser.Controls.Add(PicUserProfile);
            PnlUser.Dock = DockStyle.Top;
            PnlUser.Location = new Point(0, 0);
            PnlUser.Name = "PnlUser";
            PnlUser.Size = new Size(220, 145);
            PnlUser.TabIndex = 0;
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblAdSoyad.ForeColor = Color.LightSkyBlue;
            lblAdSoyad.Location = new Point(60, 122);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(100, 19);
            lblAdSoyad.TabIndex = 0;
            lblAdSoyad.Text = "Melisa Köklü";
            // 
            // PicUserProfile
            // 
            PicUserProfile.Dock = DockStyle.Top;
            PicUserProfile.Image = (Image)resources.GetObject("PicUserProfile.Image");
            PicUserProfile.Location = new Point(0, 0);
            PicUserProfile.Name = "PicUserProfile";
            PicUserProfile.Size = new Size(220, 120);
            PicUserProfile.SizeMode = PictureBoxSizeMode.Zoom;
            PicUserProfile.TabIndex = 0;
            PicUserProfile.TabStop = false;
            // 
            // pnlTopBar
            // 
            pnlTopBar.BackColor = Color.FromArgb(20, 0, 32);
            pnlTopBar.Controls.Add(lblHosGeldinAd);
            pnlTopBar.Controls.Add(lblHome);
            pnlTopBar.Controls.Add(btnSettings);
            pnlTopBar.Controls.Add(btnHome);
            pnlTopBar.Dock = DockStyle.Top;
            pnlTopBar.Location = new Point(220, 0);
            pnlTopBar.Name = "pnlTopBar";
            pnlTopBar.Size = new Size(1227, 60);
            pnlTopBar.TabIndex = 1;
            pnlTopBar.MouseDown += pnlTopBar_MouseDown;
            // 
            // lblHosGeldinAd
            // 
            lblHosGeldinAd.AutoSize = true;
            lblHosGeldinAd.Dock = DockStyle.Right;
            lblHosGeldinAd.FlatStyle = FlatStyle.Flat;
            lblHosGeldinAd.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHosGeldinAd.ForeColor = Color.WhiteSmoke;
            lblHosGeldinAd.Location = new Point(998, 0);
            lblHosGeldinAd.Name = "lblHosGeldinAd";
            lblHosGeldinAd.Padding = new Padding(0, 20, 5, 0);
            lblHosGeldinAd.Size = new Size(154, 40);
            lblHosGeldinAd.TabIndex = 3;
            lblHosGeldinAd.Text = "Merhaba, Melisa!";
            lblHosGeldinAd.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHome
            // 
            lblHome.AutoSize = true;
            lblHome.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblHome.ForeColor = Color.Gainsboro;
            lblHome.Location = new Point(66, 19);
            lblHome.Name = "lblHome";
            lblHome.Size = new Size(90, 21);
            lblHome.TabIndex = 2;
            lblHome.Text = "Ana Sayfa";
            lblHome.Click += lblHome_Click;
            // 
            // btnSettings
            // 
            btnSettings.Dock = DockStyle.Right;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.IconChar = FontAwesome.Sharp.IconChar.Bars;
            btnSettings.IconColor = Color.Gainsboro;
            btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSettings.IconSize = 40;
            btnSettings.Location = new Point(1152, 0);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(75, 60);
            btnSettings.TabIndex = 1;
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Left;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnHome.ForeColor = Color.WhiteSmoke;
            btnHome.IconChar = FontAwesome.Sharp.IconChar.House;
            btnHome.IconColor = Color.Gainsboro;
            btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHome.IconSize = 40;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(60, 60);
            btnHome.TabIndex = 0;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // pnlShadow
            // 
            pnlShadow.BackColor = Color.FromArgb(5, 2, 10);
            pnlShadow.Dock = DockStyle.Top;
            pnlShadow.Location = new Point(220, 60);
            pnlShadow.Name = "pnlShadow";
            pnlShadow.Size = new Size(1227, 8);
            pnlShadow.TabIndex = 3;
            // 
            // pnlDesktop
            // 
            pnlDesktop.Controls.Add(lblAnaMetin);
            pnlDesktop.Controls.Add(pnlKategoriler);
            pnlDesktop.Controls.Add(pnlSlider);
            pnlDesktop.Dock = DockStyle.Fill;
            pnlDesktop.Location = new Point(220, 68);
            pnlDesktop.Name = "pnlDesktop";
            pnlDesktop.Size = new Size(1227, 731);
            pnlDesktop.TabIndex = 4;
            // 
            // lblAnaMetin
            // 
            lblAnaMetin.AutoSize = true;
            lblAnaMetin.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblAnaMetin.ForeColor = Color.WhiteSmoke;
            lblAnaMetin.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lblAnaMetin.Location = new Point(42, 77);
            lblAnaMetin.Name = "lblAnaMetin";
            lblAnaMetin.Size = new Size(0, 22);
            lblAnaMetin.TabIndex = 8;
            // 
            // pnlKategoriler
            // 
            pnlKategoriler.BackColor = Color.FromArgb(20, 0, 32);
            pnlKategoriler.Controls.Add(btnKategori16);
            pnlKategoriler.Controls.Add(btnKategori15);
            pnlKategoriler.Controls.Add(btnKategori14);
            pnlKategoriler.Controls.Add(btnKategori13);
            pnlKategoriler.Controls.Add(btnKategori12);
            pnlKategoriler.Controls.Add(btnKategori11);
            pnlKategoriler.Controls.Add(btnKategori10);
            pnlKategoriler.Controls.Add(btnKategori9);
            pnlKategoriler.Controls.Add(btnKategori8);
            pnlKategoriler.Controls.Add(btnKategori7);
            pnlKategoriler.Controls.Add(btnKategori6);
            pnlKategoriler.Controls.Add(btnKategori5);
            pnlKategoriler.Controls.Add(btnKategori4);
            pnlKategoriler.Controls.Add(btnKategori3);
            pnlKategoriler.Controls.Add(btnKategori2);
            pnlKategoriler.Controls.Add(btnKategori1);
            pnlKategoriler.Location = new Point(772, 121);
            pnlKategoriler.Name = "pnlKategoriler";
            pnlKategoriler.Size = new Size(228, 466);
            pnlKategoriler.TabIndex = 7;
            pnlKategoriler.Visible = false;
            // 
            // btnKategori16
            // 
            btnKategori16.Dock = DockStyle.Top;
            btnKategori16.FlatAppearance.BorderSize = 0;
            btnKategori16.FlatStyle = FlatStyle.Flat;
            btnKategori16.ForeColor = Color.Lavender;
            btnKategori16.Location = new Point(0, 435);
            btnKategori16.Name = "btnKategori16";
            btnKategori16.Padding = new Padding(5, 0, 0, 0);
            btnKategori16.Size = new Size(228, 29);
            btnKategori16.TabIndex = 15;
            btnKategori16.Text = "Sosyal Mühendislikten Korunma Yolları";
            btnKategori16.TextAlign = ContentAlignment.MiddleLeft;
            btnKategori16.UseVisualStyleBackColor = true;
            btnKategori16.Click += buttonKategoriler_Click;
            // 
            // btnKategori15
            // 
            btnKategori15.Dock = DockStyle.Top;
            btnKategori15.FlatAppearance.BorderSize = 0;
            btnKategori15.FlatStyle = FlatStyle.Flat;
            btnKategori15.ForeColor = Color.Lavender;
            btnKategori15.Location = new Point(0, 406);
            btnKategori15.Name = "btnKategori15";
            btnKategori15.Padding = new Padding(5, 0, 0, 0);
            btnKategori15.Size = new Size(228, 29);
            btnKategori15.TabIndex = 14;
            btnKategori15.Text = "Psikolojik Teknikler";
            btnKategori15.TextAlign = ContentAlignment.MiddleLeft;
            btnKategori15.UseVisualStyleBackColor = true;
            btnKategori15.Click += buttonKategoriler_Click;
            // 
            // btnKategori14
            // 
            btnKategori14.Dock = DockStyle.Top;
            btnKategori14.FlatAppearance.BorderSize = 0;
            btnKategori14.FlatStyle = FlatStyle.Flat;
            btnKategori14.ForeColor = Color.Lavender;
            btnKategori14.Location = new Point(0, 377);
            btnKategori14.Name = "btnKategori14";
            btnKategori14.Padding = new Padding(5, 0, 0, 0);
            btnKategori14.Size = new Size(228, 29);
            btnKategori14.TabIndex = 13;
            btnKategori14.Text = "Sosyal Mühendislikte Saldırı Çeşitleri";
            btnKategori14.TextAlign = ContentAlignment.MiddleLeft;
            btnKategori14.UseVisualStyleBackColor = true;
            btnKategori14.Click += buttonKategoriler_Click;
            // 
            // btnKategori13
            // 
            btnKategori13.Dock = DockStyle.Top;
            btnKategori13.FlatAppearance.BorderSize = 0;
            btnKategori13.FlatStyle = FlatStyle.Flat;
            btnKategori13.ForeColor = Color.Lavender;
            btnKategori13.Location = new Point(0, 348);
            btnKategori13.Name = "btnKategori13";
            btnKategori13.Padding = new Padding(5, 0, 0, 0);
            btnKategori13.Size = new Size(228, 29);
            btnKategori13.TabIndex = 12;
            btnKategori13.Text = "Sosyal mühendislik nedir?";
            btnKategori13.TextAlign = ContentAlignment.MiddleLeft;
            btnKategori13.UseVisualStyleBackColor = true;
            btnKategori13.Click += buttonKategoriler_Click;
            // 
            // btnKategori12
            // 
            btnKategori12.Dock = DockStyle.Top;
            btnKategori12.FlatAppearance.BorderSize = 0;
            btnKategori12.FlatStyle = FlatStyle.Flat;
            btnKategori12.ForeColor = Color.Lavender;
            btnKategori12.Location = new Point(0, 319);
            btnKategori12.Name = "btnKategori12";
            btnKategori12.Padding = new Padding(5, 0, 0, 0);
            btnKategori12.Size = new Size(228, 29);
            btnKategori12.TabIndex = 11;
            btnKategori12.Text = "Zararlı Yazılımlardan Korunma Yöntemleri";
            btnKategori12.TextAlign = ContentAlignment.MiddleLeft;
            btnKategori12.UseVisualStyleBackColor = true;
            btnKategori12.Click += buttonKategoriler_Click;
            // 
            // btnKategori11
            // 
            btnKategori11.Dock = DockStyle.Top;
            btnKategori11.FlatAppearance.BorderSize = 0;
            btnKategori11.FlatStyle = FlatStyle.Flat;
            btnKategori11.ForeColor = Color.Lavender;
            btnKategori11.Location = new Point(0, 290);
            btnKategori11.Name = "btnKategori11";
            btnKategori11.Padding = new Padding(5, 0, 0, 0);
            btnKategori11.Size = new Size(228, 29);
            btnKategori11.TabIndex = 10;
            btnKategori11.Text = "Zararlı Yazılım Tespiti ve Analizi";
            btnKategori11.TextAlign = ContentAlignment.MiddleLeft;
            btnKategori11.UseVisualStyleBackColor = true;
            btnKategori11.Click += buttonKategoriler_Click;
            // 
            // btnKategori10
            // 
            btnKategori10.Dock = DockStyle.Top;
            btnKategori10.FlatAppearance.BorderSize = 0;
            btnKategori10.FlatStyle = FlatStyle.Flat;
            btnKategori10.ForeColor = Color.Lavender;
            btnKategori10.Location = new Point(0, 261);
            btnKategori10.Name = "btnKategori10";
            btnKategori10.Padding = new Padding(5, 0, 0, 0);
            btnKategori10.Size = new Size(228, 29);
            btnKategori10.TabIndex = 9;
            btnKategori10.Text = "Zararlı Yazılımlar Nasıl Çalışır?";
            btnKategori10.TextAlign = ContentAlignment.MiddleLeft;
            btnKategori10.UseVisualStyleBackColor = true;
            btnKategori10.Click += buttonKategoriler_Click;
            // 
            // btnKategori9
            // 
            btnKategori9.Dock = DockStyle.Top;
            btnKategori9.FlatAppearance.BorderSize = 0;
            btnKategori9.FlatStyle = FlatStyle.Flat;
            btnKategori9.ForeColor = Color.Lavender;
            btnKategori9.Location = new Point(0, 232);
            btnKategori9.Name = "btnKategori9";
            btnKategori9.Padding = new Padding(5, 0, 0, 0);
            btnKategori9.Size = new Size(228, 29);
            btnKategori9.TabIndex = 8;
            btnKategori9.Text = "Zararlı Yazılım Nedir? ";
            btnKategori9.TextAlign = ContentAlignment.MiddleLeft;
            btnKategori9.UseVisualStyleBackColor = true;
            btnKategori9.Click += buttonKategoriler_Click;
            // 
            // btnKategori8
            // 
            btnKategori8.Dock = DockStyle.Top;
            btnKategori8.FlatAppearance.BorderSize = 0;
            btnKategori8.FlatStyle = FlatStyle.Flat;
            btnKategori8.ForeColor = Color.Lavender;
            btnKategori8.Location = new Point(0, 203);
            btnKategori8.Name = "btnKategori8";
            btnKategori8.Padding = new Padding(5, 0, 0, 0);
            btnKategori8.Size = new Size(228, 29);
            btnKategori8.TabIndex = 7;
            btnKategori8.Text = "Ağ İzleme ve Saldırı Tespiti";
            btnKategori8.TextAlign = ContentAlignment.MiddleLeft;
            btnKategori8.UseVisualStyleBackColor = true;
            btnKategori8.Click += buttonKategoriler_Click;
            // 
            // btnKategori7
            // 
            btnKategori7.Dock = DockStyle.Top;
            btnKategori7.FlatAppearance.BorderSize = 0;
            btnKategori7.FlatStyle = FlatStyle.Flat;
            btnKategori7.ForeColor = Color.Lavender;
            btnKategori7.Location = new Point(0, 174);
            btnKategori7.Name = "btnKategori7";
            btnKategori7.Padding = new Padding(5, 0, 0, 0);
            btnKategori7.Size = new Size(228, 29);
            btnKategori7.TabIndex = 6;
            btnKategori7.Text = "Ağ Güvenliği Temelleri";
            btnKategori7.TextAlign = ContentAlignment.MiddleLeft;
            btnKategori7.UseVisualStyleBackColor = true;
            btnKategori7.Click += buttonKategoriler_Click;
            // 
            // btnKategori6
            // 
            btnKategori6.Dock = DockStyle.Top;
            btnKategori6.FlatAppearance.BorderSize = 0;
            btnKategori6.FlatStyle = FlatStyle.Flat;
            btnKategori6.ForeColor = Color.Lavender;
            btnKategori6.Location = new Point(0, 145);
            btnKategori6.Name = "btnKategori6";
            btnKategori6.Padding = new Padding(5, 0, 0, 0);
            btnKategori6.Size = new Size(228, 29);
            btnKategori6.TabIndex = 5;
            btnKategori6.Text = "Ağ Protokolleri ve Veri İletişimi";
            btnKategori6.TextAlign = ContentAlignment.MiddleLeft;
            btnKategori6.UseVisualStyleBackColor = true;
            btnKategori6.Click += buttonKategoriler_Click;
            // 
            // btnKategori5
            // 
            btnKategori5.Dock = DockStyle.Top;
            btnKategori5.FlatAppearance.BorderSize = 0;
            btnKategori5.FlatStyle = FlatStyle.Flat;
            btnKategori5.ForeColor = Color.Lavender;
            btnKategori5.Location = new Point(0, 116);
            btnKategori5.Name = "btnKategori5";
            btnKategori5.Padding = new Padding(5, 0, 0, 0);
            btnKategori5.Size = new Size(228, 29);
            btnKategori5.TabIndex = 4;
            btnKategori5.Text = "Temel Ağ Bilgisi";
            btnKategori5.TextAlign = ContentAlignment.MiddleLeft;
            btnKategori5.UseVisualStyleBackColor = true;
            btnKategori5.Click += buttonKategoriler_Click;
            // 
            // btnKategori4
            // 
            btnKategori4.Dock = DockStyle.Top;
            btnKategori4.FlatAppearance.BorderSize = 0;
            btnKategori4.FlatStyle = FlatStyle.Flat;
            btnKategori4.ForeColor = Color.Lavender;
            btnKategori4.Location = new Point(0, 87);
            btnKategori4.Name = "btnKategori4";
            btnKategori4.Padding = new Padding(5, 0, 0, 0);
            btnKategori4.Size = new Size(228, 29);
            btnKategori4.TabIndex = 3;
            btnKategori4.Text = "Temel Koruma Yöntemleri";
            btnKategori4.TextAlign = ContentAlignment.MiddleLeft;
            btnKategori4.UseVisualStyleBackColor = true;
            btnKategori4.Click += buttonKategoriler_Click;
            // 
            // btnKategori3
            // 
            btnKategori3.Dock = DockStyle.Top;
            btnKategori3.FlatAppearance.BorderSize = 0;
            btnKategori3.FlatStyle = FlatStyle.Flat;
            btnKategori3.ForeColor = Color.Lavender;
            btnKategori3.Location = new Point(0, 58);
            btnKategori3.Name = "btnKategori3";
            btnKategori3.Padding = new Padding(5, 0, 0, 0);
            btnKategori3.Size = new Size(228, 29);
            btnKategori3.TabIndex = 2;
            btnKategori3.Text = "Şifreleme ve Kriptografi";
            btnKategori3.TextAlign = ContentAlignment.MiddleLeft;
            btnKategori3.UseVisualStyleBackColor = true;
            btnKategori3.Click += buttonKategoriler_Click;
            // 
            // btnKategori2
            // 
            btnKategori2.Dock = DockStyle.Top;
            btnKategori2.FlatAppearance.BorderSize = 0;
            btnKategori2.FlatStyle = FlatStyle.Flat;
            btnKategori2.ForeColor = Color.Lavender;
            btnKategori2.Location = new Point(0, 29);
            btnKategori2.Name = "btnKategori2";
            btnKategori2.Padding = new Padding(5, 0, 0, 0);
            btnKategori2.Size = new Size(228, 29);
            btnKategori2.TabIndex = 1;
            btnKategori2.Text = "Siber Tehdit Türleri";
            btnKategori2.TextAlign = ContentAlignment.MiddleLeft;
            btnKategori2.UseVisualStyleBackColor = true;
            btnKategori2.Click += buttonKategoriler_Click;
            // 
            // btnKategori1
            // 
            btnKategori1.Dock = DockStyle.Top;
            btnKategori1.FlatAppearance.BorderSize = 0;
            btnKategori1.FlatStyle = FlatStyle.Flat;
            btnKategori1.ForeColor = Color.Lavender;
            btnKategori1.Location = new Point(0, 0);
            btnKategori1.Name = "btnKategori1";
            btnKategori1.Padding = new Padding(5, 0, 0, 0);
            btnKategori1.Size = new Size(228, 29);
            btnKategori1.TabIndex = 0;
            btnKategori1.Text = "Siber Güvenlik Nedir?";
            btnKategori1.TextAlign = ContentAlignment.MiddleLeft;
            btnKategori1.UseVisualStyleBackColor = true;
            btnKategori1.Click += buttonKategoriler_Click;
            // 
            // pnlSlider
            // 
            pnlSlider.Controls.Add(label3);
            pnlSlider.Controls.Add(label2);
            pnlSlider.Controls.Add(label1);
            pnlSlider.Controls.Add(pictureBox3);
            pnlSlider.Controls.Add(pictureBox2);
            pnlSlider.Controls.Add(pictureBox1);
            pnlSlider.Location = new Point(6, 200);
            pnlSlider.Name = "pnlSlider";
            pnlSlider.Size = new Size(1221, 355);
            pnlSlider.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(853, 284);
            label3.Name = "label3";
            label3.Size = new Size(60, 22);
            label3.TabIndex = 5;
            label3.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(503, 284);
            label2.Name = "label2";
            label2.Size = new Size(60, 22);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(122, 284);
            label1.Name = "label1";
            label1.Size = new Size(60, 22);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(775, 62);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(354, 206);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(392, 62);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(354, 206);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(354, 206);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnProfilim
            // 
            btnProfilim.Dock = DockStyle.Top;
            btnProfilim.FlatAppearance.BorderSize = 0;
            btnProfilim.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 50);
            btnProfilim.FlatStyle = FlatStyle.Flat;
            btnProfilim.ForeColor = Color.Lavender;
            btnProfilim.IconChar = FontAwesome.Sharp.IconChar.None;
            btnProfilim.IconColor = Color.Lavender;
            btnProfilim.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProfilim.IconSize = 44;
            btnProfilim.Location = new Point(0, 0);
            btnProfilim.Name = "btnProfilim";
            btnProfilim.Padding = new Padding(0, 10, 0, 10);
            btnProfilim.Size = new Size(230, 50);
            btnProfilim.TabIndex = 0;
            btnProfilim.Text = "Profilim";
            btnProfilim.UseVisualStyleBackColor = true;
            btnProfilim.Click += btnProfilim_Click;
            // 
            // pnlSettinsBar
            // 
            pnlSettinsBar.BackColor = Color.FromArgb(20, 0, 32);
            pnlSettinsBar.Controls.Add(btnKategoriler);
            pnlSettinsBar.Controls.Add(lblCizgi2);
            pnlSettinsBar.Controls.Add(btnNotlarım);
            pnlSettinsBar.Controls.Add(lblCizgi);
            pnlSettinsBar.Controls.Add(btnUygulamaHakkinda);
            pnlSettinsBar.Controls.Add(btnProfilim);
            pnlSettinsBar.Dock = DockStyle.Right;
            pnlSettinsBar.Location = new Point(1217, 68);
            pnlSettinsBar.Name = "pnlSettinsBar";
            pnlSettinsBar.Size = new Size(230, 731);
            pnlSettinsBar.TabIndex = 2;
            pnlSettinsBar.Visible = false;
            // 
            // btnKategoriler
            // 
            btnKategoriler.Dock = DockStyle.Top;
            btnKategoriler.FlatAppearance.BorderSize = 0;
            btnKategoriler.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 50);
            btnKategoriler.FlatStyle = FlatStyle.Flat;
            btnKategoriler.ForeColor = Color.Lavender;
            btnKategoriler.IconChar = FontAwesome.Sharp.IconChar.None;
            btnKategoriler.IconColor = Color.Lavender;
            btnKategoriler.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnKategoriler.IconSize = 44;
            btnKategoriler.Location = new Point(0, 130);
            btnKategoriler.Name = "btnKategoriler";
            btnKategoriler.Padding = new Padding(0, 10, 0, 10);
            btnKategoriler.Size = new Size(230, 50);
            btnKategoriler.TabIndex = 6;
            btnKategoriler.Text = "Tüm Kategoriler";
            btnKategoriler.UseVisualStyleBackColor = true;
            btnKategoriler.Click += btnKategoriler_Click;
            // 
            // lblCizgi2
            // 
            lblCizgi2.AutoSize = true;
            lblCizgi2.Dock = DockStyle.Top;
            lblCizgi2.Font = new Font("Bell MT", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCizgi2.ForeColor = Color.DarkMagenta;
            lblCizgi2.Location = new Point(0, 115);
            lblCizgi2.Name = "lblCizgi2";
            lblCizgi2.Size = new Size(227, 15);
            lblCizgi2.TabIndex = 5;
            lblCizgi2.Text = "-------------------------------------------------------";
            // 
            // btnNotlarım
            // 
            btnNotlarım.Dock = DockStyle.Top;
            btnNotlarım.FlatAppearance.BorderSize = 0;
            btnNotlarım.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 50);
            btnNotlarım.FlatStyle = FlatStyle.Flat;
            btnNotlarım.ForeColor = Color.Lavender;
            btnNotlarım.IconChar = FontAwesome.Sharp.IconChar.None;
            btnNotlarım.IconColor = Color.Lavender;
            btnNotlarım.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNotlarım.IconSize = 44;
            btnNotlarım.Location = new Point(0, 65);
            btnNotlarım.Name = "btnNotlarım";
            btnNotlarım.Padding = new Padding(0, 10, 0, 10);
            btnNotlarım.Size = new Size(230, 50);
            btnNotlarım.TabIndex = 4;
            btnNotlarım.Text = "Notlarım";
            btnNotlarım.UseVisualStyleBackColor = true;
            btnNotlarım.Click += btnNotlarım_Click;
            // 
            // lblCizgi
            // 
            lblCizgi.AutoSize = true;
            lblCizgi.BackColor = Color.FromArgb(20, 0, 32);
            lblCizgi.Dock = DockStyle.Top;
            lblCizgi.Font = new Font("Bell MT", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCizgi.ForeColor = Color.DarkMagenta;
            lblCizgi.Location = new Point(0, 50);
            lblCizgi.Name = "lblCizgi";
            lblCizgi.Size = new Size(227, 15);
            lblCizgi.TabIndex = 0;
            lblCizgi.Text = "-------------------------------------------------------";
            // 
            // btnUygulamaHakkinda
            // 
            btnUygulamaHakkinda.Dock = DockStyle.Bottom;
            btnUygulamaHakkinda.FlatAppearance.BorderSize = 0;
            btnUygulamaHakkinda.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 50);
            btnUygulamaHakkinda.FlatStyle = FlatStyle.Flat;
            btnUygulamaHakkinda.ForeColor = Color.Lavender;
            btnUygulamaHakkinda.IconChar = FontAwesome.Sharp.IconChar.None;
            btnUygulamaHakkinda.IconColor = Color.Lavender;
            btnUygulamaHakkinda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUygulamaHakkinda.IconSize = 44;
            btnUygulamaHakkinda.Location = new Point(0, 681);
            btnUygulamaHakkinda.Name = "btnUygulamaHakkinda";
            btnUygulamaHakkinda.Padding = new Padding(0, 10, 0, 10);
            btnUygulamaHakkinda.Size = new Size(230, 50);
            btnUygulamaHakkinda.TabIndex = 3;
            btnUygulamaHakkinda.Text = "Uygulama Sürümü: 1.1.2";
            btnUygulamaHakkinda.UseVisualStyleBackColor = true;
            // 
            // sliderTimer
            // 
            sliderTimer.Interval = 1500;
            sliderTimer.Tick += sliderTimer_Tick_1;
            // 
            // timer1
            // 
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 28, 55);
            BackgroundImageLayout = ImageLayout.Center;
            CancelButton = btnOut;
            ClientSize = new Size(1447, 799);
            Controls.Add(pnlSettinsBar);
            Controls.Add(pnlDesktop);
            Controls.Add(pnlShadow);
            Controls.Add(pnlTopBar);
            Controls.Add(panelMenu);
            DoubleBuffered = true;
            Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ForeColor = Color.Black;
            Name = "MainForm";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Education Platform";
            Load += MainForm_Load;
            panelMenu.ResumeLayout(false);
            PnlUser.ResumeLayout(false);
            PnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicUserProfile).EndInit();
            pnlTopBar.ResumeLayout(false);
            pnlTopBar.PerformLayout();
            pnlDesktop.ResumeLayout(false);
            pnlDesktop.PerformLayout();
            pnlKategoriler.ResumeLayout(false);
            pnlSlider.ResumeLayout(false);
            pnlSlider.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlSettinsBar.ResumeLayout(false);
            pnlSettinsBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel PnlUser;
        private PictureBox PicUserProfile;
        private Label lblAdSoyad;
        private FontAwesome.Sharp.IconButton btnOut;
        private FontAwesome.Sharp.IconButton btnLessons;
        private FontAwesome.Sharp.IconButton btnSimulations;
        private FontAwesome.Sharp.IconButton btnTests;
        private FontAwesome.Sharp.IconButton btnFlashcards;
        private Panel pnlTopBar;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton btnSettings;
        private Panel pnlShadow;
        private Panel pnlDesktop;
        private Label lblHome;
        private FontAwesome.Sharp.IconButton btnProfilim;
        private Panel pnlSettinsBar;
        private Label lblHosGeldinAd;
        private FontAwesome.Sharp.IconButton btnUygulamaHakkinda;
        private Label lblCizgi;
        private FontAwesome.Sharp.IconButton btnKategoriler;
        private Label lblCizgi2;
        private FontAwesome.Sharp.IconButton btnNotlarım;
        private System.Windows.Forms.Timer sliderTimer;
        private Panel pnlSlider;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel pnlKategoriler;
        private Button btnKategori16;
        private Button btnKategori15;
        private Button btnKategori14;
        private Button btnKategori13;
        private Button btnKategori12;
        private Button btnKategori11;
        private Button btnKategori10;
        private Button btnKategori9;
        private Button btnKategori8;
        private Button btnKategori7;
        private Button btnKategori6;
        private Button btnKategori5;
        private Button btnKategori4;
        private Button btnKategori3;
        private Button btnKategori2;
        private Button btnKategori1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label lblAnaMetin;
        private System.Windows.Forms.Timer timer1;
    }
}
