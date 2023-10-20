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
    public partial class fr8 : Form
    {
        public fr8()
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
            label1.Text = "COFFEE";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "LEMONADE";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "HOT CHOCOLATE";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "JUİCE";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "MİLKSHAKE";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "WATER";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = "TEA";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = "MİLK";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label2.Text = "KAHVE";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label2.Text = "LİMONATA";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label2.Text = "SICAK ÇİKOLATA";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label2.Text = "MEYVE SUYU";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label2.Text = " MİLKSHAKE";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            label2.Text = "SU";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            label2.Text = "ÇAY";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            label2.Text = "SÜT";
        }

        private void btnkontrol1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "COFFEE" && label2.Text == "KAHVE")
            {
                button1.Enabled = false;
                pictureBox1.Enabled = false;
                button1.BackColor = Color.YellowGreen;
                pictureBox1.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "LEMONADE" && label2.Text == "LİMONATA")
            {
                button2.Enabled = false;
                pictureBox2.Enabled = false;
                button2.BackColor = Color.YellowGreen;
                pictureBox2.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "HOT CHOCOLATE" && label2.Text == "SICAK ÇİKOLATA")
            {
                button3.Enabled = false;
                pictureBox3.Enabled = false;
                button3.BackColor = Color.YellowGreen;
                pictureBox3.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "JUİCE" && label2.Text == "MEYVE SUYU")
            {
                button4.Enabled = false;
                pictureBox4.Enabled = false;
                button4.BackColor = Color.YellowGreen;
                pictureBox4.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";

            }
            else if (label1.Text == "MİLKSHAKE" && label2.Text == "MİLKSHAKE")
            {
                button5.Enabled = false;
                pictureBox5.Enabled = false;
                button5.BackColor = Color.YellowGreen;
                pictureBox5.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";

            }
            else if (label1.Text == "WATER" && label2.Text == "SU")
            {
                button6.Enabled = false;
                pictureBox6.Enabled = false;
                button6.BackColor = Color.YellowGreen;
                pictureBox6.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "TEA" && label2.Text == "ÇAY")
            {
                button7.Enabled = false;
                pictureBox7.Enabled = false;
                button7.BackColor = Color.YellowGreen;
                pictureBox7.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "MİLK" && label2.Text == "SÜT")
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
