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
    public partial class BuyukFutbol : Form
    {
        public BuyukFutbol()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Secim scm = new Secim();
            scm.Show();
            this.Hide();
        }

        private void BuyukFutbol_Load(object sender, EventArgs e)
        {

        }
    }
}
