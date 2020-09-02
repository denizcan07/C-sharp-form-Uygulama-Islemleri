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
    public partial class Form5 : Form
    {
        public Form1 frm1;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 1000; i++)
            {
                if (i % 2 == 1)
                {
                    listBox1.Items.Add(i);
                }

            }
        }
    }
}
