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
    public partial class fr6 : Form
    {
        public fr6()
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
            label1.Text = "PATATO";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = "TOMATO";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "CUCUMBER";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "CARROT";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "BROCCOLİ";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "CORN";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = "MUSHROOM";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "ONİONS";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = "GARLİC";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = "PEPPERS";
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            label2.Text = "HAVUÇ";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label2.Text = "PATATES";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label2.Text = "BROKOLİ";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label2.Text = "SALATALIK";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label2.Text = "SOĞAN";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label2.Text = "MISIR";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            label2.Text = "MANTAR";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            label2.Text = "BİBER";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            label2.Text = "DOMATES";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            label2.Text = "SARIMSAK";
        }
        private void btnkontrol1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "PATATO" && label2.Text == "PATATES")
            {
                button1.Enabled = false;
                pictureBox1.Enabled = false;
                button1.BackColor = Color.YellowGreen;
                pictureBox1.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "BROCCOLİ" && label2.Text == "BROKOLİ")
            {
                button2.Enabled = false;
                pictureBox2.Enabled = false;
                button2.BackColor = Color.YellowGreen;
                pictureBox2.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "CUCUMBER" && label2.Text == "SALATALIK")
            {
                button3.Enabled = false;
                pictureBox3.Enabled = false;
                button3.BackColor = Color.YellowGreen;
                pictureBox3.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "ONİONS" && label2.Text == "SOĞAN")
            {
                button4.Enabled = false;
                pictureBox4.Enabled = false;
                button4.BackColor = Color.YellowGreen;
                pictureBox4.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";

            }
            else if (label1.Text == "CORN" && label2.Text == "MISIR")
            {
                button5.Enabled = false;
                pictureBox5.Enabled = false;
                button5.BackColor = Color.YellowGreen;
                pictureBox5.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";

            }
            else if (label1.Text == "CARROT" && label2.Text == "HAVUÇ")
            {
                button6.Enabled = false;
                pictureBox6.Enabled = false;
                button6.BackColor = Color.YellowGreen;
                pictureBox6.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "MUSHROOM" && label2.Text == "MANTAR")
            {
                button7.Enabled = false;
                pictureBox7.Enabled = false;
                button7.BackColor = Color.YellowGreen;
                pictureBox7.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "TOMATO" && label2.Text == "DOMATES")
            {
                button8.Enabled = false;
                pictureBox8.Enabled = false;
                button8.BackColor = Color.YellowGreen;
                pictureBox8.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "PEPPER" && label2.Text == "BİBER")
            {
                button9.Enabled = false;
                pictureBox9.Enabled = false;
                button9.BackColor = Color.YellowGreen;
                pictureBox9.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "GARLİC" && label2.Text == "SARIMSAK")
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
