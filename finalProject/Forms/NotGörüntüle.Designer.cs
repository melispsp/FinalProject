namespace finalProject.Forms
{
    partial class NotGörüntüle
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
            pnlMainNotlarım = new Panel();
            label1 = new Label();
            pnlTextNotlar = new Panel();
            txtKayıtlıNotlar = new TextBox();
            pnlMainNotlarım.SuspendLayout();
            pnlTextNotlar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMainNotlarım
            // 
            pnlMainNotlarım.BackColor = Color.FromArgb(25, 28, 55);
            pnlMainNotlarım.Controls.Add(label1);
            pnlMainNotlarım.Controls.Add(pnlTextNotlar);
            pnlMainNotlarım.Dock = DockStyle.Fill;
            pnlMainNotlarım.Location = new Point(0, 0);
            pnlMainNotlarım.Name = "pnlMainNotlarım";
            pnlMainNotlarım.Size = new Size(993, 579);
            pnlMainNotlarım.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Tahoma", 16.2F);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(411, 46);
            label1.Name = "label1";
            label1.Size = new Size(170, 34);
            label1.TabIndex = 1;
            label1.Text = "Kayıtlı Notlar";
            // 
            // pnlTextNotlar
            // 
            pnlTextNotlar.AutoScroll = true;
            pnlTextNotlar.BackColor = Color.FromArgb(55, 55, 80);
            pnlTextNotlar.Controls.Add(txtKayıtlıNotlar);
            pnlTextNotlar.Location = new Point(98, 116);
            pnlTextNotlar.Name = "pnlTextNotlar";
            pnlTextNotlar.Size = new Size(788, 388);
            pnlTextNotlar.TabIndex = 0;
            // 
            // txtKayıtlıNotlar
            // 
            txtKayıtlıNotlar.BackColor = Color.FromArgb(55, 55, 80);
            txtKayıtlıNotlar.BorderStyle = BorderStyle.FixedSingle;
            txtKayıtlıNotlar.Dock = DockStyle.Fill;
            txtKayıtlıNotlar.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtKayıtlıNotlar.ForeColor = Color.Gainsboro;
            txtKayıtlıNotlar.Location = new Point(0, 0);
            txtKayıtlıNotlar.Multiline = true;
            txtKayıtlıNotlar.Name = "txtKayıtlıNotlar";
            txtKayıtlıNotlar.ReadOnly = true;
            txtKayıtlıNotlar.Size = new Size(788, 388);
            txtKayıtlıNotlar.TabIndex = 0;
            // 
            // NotGörüntüle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 579);
            Controls.Add(pnlMainNotlarım);
            Name = "NotGörüntüle";
            Text = "NotGörüntüle";
            pnlMainNotlarım.ResumeLayout(false);
            pnlMainNotlarım.PerformLayout();
            pnlTextNotlar.ResumeLayout(false);
            pnlTextNotlar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMainNotlarım;
        private Panel pnlTextNotlar;
        private Label label1;
        private TextBox txtKayıtlıNotlar;
    }
}