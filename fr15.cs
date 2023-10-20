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
    public partial class fr15 : Form
    {
        public fr15()
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
            label1.Text = "T-SHİRT";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "DRESS";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "JACKET";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "JEANS";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "SHOES";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "SHORTS";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = "GLOVES";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = "BOOTS";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = "HAT";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = "CAP";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = "RAİNCOAT";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text = "BELT";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label2.Text = "TŞÖRT";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label2.Text = "ELBİSE";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label2.Text = "ÇEKET";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label2.Text = "KOT";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label2.Text = "AYAKKABI";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            label2.Text = "ŞORT";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            label2.Text = "ELDİVEN";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            label2.Text = "BOT";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            label2.Text = "ŞAPKA";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            label2.Text = "KAP";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            label2.Text = "YAĞMURLUK";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            label2.Text = "KEMER";
        }

        private void btnkontrol1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "T-SHİRT" && label2.Text == "TŞÖRT")
            {
                button1.Enabled = false;
                pictureBox1.Enabled = false;
                button1.BackColor = Color.YellowGreen;
                pictureBox1.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "DRESS" && label2.Text == "ELBİSE")
            {
                button2.Enabled = false;
                pictureBox2.Enabled = false;
                button2.BackColor = Color.YellowGreen;
                pictureBox2.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "JACKET" && label2.Text == "ÇEKET")
            {
                button3.Enabled = false;
                pictureBox3.Enabled = false;
                button3.BackColor = Color.YellowGreen;
                pictureBox3.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "JEANS" && label2.Text == "KOT")
            {
                button4.Enabled = false;
                pictureBox4.Enabled = false;
                button4.BackColor = Color.YellowGreen;
                pictureBox4.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";

            }
            else if (label1.Text == "SHOES" && label2.Text == "AYAKKABI")
            {
                button5.Enabled = false;
                pictureBox5.Enabled = false;
                button5.BackColor = Color.YellowGreen;
                pictureBox5.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";

            }
            else if (label1.Text == "SHORTS" && label2.Text == "ŞORT")
            {
                button6.Enabled = false;
                pictureBox6.Enabled = false;
                button6.BackColor = Color.YellowGreen;
                pictureBox6.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "GLOVES" && label2.Text == "ELDİVEN")
            {
                button7.Enabled = false;
                pictureBox7.Enabled = false;
                button7.BackColor = Color.YellowGreen;
                pictureBox7.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "BOOTS" && label2.Text == "BOT")
            {
                button8.Enabled = false;
                pictureBox8.Enabled = false;
                button8.BackColor = Color.YellowGreen;
                pictureBox8.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "HAT" && label2.Text == "ŞAPKA")
            {
                button9.Enabled = false;
                pictureBox9.Enabled = false;
                button9.BackColor = Color.YellowGreen;
                pictureBox9.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "CAP" && label2.Text == "KAP")
            {
                button10.Enabled = false;
                pictureBox10.Enabled = false;
                button10.BackColor = Color.YellowGreen;
                pictureBox10.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "RAİNCOAT" && label2.Text == "YAĞMURLUK")
            {
                button11.Enabled = false;
                pictureBox11.Enabled = false;
                button11.BackColor = Color.YellowGreen;
                pictureBox11.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "BELT" && label2.Text == "KEMER")
            {
                button12.Enabled = false;
                pictureBox12.Enabled = false;
                button12.BackColor = Color.YellowGreen;
                pictureBox12.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else
            {
                label5.Text = "Yanlış Eşleştirme";
            }
        }
    }
}
