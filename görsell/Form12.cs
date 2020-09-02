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
    public partial class Form12 : Form
    {
        public Form1 frm1;
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int akenar = Convert.ToInt32(textBox1.Text);
            int bkenar = Convert.ToInt32(textBox2.Text);
            int ckenar = Convert.ToInt32(textBox3.Text);
            if(akenar==bkenar && akenar==ckenar)
            {
                MessageBox.Show("Üçgeniniz Eşkenar Üçgen");
            }
            if(akenar==bkenar && akenar != ckenar|| akenar != bkenar && bkenar==ckenar||ckenar!=bkenar && akenar==ckenar)
            {
                MessageBox.Show("Üçgeniniz İkizkenar Üçgen");
            }
            if(akenar!=bkenar && bkenar!=ckenar&& ckenar!=akenar)
            {
                MessageBox.Show("Üçgeniniz Çeşitkenar Üçgen");
            }
        }
    }
}
