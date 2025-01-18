namespace finalProject.Forms
{
    partial class DersIcerigi
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
            pnlBack = new Panel();
            btnClose = new FontAwesome.Sharp.IconButton();
            lblDersAdi = new Label();
            panel2 = new Panel();
            tboxDersIcerigi = new TextBox();
            panel1 = new Panel();
            pnlBack.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBack
            // 
            pnlBack.BackColor = Color.FromArgb(25, 28, 55);
            pnlBack.Controls.Add(btnClose);
            pnlBack.Controls.Add(lblDersAdi);
            pnlBack.Controls.Add(panel2);
            pnlBack.Controls.Add(panel1);
            pnlBack.Dock = DockStyle.Fill;
            pnlBack.Location = new Point(0, 0);
            pnlBack.Name = "pnlBack";
            pnlBack.Size = new Size(1209, 714);
            pnlBack.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            btnClose.IconChar = FontAwesome.Sharp.IconChar.X;
            btnClose.IconColor = Color.LightGray;
            btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClose.IconSize = 25;
            btnClose.Location = new Point(1174, 58);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 30);
            btnClose.TabIndex = 3;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblDersAdi
            // 
            lblDersAdi.AutoSize = true;
            lblDersAdi.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblDersAdi.ForeColor = Color.WhiteSmoke;
            lblDersAdi.Location = new Point(537, 84);
            lblDersAdi.Name = "lblDersAdi";
            lblDersAdi.Size = new Size(0, 23);
            lblDersAdi.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(tboxDersIcerigi);
            panel2.Location = new Point(110, 124);
            panel2.Name = "panel2";
            panel2.Size = new Size(988, 561);
            panel2.TabIndex = 1;
            // 
            // tboxDersIcerigi
            // 
            tboxDersIcerigi.AccessibleRole = AccessibleRole.ScrollBar;
            tboxDersIcerigi.BackColor = Color.FromArgb(35, 40, 65);
            tboxDersIcerigi.BorderStyle = BorderStyle.FixedSingle;
            tboxDersIcerigi.Dock = DockStyle.Fill;
            tboxDersIcerigi.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tboxDersIcerigi.ForeColor = Color.WhiteSmoke;
            tboxDersIcerigi.Location = new Point(0, 0);
            tboxDersIcerigi.Multiline = true;
            tboxDersIcerigi.Name = "tboxDersIcerigi";
            tboxDersIcerigi.ReadOnly = true;
            tboxDersIcerigi.ScrollBars = ScrollBars.Vertical;
            tboxDersIcerigi.Size = new Size(988, 561);
            tboxDersIcerigi.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1209, 54);
            panel1.TabIndex = 0;
            // 
            // DersIcerigi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 714);
            Controls.Add(pnlBack);
            Name = "DersIcerigi";
            Text = "DersIcerigi";
            pnlBack.ResumeLayout(false);
            pnlBack.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBack;
        private Panel panel2;
        private TextBox tboxDersIcerigi;
        private Panel panel1;
        private Label lblDersAdi;
        private FontAwesome.Sharp.IconButton btnClose;
    }
}