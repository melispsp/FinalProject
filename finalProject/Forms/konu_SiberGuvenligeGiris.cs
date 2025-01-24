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
    public partial class konu_SiberGuvenligeGiris : Form
    {
        private Form testForm;
        string connectionString = "Server=localhost;Database=projectdb;Uid=root;Pwd=;";
        private Form currentChildForm;



        public konu_SiberGuvenligeGiris()
        {
            InitializeComponent();
        }

        private void OpenTestChildForm(Form childForm)
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
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnTestBasla_Click(object sender, EventArgs e)
        {
            LoadNextQuestion();
        }

        private void konu_SiberGuvenligeGiris_Load(object sender, EventArgs e)
        {
           LoadNextQuestion();
        }

        private void LoadNextQuestion()
        {
            // Veritabanı sorgusu (Siber Güvenlik konusundan rastgele 1 soru)
            string query = "SELECT `id`, `soru_metni`, `secenek1`, `secenek2`, `secenek3`, `secenek4` FROM sorular WHERE `konuAdi` = 'Siber Güvenlik' ORDER BY RAND() LIMIT 1";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string soruNo = reader["id"].ToString();
                                string soruMetni = reader["soru_metni"].ToString();
                                string secenek1 = reader["secenek1"].ToString();
                                string secenek2 = reader["secenek2"].ToString();
                                string secenek3 = reader["secenek3"].ToString();
                                string secenek4 = reader["secenek4"].ToString();

                                // Yeni formu oluştur ve özellikleri ayarla
                                Forms.testSoruları testForm = new Forms.testSoruları
                                {
                                    SoruNo = soruNo,
                                    SoruMetni = soruMetni,
                                    Secenek1=secenek1,
                                    Secenek2=secenek2,
                                    Secenek3=secenek3,
                                    Secenek4=secenek4
                                };

                                // Formu göster
                                OpenTestChildForm(testForm);


                            }
                            else
                            {
                                MessageBox.Show("Siber güvenlik konusuyla ilgili soru bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
