using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus(); //imcleci buradan başlat
        }

        void renklendir()
        {
            textBox1.BackColor = Color.Red;
            textBox2.BackColor = Color.Green;
            textBox3.BackColor = Color.Blue;
            textBox4.BackColor = Color.Yellow;
        }

        void yazdir()
        {
            textBox1.Text = "Mustafa Emre";
            textBox2.Text = "İlhan";
            textBox3.Text = "İstanbul";
            textBox4.Text = "23";
        }

        int Toplam(int s1,int s2)
        {
            int s3 = s1 + s2;
            return s3;

        }

        



        private void button1_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            renklendir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            yazdir();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = Toplam(1,2).ToString();
            label2.Text = Toplam(7,3).ToString();
            label3.Text = Toplam(9,8).ToString();
        }

      
    }
}
