using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SporKompleksi
{
    public partial class FutbolSecim : Form
    {
        public FutbolSecim()
        {
            InitializeComponent();
        }

        private void FutbolSecim_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuyukFutbol bfb = new BuyukFutbol();
            bfb.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KucukFutbol kfb = new KucukFutbol();
            kfb.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Secim scm = new Secim();
            scm.Show();
            this.Hide();
        }
    }
}
