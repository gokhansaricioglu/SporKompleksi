using SporKompleksi;
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
    public partial class SonKisim : Form
    {
        public SonKisim(string adi,string tarih,string saat)
        {
            InitializeComponent();
            label4.Text = adi;
            label5.Text = tarih;
            label6.Text = saat;
        }

        private void SonKisim_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Basketbol bsk = new Basketbol();
            bsk.Show();
            this.Hide();
        }
    }
}
