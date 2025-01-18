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
    public partial class Dersler : Form
    {

        //fields
        private Form currentChildForm;


        public Dersler()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
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


        private void Buton_MouseHover(object sender, EventArgs e)
        {
            Button buton = (Button)sender;
            buton.BackColor = Color.LightBlue;
        }

        private void Buton_MouseLeave(object sender, EventArgs e)
        {
            Button buton = (Button)sender;
            buton.BackColor = SystemColors.Control;
        }

        private void btnEgitimler_Click(object sender, EventArgs e)
        {
            if (pnlEgitimlerMenu.Visible)
            {
                pnlEgitimlerMenu.Visible = false;
            }
            else { pnlEgitimlerMenu.Visible = true; }
        }

        private void btnListelerim_Click(object sender, EventArgs e)
        {
            if (pnlListelerimMenu.Visible)
            {
                pnlListelerimMenu.Visible = false;
            }
            else { pnlListelerimMenu.Visible = true; }
        }

        private void btnSiberGuvenligegiris_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Dersler_siberGüvenligeGiris());
            pnlEgitimlerMenu.Visible = false;
        }

        private void btnAgBilgisi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Dersler_AgBilgisi());
            pnlEgitimlerMenu.Visible = false;
        }

        private void btnZararliYazilimlar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Dersler_ZararliYazilimlar());
            pnlEgitimlerMenu.Visible = false;
        }

        private void btnSosyalMuhendislik_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Dersler_SosyalMuhendislik());
            pnlEgitimlerMenu.Visible = false;
        }

        private void btnFavorilerim_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Dersler_Favorilerim());
            pnlListelerimMenu.Visible = false;
        }

        private void btnListeEkle_Click(object sender, EventArgs e)
        {
            pnlListelerimMenu.Visible = false;
        }


    }
}