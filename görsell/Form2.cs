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
    public partial class Form2 : Form
    {
        public Form1 frm1;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);
            int z = Convert.ToInt32(textBox3.Text);
            if (x > y & x > z) 
            {
                MessageBox.Show("En büyük Sayı: "+ x);
            
            }
            if (y > x & y > z) 
            {
                MessageBox.Show("En büyük Sayı: "+ y);
            }
            if (z > y & z > x) 
            {
                MessageBox.Show("En büyük Sayı: "+ z);
            }
        }
    }
}
