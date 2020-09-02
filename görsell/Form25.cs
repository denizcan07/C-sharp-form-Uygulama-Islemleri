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
    public partial class Form25 : Form
    {
        public Form1 frm1;
        public Form25()
        {
            InitializeComponent();
        }

        private void Form25_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b= Convert.ToInt32(textBox2.Text);
            double hipot = Math.Sqrt((a * a + b * b));
            MessageBox.Show("Hipotenüs: " + hipot);

        }
    }
}
