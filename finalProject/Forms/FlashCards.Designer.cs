namespace finalProject.Forms
{
    partial class FlashCards
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            btnCard1 = new Button();
            btnCard2 = new Button();
            btnCard3 = new Button();
            btnCard4 = new Button();
            btnCard5 = new Button();
            btnCard6 = new Button();
            btnCard7 = new Button();
            btnCard8 = new Button();

            // Butonlarılisteye ekleyin
            cards.Add(new Card("Front 1", "Back 1", btnCard1));
            cards.Add(new Card("Front 2", "Back 2", btnCard2));
            cards.Add(new Card("Front 3", "Back 3", btnCard3));
            cards.Add(new Card("Front 4", "Back 4", btnCard4));
            cards.Add(new Card("Front 5", "Back 5", btnCard5));
            cards.Add(new Card("Front 6", "Back 6", btnCard6));
            cards.Add(new Card("Front 7", "Back 7", btnCard7));
            cards.Add(new Card("Front 8", "Back 8", btnCard8));


            pnlflashcard = new Panel();
            panel2 = new Panel();
            lblHosGeldiniz = new Label();
            panel1 = new Panel();
            btnRefresh = new FontAwesome.Sharp.IconButton();
            pnlflashcard.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // btnCard1
            // 
            btnCard1.BackColor = Color.BlueViolet;
            btnCard1.FlatAppearance.BorderColor = Color.MediumSlateBlue;
            btnCard1.FlatAppearance.BorderSize = 3;
            btnCard1.FlatStyle = FlatStyle.Flat;
            btnCard1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCard1.ForeColor = Color.WhiteSmoke;
            btnCard1.Location = new Point(153, 140);
            btnCard1.Name = "btnCard1";
            btnCard1.Size = new Size(181, 260);
            btnCard1.TabIndex = 0;
            btnCard1.UseVisualStyleBackColor = false;
            btnCard1.Click += btnCard_Click;
            // 
            // btnCard2
            // 
            btnCard2.BackColor = Color.BlueViolet;
            btnCard2.FlatAppearance.BorderColor = Color.MediumSlateBlue;
            btnCard2.FlatAppearance.BorderSize = 3;
            btnCard2.FlatStyle = FlatStyle.Flat;
            btnCard2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCard2.ForeColor = Color.WhiteSmoke;
            btnCard2.Location = new Point(386, 140);
            btnCard2.Name = "btnCard2";
            btnCard2.Size = new Size(181, 260);
            btnCard2.TabIndex = 1;
            btnCard2.UseVisualStyleBackColor = false;
            btnCard2.Click += btnCard_Click;
            // 
            // btnCard3
            // 
            btnCard3.BackColor = Color.BlueViolet;
            btnCard3.FlatAppearance.BorderColor = Color.MediumSlateBlue;
            btnCard3.FlatAppearance.BorderSize = 3;
            btnCard3.FlatStyle = FlatStyle.Flat;
            btnCard3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCard3.ForeColor = Color.WhiteSmoke;
            btnCard3.Location = new Point(618, 140);
            btnCard3.Name = "btnCard3";
            btnCard3.Size = new Size(181, 260);
            btnCard3.TabIndex = 2;
            btnCard3.UseVisualStyleBackColor = false;
            btnCard3.Click += btnCard_Click;
            // 
            // btnCard4
            // 
            btnCard4.BackColor = Color.BlueViolet;
            btnCard4.FlatAppearance.BorderColor = Color.MediumSlateBlue;
            btnCard4.FlatAppearance.BorderSize = 3;
            btnCard4.FlatStyle = FlatStyle.Flat;
            btnCard4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCard4.ForeColor = Color.WhiteSmoke;
            btnCard4.Location = new Point(153, 427);
            btnCard4.Name = "btnCard4";
            btnCard4.Size = new Size(181, 260);
            btnCard4.TabIndex = 3;
            btnCard4.UseVisualStyleBackColor = false;
            btnCard4.Click += btnCard_Click;
            // 
            // btnCard5
            // 
            btnCard5.BackColor = Color.BlueViolet;
            btnCard5.FlatAppearance.BorderColor = Color.MediumSlateBlue;
            btnCard5.FlatAppearance.BorderSize = 3;
            btnCard5.FlatStyle = FlatStyle.Flat;
            btnCard5.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCard5.ForeColor = Color.WhiteSmoke;
            btnCard5.Location = new Point(386, 427);
            btnCard5.Name = "btnCard5";
            btnCard5.Size = new Size(181, 260);
            btnCard5.TabIndex = 4;
            btnCard5.UseVisualStyleBackColor = false;
            btnCard5.Click += btnCard_Click;
            // 
            // btnCard6
            // 
            btnCard6.BackColor = Color.BlueViolet;
            btnCard6.FlatAppearance.BorderColor = Color.MediumSlateBlue;
            btnCard6.FlatAppearance.BorderSize = 3;
            btnCard6.FlatStyle = FlatStyle.Flat;
            btnCard6.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCard6.ForeColor = Color.WhiteSmoke;
            btnCard6.Location = new Point(618, 427);
            btnCard6.Name = "btnCard6";
            btnCard6.Size = new Size(181, 260);
            btnCard6.TabIndex = 5;
            btnCard6.UseVisualStyleBackColor = false;
            btnCard6.Click += btnCard_Click;
            // 
            // btnCard7
            // 
            btnCard7.BackColor = Color.BlueViolet;
            btnCard7.FlatAppearance.BorderColor = Color.MediumSlateBlue;
            btnCard7.FlatAppearance.BorderSize = 3;
            btnCard7.FlatStyle = FlatStyle.Flat;
            btnCard7.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCard7.ForeColor = Color.WhiteSmoke;
            btnCard7.Location = new Point(852, 140);
            btnCard7.Name = "btnCard7";
            btnCard7.Size = new Size(181, 260);
            btnCard7.TabIndex = 6;
            btnCard7.UseVisualStyleBackColor = false;
            btnCard7.Click += btnCard_Click;
            // 
            // btnCard8
            // 
            btnCard8.BackColor = Color.BlueViolet;
            btnCard8.FlatAppearance.BorderColor = Color.MediumSlateBlue;
            btnCard8.FlatAppearance.BorderSize = 3;
            btnCard8.FlatStyle = FlatStyle.Flat;
            btnCard8.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCard8.ForeColor = Color.WhiteSmoke;
            btnCard8.Location = new Point(852, 427);
            btnCard8.Name = "btnCard8";
            btnCard8.Size = new Size(181, 260);
            btnCard8.TabIndex = 7;
            btnCard8.UseVisualStyleBackColor = false;
            btnCard8.Click += btnCard_Click;
            // 
            // pnlflashcard
            // 
            pnlflashcard.Controls.Add(panel2);
            pnlflashcard.Controls.Add(panel1);
            pnlflashcard.Dock = DockStyle.Fill;
            pnlflashcard.Location = new Point(0, 0);
            pnlflashcard.Name = "pnlflashcard";
            pnlflashcard.Size = new Size(1209, 714);
            pnlflashcard.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblHosGeldiniz);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(1209, 45);
            panel2.TabIndex = 11;
            // 
            // lblHosGeldiniz
            // 
            lblHosGeldiniz.Dock = DockStyle.Bottom;
            lblHosGeldiniz.ForeColor = Color.Gainsboro;
            lblHosGeldiniz.Location = new Point(0, 11);
            lblHosGeldiniz.Name = "lblHosGeldiniz";
            lblHosGeldiniz.Size = new Size(1209, 34);
            lblHosGeldiniz.TabIndex = 0;
            lblHosGeldiniz.Text = "   Hoş Geldiniz!  Kartların ön yüzünde eğitimlerde gördüğünüz bazı kavramlar bulunmakta. Arka yüzünde ise açıklamaları. Daha hızlı öğrenmek için çevirmeye başlayın!";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(60, 0, 80);
            panel1.Controls.Add(btnRefresh);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1209, 60);
            panel1.TabIndex = 10;
            // 
            // btnRefresh
            // 
            btnRefresh.Dock = DockStyle.Right;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 2, 76);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            btnRefresh.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.Gainsboro;
            btnRefresh.IconChar = FontAwesome.Sharp.IconChar.Refresh;
            btnRefresh.IconColor = Color.Gainsboro;
            btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRefresh.IconSize = 25;
            btnRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            btnRefresh.Location = new Point(1060, 0);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Padding = new Padding(15, 0, 15, 0);
            btnRefresh.Size = new Size(149, 60);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "Yenile";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // FlashCards
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 28, 55);
            ClientSize = new Size(1209, 714);
            Controls.Add(btnCard8);
            Controls.Add(btnCard7);
            Controls.Add(btnCard6);
            Controls.Add(btnCard5);
            Controls.Add(btnCard4);
            Controls.Add(btnCard3);
            Controls.Add(btnCard2);
            Controls.Add(btnCard1);
            Controls.Add(pnlflashcard);
            Name = "FlashCards";
            ShowIcon = false;
            Text = "Flashcards";
            pnlflashcard.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Button btnCard1;
        private Button btnCard2;
        private Button btnCard3;
        private Button btnCard4;
        private Button btnCard5;
        private Button btnCard6;
        private Button btnCard7;
        private Button btnCard8;
        private Panel pnlflashcard;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private Panel panel2;
        private Label lblHosGeldiniz;
    }
}