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
            pnlKategoriler = new Panel();
            button16 = new Button();
            button15 = new Button();
            button14 = new Button();
            button13 = new Button();
            button12 = new Button();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pnlSlider = new Panel();
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
            pnlDesktop.Controls.Add(pnlKategoriler);
            pnlDesktop.Controls.Add(pnlSlider);
            pnlDesktop.Dock = DockStyle.Fill;
            pnlDesktop.Location = new Point(220, 68);
            pnlDesktop.Name = "pnlDesktop";
            pnlDesktop.Size = new Size(1227, 731);
            pnlDesktop.TabIndex = 4;
            // 
            // pnlKategoriler
            // 
            pnlKategoriler.BackColor = Color.FromArgb(20, 0, 32);
            pnlKategoriler.Controls.Add(button16);
            pnlKategoriler.Controls.Add(button15);
            pnlKategoriler.Controls.Add(button14);
            pnlKategoriler.Controls.Add(button13);
            pnlKategoriler.Controls.Add(button12);
            pnlKategoriler.Controls.Add(button11);
            pnlKategoriler.Controls.Add(button10);
            pnlKategoriler.Controls.Add(button9);
            pnlKategoriler.Controls.Add(button8);
            pnlKategoriler.Controls.Add(button7);
            pnlKategoriler.Controls.Add(button6);
            pnlKategoriler.Controls.Add(button5);
            pnlKategoriler.Controls.Add(button4);
            pnlKategoriler.Controls.Add(button3);
            pnlKategoriler.Controls.Add(button2);
            pnlKategoriler.Controls.Add(button1);
            pnlKategoriler.Location = new Point(772, 127);
            pnlKategoriler.Name = "pnlKategoriler";
            pnlKategoriler.Size = new Size(228, 466);
            pnlKategoriler.TabIndex = 7;
            pnlKategoriler.Visible = false;
            // 
            // button16
            // 
            button16.Dock = DockStyle.Top;
            button16.FlatAppearance.BorderSize = 0;
            button16.FlatStyle = FlatStyle.Flat;
            button16.ForeColor = Color.Lavender;
            button16.Location = new Point(0, 435);
            button16.Name = "button16";
            button16.Padding = new Padding(5, 0, 0, 0);
            button16.Size = new Size(228, 29);
            button16.TabIndex = 15;
            button16.Text = "Sosyal Mühendislikten Korunma Yolları";
            button16.TextAlign = ContentAlignment.MiddleLeft;
            button16.UseVisualStyleBackColor = true;
            button16.Click += buttonKategoriler_Click;
            // 
            // button15
            // 
            button15.Dock = DockStyle.Top;
            button15.FlatAppearance.BorderSize = 0;
            button15.FlatStyle = FlatStyle.Flat;
            button15.ForeColor = Color.Lavender;
            button15.Location = new Point(0, 406);
            button15.Name = "button15";
            button15.Padding = new Padding(5, 0, 0, 0);
            button15.Size = new Size(228, 29);
            button15.TabIndex = 14;
            button15.Text = "Psikolojik Teknikler";
            button15.TextAlign = ContentAlignment.MiddleLeft;
            button15.UseVisualStyleBackColor = true;
            button15.Click += buttonKategoriler_Click;
            // 
            // button14
            // 
            button14.Dock = DockStyle.Top;
            button14.FlatAppearance.BorderSize = 0;
            button14.FlatStyle = FlatStyle.Flat;
            button14.ForeColor = Color.Lavender;
            button14.Location = new Point(0, 377);
            button14.Name = "button14";
            button14.Padding = new Padding(5, 0, 0, 0);
            button14.Size = new Size(228, 29);
            button14.TabIndex = 13;
            button14.Text = "Sosyal Mühendislikte Saldırı Çeşitleri";
            button14.TextAlign = ContentAlignment.MiddleLeft;
            button14.UseVisualStyleBackColor = true;
            button14.Click += buttonKategoriler_Click;
            // 
            // button13
            // 
            button13.Dock = DockStyle.Top;
            button13.FlatAppearance.BorderSize = 0;
            button13.FlatStyle = FlatStyle.Flat;
            button13.ForeColor = Color.Lavender;
            button13.Location = new Point(0, 348);
            button13.Name = "button13";
            button13.Padding = new Padding(5, 0, 0, 0);
            button13.Size = new Size(228, 29);
            button13.TabIndex = 12;
            button13.Text = "Sosyal mühendislik nedir?";
            button13.TextAlign = ContentAlignment.MiddleLeft;
            button13.UseVisualStyleBackColor = true;
            button13.Click += buttonKategoriler_Click;
            // 
            // button12
            // 
            button12.Dock = DockStyle.Top;
            button12.FlatAppearance.BorderSize = 0;
            button12.FlatStyle = FlatStyle.Flat;
            button12.ForeColor = Color.Lavender;
            button12.Location = new Point(0, 319);
            button12.Name = "button12";
            button12.Padding = new Padding(5, 0, 0, 0);
            button12.Size = new Size(228, 29);
            button12.TabIndex = 11;
            button12.Text = "Zararlı Yazılımlardan Korunma Yöntemleri";
            button12.TextAlign = ContentAlignment.MiddleLeft;
            button12.UseVisualStyleBackColor = true;
            button12.Click += buttonKategoriler_Click;
            // 
            // button11
            // 
            button11.Dock = DockStyle.Top;
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Flat;
            button11.ForeColor = Color.Lavender;
            button11.Location = new Point(0, 290);
            button11.Name = "button11";
            button11.Padding = new Padding(5, 0, 0, 0);
            button11.Size = new Size(228, 29);
            button11.TabIndex = 10;
            button11.Text = "Zararlı Yazılım Tespiti ve Analizi";
            button11.TextAlign = ContentAlignment.MiddleLeft;
            button11.UseVisualStyleBackColor = true;
            button11.Click += buttonKategoriler_Click;
            // 
            // button10
            // 
            button10.Dock = DockStyle.Top;
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.ForeColor = Color.Lavender;
            button10.Location = new Point(0, 261);
            button10.Name = "button10";
            button10.Padding = new Padding(5, 0, 0, 0);
            button10.Size = new Size(228, 29);
            button10.TabIndex = 9;
            button10.Text = "Zararlı Yazılımlar Nasıl Çalışır?";
            button10.TextAlign = ContentAlignment.MiddleLeft;
            button10.UseVisualStyleBackColor = true;
            button10.Click += buttonKategoriler_Click;
            // 
            // button9
            // 
            button9.Dock = DockStyle.Top;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.ForeColor = Color.Lavender;
            button9.Location = new Point(0, 232);
            button9.Name = "button9";
            button9.Padding = new Padding(5, 0, 0, 0);
            button9.Size = new Size(228, 29);
            button9.TabIndex = 8;
            button9.Text = "Zararlı Yazılım Nedir? ";
            button9.TextAlign = ContentAlignment.MiddleLeft;
            button9.UseVisualStyleBackColor = true;
            button9.Click += buttonKategoriler_Click;
            // 
            // button8
            // 
            button8.Dock = DockStyle.Top;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.ForeColor = Color.Lavender;
            button8.Location = new Point(0, 203);
            button8.Name = "button8";
            button8.Padding = new Padding(5, 0, 0, 0);
            button8.Size = new Size(228, 29);
            button8.TabIndex = 7;
            button8.Text = "Ağ İzleme ve Saldırı Tespiti";
            button8.TextAlign = ContentAlignment.MiddleLeft;
            button8.UseVisualStyleBackColor = true;
            button8.Click += buttonKategoriler_Click;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Top;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.Lavender;
            button7.Location = new Point(0, 174);
            button7.Name = "button7";
            button7.Padding = new Padding(5, 0, 0, 0);
            button7.Size = new Size(228, 29);
            button7.TabIndex = 6;
            button7.Text = "Ağ Güvenliği Temelleri";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = true;
            button7.Click += buttonKategoriler_Click;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Top;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.Lavender;
            button6.Location = new Point(0, 145);
            button6.Name = "button6";
            button6.Padding = new Padding(5, 0, 0, 0);
            button6.Size = new Size(228, 29);
            button6.TabIndex = 5;
            button6.Text = "Ağ Protokolleri ve Veri İletişimi";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = true;
            button6.Click += buttonKategoriler_Click;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Top;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.Lavender;
            button5.Location = new Point(0, 116);
            button5.Name = "button5";
            button5.Padding = new Padding(5, 0, 0, 0);
            button5.Size = new Size(228, 29);
            button5.TabIndex = 4;
            button5.Text = "Temel Ağ Bilgisi";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = true;
            button5.Click += buttonKategoriler_Click;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.Lavender;
            button4.Location = new Point(0, 87);
            button4.Name = "button4";
            button4.Padding = new Padding(5, 0, 0, 0);
            button4.Size = new Size(228, 29);
            button4.TabIndex = 3;
            button4.Text = "Temel Koruma Yöntemleri";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            button4.Click += buttonKategoriler_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Lavender;
            button3.Location = new Point(0, 58);
            button3.Name = "button3";
            button3.Padding = new Padding(5, 0, 0, 0);
            button3.Size = new Size(228, 29);
            button3.TabIndex = 2;
            button3.Text = "Şifreleme ve Kriptografi";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            button3.Click += buttonKategoriler_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Lavender;
            button2.Location = new Point(0, 29);
            button2.Name = "button2";
            button2.Padding = new Padding(5, 0, 0, 0);
            button2.Size = new Size(228, 29);
            button2.TabIndex = 1;
            button2.Text = "Siber Tehdit Türleri";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonKategoriler_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Lavender;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Padding = new Padding(5, 0, 0, 0);
            button1.Size = new Size(228, 29);
            button1.TabIndex = 0;
            button1.Text = "Siber Güvenlik Nedir?";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonKategoriler_Click;
            // 
            // pnlSlider
            // 
            pnlSlider.Controls.Add(pictureBox3);
            pnlSlider.Controls.Add(pictureBox2);
            pnlSlider.Controls.Add(pictureBox1);
            pnlSlider.Location = new Point(6, 200);
            pnlSlider.Name = "pnlSlider";
            pnlSlider.Size = new Size(1221, 355);
            pnlSlider.TabIndex = 0;
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
            btnUygulamaHakkinda.Text = "Uygulama Hakkında";
            btnUygulamaHakkinda.UseVisualStyleBackColor = true;
            // 
            // sliderTimer
            // 
            sliderTimer.Interval = 5;
            sliderTimer.Tick += sliderTimer_Tick_1;
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
            panelMenu.ResumeLayout(false);
            PnlUser.ResumeLayout(false);
            PnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicUserProfile).EndInit();
            pnlTopBar.ResumeLayout(false);
            pnlTopBar.PerformLayout();
            pnlDesktop.ResumeLayout(false);
            pnlKategoriler.ResumeLayout(false);
            pnlSlider.ResumeLayout(false);
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
        private Button button16;
        private Button button15;
        private Button button14;
        private Button button13;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}
