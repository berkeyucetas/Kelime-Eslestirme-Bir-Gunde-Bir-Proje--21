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
    public partial class fr7 : Form
    {
        public fr7()
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
            label1.Text = "CHEESE";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "EGGS";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "YOGURT";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "BREAD";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "PİZZA";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "HAMBURGER";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = "CHİCKEN";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = "STEAK";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = "FİSH";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = "JAM";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label2.Text = "PEYNİR";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label2.Text = "YUMURTA";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label2.Text = "YOĞURT";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label2.Text = "EKMEK";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label2.Text = "PİZZA";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            label2.Text = "HAMBURGER";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            label2.Text = "TAVUK";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            label2.Text = "BİFTEK";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            label2.Text = "BALIK";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            label2.Text = "REÇEL";
        }

        private void btnkontrol1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "CHEESE" && label2.Text == "PEYNİR")
            {
                button1.Enabled = false;
                pictureBox1.Enabled = false;
                button1.BackColor = Color.YellowGreen;
                pictureBox1.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "EGGS" && label2.Text == "YUMURTA")
            {
                button2.Enabled = false;
                pictureBox2.Enabled = false;
                button2.BackColor = Color.YellowGreen;
                pictureBox2.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "YOGURT" && label2.Text == "YOĞURT")
            {
                button3.Enabled = false;
                pictureBox3.Enabled = false;
                button3.BackColor = Color.YellowGreen;
                pictureBox3.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "BREAD" && label2.Text == "EKMEK")
            {
                button4.Enabled = false;
                pictureBox4.Enabled = false;
                button4.BackColor = Color.YellowGreen;
                pictureBox4.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";

            }
            else if (label1.Text == "PİZZA" && label2.Text == "PİZZA")
            {
                button5.Enabled = false;
                pictureBox5.Enabled = false;
                button5.BackColor = Color.YellowGreen;
                pictureBox5.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";

            }
            else if (label1.Text == "HAMBURGER" && label2.Text == "HAMBURGER")
            {
                button6.Enabled = false;
                pictureBox6.Enabled = false;
                button6.BackColor = Color.YellowGreen;
                pictureBox6.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "CHİCKEN" && label2.Text == "TAVUK")
            {
                button7.Enabled = false;
                pictureBox7.Enabled = false;
                button7.BackColor = Color.YellowGreen;
                pictureBox7.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "STEAK" && label2.Text == "BİFTEK")
            {
                button8.Enabled = false;
                pictureBox8.Enabled = false;
                button8.BackColor = Color.YellowGreen;
                pictureBox8.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "FİSH" && label2.Text == "BALIK")
            {
                button9.Enabled = false;
                pictureBox9.Enabled = false;
                button9.BackColor = Color.YellowGreen;
                pictureBox9.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "JAM" && label2.Text == "REÇEL")
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
