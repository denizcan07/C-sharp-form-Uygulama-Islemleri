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
    
    public partial class Form16 : Form
    {
        public Form1 frm1;
        public Form16()
        {
            InitializeComponent();
        }

        private void Form16_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ort;
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int sayi3 = Convert.ToInt32(textBox3.Text);
            int sayi4 = Convert.ToInt32(textBox4.Text);
            int sayi5 = Convert.ToInt32(textBox5.Text);
            int sayi6 = Convert.ToInt32(textBox6.Text);
            int sayi7 = Convert.ToInt32(textBox7.Text);
            int sayi8 = Convert.ToInt32(textBox8.Text);
            int sayi9 = Convert.ToInt32(textBox9.Text);
            int sayi10 = Convert.ToInt32(textBox10.Text);
            ort = (sayi1 + sayi2 + sayi3 + sayi4 + sayi5 + sayi6 + sayi7 + sayi8 + sayi9 + sayi10) / 10;
            MessageBox.Show("Ortalama=" + ort);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();

        }
    }
}
