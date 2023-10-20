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
    public partial class fr5 : Form
    {
        public fr5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "APPLE";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "ORANGE";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "LEMON";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "BANANA";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "PEACH";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "GRAPES";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = "CHERRY";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = "WATER MELON";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = "MELON";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = "STRAWBERRY";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = "PEAR";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text = "KİWİ";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Text = "PİNEAPPLE";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label1.Text = "COCONUT";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label2.Text = "ELMA";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label2.Text = "PORTAKAL";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label2.Text = "LİMON";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label2.Text = "MUZ";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label2.Text = "ŞEFTALİ";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            label2.Text = "ÜZÜM";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            label2.Text = "KİRAZ";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            label2.Text = "KARPUZ";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            label2.Text = "KAVUN";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            label2.Text = "ÇİLEK";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            label2.Text = "ARMUT";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            label2.Text = "KİVİ";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            label2.Text = "ANANAS";
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            label2.Text = "KOKONAT";
        }

        private void btnkontrol1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "APPLE" && label2.Text == "ELMA")
            {
                button1.Enabled = false;
                pictureBox1.Enabled = false;
                button1.BackColor = Color.YellowGreen;
                pictureBox1.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "ORANGE" && label2.Text == "PORTAKAL")
            {
                button2.Enabled = false;
                pictureBox2.Enabled = false;
                button2.BackColor = Color.YellowGreen;
                pictureBox2.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "LEMON" && label2.Text == "LİMON")
            {
                button3.Enabled = false;
                pictureBox3.Enabled = false;
                button3.BackColor = Color.YellowGreen;
                pictureBox3.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "BANANA" && label2.Text == "MUZ")
            {
                button4.Enabled = false;
                pictureBox4.Enabled = false;
                button4.BackColor = Color.YellowGreen;
                pictureBox4.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";

            }
            else if (label1.Text == "PEACH" && label2.Text == "ŞEFTALİ")
            {
                button5.Enabled = false;
                pictureBox5.Enabled = false;
                button5.BackColor = Color.YellowGreen;
                pictureBox5.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";

            }
            else if (label1.Text == "GRAPES" && label2.Text == "ÜZÜM")
            {
                button6.Enabled = false;
                pictureBox6.Enabled = false;
                button6.BackColor = Color.YellowGreen;
                pictureBox6.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "CHERRY" && label2.Text == "KİRAZ")
            {
                button7.Enabled = false;
                pictureBox7.Enabled = false;
                button7.BackColor = Color.YellowGreen;
                pictureBox7.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "WATER MELON" && label2.Text == "KARPUZ")
            {
                button8.Enabled = false;
                pictureBox8.Enabled = false;
                button8.BackColor = Color.YellowGreen;
                pictureBox8.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "MELON" && label2.Text == "KAVUN")
            {
                button9.Enabled = false;
                pictureBox9.Enabled = false;
                button9.BackColor = Color.YellowGreen;
                pictureBox9.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "STRAWBERRY" && label2.Text == "ÇİLEK")
            {
                button10.Enabled = false;
                pictureBox10.Enabled = false;
                button10.BackColor = Color.YellowGreen;
                pictureBox10.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "PEAR" && label2.Text == "ARMUT")
            {
                button11.Enabled = false;
                pictureBox11.Enabled = false;
                button11.BackColor = Color.YellowGreen;
                pictureBox11.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "KİWİ" && label2.Text == "KİVİ")
            {
                button12.Enabled = false;
                pictureBox12.Enabled = false;
                button12.BackColor = Color.YellowGreen;
                pictureBox12.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "PİNEAPPLE" && label2.Text == "ANANAS")
            {
                button13.Enabled = false;
                pictureBox13.Enabled = false;
                button13.BackColor = Color.YellowGreen;
                pictureBox13.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "COCONUT" && label2.Text == "KOKONAT")
            {
                button14.Enabled = false;
                pictureBox14.Enabled = false;
                button14.BackColor = Color.YellowGreen;
                pictureBox14.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else
            {
                label5.Text = "Yanlış Eşleştirme";
            }
        }
    }
}
