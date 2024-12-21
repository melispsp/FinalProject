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
        public Dersler()
        {
            InitializeComponent();
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


    }
}
