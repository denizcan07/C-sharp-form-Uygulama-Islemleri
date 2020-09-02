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
    public partial class Form19 : Form
    {
        public Form1 frm1;
        public Form19()
        {
            InitializeComponent();
        }

        private void Form19_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int top = 0;
            int N = Convert.ToInt32(textBox1.Text);
            for (int i = 2; i <= N; i++)
            {
                if (i % 2 == 0)
                {
                    top = top + i;

                }
            }
            MessageBox.Show("Toplam Sonuc=" + top);
        }
    }
}
