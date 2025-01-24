namespace finalProject.Forms
{
    partial class Simülasyonlar
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
            pnlSimulasyonlar = new Panel();
            pnlSimulasyon = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            pnlSimulasyon.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSimulasyonlar
            // 
            pnlSimulasyonlar.BackColor = Color.FromArgb(55, 0, 5);
            pnlSimulasyonlar.Dock = DockStyle.Top;
            pnlSimulasyonlar.Location = new Point(0, 0);
            pnlSimulasyonlar.Name = "pnlSimulasyonlar";
            pnlSimulasyonlar.Size = new Size(1209, 54);
            pnlSimulasyonlar.TabIndex = 0;
            // 
            // pnlSimulasyon
            // 
            pnlSimulasyon.Controls.Add(panel1);
            pnlSimulasyon.Dock = DockStyle.Fill;
            pnlSimulasyon.Location = new Point(0, 54);
            pnlSimulasyon.Name = "pnlSimulasyon";
            pnlSimulasyon.Size = new Size(1209, 660);
            pnlSimulasyon.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(55, 0, 5);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(335, 246);
            panel1.Name = "panel1";
            panel1.Size = new Size(538, 168);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(40, 5, 5);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(8, 8);
            panel2.Name = "panel2";
            panel2.Size = new Size(520, 152);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(27, 57);
            label1.Name = "label1";
            label1.Size = new Size(466, 40);
            label1.TabIndex = 0;
            label1.Text = "Bu özellik şu anki sürümde mevcut değil. \r\nSonraki Sürümlerde Bu bölümde görüşmek üzere :3.";
            // 
            // Simülasyonlar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 28, 55);
            ClientSize = new Size(1209, 714);
            Controls.Add(pnlSimulasyon);
            Controls.Add(pnlSimulasyonlar);
            Name = "Simülasyonlar";
            ShowIcon = false;
            Text = "Simülasyonlar";
            pnlSimulasyon.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSimulasyonlar;
        private Panel pnlSimulasyon;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
    }
}