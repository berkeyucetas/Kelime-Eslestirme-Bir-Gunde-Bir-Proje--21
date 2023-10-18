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
    public partial class fr1 : Form
    {
        public fr1()
        {
            InitializeComponent();
        }

        private void fr1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "ZERO";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "ONE";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "TWO";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "THREE";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "FOUR";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "FİVE";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = "SİX";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = "SEVEN";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = "EİGHT";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = "NİNE";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = "TEN";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text = "TWENTY";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Text = "THİRTY";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label1.Text = "FORTY";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label1.Text = "FİFTY";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label1.Text = "SİXTY";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label1.Text = "SEVENTY";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            label1.Text = "EİGHTY";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            label1.Text = "NİNETY";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            label1.Text = "ONE HUNDRED";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label2.Text = "SIFIR";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label2.Text = "BİR";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label2.Text = "İKİ";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label2.Text = "ÜÇ";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label2.Text = "DÖRT";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            label2.Text = "BEŞ";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            label2.Text = "ALTI";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            label2.Text = "YEDİ";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            label2.Text = "SEKİZ";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            label2.Text = "DOKUZ";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            label2.Text = "ON";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            label2.Text = "YİRMİ";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            label2.Text = "OTUZ";
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            label2.Text = "KIRK";
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            label2.Text = "ELLİ";
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            label2.Text = "ATMIŞ";
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            label2.Text = "YETMİŞ";
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            label2.Text = "SEKSEN";
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            label2.Text = "DOKSAN";
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            label2.Text = "YÜZ";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
            this.Close();
        }

        private void btnkontrol1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "ZERO" && label2.Text == "SIFIR")
            {
                button1.Enabled = false;
                pictureBox1.Enabled = false;
                button1.BackColor = Color.YellowGreen;
                pictureBox1.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "ONE" && label2.Text == "BİR")
            {
                button2.Enabled = false;
                pictureBox2.Enabled = false;
                button2.BackColor = Color.YellowGreen;
                pictureBox2.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "TWO" && label2.Text == "İKİ")
            {
                button3.Enabled = false;
                pictureBox3.Enabled = false;
                button3.BackColor = Color.YellowGreen;
                pictureBox3.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "THREE" && label2.Text == "ÜÇ")
            {
                button4.Enabled = false;
                pictureBox4.Enabled = false;
                button4.BackColor = Color.YellowGreen;
                pictureBox4.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";

            }
            else if (label1.Text == "FOUR" && label2.Text == "DÖRT")
            {
                button5.Enabled = false;
                pictureBox5.Enabled = false;
                button5.BackColor = Color.YellowGreen;
                pictureBox5.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";

            }
            else if (label1.Text == "FİVE" && label2.Text == "BEŞ")
            {
                button6.Enabled = false;
                pictureBox6.Enabled = false;
                button6.BackColor = Color.YellowGreen;
                pictureBox6.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "SİX" && label2.Text == "ALTI")
            {
                button7.Enabled = false;
                pictureBox7.Enabled = false;
                button7.BackColor = Color.YellowGreen;
                pictureBox7.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "SEVEN" && label2.Text == "YEDİ")
            {
                button8.Enabled = false;
                pictureBox8.Enabled = false;
                button8.BackColor = Color.YellowGreen;
                pictureBox8.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "EİGHT" && label2.Text == "SEKİZ")
            {
                button9.Enabled = false;
                pictureBox9.Enabled = false;
                button9.BackColor = Color.YellowGreen;
                pictureBox9.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "NİNE" && label2.Text == "DOKUZ")
            {
                button10.Enabled = false;
                pictureBox10.Enabled = false;
                button10.BackColor = Color.YellowGreen;
                pictureBox10.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "TEN" && label2.Text == "ON")
            {
                button11.Enabled = false;
                pictureBox11.Enabled = false;
                button11.BackColor = Color.YellowGreen;
                pictureBox11.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "TWENTY" && label2.Text == "YİRMİ")
            {
                button12.Enabled = false;
                pictureBox12.Enabled = false;
                button12.BackColor = Color.YellowGreen;
                pictureBox12.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "THİRTY" && label2.Text == "OTUZ")
            {
                button13.Enabled = false;
                pictureBox13.Enabled = false;
                button13.BackColor = Color.YellowGreen;
                pictureBox13.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "FORTY" && label2.Text == "KIRK")
            {
                button14.Enabled = false;
                pictureBox14.Enabled = false;
                button14.BackColor = Color.YellowGreen;
                pictureBox14.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "FİFTY" && label2.Text == "ELLİ")
            {
                button15.Enabled = false;
                pictureBox15.Enabled = false;
                button15.BackColor = Color.YellowGreen;
                pictureBox15.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "SİXTY" && label2.Text == "ATMIŞ")
            {
                button16.Enabled = false;
                pictureBox16.Enabled = false;
                button16.BackColor = Color.YellowGreen;
                pictureBox16.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "SEVENTY" && label2.Text == "YETMİŞ")
            {
                button17.Enabled = false;
                pictureBox17.Enabled = false;
                button17.BackColor = Color.YellowGreen;
                pictureBox17.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "EİGHTY" && label2.Text == "SEKSEN")
            {
                button18.Enabled = false;
                pictureBox18.Enabled = false;
                button18.BackColor = Color.YellowGreen;
                pictureBox18.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "NİNETY" && label2.Text == "DOKSAN")
            {
                button19.Enabled = false;
                pictureBox19.Enabled = false;
                button19.BackColor = Color.YellowGreen;
                pictureBox19.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "ONE HUNDRED" && label2.Text == "YÜZ")
            {
                button20.Enabled = false;
                pictureBox20.Enabled = false;
                button20.BackColor = Color.YellowGreen;
                pictureBox20.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else
            {
                label5.Text = "Yanlış Eşleştirme";
            }

        }
    }
}
