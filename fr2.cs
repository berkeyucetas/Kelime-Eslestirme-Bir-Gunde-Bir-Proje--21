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
    public partial class fr2 : Form
    {
        public fr2()
        {
            InitializeComponent();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
            this.Close();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            label1.Text = "RED";

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            label1.Text = "BLUE";

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            label1.Text = "YELLOW";

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            label1.Text = "GREEN";

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            label1.Text = "ORANGE";

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            label1.Text = "PİNK";

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            label1.Text = "PURPLE";

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            label1.Text = "BROWN";

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            label1.Text = "NAVY BLUE";

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            label1.Text = "GRAY";

        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            label1.Text = "BLACK";

        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            label1.Text = "WHİTE";
        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            label2.Text = "KIRMIZI";
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            label2.Text = "SİYAH";
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            label2.Text = "MAVİ";
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            label2.Text = "BEYAZ";
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            label2.Text = "SARI";
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            label2.Text = "TURUNCU";
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            label2.Text = "YEŞİL";
        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            label2.Text = "MOR";
        }

        private void pictureBox9_Click_1(object sender, EventArgs e)
        {
            label2.Text = "PEMBE";
        }

        private void pictureBox10_Click_1(object sender, EventArgs e)
        {
            label2.Text = "GRİ";
        }

        private void pictureBox11_Click_1(object sender, EventArgs e)
        {
            label2.Text = "LACİVERT";
        }

        private void pictureBox12_Click_1(object sender, EventArgs e)
        {
            label2.Text = "KAHVERENGİ";
        }

        private void btnkontrol2_Click(object sender, EventArgs e)
        {
            if (label1.Text == "RED" && label2.Text == "KIRMIZI")
            {
                button1.Enabled = false;
                pictureBox1.Enabled = false;
                button1.BackColor = Color.YellowGreen;
                pictureBox1.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "BLUE" && label2.Text == "MAVİ")
            {
                button2.Enabled = false;
                pictureBox3.Enabled = false;
                button2.BackColor = Color.YellowGreen;
                pictureBox3.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "YELLOW" && label2.Text == "SARI")
            {
                button3.Enabled = false;
                pictureBox5.Enabled = false;
                button3.BackColor = Color.YellowGreen;
                pictureBox5.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "GREEN" && label2.Text == "YEŞİL")
            {
                button4.Enabled = false;
                pictureBox7.Enabled = false;
                button4.BackColor = Color.YellowGreen;
                pictureBox7.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";

            }
            else if (label1.Text == "ORANGE" && label2.Text == "TURUNCU")
            {
                button5.Enabled = false;
                pictureBox6.Enabled = false;
                button5.BackColor = Color.YellowGreen;
                pictureBox6.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";

            }
            else if (label1.Text == "PİNK" && label2.Text == "PEMBE")
            {
                button6.Enabled = false;
                pictureBox9.Enabled = false;
                button6.BackColor = Color.YellowGreen;
                pictureBox9.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "PURPLE" && label2.Text == "MOR")
            {
                button7.Enabled = false;
                pictureBox8.Enabled = false;
                button7.BackColor = Color.YellowGreen;
                pictureBox8.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "BROWN" && label2.Text == "KAHVERENGİ")
            {
                button8.Enabled = false;
                pictureBox12.Enabled = false;
                button8.BackColor = Color.YellowGreen;
                pictureBox12.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "NAVY BLUE" && label2.Text == "LACİVERT")
            {
                button9.Enabled = false;
                pictureBox11.Enabled = false;
                button9.BackColor = Color.YellowGreen;
                pictureBox11.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "GRAY" && label2.Text == "GRİ")
            {
                button10.Enabled = false;
                pictureBox10.Enabled = false;
                button10.BackColor = Color.YellowGreen;
                pictureBox10.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "BLACK" && label2.Text == "SİYAH")
            {
                button11.Enabled = false;
                pictureBox2.Enabled = false;
                button11.BackColor = Color.YellowGreen;
                pictureBox2.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "WHİTE" && label2.Text == "BEYAZ")
            {
                button12.Enabled = false;
                pictureBox4.Enabled = false;
                button12.BackColor = Color.YellowGreen;
                pictureBox4.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else
            {
                label5.Text = "Yanlış Eşleştirme";
            }
        }        
    }
}
