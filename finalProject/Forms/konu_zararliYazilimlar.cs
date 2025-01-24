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
    public partial class konu_zararliYazilimlar : Form
    {
     
        private Form currentChildForm;


        public konu_zararliYazilimlar()
        {
            InitializeComponent();
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
            pnlBack.Controls.Add(childForm);
            pnlBack.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnTestBasla_Click(object sender, EventArgs e)
        {
           
        }
    }
}
