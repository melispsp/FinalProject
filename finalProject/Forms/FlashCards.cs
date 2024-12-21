using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System;
using System.Windows.Forms;

namespace finalProject.Forms
{
    public partial class FlashCards : Form
    {
        //kartların dönme efekti
        bool isFlipped = false; // Kartın yüz durumunu kontrol etmek için
        int targetWidth = 30;   // Kart küçülürken ulaşacağı genişlik
        int originalWidth = 180;      // Kartın orijinal genişliği
        private Button currentButton;

        //kartların textleri seçilen konuya göre set edilecek
        public string Kavram { get; private set; }
        public string Açıklama { get; private set; }

        public FlashCards()
        {
            InitializeComponent();
          
            btnCard1.Text = Kavram;
            btnCard2.Text = Kavram;
            btnCard3.Text = Kavram;
            btnCard4.Text = Kavram;
            btnCard5.Text = Kavram;
            btnCard6.Text = Kavram;
            btnCard7.Text = Kavram;
            btnCard8.Text = Kavram;
            btnCard9.Text = Kavram;

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!isFlipped)
            {
                // Kart küçülme aşaması
                if (currentButton.Width > targetWidth)
                {
                    currentButton.Width -= 5; // Genişliği küçült
                    currentButton.Left += 2; // Ortalamayı sağlamak için konum ayarla
                }
                else
                {
                    // Metni ve rengini değiştir
                    if (currentButton.BackColor == Color.FromArgb(100, 30, 120))
                    {
                        currentButton.Text = Kavram;
                        currentButton.BackColor = Color.BlueViolet; // Ön yüz rengi
                    }
                    else
                    {
                        currentButton.Text = Açıklama;
                        currentButton.BackColor = Color.FromArgb(100, 30, 120); // Arka yüz rengi
                    }
                    isFlipped = true;         // Artık genişleme başlasın
                }
            }
            else
            {
                // Kart genişleme aşaması
                if (currentButton.Width < originalWidth)
                {
                    currentButton.Width += 5; // Genişliği büyüt
                    currentButton.Left -= 2; // Konumu tekrar düzelt
                }
                else
                {
                    // Kart tekrar eski boyuta ulaştığında animasyonu durdur
                    timer1.Stop();
                    isFlipped = false; // Kartı tekrar çevirme durumu

                }
            }
        }


        private void btnCard_Click(object sender, EventArgs e)
        {
            currentButton = (Button)sender;  // Tıklanan butonu belirle
            timer1.Start();
        }

        private void btnCard2_Click(object sender, EventArgs e)
        {
            currentButton = (Button)sender;  // Tıklanan butonu belirle
            timer1.Start();
        }

        private void btnCard3_Click(object sender, EventArgs e)
        {
            currentButton = (Button)sender;  // Tıklanan butonu belirle
            timer1.Start();
        }

        private void btnCard4_Click(object sender, EventArgs e)
        {
            currentButton = (Button)sender;  // Tıklanan butonu belirle
            timer1.Start();
        }

        private void btnCard5_Click(object sender, EventArgs e)
        {
            currentButton = (Button)sender;  // Tıklanan butonu belirle
            timer1.Start();
        }

        private void btnCard6_Click(object sender, EventArgs e)
        {
            currentButton = (Button)sender;  // Tıklanan butonu belirle
            timer1.Start();
        }

        private void btnCard7_Click(object sender, EventArgs e)
        {
            currentButton = (Button)sender;  // Tıklanan butonu belirle
            timer1.Start();
        }

        private void btnCard8_Click(object sender, EventArgs e)
        {
            currentButton = (Button)sender;  // Tıklanan butonu belirle
            timer1.Start();
        }

        private void btnCard9_Click(object sender, EventArgs e)
        {
            currentButton = (Button)sender;  // Tıklanan butonu belirle
            timer1.Start();
        }

    }  
}
