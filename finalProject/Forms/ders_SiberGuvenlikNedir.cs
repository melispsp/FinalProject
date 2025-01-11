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
    public partial class ders_SiberGuvenlikNedir : Form
    {
        public ders_SiberGuvenlikNedir()
        {
            InitializeComponent();
        }

        public string DersIcerigi
        {
            set
            {
                tboxDersIcerigi.Text = value;
            }
        }
        public string DersAdi
        {
            set
            {
                lblDersAdi.Text = value;
            }
        }


    }
}
