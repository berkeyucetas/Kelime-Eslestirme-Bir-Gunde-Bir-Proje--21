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
    public partial class fr3 : Form
    {
        public fr3()
        {
            InitializeComponent();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            {
                Form1 form = new Form1();
                form.ShowDialog();
                this.Close();
            }
        }

        private void fr3_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\bekoo\\Desktop\\DERS\\C# Uygulama\\Eşleştirme Oyunu\\alfabe.mp3";
        }
    }
}
