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
    public partial class Form10 : Form
    {
        public Form1 frm1;
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String isim = Convert.ToString(textBox1.Text);
            int N = Convert.ToInt32(textBox2.Text);
            for(int i=0;i<N;i++)
            {
                
                listBox1.Items.Add(isim);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
