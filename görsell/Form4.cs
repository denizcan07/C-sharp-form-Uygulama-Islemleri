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
    public partial class Form4 : Form
    {
        public Form1 frm1;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vize, final, ortalama,no;
            no = Convert.ToDouble(textBox1.Text);
            vize = Convert.ToDouble(textBox2.Text);
            final = Convert.ToDouble(textBox3.Text);
            ortalama = vize * 0.4 + final * 0.6;
            label7.Text = ortalama.ToString();
            label6.Text = no.ToString();
            
        
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
