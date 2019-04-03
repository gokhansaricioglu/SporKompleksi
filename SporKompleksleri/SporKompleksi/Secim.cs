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
    public partial class Secim : Form
    {
        public Secim()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FutbolSecim fbs = new FutbolSecim();
            fbs.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Basketbol bsk = new Basketbol();
            bsk.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Voleybol vly = new Voleybol();
            vly.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Giris grs = new Giris();
            grs.Show();
            this.Hide();
        }
    }
}
