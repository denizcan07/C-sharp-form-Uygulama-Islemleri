using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace görsell
{
    public partial class Form24 : Form
    {
        public Form1 frm1;
        public Form24()
        {
            InitializeComponent();
        }

        private void Form24_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int akenar = Convert.ToInt32(textBox1.Text);
            int bkenar = Convert.ToInt32(textBox2.Text);
            int ckenar = Convert.ToInt32(textBox3.Text);
            int u = (akenar + bkenar + ckenar) / 2;
            double alan = Math.Sqrt(u * (u - akenar) * (u - bkenar) * (u - ckenar));
            MessageBox.Show("Üçgenin Alanı: " + alan);
        }
    }
}
