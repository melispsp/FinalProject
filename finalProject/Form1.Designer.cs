namespace finalProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelMenu = new Panel();
            btnSimulations = new FontAwesome.Sharp.IconButton();
            btnTests = new FontAwesome.Sharp.IconButton();
            btnFlashcards = new FontAwesome.Sharp.IconButton();
            btnLessons = new FontAwesome.Sharp.IconButton();
            BtnOut = new FontAwesome.Sharp.IconButton();
            PnlUser = new Panel();
            label1 = new Label();
            PicUserProfile = new PictureBox();
            panelMenu.SuspendLayout();
            PnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicUserProfile).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(8, 6, 15);
            panelMenu.Controls.Add(btnSimulations);
            panelMenu.Controls.Add(btnTests);
            panelMenu.Controls.Add(btnFlashcards);
            panelMenu.Controls.Add(btnLessons);
            panelMenu.Controls.Add(BtnOut);
            panelMenu.Controls.Add(PnlUser);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 663);
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
            btnSimulations.Location = new Point(0, 293);
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
            btnTests.Location = new Point(0, 243);
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
            btnFlashcards.Location = new Point(0, 193);
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
            btnLessons.Location = new Point(0, 143);
            btnLessons.Name = "btnLessons";
            btnLessons.Padding = new Padding(10, 0, 0, 0);
            btnLessons.Size = new Size(220, 50);
            btnLessons.TabIndex = 6;
            btnLessons.Text = "Dersler";
            btnLessons.UseVisualStyleBackColor = true;
            btnLessons.Click += btnLessons_Click;
            // 
            // BtnOut
            // 
            BtnOut.BackColor = Color.Black;
            BtnOut.BackgroundImageLayout = ImageLayout.None;
            BtnOut.Dock = DockStyle.Bottom;
            BtnOut.FlatAppearance.BorderSize = 0;
            BtnOut.FlatStyle = FlatStyle.Flat;
            BtnOut.ForeColor = Color.Silver;
            BtnOut.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            BtnOut.IconColor = Color.Silver;
            BtnOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnOut.IconSize = 40;
            BtnOut.ImageAlign = ContentAlignment.MiddleLeft;
            BtnOut.Location = new Point(0, 618);
            BtnOut.Name = "BtnOut";
            BtnOut.Padding = new Padding(10, 0, 20, 0);
            BtnOut.Size = new Size(220, 45);
            BtnOut.TabIndex = 5;
            BtnOut.Text = "Çıkış Yap";
            BtnOut.UseVisualStyleBackColor = false;
            // 
            // PnlUser
            // 
            PnlUser.BackColor = Color.FromArgb(8, 6, 15);
            PnlUser.Controls.Add(label1);
            PnlUser.Controls.Add(PicUserProfile);
            PnlUser.Dock = DockStyle.Top;
            PnlUser.Location = new Point(0, 0);
            PnlUser.Name = "PnlUser";
            PnlUser.Size = new Size(220, 143);
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
            PicUserProfile.Size = new Size(220, 119);
            PicUserProfile.SizeMode = PictureBoxSizeMode.Zoom;
            PicUserProfile.TabIndex = 0;
            PicUserProfile.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 26, 50);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(879, 663);
            Controls.Add(panelMenu);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            PnlUser.ResumeLayout(false);
            PnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicUserProfile).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel PnlUser;
        private PictureBox PicUserProfile;
        private Label label1;
        private FontAwesome.Sharp.IconButton BtnOut;
        private FontAwesome.Sharp.IconButton btnLessons;
        private FontAwesome.Sharp.IconButton btnSimulations;
        private FontAwesome.Sharp.IconButton btnTests;
        private FontAwesome.Sharp.IconButton btnFlashcards;
    }
}
