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
        private Form currentChildForm;

        public konu_sosyalMuhendislik(int testID)
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
          OpenTestChildForm(new Forms.testSoruları());
        }
    }
}
