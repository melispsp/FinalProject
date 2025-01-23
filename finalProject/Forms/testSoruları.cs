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
    public partial class testSoruları : Form
    {


        public testSoruları()
        {
            InitializeComponent();
        }


        public string SoruNo
        {
            set
            {
                lblSoruNo.Text = value;
            }
        }
        public string SoruMetni
        {
            set
            {
                lblSoru.Text = value;
            }
        }

        public string Secenek1
        {
            set
            {
                radioCevap1.Text = value;
            }
        }

        public string Secenek2
        {
            set
            {
                radioCevap2.Text = value;
            }
        }
        public string Secenek3
        {
            set
            {
                radioCevap3.Text = value;
            }
        }
        public string Secenek4
        {
            set
            {
                radioCevap4.Text = value;
            }
        }

        private void testSoruları_Load(object sender, EventArgs e)
        {


        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            lblSoruNo.Text = "Soru 2";
            lblSoru.Text = "Kimlik avı saldırısında saldırganın amacı nedir?";
            radioCevap1.Text = "İnternetin hızını arttırmak";
            radioCevap2.Text = "Kurbanın kişisel bilgilerini ele geçirmek";
            radioCevap3.Text = "Bilgisayara oyun yüklemek";
            radioCevap4.Text = "Bilgisayarın donanım ayarlarını bozmak";
        }
    }
}


