using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using MySql.Data.MySqlClient;


namespace finalProject.Forms
{
    public partial class konu_sosyalMuhendislik : Form
    {
        private IconButton currentBtn;
        private int testID; //id nosuna göre form üstünde soruları db den çekecek

        private Form currentChildForm;

        public konu_sosyalMuhendislik(int testID)
        {
            InitializeComponent();

            this.testID = testID;
            LoadQuestions();
            btnSosMühTest1.Tag = 1;
            btnSosMühTest2.Tag = 2;
            btnSosMühTest3.Tag = 3;
        }

        private void LoadQuestions()
        {

            string connectionString = "server=localhost;database=projectdb;uid=root;pwd=;";
            string query = "SELECT Question, Option1, Option2, Option3, Option4 FROM Questions WHERE TestID = @TestID";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@TestID", testID);
                connection.Open();

                MySqlDataReader reader = command.ExecuteReader();
                int questionNumber = 1;

                while (reader.Read())
                {
                    // Soru ve seçenekleri ekrana yazdır
                    Label lblQuestion = new Label
                    {
                        Text = $"Soru {questionNumber}: {reader["Question"]}",
                        AutoSize = true,
                        Location = new System.Drawing.Point(20, 30 * questionNumber)
                    };

                    RadioButton rbOption1 = new RadioButton
                    {
                        Text = reader["Option1"].ToString(),
                        Location = new System.Drawing.Point(40, 30 * questionNumber + 20)
                    };

                    RadioButton rbOption2 = new RadioButton
                    {
                        Text = reader["Option2"].ToString(),
                        Location = new System.Drawing.Point(40, 30 * questionNumber + 40)
                    };

                    RadioButton rbOption3 = new RadioButton
                    {
                        Text = reader["Option3"].ToString(),
                        Location = new System.Drawing.Point(40, 30 * questionNumber + 60)
                    };

                    RadioButton rbOption4 = new RadioButton
                    {
                        Text = reader["Option4"].ToString(),
                        Location = new System.Drawing.Point(40, 30 * questionNumber + 80)
                    };

                    this.Controls.Add(lblQuestion);
                    this.Controls.Add(rbOption1);
                    this.Controls.Add(rbOption2);
                    this.Controls.Add(rbOption3);
                    this.Controls.Add(rbOption4);

                    questionNumber++;
                }
            }
        }
    
        private void BtnTestBasla_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button; // Tıklanan butonu al
            int testID = Convert.ToInt32(clickedButton.Tag); // Butonun Tag değerini al (Test ID)

            // Test formunu aç ve testID'yi gönder
            testSoruları testForm = new testSoruları(testID);
            testForm.ShowDialog();
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

        private void ActivateButton(object sender)
        {
            DisableButton(sender);

            if (sender != null)
            {
                currentBtn = (IconButton)sender;
                currentBtn.TextAlign = ContentAlignment.MiddleRight;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void DisableButton(object sender)
        {
            currentBtn = (IconButton)sender;
            currentBtn.TextAlign = ContentAlignment.MiddleLeft;
            currentBtn.ImageAlign = ContentAlignment.MiddleRight;
        }

        private void btnSosMühTest_MouseHover(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnSosMühTest_MouseLeave(object sender, EventArgs e)
        {
            DisableButton(sender);
        }


        private void btnTestBasla_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button; // Tıklanan butonu al
            int testID = Convert.ToInt32(clickedButton.Tag); // Butonun Tag değerini al (Test ID)

            // TestForm'u panel içinde aç
            OpenTestChildForm(new testSoruları(testID));
        }
    }
}
