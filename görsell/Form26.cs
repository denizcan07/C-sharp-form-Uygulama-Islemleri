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
    public partial class Form26 : Form
    {
        public Form1 frm1;
        public Form26()
        {
            InitializeComponent();
        }

        private void Form26_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double akım = Convert.ToDouble(textBox1.Text);
            double direnc = Convert.ToDouble(textBox2.Text);
            double gerilim = akım * direnc;
            MessageBox.Show("Gerilim(V): " + gerilim);


        }
    }
}
