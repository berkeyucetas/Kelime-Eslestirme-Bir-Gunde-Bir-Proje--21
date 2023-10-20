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
    public partial class fr17 : Form
    {
        public fr17()
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
            label1.Text = "SCHOOL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "CLASSROOM";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "DOOR";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "WİNDOW";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "ORDER";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "DESK";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = "CHAİR";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = "BOOK";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = "PEN";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = "PENCİL";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = "ERASER";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text = "RULER";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Text = "PAPER";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label1.Text = "SCHOOL BAG";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label1.Text = "BOARD";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label1.Text = "NOTEBOOK";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label2.Text = "OKUL";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label2.Text = "SINIF";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label2.Text = "KAPI";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label2.Text = "PENCERE";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label2.Text = "SIRA";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            label2.Text = "MASA";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            label2.Text = "SANDALYE";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            label2.Text = "KİTAP";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            label2.Text = "DOLMA KALEM";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            label2.Text = "KALEM";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            label2.Text = "SİLGİ";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            label2.Text = "CETVEL";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            label2.Text = "KAĞIT";
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            label2.Text = "OKUL ÇANTASI";
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            label2.Text = "TAHTA";
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            label2.Text = "NOT DEFTERİ";
        }

        private void btnkontrol1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "SCHOOL" && label2.Text == "OKUL")
            {
                button1.Enabled = false;
                pictureBox1.Enabled = false;
                button1.BackColor = Color.YellowGreen;
                pictureBox1.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "CLASSROOM" && label2.Text == "SINIF")
            {
                button2.Enabled = false;
                pictureBox2.Enabled = false;
                button2.BackColor = Color.YellowGreen;
                pictureBox2.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "DOOR" && label2.Text == "KAPI")
            {
                button3.Enabled = false;
                pictureBox3.Enabled = false;
                button3.BackColor = Color.YellowGreen;
                pictureBox3.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "WİNDOW" && label2.Text == "PENCERE")
            {
                button4.Enabled = false;
                pictureBox4.Enabled = false;
                button4.BackColor = Color.YellowGreen;
                pictureBox4.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";

            }
            else if (label1.Text == "ORDER" && label2.Text == "SIRA")
            {
                button5.Enabled = false;
                pictureBox5.Enabled = false;
                button5.BackColor = Color.YellowGreen;
                pictureBox5.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";

            }
            else if (label1.Text == "DESK" && label2.Text == "MASA")
            {
                button6.Enabled = false;
                pictureBox6.Enabled = false;
                button6.BackColor = Color.YellowGreen;
                pictureBox6.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "CHAİR" && label2.Text == "SANDALYE")
            {
                button7.Enabled = false;
                pictureBox7.Enabled = false;
                button7.BackColor = Color.YellowGreen;
                pictureBox7.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "BOOK" && label2.Text == "KİTAP")
            {
                button8.Enabled = false;
                pictureBox8.Enabled = false;
                button8.BackColor = Color.YellowGreen;
                pictureBox8.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "PEN" && label2.Text == "DOLMA KALEM")
            {
                button9.Enabled = false;
                pictureBox9.Enabled = false;
                button9.BackColor = Color.YellowGreen;
                pictureBox9.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "PENCİL" && label2.Text == "KALEM")
            {
                button10.Enabled = false;
                pictureBox10.Enabled = false;
                button10.BackColor = Color.YellowGreen;
                pictureBox10.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "ERASER" && label2.Text == "SİLGİ")
            {
                button11.Enabled = false;
                pictureBox11.Enabled = false;
                button11.BackColor = Color.YellowGreen;
                pictureBox11.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "RULER" && label2.Text == "CETVEL")
            {
                button12.Enabled = false;
                pictureBox12.Enabled = false;
                button12.BackColor = Color.YellowGreen;
                pictureBox12.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "PAPER" && label2.Text == "KAĞIT")
            {
                button13.Enabled = false;
                pictureBox13.Enabled = false;
                button13.BackColor = Color.YellowGreen;
                pictureBox13.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "SCHOOL BAG" && label2.Text == "OKUL ÇANTASI")
            {
                button14.Enabled = false;
                pictureBox14.Enabled = false;
                button14.BackColor = Color.YellowGreen;
                pictureBox14.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "BOARD" && label2.Text == "TAHTA")
            {
                button15.Enabled = false;
                pictureBox15.Enabled = false;
                button15.BackColor = Color.YellowGreen;
                pictureBox15.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "NOTEBOOK" && label2.Text == "NOT DEFTERİ")
            {
                button16.Enabled = false;
                pictureBox16.Enabled = false;
                button16.BackColor = Color.YellowGreen;
                pictureBox16.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }            
            else
            {
                label5.Text = "Yanlış Eşleştirme";
            }
        }
    }
}
