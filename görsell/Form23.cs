using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace görsell
{
    public partial class Form23 : Form
    {
        public Form1 frm1;
        public Form23()
        {
            InitializeComponent();
        }

        private void Form23_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double alan;
            double akenar = Convert.ToInt32(textBox1.Text);
            double bkenar = Convert.ToInt32(textBox2.Text);
            Double aci = Convert.ToDouble(textBox3.Text);
            double a=Math.PI * aci / 180; 
            alan = (akenar*bkenar*Math.Sin(a))/2;
            
            MessageBox.Show("Üçgenin Alanı: " + alan);
        }
    }
}
