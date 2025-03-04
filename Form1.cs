using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul3_103022330067
{
    public partial class Form1 : Form
    {
        int a;
        int total = 0;
        string nilai;
        char b;
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            a = 5;
            nilai += a;
            textBox1.Text = textBox1.Text + a.ToString();
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            a = 8;
            nilai += a;
            textBox1.Text = textBox1.Text + a.ToString();    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a =1;
            nilai += a;
            textBox1.Text = textBox1.Text + a.ToString();    
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = 0;
            nilai += a;
            textBox1.Text = textBox1.Text + a.ToString();    
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a = 2;
            nilai += a;
            textBox1.Text = textBox1.Text + a.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = 3;
            nilai += a;
            textBox1.Text = textBox1.Text + a.ToString();    
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            a = 4;
            nilai += a;
            textBox1.Text = textBox1.Text + a.ToString();    
        }

        private void button7_Click(object sender, EventArgs e)
        {
            a = 6;
            nilai += a;
            textBox1.Text = textBox1.Text + a.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            a = 7;
            nilai += a;
            textBox1.Text = a.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            a = 9;
            nilai += a;
            textBox1.Text = textBox1.Text + a.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            total += int.Parse(nilai);
            nilai = "";
            textBox1.Text = total.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            b = '+';
            total += int.Parse(nilai);
            nilai = "";
            textBox1.Text =  b.ToString();
        }

       
    }
}
