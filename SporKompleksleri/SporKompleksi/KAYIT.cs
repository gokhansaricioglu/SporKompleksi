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
    public partial class KAYIT : Form
    {
        public KAYIT()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Giris grs = new Giris();
            grs.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Users user = new Users(textBox1.Text, textBox2.Text, "", "", textBox3.Text);
           
            VeriTabani.Kullanıcılar.Add(user);
            Giris grs = new Giris();
            grs.Show();
            this.Hide();
        }
    }
}
