using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace finalProject.Forms
{
    public partial class Dersler_siberGüvenligeGiris : Form
    {
        private Form dersForm;
        string connectionString = "Server=localhost;Database=projectdb;Uid=root;Pwd=;";
        private Form currentChildForm;

        public Dersler_siberGüvenligeGiris()
        {
            InitializeComponent();
        }
                
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlBackPanel.Controls.Add(childForm);
            pnlBackPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        
        }


        private void btnDersIcerigi(object sender, EventArgs e)
        {

            // Tıklanan butonu al
            Button clickedButton = sender as Button;
            if (clickedButton == null) return;

            // Butonun Tag değerini al ve dersID olarak kullan
            int dersID = Convert.ToInt32(clickedButton.Tag);

            // Veritabanı sorgusu
            string query = "SELECT `DersAdi`, `DersIcerigi` FROM dersiceriği WHERE `dersID` = @dersID";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@dersID", dersID);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read()) // Veri varsa
                            {
                                // Ders adı ve içeriğini al
                                string dersAdi = reader["DersAdi"].ToString();
                                string dersIcerigi = reader["DersIcerigi"].ToString();

                                // Yeni formu oluştur ve özellikleri ayarla
                                Forms.DersIcerigi dersForm = new Forms.DersIcerigi
                                {
                                    DersinAdi = dersAdi,
                                    DersinIcerigi = dersIcerigi
                                };

                                // Formu göster
                                OpenChildForm(dersForm);

                          

                            }
                            else
                            {
                                MessageBox.Show("Bu ders için içerik bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Dersler_siberGüvenligeGiris_Load(object sender, EventArgs e)
        {
            btnDers1.Tag = 1; 
            btnDers2.Tag = 2; 
            btnDers3.Tag = 3; 
            btnDers4.Tag = 4; 

        }
    }
}