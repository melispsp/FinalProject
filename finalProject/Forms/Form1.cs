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


        //fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private List<Image> images = new List<Image>();
        private int currentImageIndex = 0; // baþta gösterilen görselin indeksi
        private int animationStep = 10; // Her adýmda kaç piksel kayacak
        private int animationX = 0; // Geçiþin baþlangýç konumu

        //constructor
        public MainForm()
        {

            InitializeComponent();
            InitializeSlider();
            images.Add(Image.FromFile("C:/c# proje/homepage1.jpeg"));
            images.Add(Image.FromFile("C:/c# proje/homepage2.jpeg"));
            images.Add(Image.FromFile("C:/c# proje/homepage3.jpeg"));

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

        }

        private void btnKategoriler_Click(object sender, EventArgs e)
        {
            if (pnlKategoriler.Visible ? pnlKategoriler.Visible = false : pnlKategoriler.Visible = true) ;
        }

        private void buttonKategoriler_Click(object sender, EventArgs e)
        {

        }

        private void btnNotlarým_Click(object sender, EventArgs e)
        {
            OpenMainChildForm(new Forms.Notlarým());
        }

    }
}

