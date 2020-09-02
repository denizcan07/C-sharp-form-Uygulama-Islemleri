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
    public partial class Form7 : Form
    {
         
        public Form1 frm1;
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           ulong cifttop = 0,ciftcarp = 1;
            for (ulong i = 1; i <= 99; i++)
            {
                if (i % 2 == 0)
                {
                    cifttop = cifttop + i;
                    ciftcarp = ciftcarp * i;

                }
                
            }
            listBox1.Items.Clear();
            listBox1.Items.Add(cifttop);
            listBox2.Items.Clear();
            listBox2.Items.Add(ciftcarp);
            
                
            
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ulong tektop = 0,tekcarp = 1;
            for (ulong i = 1; i <= 99; i++)
            {
                if (i % 2 == 1)
                {
                    tektop =tektop+ i;
                    
                    tekcarp =tekcarp* i;
                    
                }

                i++;


            }
             listBox1.Items.Clear();
                listBox1.Items.Add(tektop);
                listBox2.Items.Clear();
                listBox2.Items.Add(tekcarp);
            
                


            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
