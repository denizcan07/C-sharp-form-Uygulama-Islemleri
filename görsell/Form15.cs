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
    public partial class Form15 : Form
    {
        public Form1 frm1;
        public Form15()
        {
            InitializeComponent();
        }

        private void Form15_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Gun = Convert.ToInt32(textBox1.Text);
            switch (Gun)
            {
                case 1:
                    MessageBox.Show("Pazartesi");
                    break;

                case 2:
                    MessageBox.Show("Salı");
                    break;

                case 3:
                    MessageBox.Show("Çarşamba");
                    break;

                case 4:
                    MessageBox.Show("Perşembe");
                    break;

                case 5:
                    MessageBox.Show("Cuma");
                    break;

                case 6:
                    MessageBox.Show("Cumartesi");
                    break;

                case 7:
                    MessageBox.Show("Pazar");
                    break;

                default:
                    MessageBox.Show("Lütfen 1-7 arasında bir değer giriniz.");
                    break;
            }
        }
    }
}
