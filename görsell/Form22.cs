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
    public partial class Form22 : Form
    {
        public Form1 frm1;
        public Form22()
        {
            InitializeComponent();
        }

        private void Form22_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double alan;
            double kuzunluk= Convert.ToDouble(textBox1.Text);
            double h = Convert.ToDouble(textBox2.Text);
            alan = (kuzunluk * h) / 2;
            label4.Text = alan.ToString();
            

        }
    }
}
