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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelMenu = new Panel();
            btnSimulations = new FontAwesome.Sharp.IconButton();
            btnTests = new FontAwesome.Sharp.IconButton();
            btnFlashcards = new FontAwesome.Sharp.IconButton();
            btnLessons = new FontAwesome.Sharp.IconButton();
            btnOut = new FontAwesome.Sharp.IconButton();
            PnlUser = new Panel();
            label1 = new Label();
            PicUserProfile = new PictureBox();
            pnlTopBar = new Panel();
            lblHome = new Label();
            btnSettings = new FontAwesome.Sharp.IconButton();
            btnHome = new FontAwesome.Sharp.IconButton();
            pnlShadow = new Panel();
            pnlDesktop = new Panel();
            ıconButton1 = new FontAwesome.Sharp.IconButton();
            ıconButton2 = new FontAwesome.Sharp.IconButton();
            ıconButton3 = new FontAwesome.Sharp.IconButton();
            ıconButton4 = new FontAwesome.Sharp.IconButton();
            ıconButton5 = new FontAwesome.Sharp.IconButton();
            pnlSettinsBar = new Panel();
            panelMenu.SuspendLayout();
            PnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicUserProfile).BeginInit();
            pnlTopBar.SuspendLayout();
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
            panelMenu.Size = new Size(220, 700);
            panelMenu.TabIndex = 0;
            // 
            // btnSimulations
            // 
            btnSimulations.Dock = DockStyle.Top;
            btnSimulations.FlatAppearance.BorderSize = 0;
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
            btnOut.FlatStyle = FlatStyle.Flat;
            btnOut.ForeColor = Color.Silver;
            btnOut.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            btnOut.IconColor = Color.Silver;
            btnOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnOut.IconSize = 40;
            btnOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnOut.Location = new Point(0, 655);
            btnOut.Name = "btnOut";
            btnOut.Padding = new Padding(10, 0, 20, 0);
            btnOut.Size = new Size(220, 45);
            btnOut.TabIndex = 5;
            btnOut.Text = "Çıkış Yap";
            btnOut.UseVisualStyleBackColor = false;
            btnOut.Click += btnOut_Click;
            // 
            // PnlUser
            // 
            PnlUser.BackColor = Color.FromArgb(8, 6, 15);
            PnlUser.Controls.Add(label1);
            PnlUser.Controls.Add(PicUserProfile);
            PnlUser.Dock = DockStyle.Top;
            PnlUser.Location = new Point(0, 0);
            PnlUser.Name = "PnlUser";
            PnlUser.Size = new Size(220, 145);
            PnlUser.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.LightSkyBlue;
            label1.Location = new Point(60, 122);
            label1.Name = "label1";
            label1.Size = new Size(100, 19);
            label1.TabIndex = 0;
            label1.Text = "Melisa Köklü";
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
            pnlTopBar.Controls.Add(lblHome);
            pnlTopBar.Controls.Add(btnSettings);
            pnlTopBar.Controls.Add(btnHome);
            pnlTopBar.Dock = DockStyle.Top;
            pnlTopBar.Location = new Point(220, 0);
            pnlTopBar.Name = "pnlTopBar";
            pnlTopBar.Size = new Size(780, 60);
            pnlTopBar.TabIndex = 1;
            pnlTopBar.MouseDown += pnlTopBar_MouseDown;
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
            btnSettings.Location = new Point(720, 0);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(60, 60);
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
            pnlShadow.Size = new Size(550, 8);
            pnlShadow.TabIndex = 3;
            // 
            // pnlDesktop
            // 
            pnlDesktop.Dock = DockStyle.Fill;
            pnlDesktop.Location = new Point(220, 68);
            pnlDesktop.Name = "pnlDesktop";
            pnlDesktop.Size = new Size(550, 632);
            pnlDesktop.TabIndex = 4;
            // 
            // ıconButton1
            // 
            ıconButton1.Dock = DockStyle.Top;
            ıconButton1.FlatAppearance.BorderSize = 0;
            ıconButton1.FlatStyle = FlatStyle.Flat;
            ıconButton1.ForeColor = Color.Lavender;
            ıconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            ıconButton1.IconColor = Color.Lavender;
            ıconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconButton1.IconSize = 44;
            ıconButton1.Location = new Point(0, 0);
            ıconButton1.Name = "ıconButton1";
            ıconButton1.Padding = new Padding(0, 10, 0, 10);
            ıconButton1.Size = new Size(230, 45);
            ıconButton1.TabIndex = 0;
            ıconButton1.Text = "ıconButton1";
            ıconButton1.UseVisualStyleBackColor = true;
            // 
            // ıconButton2
            // 
            ıconButton2.Dock = DockStyle.Top;
            ıconButton2.FlatAppearance.BorderSize = 0;
            ıconButton2.FlatStyle = FlatStyle.Flat;
            ıconButton2.ForeColor = Color.Lavender;
            ıconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            ıconButton2.IconColor = Color.Lavender;
            ıconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconButton2.IconSize = 44;
            ıconButton2.Location = new Point(0, 45);
            ıconButton2.Name = "ıconButton2";
            ıconButton2.Padding = new Padding(0, 10, 0, 10);
            ıconButton2.Size = new Size(230, 45);
            ıconButton2.TabIndex = 1;
            ıconButton2.Text = "ıconButton2";
            ıconButton2.UseVisualStyleBackColor = true;
            // 
            // ıconButton3
            // 
            ıconButton3.Dock = DockStyle.Top;
            ıconButton3.FlatAppearance.BorderSize = 0;
            ıconButton3.FlatStyle = FlatStyle.Flat;
            ıconButton3.ForeColor = Color.Lavender;
            ıconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            ıconButton3.IconColor = Color.Lavender;
            ıconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconButton3.IconSize = 44;
            ıconButton3.Location = new Point(0, 90);
            ıconButton3.Name = "ıconButton3";
            ıconButton3.Padding = new Padding(0, 10, 0, 10);
            ıconButton3.Size = new Size(230, 45);
            ıconButton3.TabIndex = 2;
            ıconButton3.Text = "ıconButton3";
            ıconButton3.UseVisualStyleBackColor = true;
            // 
            // ıconButton4
            // 
            ıconButton4.Dock = DockStyle.Top;
            ıconButton4.FlatAppearance.BorderSize = 0;
            ıconButton4.FlatStyle = FlatStyle.Flat;
            ıconButton4.ForeColor = Color.Lavender;
            ıconButton4.IconChar = FontAwesome.Sharp.IconChar.None;
            ıconButton4.IconColor = Color.Lavender;
            ıconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconButton4.IconSize = 44;
            ıconButton4.Location = new Point(0, 135);
            ıconButton4.Name = "ıconButton4";
            ıconButton4.Padding = new Padding(0, 10, 0, 10);
            ıconButton4.Size = new Size(230, 45);
            ıconButton4.TabIndex = 3;
            ıconButton4.Text = "ıconButton4";
            ıconButton4.UseVisualStyleBackColor = true;
            // 
            // ıconButton5
            // 
            ıconButton5.Dock = DockStyle.Top;
            ıconButton5.FlatAppearance.BorderSize = 0;
            ıconButton5.FlatStyle = FlatStyle.Flat;
            ıconButton5.ForeColor = Color.Lavender;
            ıconButton5.IconChar = FontAwesome.Sharp.IconChar.None;
            ıconButton5.IconColor = Color.Lavender;
            ıconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconButton5.IconSize = 44;
            ıconButton5.Location = new Point(0, 180);
            ıconButton5.Name = "ıconButton5";
            ıconButton5.Padding = new Padding(0, 10, 0, 10);
            ıconButton5.Size = new Size(230, 45);
            ıconButton5.TabIndex = 4;
            ıconButton5.Text = "ıconButton5";
            ıconButton5.UseVisualStyleBackColor = true;
            // 
            // pnlSettinsBar
            // 
            pnlSettinsBar.BackColor = Color.FromArgb(20, 0, 32);
            pnlSettinsBar.Controls.Add(ıconButton5);
            pnlSettinsBar.Controls.Add(ıconButton4);
            pnlSettinsBar.Controls.Add(ıconButton3);
            pnlSettinsBar.Controls.Add(ıconButton2);
            pnlSettinsBar.Controls.Add(ıconButton1);
            pnlSettinsBar.Dock = DockStyle.Right;
            pnlSettinsBar.Location = new Point(770, 60);
            pnlSettinsBar.Name = "pnlSettinsBar";
            pnlSettinsBar.Size = new Size(230, 640);
            pnlSettinsBar.TabIndex = 2;
            pnlSettinsBar.Visible = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 28, 55);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1000, 700);
            Controls.Add(pnlDesktop);
            Controls.Add(pnlShadow);
            Controls.Add(pnlSettinsBar);
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
            pnlSettinsBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel PnlUser;
        private PictureBox PicUserProfile;
        private Label label1;
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
        private FontAwesome.Sharp.IconButton ıconButton1;
        private FontAwesome.Sharp.IconButton ıconButton2;
        private FontAwesome.Sharp.IconButton ıconButton3;
        private FontAwesome.Sharp.IconButton ıconButton4;
        private FontAwesome.Sharp.IconButton ıconButton5;
        private Panel pnlSettinsBar;
    }
}
