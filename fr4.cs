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
    public partial class fr4 : Form
    {
        public fr4()
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
            label1.Text = "SQUARE";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "RACTANGLE";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "STAR";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "CİRCLE";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "OVAL";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "CUBE";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = "TRİANGLE";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = "PENTAGON";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = "HEART";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = "HEXAGON";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label2.Text = "KARE";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label2.Text = "DİKDÖRTGEN";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label2.Text = "YILDIZ";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label2.Text = "YUVARLAK";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label2.Text = "OVAL";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            label2.Text = "KÜP";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            label2.Text = "ÜÇGEN";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            label2.Text = "BEŞGEN";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            label2.Text = "KALP";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            label2.Text = "ALTIGEN";
        }

        private void btnkontrol1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "SQUARE" && label2.Text == "KARE")
            {
                button1.Enabled = false;
                pictureBox1.Enabled = false;
                button1.BackColor = Color.YellowGreen;
                pictureBox1.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "RACTANGLE" && label2.Text == "DİKDÖRTGEN")
            {
                button2.Enabled = false;
                pictureBox2.Enabled = false;
                button2.BackColor = Color.YellowGreen;
                pictureBox2.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "STAR" && label2.Text == "YILDIZ")
            {
                button3.Enabled = false;
                pictureBox3.Enabled = false;
                button3.BackColor = Color.YellowGreen;
                pictureBox3.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "CİRCLE" && label2.Text == "YUVARLAK")
            {
                button4.Enabled = false;
                pictureBox4.Enabled = false;
                button4.BackColor = Color.YellowGreen;
                pictureBox4.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";

            }
            else if (label1.Text == "OVAL" && label2.Text == "OVAL")
            {
                button5.Enabled = false;
                pictureBox5.Enabled = false;
                button5.BackColor = Color.YellowGreen;
                pictureBox5.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";

            }
            else if (label1.Text == "CUBE" && label2.Text == "KÜP")
            {
                button6.Enabled = false;
                pictureBox6.Enabled = false;
                button6.BackColor = Color.YellowGreen;
                pictureBox6.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "TRİANGLE" && label2.Text == "ÜÇGEN")
            {
                button7.Enabled = false;
                pictureBox7.Enabled = false;
                button7.BackColor = Color.YellowGreen;
                pictureBox7.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "PENTAGON" && label2.Text == "BEŞGEN")
            {
                button8.Enabled = false;
                pictureBox8.Enabled = false;
                button8.BackColor = Color.YellowGreen;
                pictureBox8.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "HEART" && label2.Text == "KALP")
            {
                button9.Enabled = false;
                pictureBox9.Enabled = false;
                button9.BackColor = Color.YellowGreen;
                pictureBox9.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "HEXAGON" && label2.Text == "ALTIGEN")
            {
                button10.Enabled = false;
                pictureBox10.Enabled = false;
                button10.BackColor = Color.YellowGreen;
                pictureBox10.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else
            {
                label5.Text = "Yanlış Eşleştirme";
            }
        }
    }
}
