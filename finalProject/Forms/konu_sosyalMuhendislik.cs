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

namespace finalProject.Forms
{
    public partial class konu_sosyalMuhendislik : Form
    {
        private IconButton currentBtn;

        public konu_sosyalMuhendislik()
        {
            InitializeComponent();
        }

        private void btnSosMühTest1_MouseHover(object sender, EventArgs e)
        {
            ActivateButton(sender);
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

        private void btnSosMühTest1_MouseLeave(object sender, EventArgs e)
        {
            DisableButton(sender);
        }

        private void btnSosMühTest2_MouseHover(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnSosMühTest2_MouseLeave(object sender, EventArgs e)
        {
            DisableButton(sender);
        }

        private void btnSosMühTest3_MouseHover(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnSosMühTest3_MouseLeave(object sender, EventArgs e)
        {
            DisableButton(sender);
        }
    }
}
