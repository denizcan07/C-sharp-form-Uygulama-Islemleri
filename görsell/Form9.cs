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
    public partial class Form9 : Form
    {
        public Form1 frm1;
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt32(textBox1.Text);
            int tektop = 0, tekcarp = 1;
            for (int i = 1; i <= N; i++)
            {
                if (i % 2 == 1)
                {
                    tektop = tektop + i;
                    tekcarp = tekcarp * i;

                }

            }
            listBox1.Items.Clear();
            listBox1.Items.Add(tektop);
            listBox2.Items.Clear();
            listBox2.Items.Add(tekcarp);
        }
    }
}
