using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using finalProject.Forms;
using FontAwesome.Sharp;
using MySql.Data.MySqlClient;
using Color = System.Drawing.Color;



namespace finalProject
{
    public partial class MainForm : Form
    {

        // mysql server
        string server = "localhost";
        string uid = "root";
        string password = "";
        string database = "projectdb";
        private Form dersForm;
        string connectionString = "Server=localhost;Database=projectdb;Uid=root;Pwd=;";



        //fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private List<Image> images = new List<Image>();
        private int currentImageIndex = 0; // baþta gösterilen görselin indeksi
        private int animationStep = 10; // Her adýmda kaç piksel kayacak
        private int animationX = 0; // Geçiþin baþlangýç konumu

        private Image[] resimler = new Image[3];
        private int resimIndex = 0;

        private String[] yazilar = new string[3];
        private int yaziIndex = 0;

        private string metin = " Console.Writeline(\"Hello World :D\"); \n Console.Writeline(\"Eðitim platformumuza hoþ geldiniz!\");        "; // Yazýlacak metin
        private int index = 0; // Hangi harfi yazacaðýmýzý takip eden deðiþken

        //constructor
        public MainForm()
        {

            InitializeComponent();
            sliderTimer.Start();

            //active edildiktem sonra yanda çýkan küçük renkli þey
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 50);
            panelMenu.Controls.Add(leftBorderBtn);

            //form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }

        private void InitializeSlider()
        {
            try
            {
                pnlSlider.BackgroundImage = images[currentImageIndex];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
            pnlSlider.BackgroundImageLayout = ImageLayout.Stretch;

            // Timer ayarlarý
            sliderTimer.Tick += sliderTimer_Tick_1;
            sliderTimer.Start();
        }



        //sutructs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(0, 255, 255);
            public static Color color2 = Color.FromArgb(123, 104, 238);
            public static Color color3 = Color.FromArgb(124, 252, 0);
            public static Color color4 = Color.FromArgb(255, 0, 0);
        }



        //methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();

                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(19, 17, 30);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                btnHome.IconChar = currentBtn.IconChar;
                btnHome.IconColor = color;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                pnlShadow.BackColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(8, 6, 15);
                pnlShadow.BackColor = Color.FromArgb(5, 2, 10);
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                btnHome.IconChar = IconChar.Home;
                btnHome.IconColor = Color.Lavender;

            }

        }

        private void OpenMainChildForm(Form childForm)
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
            pnlDesktop.Controls.Add(childForm);
            pnlDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblHome.Text = childForm.Text;
        }



        private void btnLessons_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            btnHome.IconColor = RGBColors.color1;
            OpenMainChildForm(new Forms.Dersler());
        }

        private void btnFlashcards_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            btnHome.IconColor = RGBColors.color2;
            OpenMainChildForm(new Forms.FlashCards());
        }

        private void btnTests_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            btnHome.IconColor = RGBColors.color3;
            OpenMainChildForm(new Forms.Testler());
        }

        private void btnSimulations_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            btnHome.IconColor = RGBColors.color4;
            OpenMainChildForm(new Forms.Simülasyonlar());
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            //iconCurrentChildForm.IconChar = IconChar.Home;
            //iconCurrentChildForm.IconColor = Color.MediumPurple;
            btnHome.IconColor = Color.Gainsboro;
            lblHome.Text = "Ana Sayfa";
        }



        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnlTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (pnlSettinsBar.Visible == true)
            {
                pnlSettinsBar.Visible = false;
                pnlKategoriler.Visible = false;
            }
            else
            {
                pnlSettinsBar.Visible = true;
            }

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        private void sliderTimer_Tick_1(object sender, EventArgs e)
        {
            // Resimleri kaydýrarak atýyoruz
            var temp = resimler[0];
            resimler[0] = resimler[1];
            resimler[1] = resimler[2];
            resimler[2] = temp;

            var temp2 = yazilar[0];
            yazilar[0] = yazilar[1];
            yazilar[1] = yazilar[2];
            yazilar[2] = temp2;

            // PictureBox'larý güncelliyoruz
            pictureBox1.Image = resimler[0];
            pictureBox2.Image = resimler[1];
            pictureBox3.Image = resimler[2];

            label1.Text = yazilar[0];
            label2.Text = yazilar[1];
            label3.Text = yazilar[2];
        }

        private void btnKategoriler_Click(object sender, EventArgs e)
        {
            if (pnlKategoriler.Visible ? pnlKategoriler.Visible = false : pnlKategoriler.Visible = true) ;
        }

        private void buttonKategoriler_Click(object sender, EventArgs e)
        {

            Button clickedButton = sender as Button;
            if (clickedButton == null) return;

            // Týklanan butonun Tag deðerini kontrol edin
            if (clickedButton.Tag == null || !int.TryParse(clickedButton.Tag.ToString(), out int dersID))
            {
                MessageBox.Show("Geçersiz ders bilgisi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Veritabaný sorgusu
            string query = "SELECT `DersAdi`, `DersIcerigi` FROM dersiceriði WHERE `dersID` = @dersID";

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

                                // Form oluþtur ve veri ata
                                Forms.DersIcerigi dersForm = new Forms.DersIcerigi
                                {

                                    DersinAdi = dersAdi,
                                    DersinIcerigi = dersIcerigi
                                };

                                OpenMainChildForm(dersForm);
                                // Yeni formu göster

                            }
                            else
                            {
                                MessageBox.Show("Bu ders için içerik bulunamadý.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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



        private void btnNotlarým_Click(object sender, EventArgs e)
        {
            OpenMainChildForm(new Forms.Notlarým());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();

            btnKategori1.Tag = 1;
            btnKategori2.Tag = 2;
            btnKategori3.Tag = 3;
            btnKategori4.Tag = 4;
            btnKategori5.Tag = 5;
            btnKategori6.Tag = 6;
            btnKategori7.Tag = 7;
            btnKategori8.Tag = 8;
            btnKategori9.Tag = 9;
            btnKategori10.Tag = 10;
            btnKategori11.Tag = 11;
            btnKategori12.Tag = 12;
            btnKategori13.Tag = 13;
            btnKategori14.Tag = 14;
            btnKategori15.Tag = 15;
            btnKategori16.Tag = 16;

            resimler[0] = Image.FromFile("C:/c# proje/homepage1.jpeg");
            resimler[1] = Image.FromFile("C:/c# proje/homepage2.jpeg");
            resimler[2] = Image.FromFile("C:/c# proje/homepage3.jpeg");

            pictureBox1.Image = resimler[0];
            pictureBox2.Image = resimler[1];
            pictureBox3.Image = resimler[2];

            yazilar[0] = "Eðitim Ýçerikleri";
            yazilar[1] = "Güncel Bilgiler";
            yazilar[2] = "Geleceðin teknolojisi";

            label1.Text = yazilar[0];
            label2.Text = yazilar[1];
            label3.Text = yazilar[2];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (index < metin.Length)
            {
                // Label'a metnin harflerini sýrayla ekle
                lblAnaMetin.Text += metin[index];
                index++;
            }
            else
            {
                // Metin tamamlandýðýnda baþa dön
                lblAnaMetin.Text = ""; // Label'ý temizle
                index = 0; // Baþlangýç indexine sýfýrla
            }
        }

        private void btnProfilim_Click(object sender, EventArgs e)
        {
            OpenMainChildForm(new Forms.Profilim());
        }

        //if (index < metin.Length)
        // {
        //     // Label'a metnin harflerini sýrayla ekle
        //     lblAnaMetin.Text += metin[index];
        //     index++;
        // }
        // else
        // {
        //     // Metin tamamlandýðýnda baþa dön
        //     lblAnaMetin.Text = ""; // Label'ý temizle
        //     index = 0; // Baþlangýç indexine sýfýrla
        // }

    }
}

