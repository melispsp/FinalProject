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
using MySql.Data.MySqlClient;


namespace finalProject.Forms
{
    public partial class FlashCards : Form
    {
        //fields
        private Form currentChildForm;
        private List<Card> cards = new List<Card>();


        //kartların dönme efekti
        bool isFlipped = false; // Kartın yüz durumunu kontrol etmek için  ön yüzünde false
        int targetWidth = 20;   // Kart küçülürken ulaşacağı genişlik
        int originalWidth = 180;      // Kartın orijinal genişliği
        private Button currentButton;

        //db den veri çekme
        private List<Card> LoadCardsFromDatabase()
        {
            string connectionString = "Server=localhost;Database=projectdb;Uid=root;Pwd=;";
            List<Card> loadedCards = new List<Card>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open(); // Bağlantıyı aç
                string query = "SELECT Kavram, Açıklama FROM flashcards"; // Sorgu

                using (MySqlCommand command = new MySqlCommand(query, connection))
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    int buttonIndex = 1; // Butonları sırayla bağlamak için sayaç
                    while (reader.Read())
                    {
                        string frontText = reader.GetString("Kavram"); // Kavram sütunu
                        string backText = reader.GetString("Açıklama"); // Açıklama sütunu

                        // İlgili butonu bul
                        Button relatedButton = Controls.Find($"btnCard{buttonIndex}", true).FirstOrDefault() as Button;

                        if (relatedButton != null)
                        {
                            // Yeni bir kart oluştur ve listeye ekle
                            loadedCards.Add(new Card(frontText, backText, relatedButton));
                            buttonIndex++;
                        }
                    }
                }
            }

            return loadedCards;
        }


        public FlashCards()
        {
            InitializeComponent();

            //kartları db den yükle
            cards = LoadCardsFromDatabase();

            //kartların butonlara atanması
            foreach (var card in cards)
            {
                Button btn = card.RelatedButton;
                btn.Text = card.FrontText; // Butonun ön yüz metni
                btn.Click += btnCard_Click; // Tıklama olayını bağla
            }

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
            pnlflashcard.Controls.Add(childForm);
            pnlflashcard.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private class Card
        {
            public string FrontText { get; set; }   // Ön yüz yazısı
            public string BackText { get; set; }    // Arka yüz yazısı
            public Color FrontColor { get; set; }   // Ön yüz rengi
            public Color BackColor { get; set; }    // Arka yüz rengi
            public Button RelatedButton { get; set; }

            public Card(string frontText, string backText,Button button)
            {
                FrontText = frontText;
                BackText = backText;
                FrontColor = Color.BlueViolet;
                BackColor = Color.FromArgb(100, 30, 120);
                RelatedButton = button;
            }
        }

        public void ShowBack()
        {
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

                    currentButton.BackColor = Color.BlueViolet; // Ön yüz rengi
                }
                else
                {
                    currentButton.Text = currentButton.Tag.ToString();
                    currentButton.BackColor = Color.FromArgb(100, 30, 120); // Arka yüz rengi
                }
                isFlipped = true;         // Artık genişleme başlasın
            }
        }

        private void ShowFront()
        {
            // Kart genişleme aşaması
            if (currentButton.Width < originalWidth)
            {
                currentButton.Width += 5; // Genişliği büyüt
                currentButton.Left -= 2; // Konumu tekrar düzelt
            }
            else
            {
                currentButton.Text = cards.First(c => c.RelatedButton == currentButton).FrontText;
                // Kart tekrar eski boyuta ulaştığında animasyonu durdur
                timer1.Stop();
                isFlipped = false; // Kartı tekrar çevirme durumu

            }
        }

        private void UpdateText(object sender)
        {
            
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!isFlipped)
            {
                ShowBack();
            }
            else
            {
                ShowFront();
            }
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            lblHosGeldiniz.Visible = false;
            currentButton = (Button)sender;  // Tıklanan butonu belirle

            // İlgili kartı bul
            var card = cards.FirstOrDefault(c => c.RelatedButton == currentButton);
            if (card != null)
            {
                // Kartın arka yüz metnini butonun Tag'ine koy
                currentButton.Tag = card.BackText;
            }


            timer1.Start();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            foreach (var card in cards)
            {
                Button btn = card.RelatedButton;

                // Kartın ön yüzüne çevir
                btn.BackColor = card.FrontColor;
                btn.Text = card.FrontText;
                btn.Width = 180; 
            }
        }
    }
}
