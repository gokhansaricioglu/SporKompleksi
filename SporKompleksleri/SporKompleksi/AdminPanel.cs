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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            
            listView1.Items.Clear();
            for (int i = 0; i < listView1.Columns.Count; i++)
            {
                listView1.Columns[i].Width = 90;
            }
            
            foreach (var item in VeriTabani.Rezerve)
            {
                string[] row = {item.ID, item.User.Adi + " " +item.User.Soyadi, item.Tarih, item.Saat, item.Saha.SahaAdi, item.User.Telefon };
                var satir = new ListViewItem(row);
                listView1.Items.Add(satir);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Giris grs = new Giris();
            grs.Show();
            this.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = listView1.Items[listView1.SelectedItems[0].Index].SubItems[0].Text;
            VeriTabani.Rezerve.RemoveAll(x => x.ID == id);
            listView1.Items.RemoveAt(listView1.SelectedItems[0].Index);
        
        }
    }
}
