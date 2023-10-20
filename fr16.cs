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
    public partial class fr16 : Form
    {
        public fr16()
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
            label1.Text = "CAR";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "BUS";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "PLANE";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "TRAİN";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "FERRY";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "BİCYCLE";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = "MOTORBİKE";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = "HELİCOPTER";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label2.Text = "ARABA";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label2.Text = "OTOBÜS";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label2.Text = "UÇAK";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label2.Text = "TREN";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label2.Text = "FERİBOT";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            label2.Text = "BİSİKLET";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            label2.Text = "MOTORSİKLET";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            label2.Text = "HELİKOPTER";
        }

        private void btnkontrol1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "CAR" && label2.Text == "ARABA")
            {
                button1.Enabled = false;
                pictureBox1.Enabled = false;
                button1.BackColor = Color.YellowGreen;
                pictureBox1.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "BUS" && label2.Text == "OTOBÜS")
            {
                button2.Enabled = false;
                pictureBox2.Enabled = false;
                button2.BackColor = Color.YellowGreen;
                pictureBox2.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "PLANE" && label2.Text == "UÇAK")
            {
                button3.Enabled = false;
                pictureBox3.Enabled = false;
                button3.BackColor = Color.YellowGreen;
                pictureBox3.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "TRAİN" && label2.Text == "TREN")
            {
                button4.Enabled = false;
                pictureBox4.Enabled = false;
                button4.BackColor = Color.YellowGreen;
                pictureBox4.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";

            }
            else if (label1.Text == "FERRY" && label2.Text == "FERİBOT")
            {
                button5.Enabled = false;
                pictureBox5.Enabled = false;
                button5.BackColor = Color.YellowGreen;
                pictureBox5.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";

            }
            else if (label1.Text == "BİCYCLE" && label2.Text == "BİSİKLET")
            {
                button6.Enabled = false;
                pictureBox6.Enabled = false;
                button6.BackColor = Color.YellowGreen;
                pictureBox6.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "MOTORBİKE" && label2.Text == "MOTORSİKLET")
            {
                button7.Enabled = false;
                pictureBox7.Enabled = false;
                button7.BackColor = Color.YellowGreen;
                pictureBox7.BackColor = Color.YellowGreen;
                label5.Text = "Doğru Eşleştirme";
            }
            else if (label1.Text == "HELİCOPTER" && label2.Text == "HELİKOPTER")
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
