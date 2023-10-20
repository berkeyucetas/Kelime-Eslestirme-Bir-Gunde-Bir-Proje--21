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
    public partial class fr10 : Form
    {
        public fr10()
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
            label1.Text = "FATHER";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "MOTHER";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "BROTHER";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "SİSTER";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "GRAND FATHER";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "GRAND MOTHER";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = "UNCLE";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = "AUNT";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label2.Text = "BABA";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label2.Text = "ANNE";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label2.Text = "ERKEK KARDEŞ";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label2.Text = "KIZ KARDEŞ";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label2.Text = "BÜYÜK BABA";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            label2.Text = "BÜYÜK ANNE";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            label2.Text = "AMCA, ENİŞTE, DAYI";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            label2.Text = "HALA, YENGE, TEYZE";
        }

        private void btnkontrol1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "FATHER" && label2.Text == "BABA")
            {
                button1.Enabled = false;
                pictureBox1.Enabled = false;
                button1.BackColor = Color.YellowGreen;
                pictureBox1.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "MOTHER" && label2.Text == "ANNE")
            {
                button2.Enabled = false;
                pictureBox2.Enabled = false;
                button2.BackColor = Color.YellowGreen;
                pictureBox2.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "BROTHER" && label2.Text == "ERKEK KARDEŞ")
            {
                button3.Enabled = false;
                pictureBox3.Enabled = false;
                button3.BackColor = Color.YellowGreen;
                pictureBox3.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "SİSTER" && label2.Text == "KIZ KARDEŞ")
            {
                button4.Enabled = false;
                pictureBox4.Enabled = false;
                button4.BackColor = Color.YellowGreen;
                pictureBox4.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";

            }
            else if (label1.Text == "GRAND FATHER" && label2.Text == "BÜYÜK BABA")
            {
                button5.Enabled = false;
                pictureBox5.Enabled = false;
                button5.BackColor = Color.YellowGreen;
                pictureBox5.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";

            }
            else if (label1.Text == "GRAND MOTHER" && label2.Text == "BÜYÜK ANNE")
            {
                button6.Enabled = false;
                pictureBox6.Enabled = false;
                button6.BackColor = Color.YellowGreen;
                pictureBox6.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "UNCLE" && label2.Text == "AMCA, ENİŞTE, DAYI")
            {
                button7.Enabled = false;
                pictureBox7.Enabled = false;
                button7.BackColor = Color.YellowGreen;
                pictureBox7.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "AUNT" && label2.Text == "HALA, YENGE, TEYZE")
            {
                button8.Enabled = false;
                pictureBox8.Enabled = false;
                button8.BackColor = Color.YellowGreen;
                pictureBox8.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else
            {
                label5.Text = "Yanlış Eşleştirme";
            }
        }
    }
}
