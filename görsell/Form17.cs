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
    public partial class Form17 : Form
    {
        public Form1 frm1;
        public Form17()
        {
            InitializeComponent();
        }

        private void Form17_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int top = 0;
            int N = Convert.ToInt32(textBox1.Text);
            for(int i=1;i<=N;i++)
            {
                top = top + i;
                
            }
            MessageBox.Show("Toplam Sonuç=" + top);
        }
    }
}
