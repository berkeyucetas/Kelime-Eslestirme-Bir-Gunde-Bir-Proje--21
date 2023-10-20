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
    public partial class fr11 : Form
    {
        public fr11()
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
            label1.Text = "ENGİNEER";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "SOLDİER";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "DOCTOR";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "WORKER";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "TEACHER";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "DANCER";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = "POLİCE";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = "BAKER";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = "CHİEF";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = "NURSE";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label2.Text = "MÜHENDİS";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label2.Text = "ASKER";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label2.Text = "DOKTOR";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label2.Text = "İŞCİ";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label2.Text = "ÖGRETMEN";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            label2.Text = "DANSÖZ";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            label2.Text = "POLİS";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            label2.Text = "FIRINCI";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            label2.Text = "ŞEF";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            label2.Text = "HEMŞİRE";
        }

        private void btnkontrol1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "ENGİNEER" && label2.Text == "MÜHENDİS")
            {
                button1.Enabled = false;
                pictureBox1.Enabled = false;
                button1.BackColor = Color.YellowGreen;
                pictureBox1.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "SOLDİER" && label2.Text == "ASKER")
            {
                button2.Enabled = false;
                pictureBox2.Enabled = false;
                button2.BackColor = Color.YellowGreen;
                pictureBox2.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "DOCTOR" && label2.Text == "DOKTOR")
            {
                button3.Enabled = false;
                pictureBox3.Enabled = false;
                button3.BackColor = Color.YellowGreen;
                pictureBox3.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "WORKER" && label2.Text == "İŞCİ")
            {
                button4.Enabled = false;
                pictureBox4.Enabled = false;
                button4.BackColor = Color.YellowGreen;
                pictureBox4.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";

            }
            else if (label1.Text == "TEACHER" && label2.Text == "ÖGRETMEN")
            {
                button5.Enabled = false;
                pictureBox5.Enabled = false;
                button5.BackColor = Color.YellowGreen;
                pictureBox5.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";

            }
            else if (label1.Text == "DANCER" && label2.Text == "DANSÖZ")
            {
                button6.Enabled = false;
                pictureBox6.Enabled = false;
                button6.BackColor = Color.YellowGreen;
                pictureBox6.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "POLİCE" && label2.Text == "POLİS")
            {
                button7.Enabled = false;
                pictureBox7.Enabled = false;
                button7.BackColor = Color.YellowGreen;
                pictureBox7.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "BAKER" && label2.Text == "FIRINCI")
            {
                button8.Enabled = false;
                pictureBox8.Enabled = false;
                button8.BackColor = Color.YellowGreen;
                pictureBox8.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "CHİEF" && label2.Text == "ŞEF")
            {
                button9.Enabled = false;
                pictureBox9.Enabled = false;
                button9.BackColor = Color.YellowGreen;
                pictureBox9.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "NURSE" && label2.Text == "HEMŞİRE")
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
