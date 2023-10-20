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
    public partial class fr13 : Form
    {
        public fr13()
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
            label1.Text = "WİNTER";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "SPRİNG";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "SUMMER";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "AUTUMN";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label2.Text = "KIŞ";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label2.Text = "İLKBAHAR";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label2.Text = "YAZ";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label2.Text = "SONBAHAR";
        }

        private void btnkontrol1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "WİNTER" && label2.Text == "KIŞ")
            {
                button1.Enabled = false;
                pictureBox1.Enabled = false;
                button1.BackColor = Color.YellowGreen;
                pictureBox1.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "SPRİNG" && label2.Text == "İLKBAHAR")
            {
                button2.Enabled = false;
                pictureBox2.Enabled = false;
                button2.BackColor = Color.YellowGreen;
                pictureBox2.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "SUMMER" && label2.Text == "YAZ")
            {
                button3.Enabled = false;
                pictureBox3.Enabled = false;
                button3.BackColor = Color.YellowGreen;
                pictureBox3.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "AUTUMN" && label2.Text == "SONBAHAR")
            {
                button4.Enabled = false;
                pictureBox4.Enabled = false;
                button4.BackColor = Color.YellowGreen;
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
