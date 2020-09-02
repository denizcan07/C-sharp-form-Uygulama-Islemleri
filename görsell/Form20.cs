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
    public partial class Form20 : Form
    {
        public Form1 frm1;
        public Form20()
        {
            InitializeComponent();
        }

        private void Form20_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int ilksayi, sonsayi;
            ilksayi = Convert.ToInt32(textBox1.Text);
            sonsayi = Convert.ToInt32(textBox2.Text);

            int sayi = ilksayi;
            bool durum = true;
            while (sayi <= sonsayi)
            {
                
                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        durum = false;
                    }
                }
                if (durum == true && sayi != 1)
                {
                    listBox1.Items.Add(sayi.ToString());
                }
                durum = true;
                sayi++;
            }
        }
    }
}
