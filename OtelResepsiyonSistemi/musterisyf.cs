using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OtelResepsiyonSistemi
{
    public partial class musterisyf : Form
    {
        public musterisyf()
        {
            InitializeComponent();
        }

        private void odalarbtn_Click(object sender, EventArgs e)
        {
            Anasayfa Anasayfa = new Anasayfa();
            Anasayfa.Show();
            this.Hide();
        }

        private void musterilistbtn_Click(object sender, EventArgs e)
        {
            musterilist musterilist = new musterilist();
            musterilist.Show();
            this.Hide();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }

        private void musterisyf_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("AD", 125);
            listView1.Columns.Add("SOYAD", 125);
            listView1.Columns.Add("TC NO", 125);
            listView1.Columns.Add("TEL NO", 125);
            listView1.Columns.Add("ODA NO", 125);
            listView1.Columns.Add("Giriş Tarihi", 125);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ad, soyad, tc, tel, oda, grstrh;
            ad = textBox1.Text;
            soyad = textBox2.Text;
            tc = textBox3.Text; 
            tel = textBox4.Text;
            oda = textBox5.Text;
            grstrh = textBox6.Text;
            

            string[] bilgiler = { ad, soyad, tc, tel, oda, grstrh};

            ListViewItem kayit = new ListViewItem(bilgiler);

            listView1.Items.Add(kayit);
        }

        private void musterisyf_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0) 
            {
                listView1.Items.Remove(listView1.SelectedItems[0]); 
            }
            else
            {
                MessageBox.Show("Silmek için bir satır seçin.");
            }
        }
    }
}
