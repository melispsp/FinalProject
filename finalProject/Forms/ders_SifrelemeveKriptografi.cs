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
    public partial class ders_SifrelemeveKriptografi : Form
    {
        // Bağlantı dizesi (connection string) burada tanımlı olmalı.
        string connectionString = "your_connection_string_here";

        public ders_SifrelemeveKriptografi()
        {
            InitializeComponent();
        }

        // Ders içeriğini formdaki TextBox'a yazdıracak bir property
        public string DersIcerigi
        {
            set
            {
                tboxDersIcerigi.Text = value; // Ders içeriğini tboxDersIcerigi'ne yazdır
            }
        }

        // Form yüklendiğinde veritabanından veri çekip TextBox'lara yazdırma işlemi
        private void ders_SifrelemeveKriptografi_Load(object sender, EventArgs e)
        {
            try
            {
                // MySQL bağlantısını aç
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL sorgusu: dersicerigi tablosundaki ders adı ve ders içeriğini çek
                    string query = "SELECT `ders adı`, `ders içeriği` FROM dersicerigi";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows) // Eğer veri varsa
                            {
                                while (reader.Read()) // Verileri sırayla oku
                                {
                                    // Ders adını ve ders içeriğini al
                                    string dersAdi = reader["ders adı"].ToString();
                                    string dersIcerigi = reader["ders içeriği"].ToString();

                                    // Ders adı tboxDersAdi'ne yazdır
                                    lblDersAdi.Text = dersAdi;
                                    // Ders içeriğini DersIcerigi property aracılığıyla tboxDersIcerigi'ne yazdır
                                    DersIcerigi = dersIcerigi;
                                }
                            }
                            else
                            {
                                // Eğer veri yoksa uyarı göster
                                MessageBox.Show("Henüz ders kaydı bulunmamaktadır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Hata mesajı göster
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
