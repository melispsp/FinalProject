﻿using System;
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
            pnlDers.Controls.Add(childForm);
            pnlDers.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnDersIcerigi(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=projectdb;Uid=root;Pwd=;";

            try
            {
                // MySQL bağlantısını aç
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL sorgusu: dersicerigi tablosundaki ders adı ve ders içeriğini çek
                    string query = "SELECT `ders adı`, `ders içeriği` FROM dersiceriği";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows) // Eğer veri varsa
                            {
                                string icerik = "";
                                string baslik = "";

                                while (reader.Read()) // Verileri sırayla oku
                                {
                                    // Ders adını ve ders içeriğini al
                                    string dersAdi = reader["ders adı"].ToString();
                                    string dersIcerigi = reader["ders içeriği"].ToString();

                                    baslik += $"{dersAdi}";
                                    icerik += $"{dersIcerigi}";
                                }

                                // Yeni formu aç ve notları gönder
                                Forms.ders_SiberGuvenlikNedir ders = new Forms.ders_SiberGuvenlikNedir();
                                ders.DersIcerigi = icerik;
                                ders.DersAdi = baslik;
                                OpenChildForm(ders);
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