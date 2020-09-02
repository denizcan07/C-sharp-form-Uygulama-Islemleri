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
    public partial class Form11 : Form
    {
        public Form1 frm1;
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double  km, cm;
            double m = Convert.ToDouble(textBox1.Text);
            km = m/1000;
            cm = m * 100;
            label4.Text = km.ToString();
            label5.Text = cm.ToString();
           
        } 
    }
}
