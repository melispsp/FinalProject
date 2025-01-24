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
    public partial class Notlarım : Form
    {
        string connectionString = "Server=localhost;Database=projectdb;Uid=root;Pwd=;";
        private Form currentChildForm;

        public Notlarım()
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
            pnlMainNotlarım.Controls.Add(childForm);
            pnlMainNotlarım.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void textBox1_Clicked(object sender, EventArgs e)
        {
            lblBaşlık.Visible = false;

        }

        private void tboxNotlarım_Clicked(object sender, EventArgs e)
        {
            lblNotGiriniz.Visible = false;
        }

        private void btnNotKaydet_Click(object sender, EventArgs e)
        {

            // MySQL bağlantı bilgileri
            
            string Başlık = txtBaslik.Text; // Başlık için TextBox
            string İçerik = txtIcerik.Text; // İçerik için TextBox

            // Eğer başlık ya da içerik boş bırakılmışsa uyarı göster
            if (string.IsNullOrEmpty(Başlık) || string.IsNullOrEmpty(İçerik))
            {
                MessageBox.Show("Başlık ve içerik alanlarını doldurmayı unutma.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // MySQL bağlantısını aç
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Veriyi eklemek için SQL sorgusu
                    string query = "INSERT INTO Notlar (Başlık, İçerik) VALUES (@Başlık, @İçerik)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Parametreleri ekle
                        command.Parameters.AddWithValue("@Başlık", Başlık);
                        command.Parameters.AddWithValue("@İçerik", İçerik);

                        // Komutu çalıştır
                        int result = command.ExecuteNonQuery();

                        // Başarılıysa kullanıcıya bilgi ver
                        if (result > 0)
                        {
                            MessageBox.Show("Not başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // TextBox'ları temizle
                            txtBaslik.Clear();
                            txtIcerik.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Not kaydedilirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Hata mesajını göster
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnNotGörüntüle_Click(object sender, EventArgs e)
        {
           

            // MySQL bağlantı bilgileri
            string connectionString = "Server=localhost;Database=projectdb;Uid=root;Pwd=;";

            try
            {
                // MySQL bağlantısını aç
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL sorgusu: Tüm notları çek
                    string query = "SELECT Başlık, İçerik, NotNo FROM notlar";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows) // Eğer veri varsa
                            {
                                string notlar = "";

                                while (reader.Read()) // Tüm verileri oku
                                {
                                    // Notları sırayla ekle
                                    string baslik = reader["Başlık"].ToString();
                                    string icerik = reader["İçerik"].ToString();
                                    string id = reader["NotNo"].ToString();

                                    //notlar += $"Başlık: {baslik}\n Not: {icerik}\n\n";
                                    notlar += $"{id}. Not{Environment.NewLine}Başlık: {baslik} {Environment.NewLine}Not: {icerik}{Environment.NewLine}{Environment.NewLine}";

                                }

                                // Yeni formu aç ve notları gönder
                                Forms.NotGörüntüle notGörüntüle = new Forms.NotGörüntüle();
                                notGörüntüle.NotMetni = notlar; // Formda bir public property olmalı
                                OpenChildForm(notGörüntüle);
                            }
                            else
                            {
                                // Eğer veri yoksa uyarı göster
                                MessageBox.Show("Henüz kayıtlı bir not bulunmamaktadır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
