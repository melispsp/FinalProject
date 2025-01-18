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
    public partial class Dersler_SosyalMuhendislik : Form
    {
        private Form currentChildForm;
        string connectionString = "Server=localhost;Database=projectdb;Uid=root;Pwd=;";

        public Dersler_SosyalMuhendislik()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
            // Sadece bir form açık tut
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;

            // Yeni formu ana panelde göster
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlBack.Controls.Add(childForm);
            pnlBack.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnDersIcerigi_Click(object sender, EventArgs e)
        {
            // Tıklanan butonu al
            Button clickedButton = sender as Button;
            if (clickedButton == null) return;

            // Butonun Tag değerini dersID olarak kullan
            int dersID = Convert.ToInt32(clickedButton.Tag);

            // Veritabanı sorgusu
            string query = "SELECT `DersAdi`, `DersIcerigi` FROM dersicerikleri WHERE `dersID` = @dersID";

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

        private void Dersler_SosyalMuhendislik_Load(object sender, EventArgs e)
        {
            // Butonların Tag değerlerini dersID ile eşle
            btnDers1.Tag = 13; // Sosyal mühendislik ile ilgili dersID'ler
            btnDers2.Tag = 14;
            btnDers3.Tag = 15;
            btnDers4.Tag = 16;

            // Click event'lerini butonlara bağla
            btnDers1.Click += btnDersIcerigi_Click;
            btnDers2.Click += btnDersIcerigi_Click;
            btnDers3.Click += btnDersIcerigi_Click;
            btnDers4.Click += btnDersIcerigi_Click;
        }
    }
}
