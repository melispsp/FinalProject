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
    public partial class NotGörüntüle : Form
    {
        public NotGörüntüle()
        {
            InitializeComponent();
        }

        public string NotMetni
        {
            set
            {
                txtKayıtlıNotlar.Text = value; // lblNotlar, Notları göstermek için bir Label olmalı
            }
        }

    }
}
