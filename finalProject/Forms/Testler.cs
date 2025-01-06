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
    public partial class Testler : Form
    {

        //fields
        private Form currentChildForm;


        public Testler()
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
            pnlTest.Controls.Add(childForm);
            pnlTest.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void btnChoiseTopics_Click(object sender, EventArgs e)
        {
            if (pnlKonuMenu.Visible)
            {
                pnlKonuMenu.Visible = false;
            }
            else { pnlKonuMenu.Visible = true; }
        }

        private void btnTopSiberGuvenligeGiris_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.konu_SiberGuvenligeGiris());
            pnlKonuMenu.Visible = false;
        }

        private void btnTopAgBilgisi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.konu_AgBilgisi());
            pnlKonuMenu.Visible = false;
        }

        private void btnzararliYazilimlar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.konu_zararliYazilimlar());
            pnlKonuMenu.Visible = false;
        }

        private void bntopsosyalMuhendislik_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.konu_sosyalMuhendislik());
            pnlKonuMenu.Visible = false;
        }
    }
}
