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


        private void Dersler_Load(object sender, EventArgs e)
        {

        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            if (pnlEgitimlerMenu.Visible == true)
            {
                pnlEgitimlerMenu.Visible = false;
            }
            else { pnlEgitimlerMenu.Visible = true; }

        }
    }
}
