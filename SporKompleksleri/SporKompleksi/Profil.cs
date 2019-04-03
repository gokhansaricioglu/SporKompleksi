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
    public partial class Profil : Form
    {
        public Profil(string adi,string tarih,string saat,string saha)
        {
            InitializeComponent();
            label2.Text = adi;
            label6.Text = saat;
            label7.Text = tarih;
            label9.Text = saha;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Secim scm = new Secim();
            scm.Show();
            this.Close();

        }

        private void Profil_Load(object sender, EventArgs e)
        {
          

            //"admin", "rastgele", "yıldırım", "5555555555", "15-05-2018", "17:00"
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Saha = VeriTabani.Sahalar;
            VeriTabani.Rezerve.Add(new Rezervasyon(Giris.Kullanici, Saha[0],label6.Text,label7.Text));

           // SonKisim son = new SonKisim(label2.Text, label7.Text, label6.Text);

            SonKisim sk = new SonKisim(label2.Text,label7.Text,label6.Text);
            sk.Show();
            this.Hide();
        }
    }
}
