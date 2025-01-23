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
    public partial class Dersler_AgBilgisi : Form
    {
        private Form dersForm;
        string connectionString = "Server=localhost;Database=projectdb;Uid=root;Pwd=;";
        private Form currentChildForm;

        public Dersler_AgBilgisi()
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


            Button clickedButton = sender as Button;
            if (clickedButton == null) return;

            // Tıklanan butonun Tag değerini kontrol edin
            if (clickedButton.Tag == null || !int.TryParse(clickedButton.Tag.ToString(), out int dersID))
            {
                MessageBox.Show("Geçersiz ders bilgisi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
                            if (reader.Read())
                            {


                                string dersAdi = reader["DersAdi"].ToString();
                                string dersIcerigi = reader["DersIcerigi"].ToString();

                                // Form oluştur ve veri ata
                                Forms.DersIcerigi dersForm = new Forms.DersIcerigi
                                {

                                    DersinAdi = dersAdi,
                                    DersinIcerigi = dersIcerigi
                                };

                                OpenChildForm(dersForm);
                                // Yeni formu göster

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


        private void Dersler_AgBilgisi_Load(object sender, EventArgs e)
        {
            btnDers1.Tag = 5;
            btnDers2.Tag = 6;
            btnDers3.Tag = 7;
            btnDers4.Tag = 8;
        }

    }
}
