namespace finalProject.Forms
{
    partial class ders_SiberTehditTurleri
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
            pnlSibergiris = new Panel();
            lblDersAdi = new Label();
            pnlTextNotlar = new Panel();
            tboxDersIcerigi = new TextBox();
            pnlSibergiris.SuspendLayout();
            pnlTextNotlar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSibergiris
            // 
            pnlSibergiris.BackColor = Color.FromArgb(25, 28, 55);
            pnlSibergiris.Controls.Add(lblDersAdi);
            pnlSibergiris.Controls.Add(pnlTextNotlar);
            pnlSibergiris.Dock = DockStyle.Fill;
            pnlSibergiris.Location = new Point(0, 0);
            pnlSibergiris.Name = "pnlSibergiris";
            pnlSibergiris.Size = new Size(1246, 746);
            pnlSibergiris.TabIndex = 1;
            // 
            // lblDersAdi
            // 
            lblDersAdi.AutoSize = true;
            lblDersAdi.Location = new Point(615, 41);
            lblDersAdi.Name = "lblDersAdi";
            lblDersAdi.Size = new Size(0, 20);
            lblDersAdi.TabIndex = 2;
            // 
            // pnlTextNotlar
            // 
            pnlTextNotlar.AutoScroll = true;
            pnlTextNotlar.BackColor = Color.FromArgb(55, 55, 80);
            pnlTextNotlar.Controls.Add(tboxDersIcerigi);
            pnlTextNotlar.Location = new Point(75, 101);
            pnlTextNotlar.Name = "pnlTextNotlar";
            pnlTextNotlar.Size = new Size(1080, 596);
            pnlTextNotlar.TabIndex = 1;
            // 
            // tboxDersIcerigi
            // 
            tboxDersIcerigi.BackColor = Color.FromArgb(30, 35, 60);
            tboxDersIcerigi.BorderStyle = BorderStyle.FixedSingle;
            tboxDersIcerigi.Dock = DockStyle.Fill;
            tboxDersIcerigi.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tboxDersIcerigi.ForeColor = Color.Gainsboro;
            tboxDersIcerigi.Location = new Point(0, 0);
            tboxDersIcerigi.Multiline = true;
            tboxDersIcerigi.Name = "tboxDersIcerigi";
            tboxDersIcerigi.ReadOnly = true;
            tboxDersIcerigi.Size = new Size(1080, 596);
            tboxDersIcerigi.TabIndex = 0;
            // 
            // ders_SiberTehditTurleri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 746);
            Controls.Add(pnlSibergiris);
            Name = "ders_SiberTehditTurleri";
            Text = "ders_SiberTehditTurleri";
            pnlSibergiris.ResumeLayout(false);
            pnlSibergiris.PerformLayout();
            pnlTextNotlar.ResumeLayout(false);
            pnlTextNotlar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSibergiris;
        private Label lblDersAdi;
        private Panel pnlTextNotlar;
        private TextBox tboxDersIcerigi;
    }
}