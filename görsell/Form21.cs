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
    public partial class Form21 : Form
    {
        public Form1 frm1;
        public Form21()
        {
            InitializeComponent();
        }

        private void Form21_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = 1;
            int sayi2 = 1;
            int sayi3;
            int sondeger = Convert.ToInt32(textBox1.Text);
            listBox1.Items.Clear();
            listBox1.Items.Add(sayi1);
            listBox1.Items.Add( sayi2);


            for (int i = 0; i < sondeger - 2; i++)
            {
                sayi3 = sayi1 + sayi2;
                listBox1.Items.Add(sayi3);
                sayi1 = sayi2;
                sayi2 = sayi3;
            }
        }
    }
}
