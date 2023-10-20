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
    public partial class fr9 : Form
    {
        public fr9()
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
            label1.Text = "HEAD";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "HAİR";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "LİP";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "NOSE";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "TEETH";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "FOOT";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = "EAR";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = "EYE";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = "FACE";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = "HAND";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = "FİNGER";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text = "LEG";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label2.Text = "KAFA";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label2.Text = "SAÇ";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label2.Text = "DUDAK";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label2.Text = "BURUN";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label2.Text = "DİŞ";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            label2.Text = "AYAK";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            label2.Text = "KULAK";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            label2.Text = "GÖZ";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            label2.Text = "YÜZ";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            label2.Text = "EL";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            label2.Text = "PARMAK";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            label2.Text = "BACAK";
        }

        private void btnkontrol1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "HEAD" && label2.Text == "KAFA")
            {
                button1.Enabled = false;
                pictureBox1.Enabled = false;
                button1.BackColor = Color.YellowGreen;
                pictureBox1.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "HAİR" && label2.Text == "SAÇ")
            {
                button2.Enabled = false;
                pictureBox2.Enabled = false;
                button2.BackColor = Color.YellowGreen;
                pictureBox2.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "LİP" && label2.Text == "DUDAK")
            {
                button3.Enabled = false;
                pictureBox3.Enabled = false;
                button3.BackColor = Color.YellowGreen;
                pictureBox3.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "NOSE" && label2.Text == "BURUN")
            {
                button4.Enabled = false;
                pictureBox4.Enabled = false;
                button4.BackColor = Color.YellowGreen;
                pictureBox4.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";

            }
            else if (label1.Text == "TEETH" && label2.Text == "DİŞ")
            {
                button5.Enabled = false;
                pictureBox5.Enabled = false;
                button5.BackColor = Color.YellowGreen;
                pictureBox5.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";

            }
            else if (label1.Text == "FOOT" && label2.Text == "AYAK")
            {
                button6.Enabled = false;
                pictureBox6.Enabled = false;
                button6.BackColor = Color.YellowGreen;
                pictureBox6.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "EAR" && label2.Text == "KULAK")
            {
                button7.Enabled = false;
                pictureBox7.Enabled = false;
                button7.BackColor = Color.YellowGreen;
                pictureBox7.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "EYE" && label2.Text == "GÖZ")
            {
                button8.Enabled = false;
                pictureBox8.Enabled = false;
                button8.BackColor = Color.YellowGreen;
                pictureBox8.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "FACE" && label2.Text == "YÜZ")
            {
                button9.Enabled = false;
                pictureBox9.Enabled = false;
                button9.BackColor = Color.YellowGreen;
                pictureBox9.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "HAND" && label2.Text == "EL")
            {
                button10.Enabled = false;
                pictureBox10.Enabled = false;
                button10.BackColor = Color.YellowGreen;
                pictureBox10.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "FİNGER" && label2.Text == "PARMAK")
            {
                button11.Enabled = false;
                pictureBox11.Enabled = false;
                button11.BackColor = Color.YellowGreen;
                pictureBox11.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "LEG" && label2.Text == "BACAK")
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
