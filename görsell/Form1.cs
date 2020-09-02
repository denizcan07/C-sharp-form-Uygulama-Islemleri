using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace görsell
{
    public partial class Form1 : Form
    { 
        public Form26 frm26;
        public Form25 frm25;
        public Form24 frm24;
        public Form23 frm23;
        public Form22 frm22;
        public Form21 frm21;
        public Form20 frm20;
        public Form19 frm19;
        public Form18 frm18;
        public Form17 frm17;
        public Form16 frm16;
        public Form15 frm15;
        public Form14 frm14;
        public Form13 frm13;
        public Form12 frm12;
        public Form11 frm11;
        public Form10 frm10;
        public Form9 frm9;
        public Form8 frm8;
        public Form7 frm7;
        public Form6 frm6;
        public Form5 frm5;
        public Form4 frm4;
        public Form3 frm3;
        public Form2 frm2;
        public Form1()
        {          
            frm26 = new Form26();
            frm25 = new Form25();
            frm24 = new Form24();
            frm23 = new Form23();
            frm22 = new Form22();
            frm21 = new Form21();
            frm20 = new Form20();
            frm19 = new Form19();
            frm18 = new Form18();
            frm17 = new Form17();
            frm16 = new Form16();
            frm15 = new Form15();
            frm14 = new Form14();
            frm13 = new Form13();
            frm12 = new Form12();
            frm11 = new Form11();
            frm10 = new Form10();
            frm9 = new Form9();
            frm8 = new Form8();
            frm7 = new Form7();
            frm6 = new Form6();
            frm5 = new Form5();
            frm4 = new Form4();
            frm3 = new Form3();
            frm2 = new Form2();
            InitializeComponent();
            frm2.frm1 = this;
            frm3.frm1 = this;
            frm4.frm1 = this;
            frm5.frm1 = this;
            frm6.frm1 = this;
            frm7.frm1 = this;
            frm8.frm1 = this;
            frm9.frm1 = this;
            frm10.frm1 = this;
            frm11.frm1 = this;
            frm12.frm1 = this;
            frm13.frm1 = this;
            frm14.frm1 = this;
            frm15.frm1 = this;
            frm16.frm1 = this;
            frm17.frm1 = this;
            frm18.frm1 = this;
            frm19.frm1 = this;
            frm20.frm1 = this;
            frm21.frm1 = this;
            frm22.frm1 = this;
            frm23.frm1 = this;
            frm24.frm1 = this;
            frm25.frm1 = this;
            frm26.frm1 = this;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("1-Girilen 3 sayıdan en büyüğünü bulma");
            comboBox1.Items.Add("2-Girilen sayının negatif,pozitif,sıfır olduğunu bulma");
            comboBox1.Items.Add("3-Öğrenci no,vize, final notunu aldıktan sonra ort hesaplayıp no ve not ortalamasını yazdırma");
            comboBox1.Items.Add("4-1 ile 1000 arasındaki tek sayıları ekrana yazdıran program");
            comboBox1.Items.Add("5-Girilen üç sayıyı küçükten büyüğe doğru sıralayan program");
            comboBox1.Items.Add("6-1 - 99 arasındaki tek ve çift sayıların toplamları ile çarpımlarını hesaplayan program");
            comboBox1.Items.Add("7-Klavyeden girilen pozitif bir sayının tek mi çift mi olduğunu bulan program");
            comboBox1.Items.Add("8-N sayısına göre 1'den N'e kadar olan tek sayıların toplamını ve çarpımını bulan program");
            comboBox1.Items.Add("9-Klavyeden girilen ismi istenen sayı kadar alt alta yazdıran program");
            comboBox1.Items.Add("10-Klavyeden metre cinsinden girilen uzunluğu (km) ve (cm) dönüştürüp yazdıran program");
            comboBox1.Items.Add("11-Üç kenar uzunluğu girilen üçgenin (eşkenar, ikizkenar veya çeşitkenar) yazdıran program");
            comboBox1.Items.Add("12-Klavyeden girilen sayının yine klavyeden istenen yüzdesini hesaplayıp yazdıran program");
            comboBox1.Items.Add("13-Birir ürünün fiyatı ve KDV oranı istenip, ürünün KDV'li satış fiyatını hesaplayan program");
            comboBox1.Items.Add("14-Haftanın gününü bulan Program");
            comboBox1.Items.Add("15-Girilen 10 sayının ortalamasını hesaplayan program");
            comboBox1.Items.Add("16-1’den n’e kadar tamsayıların toplamını bulan program");
            comboBox1.Items.Add("17-1’den n’e kadar tek tamsayıların toplamını bulan program");
            comboBox1.Items.Add("18-2’den n’e kadar çift sayıların toplamını bulan program");
            comboBox1.Items.Add("19-A ve B sayıları arasındaki (sınırlar dahil) asal sayıları ekrana yazdıran program");
            comboBox1.Items.Add("20-Fibonacci sayını bulan program");
            comboBox1.Items.Add("21-Üçgenin alanını hesaplayan program");
            comboBox1.Items.Add("22-İki kenarı ve derecesi bilinen üçgenin alanını hesaplayan program");
            comboBox1.Items.Add("23-Tüm kenar uzunlukları girilen üçgenin alanını hesaplayan program");
            comboBox1.Items.Add("24-Dik kenar uzunlukları girilen bir üçgende, hipotenüsü bulan program");
            comboBox1.Items.Add("25-Gerilimi hesaplayan program");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Bir Seçenek Seçiniz...","Hata!!");
            }

            if (comboBox1.Text == "1-Girilen 3 sayıdan en büyüğünü bulma")
            {
                frm2.ShowDialog();

            }
            if (comboBox1.Text == "2-Girilen sayının negatif,pozitif,sıfır olduğunu bulma")
            {
                frm3.ShowDialog();
            }
            if (comboBox1.Text == "3-Öğrenci no,vize, final notunu aldıktan sonra ort hesaplayıp no ve not ortalamasını yazdırma")
            {
                frm4.ShowDialog();
            }
            if (comboBox1.Text == "4-1 ile 1000 arasındaki tek sayıları ekrana yazdıran program")
            {
                frm5.ShowDialog();
            }
            if (comboBox1.Text == "5-Girilen üç sayıyı küçükten büyüğe doğru sıralayan program")
            {
                frm6.ShowDialog();
            }
            if (comboBox1.Text == "6-1 - 99 arasındaki tek ve çift sayıların toplamları ile çarpımlarını hesaplayan program")
            {
                frm7.ShowDialog();
            }
            if (comboBox1.Text == "7-Klavyeden girilen pozitif bir sayının tek mi çift mi olduğunu bulan program")
            {
                frm8.ShowDialog();
            }
            if (comboBox1.Text == "8-N sayısına göre 1'den N'e kadar olan tek sayıların toplamını ve çarpımını bulan program")
            {
                frm9.ShowDialog();
            }
            if (comboBox1.Text == "9-Klavyeden girilen ismi istenen sayı kadar alt alta yazdıran program")
            {
                frm10.ShowDialog();
            }
            if (comboBox1.Text == "10-Klavyeden metre cinsinden girilen uzunluğu (km) ve (cm) dönüştürüp yazdıran program")
            {
                frm11.ShowDialog();
            }
            if (comboBox1.Text == "11-Üç kenar uzunluğu girilen üçgenin (eşkenar, ikizkenar veya çeşitkenar) yazdıran program")
            {
                frm12.ShowDialog();
            }
            if (comboBox1.Text == "12-Klavyeden girilen sayının yine klavyeden istenen yüzdesini hesaplayıp yazdıran program")
            {
                frm13.ShowDialog();
            }
            if (comboBox1.Text == "13-Birir ürünün fiyatı ve KDV oranı istenip, ürünün KDV'li satış fiyatını hesaplayan program")
            {
                frm14.ShowDialog();
            }
            if (comboBox1.Text == "14-Haftanın gününü bulan Program")
            {
                frm15.ShowDialog();
            }
            if (comboBox1.Text == "15-Girilen 10 sayının ortalamasını hesaplayan program")
            {
                frm16.ShowDialog();
            }
            if (comboBox1.Text == "16-1’den n’e kadar tamsayıların toplamını bulan program")
            {
                frm17.ShowDialog();
            }
            if (comboBox1.Text == "17-1’den n’e kadar tek tamsayıların toplamını bulan program")
            {
                frm18.ShowDialog();
            }
            if (comboBox1.Text == "18-2’den n’e kadar çift sayıların toplamını bulan program")
            {
                frm19.ShowDialog();
            }
            if (comboBox1.Text == "19-A ve B sayıları arasındaki (sınırlar dahil) asal sayıları ekrana yazdıran program")
            {
                frm20.ShowDialog();
            }
            if (comboBox1.Text == "20-Fibonacci sayını bulan program")
            {
                frm21.ShowDialog();
            }
            if (comboBox1.Text == "21-Üçgenin alanını hesaplayan program")
            {
                frm22.ShowDialog();
            }
            if (comboBox1.Text == "22-İki kenarı ve derecesi bilinen üçgenin alanını hesaplayan program")
            {
                frm23.ShowDialog();
            }
            if (comboBox1.Text == "23-Tüm kenar uzunlukları girilen üçgenin alanını hesaplayan program")
            {
                frm24.ShowDialog();
            }
            if (comboBox1.Text == "24-Dik kenar uzunlukları girilen bir üçgende, hipotenüsü bulan program")
            {
                frm25.ShowDialog();
            }
            if (comboBox1.Text == "25-Gerilimi hesaplayan program")
            {
                frm26.ShowDialog();
            }
           


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
