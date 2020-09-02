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
    public partial class Form6 : Form
    {
        public Form1 frm1;
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int sayi3 = Convert.ToInt32(textBox3.Text);
            if(sayi1<sayi2 && sayi1<sayi3 && sayi2<sayi3)
            {
                MessageBox.Show(""+sayi1 + "<" + ""+sayi2+"<"+""+sayi3 );
            }
            if (sayi2 < sayi1 && sayi2 < sayi3 && sayi1 < sayi3)
            {
                MessageBox.Show("" + sayi2 + "<" + "" + sayi1 + "<" + "" + sayi3);
            }
            if (sayi3 < sayi2 && sayi3 < sayi1 && sayi2 < sayi1)
            {
                MessageBox.Show("" + sayi3 + "<" + "" + sayi2 + "<" + "" + sayi1);
            }
            if (sayi1 < sayi2 && sayi1 < sayi3 && sayi2 > sayi3)
            {
                MessageBox.Show("" + sayi1 + "<" + "" + sayi3 + "<" + "" + sayi2);
            }
            if (sayi2 < sayi3 && sayi2 < sayi1 && sayi3 < sayi1)
            {
                MessageBox.Show("" + sayi2 + "<" + "" + sayi3 + "<" + "" + sayi1);
            }
        } 
    }
}
