using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eşleştirme_Oyunu
{
    public partial class fr14 : Form
    {
        public fr14()
        {
            InitializeComponent();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "SUNNY";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "CLOUDY";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "RAİNY";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "WİNDY";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "STORMY";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "FOGGY";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = "SNOWY";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = "ICY";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label2.Text = "GÜNEŞLİ";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label2.Text = "BULUTLU";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label2.Text = "YAĞMURLU";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label2.Text = "RÜZGARLI";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label2.Text = "FIRTINALI";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            label2.Text = "SİSLİ";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            label2.Text = "KAR YAĞIŞLI";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            label2.Text = "BUZLU";
        }

        private void btnkontrol1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "SUNNY" && label2.Text == "GÜNEŞLİ")
            {
                button1.Enabled = false;
                pictureBox1.Enabled = false;
                button1.BackColor = Color.YellowGreen;
                pictureBox1.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "CLOUDY" && label2.Text == "BULUTLU")
            {
                button2.Enabled = false;
                pictureBox2.Enabled = false;
                button2.BackColor = Color.YellowGreen;
                pictureBox2.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "RAİNY" && label2.Text == "YAĞMURLU")
            {
                button3.Enabled = false;
                pictureBox3.Enabled = false;
                button3.BackColor = Color.YellowGreen;
                pictureBox3.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "WİNDY" && label2.Text == "RÜZGARLI")
            {
                button4.Enabled = false;
                pictureBox4.Enabled = false;
                button4.BackColor = Color.YellowGreen;
                pictureBox4.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";

            }
            else if (label1.Text == "STORMY" && label2.Text == "FIRTINALI")
            {
                button5.Enabled = false;
                pictureBox5.Enabled = false;
                button5.BackColor = Color.YellowGreen;
                pictureBox5.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";

            }
            else if (label1.Text == "FOGGY" && label2.Text == "SİSLİ")
            {
                button6.Enabled = false;
                pictureBox6.Enabled = false;
                button6.BackColor = Color.YellowGreen;
                pictureBox6.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "SNOWY" && label2.Text == "KAR YAĞIŞLI")
            {
                button7.Enabled = false;
                pictureBox7.Enabled = false;
                button7.BackColor = Color.YellowGreen;
                pictureBox7.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "ICY" && label2.Text == "BUZLU")
            {
                button8.Enabled = false;
                pictureBox8.Enabled = false;
                button8.BackColor = Color.YellowGreen;
                pictureBox8.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else
            {
                label5.Text = "Yanlış Eşleştirme";
            }
        }
    }
}
