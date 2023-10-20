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
    public partial class fr12 : Form
    {
        public fr12()
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
            label1.Text = "ALLİGATOR";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "LİON";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "PANDA";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "CAMEL";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "PİG";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "DOG";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = "CAT";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = "HORSE";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = "FİSH";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = "SHEEP";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = "FOX";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text = "COW";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Text = "DEER";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label1.Text = "GİRAFFE";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label1.Text = "DUCK";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label1.Text = "SNAKE";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label2.Text = "TİMSAH";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label2.Text = "ASLAN";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label2.Text = "PANDA";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label2.Text = "DEVE";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label2.Text = "DOMUZ";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            label2.Text = "KÖPEK";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            label2.Text = "KEDİ";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            label2.Text = "AT";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            label2.Text = "BALIK";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            label2.Text = "KOYUN";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            label2.Text = "TİLKİ";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            label2.Text = "İNEK";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            label2.Text = "GEYİK";
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            label2.Text = "ZÜRAFA";
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            label2.Text = "ÖRDEK";
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            label2.Text = "YILAN";
        }

        private void btnkontrol1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "ALLİGATOR" && label2.Text == "TİMSAH")
            {
                button1.Enabled = false;
                pictureBox1.Enabled = false;
                button1.BackColor = Color.YellowGreen;
                pictureBox1.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "LİON" && label2.Text == "ASLAN")
            {
                button2.Enabled = false;
                pictureBox2.Enabled = false;
                button2.BackColor = Color.YellowGreen;
                pictureBox2.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "PANDA" && label2.Text == "PANDA")
            {
                button3.Enabled = false;
                pictureBox3.Enabled = false;
                button3.BackColor = Color.YellowGreen;
                pictureBox3.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "CAMEL" && label2.Text == "DEVE")
            {
                button4.Enabled = false;
                pictureBox4.Enabled = false;
                button4.BackColor = Color.YellowGreen;
                pictureBox4.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";

            }
            else if (label1.Text == "PİG" && label2.Text == "DOMUZ")
            {
                button5.Enabled = false;
                pictureBox5.Enabled = false;
                button5.BackColor = Color.YellowGreen;
                pictureBox5.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";

            }
            else if (label1.Text == "DOG" && label2.Text == "KÖPEK")
            {
                button6.Enabled = false;
                pictureBox6.Enabled = false;
                button6.BackColor = Color.YellowGreen;
                pictureBox6.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "CAT" && label2.Text == "KEDİ")
            {
                button7.Enabled = false;
                pictureBox7.Enabled = false;
                button7.BackColor = Color.YellowGreen;
                pictureBox7.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "HORSE" && label2.Text == "AT")
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
            else if (label1.Text == "SHEEP" && label2.Text == "KOYUN")
            {
                button10.Enabled = false;
                pictureBox10.Enabled = false;
                button10.BackColor = Color.YellowGreen;
                pictureBox10.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "FOX" && label2.Text == "TİLKİ")
            {
                button11.Enabled = false;
                pictureBox11.Enabled = false;
                button11.BackColor = Color.YellowGreen;
                pictureBox11.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "COW" && label2.Text == "İNEK")
            {
                button12.Enabled = false;
                pictureBox12.Enabled = false;
                button12.BackColor = Color.YellowGreen;
                pictureBox12.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "DEER" && label2.Text == "GEYİK")
            {
                button13.Enabled = false;
                pictureBox13.Enabled = false;
                button13.BackColor = Color.YellowGreen;
                pictureBox13.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "GİRAFFE" && label2.Text == "ZÜRAFA")
            {
                button14.Enabled = false;
                pictureBox14.Enabled = false;
                button14.BackColor = Color.YellowGreen;
                pictureBox14.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "DUCK" && label2.Text == "ÖRDEK")
            {
                button15.Enabled = false;
                pictureBox15.Enabled = false;
                button15.BackColor = Color.YellowGreen;
                pictureBox15.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "SNAKE" && label2.Text == "YILAN")
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
