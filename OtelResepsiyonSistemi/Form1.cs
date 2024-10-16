using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelResepsiyonSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sifretext.PasswordChar = '*'; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kul_adi = ("admin");
            string sifre = ("admin");
            if (textBox1.Text == "admin" && sifretext.Text == "admin")
            {
                MessageBox.Show("Giriş başarılı ! ");
                Anasayfa anasayfa = new Anasayfa();
                anasayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Şifre veya Kullanıcı adı yanlış ! ");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                sifretext.PasswordChar = '\0';
            }
            else
            {
                sifretext.PasswordChar = '*';
            }
        }
    }
}

