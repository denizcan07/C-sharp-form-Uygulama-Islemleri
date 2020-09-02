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
    public partial class Form3 : Form
    {
        public Form1 frm1;
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            if(x<0)
            {
                MessageBox.Show("Sayı Negatif..");
            }
            if (x == 0)
            {
                MessageBox.Show("Sayı Sıfır.. ");
            }
            if (x > 0)
            {
                MessageBox.Show("Sayı Pozitif.. ");
            }
        }
    }
}
