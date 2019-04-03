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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        public static Users Kullanici;

        private void button1_Click(object sender, EventArgs e)
        {
            
            var ka = textBox1.Text;
            var sif = textBox2.Text;
            var sahalar = VeriTabani.Sahalar;
            if (VeriTabani.Kullanıcılar.Exists(x=> x.KullaniciAdi == ka && sif == x.Sifre) == true)
            {
                Kullanici = VeriTabani.Kullanıcılar.FirstOrDefault(x => x.KullaniciAdi == ka && sif == x.Sifre);
                if(ka=="admin"&&sif=="admin")
                {
                    AdminPanel ap = new AdminPanel();
                    ap.Show();
                    this.Hide();
                }
                else
                {
                     Secim scm = new Secim();
                scm.Show();
                this.Hide();
                }
               
            }
            else
            {
                MessageBox.Show("Kullanıcı Adi yada şifre hatalı");
            }

        
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KAYIT kyt = new KAYIT();
            kyt.Show();
            this.Hide();
        }

        private void Giris_Load(object sender, EventArgs e)
        {
            textBox1.Text = "admin";
            textBox2.Text = "admin";
            VeriTabani.VeriTabaniniAc();
            

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
            }
        }
    }
}
