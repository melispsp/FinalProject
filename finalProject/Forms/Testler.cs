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
        public Testler()
        {
            InitializeComponent();
        }

        private void btnChoiseTopics_Click(object sender, EventArgs e)
        {
            if (pnlTopics.Visible)
            {
                pnlTopics.Visible = false;
            }
            else { pnlTopics.Visible = true; }
        }
    }
}
