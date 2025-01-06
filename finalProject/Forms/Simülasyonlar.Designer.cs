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
            pnlSimulasyon.Dock = DockStyle.Fill;
            pnlSimulasyon.Location = new Point(0, 54);
            pnlSimulasyon.Name = "pnlSimulasyon";
            pnlSimulasyon.Size = new Size(1209, 660);
            pnlSimulasyon.TabIndex = 1;
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
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSimulasyonlar;
        private Panel pnlSimulasyon;
    }
}