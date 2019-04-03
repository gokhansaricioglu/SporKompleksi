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
    

    public partial class Basketbol : Form
    {
        public string tarih;
        public string saat;
        public Button oncekiButon;

        public Basketbol()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            oncekiButon = null;
            textBox2.Text = dateTimePicker1.Value.ToShortDateString();
            string tarih=textBox2.Text;
            string saat=textBox1.Text;
            List<Rezervasyon> gelenTarih = VeriTabani.Rezerve.Where(x => x.Tarih == tarih).ToList();
            List<string> gelenSaat = gelenTarih.Select(x => x.Saat).ToList();

            foreach (var item in panel1.Controls)
            {
                if (item is Button gelenButton)
                {
                    if(gelenSaat.IndexOf(gelenButton.Text)!=-1)
                    {
                        gelenButton.BackColor = Color.Red;
                        gelenButton.Enabled = false;
                    }
                    else
                    {
                        gelenButton.BackColor = Color.Lime;
                        gelenButton.Enabled = true;
                    }
                }
            }   



        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Secim scm = new Secim();
            scm.Show();
            this.Hide();
        }
        private void button_Click(object sender, EventArgs e)
        {
            var simdikiButon = (sender as Button);
            textBox1.Text = simdikiButon.Text;
            simdikiButon.BackColor = Color.Gray; 
            simdikiButon.Enabled = false;

            if(oncekiButon!=null)
            {
                oncekiButon.BackColor = Color.Lime;
                oncekiButon.Enabled = true;
                
            }
            oncekiButon = simdikiButon;


        }

        private void Basketbol_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Basketbol_Load(object sender, EventArgs e)
        {
            label1.Text = Giris.Kullanici.KullaniciAdi;
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text.Length==0 || textBox2.Text.Length == 0)
            {
                MessageBox.Show("Lütfen Tarih ve Saat Seçiniz");
            }
            else
            { 
            Profil prf = new Profil(label1.Text,textBox1.Text,textBox2.Text,comboBox1.Text);
            prf.Show();
            this.Hide();
            }
        }
    }
}
