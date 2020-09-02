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
    public partial class Form14 : Form
    {
        public Form1 frm1;
        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float gelisfiyat, satısfiyat, kdv;
            gelisfiyat = Convert.ToInt32(textBox1.Text);
            kdv = Convert.ToInt32(textBox2.Text);
            satısfiyat = gelisfiyat + ((gelisfiyat * kdv) / 100);
            MessageBox.Show("Satış Fiyatı:" + satısfiyat);
        }
    }
}
