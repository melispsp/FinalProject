using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace finalProject.Forms
{
    public partial class Dersler_siberGüvenligeGiris : Form
    {
        public Dersler_siberGüvenligeGiris()
        {
            InitializeComponent();

            //    // Dinamik ders listesi oluştur
            //    List<Course> courses = new List<Course>
            //    {
            //        new Course { Title = "Siber Güvenliğe Giriş", Description = "Bu derste siber güvenliğin temellerini öğreneceksiniz.", ImagePath = "path_to_image1.jpg" },
            //        new Course { Title = "Ağ Güvenliği", Description = "Ağ güvenliğine dair temel kavramlar ve uygulamalar.", ImagePath = "path_to_image2.jpg" },
            //        new Course { Title = "Kriptografi", Description = "Kriptografinin temel prensipleri ve uygulamaları.", ImagePath = "path_to_image3.jpg" },
            //        new Course { Title = "Zararlı Yazılım Analizi", Description = "Zararlı yazılımların analizi ve önlenmesi.", ImagePath = "path_to_image4.jpg" }
            //    };

            //    // FlowLayoutPanel ayarları
            //    FlowLayoutPanel flowPanel = new FlowLayoutPanel
            //    {
            //        Dock = DockStyle.Fill,
            //        AutoScroll = true,
            //        Padding = new Padding(10),
            //        BackColor = Color.White
            //    };

            //    // Ders kartlarını ekle
            //    foreach (var course in courses)
            //    {
            //        flowPanel.Controls.Add(CreateCourseCard(course));
            //    }

            //    // Form içine ekle
            //    this.Controls.Add(flowPanel);
            //}

            //private Panel CreateCourseCard(Course course)
            //{
            //    // Kart paneli oluştur
            //    Panel card = new Panel
            //    {
            //        Width = 300,
            //        Height = 150,
            //        Margin = new Padding(10),
            //        BackColor = Color.LightGray,
            //        BorderStyle = BorderStyle.FixedSingle
            //    };

            //    // Resim kutusu
            //    PictureBox pictureBox = new PictureBox
            //    {
            //        ImageLocation = course.ImagePath,
            //        SizeMode = PictureBoxSizeMode.StretchImage,
            //        Width = 300,
            //        Height = 70
            //    };

            //    // Başlık etiketi
            //    Label titleLabel = new Label
            //    {
            //        Text = course.Title,
            //        Font = new Font("Segoe UI", 12, FontStyle.Bold),
            //        Dock = DockStyle.Top,
            //        TextAlign = ContentAlignment.MiddleCenter
            //    };

            //    // Açıklama etiketi
            //    Label descriptionLabel = new Label
            //    {
            //        Text = course.Description,
            //        Font = new Font("Segoe UI", 10),
            //        Dock = DockStyle.Fill,
            //        TextAlign = ContentAlignment.TopLeft,
            //        Padding = new Padding(5)
            //    };

            //    // Başla butonu
            //    Button startButton = new Button
            //    {
            //        Text = "Başla",
            //        Dock = DockStyle.Bottom,
            //        Height = 30,
            //        BackColor = Color.Blue,
            //        ForeColor = Color.White,
            //        FlatStyle = FlatStyle.Flat
            //    };
            //    startButton.Click += (s, e) => MessageBox.Show($"{course.Title} dersine başlıyorsunuz!");

            //    // Kontrolleri karta ekle
            //    card.Controls.Add(startButton);
            //    card.Controls.Add(descriptionLabel);
            //    card.Controls.Add(titleLabel);
            //    card.Controls.Add(pictureBox);

            //    return card;
            //}

            //private class Course
            //{
            //    public string Title { get; set; }
            //    public string Description { get; set; }
            //    public string ImagePath { get; set; }
            //}
        }
    }
}