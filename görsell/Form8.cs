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
    public partial class Form8 : Form
    {
        public Form1 frm1;
        public Form8()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            if(sayi%2==0)
            {
                MessageBox.Show("Sayı Çifttir.");
            }
            if (sayi % 2 == 1)
            {
                MessageBox.Show("Sayı Tektir.");
            }
        }
    }
}
