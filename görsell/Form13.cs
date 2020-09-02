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
    public partial class Form13 : Form
    {
        public Form1 frm1;
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float hesap,sayi,yüzde;
            sayi = Convert.ToInt32(textBox1.Text);
            yüzde = Convert.ToInt32(textBox2.Text);
            hesap = (sayi * yüzde) / 100;
            MessageBox.Show("Sonuc:" + hesap);

        }
    }
}
