using System;
using System.Drawing;
using System.Windows.Forms;

namespace OtelResepsiyonSistemi
{
    public partial class Anasayfa : Form
    {
        private System.Windows.Forms.Timer geriSayimTimer;
        private DateTime hedefTarih;

        public Anasayfa()
        {
            InitializeComponent();
            hedefTarih = DateTime.Now.AddDays(30);
            geriSayimTimer = new System.Windows.Forms.Timer { Interval = 1000 }; 
            geriSayimTimer.Tick += timer2_Tick; 
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000; 
            timer1.Start(); 
        }

        private void Anasayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void musterilst_Click(object sender, EventArgs e)
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

        private void oda1_Click(object sender, EventArgs e)
        {
            oda1.BackColor = Color.Red;
            geriSayimTimer.Start(); 
            label8.BackColor = Color.Red;
            label7.BackColor = Color.Red;
            TimeSpan kalanSure = hedefTarih - DateTime.Now;
            label7.Text = (kalanSure.Days + 1).ToString(); 
            geriSayimTimer.Start();

        }
        private void musteriekl_Click(object sender, EventArgs e)
        {
            musterisyf musterisyf = new musterisyf();
            musterisyf.Show();
            this.Hide();
        }

        private void oda1_MouseDown(object sender, MouseEventArgs e)
        {
            oda1.BackColor = Color.LimeGreen;
            label9.BackColor = Color.LimeGreen;
            label10.BackColor = Color.LimeGreen;
            geriSayimTimer.Stop();
        }

        private void oda2_Click(object sender, EventArgs e)
        {
            oda2.BackColor = Color.Red;
        }


        private void oda2_MouseDown(object sender, MouseEventArgs e)
        {
            oda2.BackColor = Color.LimeGreen;
        }

        private void oda3_Click(object sender, EventArgs e)
        {
            oda3.BackColor = Color.Red;
        }

        private void oda3_MouseDown(object sender, MouseEventArgs e)
        {
            oda3.BackColor = Color.LimeGreen;
        }

        private void oda4_Click(object sender, EventArgs e)
        {
            oda4.BackColor = Color.Red;
        }

        private void oda4_MouseDown(object sender, MouseEventArgs e)
        {
            oda4.BackColor = Color.LimeGreen;
        }

        private void oda5_Click(object sender, EventArgs e)
        {
            oda5.BackColor = Color.Red;
        }

        private void oda5_MouseDown(object sender, MouseEventArgs e)
        {
            oda5.BackColor = Color.LimeGreen;
        }

        private void oda6_Click(object sender, EventArgs e)
        {
            oda6.BackColor = Color.Red;
        }

        private void oda6_MouseDown(object sender, MouseEventArgs e)
        {
            oda6.BackColor = Color.LimeGreen;
        }

        private void oda7_Click(object sender, EventArgs e)
        {
            oda7.BackColor = Color.Red;
        }

        private void oda7_MouseDown(object sender, MouseEventArgs e)
        {
            oda7.BackColor = Color.LimeGreen;
        }

        private void oda8_Click(object sender, EventArgs e)
        {
            oda8.BackColor = Color.Red;
        }

        private void oda8_MouseDown(object sender, MouseEventArgs e)
        {
            oda8.BackColor = Color.LimeGreen;
        }

        private void oda9_Click(object sender, EventArgs e)
        {
            oda9.BackColor = Color.Red;
        }
        private void oda9_MouseDown(object sender, MouseEventArgs e)
        {
            oda9.BackColor = Color.LimeGreen;
        }

        private void oda10_Click(object sender, EventArgs e)
        {
            oda10.BackColor = Color.Red;
        }
        private void oda10_MouseDown(object sender, MouseEventArgs e)
        {
            oda10.BackColor = Color.LimeGreen;
        }

        private void oda11_Click(object sender, EventArgs e)
        {
            oda11.BackColor = Color.Red;
        }
        private void oda11_MouseDown(object sender, MouseEventArgs e)
        {
            oda11.BackColor = Color.LimeGreen;
        }

        private void oda12_Click(object sender, EventArgs e)
        {
            oda12.BackColor = Color.Red;
        }
        private void oda13_Click(object sender, EventArgs e)
        {
            oda13.BackColor = Color.Red;
        }
        private void oda14_Click(object sender, EventArgs e)
        {
            oda14.BackColor = Color.Red;
        }

        private void oda15_Click(object sender, EventArgs e)
        {
            oda15.BackColor = Color.Red;
        }
        private void oda16_Click(object sender, EventArgs e)
        {
            oda16.BackColor = Color.Red;
        }
        private void oda17_Click(object sender, EventArgs e)
        {
            oda17.BackColor = Color.Red;
        }

        private void oda18_Click(object sender, EventArgs e)
        {
            oda18.BackColor = Color.Red;
        }

        private void oda19_Click(object sender, EventArgs e)
        {
            oda19.BackColor = Color.Red;
        }

        private void oda20_Click(object sender, EventArgs e)
        {
            oda20.BackColor = Color.Red;
        }

        private void oda21_Click(object sender, EventArgs e)
        {
            oda21.BackColor = Color.Red;
        }

        private void oda22_Click(object sender, EventArgs e)
        {
            oda22.BackColor = Color.Red;
        }

        private void oda23_Click(object sender, EventArgs e)
        {
            oda23.BackColor = Color.Red;
        }

        private void oda24_Click(object sender, EventArgs e)
        {
            oda24.BackColor = Color.Red;
        }

        private void oda25_Click(object sender, EventArgs e)
        {
            oda25.BackColor = Color.Red;
        }

        private void oda26_Click(object sender, EventArgs e)
        {
            oda26.BackColor = Color.Red;
        }

        private void oda27_Click(object sender, EventArgs e)
        {
            oda27.BackColor = Color.Red;
        }
        private void oda28_Click(object sender, EventArgs e)
        {
            oda28.BackColor = Color.Red;
        }

        private void oda12_MouseDown(object sender, MouseEventArgs e)
        {
            oda12.BackColor = Color.LimeGreen;
        }

        private void oda13_MouseDown(object sender, MouseEventArgs e)
        {
            oda13.BackColor = Color.LimeGreen;
        }

        private void oda14_MouseDown(object sender, MouseEventArgs e)
        {
            oda14.BackColor = Color.LimeGreen;
        }

        private void oda15_MouseDown(object sender, MouseEventArgs e)
        {
            oda15.BackColor = Color.LimeGreen;
        }

        private void oda16_MouseDown(object sender, MouseEventArgs e)
        {
            oda16.BackColor = Color.LimeGreen;
        }

        private void oda17_MouseDown(object sender, MouseEventArgs e)
        {
            oda17.BackColor = Color.LimeGreen;
        }

        private void oda18_MouseDown(object sender, MouseEventArgs e)
        {
            oda18.BackColor = Color.LimeGreen;
        }

        private void oda19_MouseDown(object sender, MouseEventArgs e)
        {
            oda19.BackColor = Color.LimeGreen;
        }

        private void oda20_MouseDown(object sender, MouseEventArgs e)
        {
            oda20.BackColor = Color.LimeGreen;
        }

        private void oda21_MouseDown(object sender, MouseEventArgs e)
        {
            oda21.BackColor = Color.LimeGreen;
        }

        private void oda22_MouseDown(object sender, MouseEventArgs e)
        {
            oda22.BackColor = Color.LimeGreen;
        }

        private void oda23_MouseDown(object sender, MouseEventArgs e)
        {
            oda23.BackColor = Color.LimeGreen;
        }

        private void oda24_MouseDown(object sender, MouseEventArgs e)
        {
            oda24.BackColor = Color.LimeGreen;
        }

        private void oda25_MouseDown(object sender, MouseEventArgs e)
        {
            oda25.BackColor = Color.LimeGreen;
        }

        private void oda26_MouseDown(object sender, MouseEventArgs e)
        {
            oda26.BackColor = Color.LimeGreen;
        }

        private void oda27_MouseDown(object sender, MouseEventArgs e)
        {
            oda27.BackColor = Color.LimeGreen;
        }

        private void oda28_MouseDown(object sender, MouseEventArgs e)
        {
            oda28.BackColor = Color.LimeGreen;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            TimeSpan kalanSure = hedefTarih - DateTime.Now;

            if (kalanSure.Days > 0)
            {
                label7.Text = (kalanSure.Days +1) .ToString();
            }
            else
            {
                label7.Text = "0";
                MessageBox.Show("1 Numaralı Odanın Süresi Dolmuştur Bilginize !");
                geriSayimTimer.Stop(); 
            }
        }
    }
}