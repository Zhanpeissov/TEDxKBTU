using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2Exercize
{
    public partial class Form1 : Form
    {
        int a = 0;
        public Form1()
        {
            InitializeComponent();
            string s = "0";
        }


        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text =Int32Converter(a + 1);
            if (int.Parse(button9.Text)%2==0)
            {
                textBox1.Text = (a + 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = Int32Converter(a + 1);
            if (int.Parse(button1.Text) % 2 == 0)
            {
                textBox1.Text = (a + 1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = Int32Converter(a + 1);
            if (int.Parse(button2.Text) % 2 == 0)
            {
                textBox1.Text = (a + 1);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = Int32Converter(a + 1);
            if (int.Parse(button3.Text) % 2 == 0)
            {
                textBox1.Text = (a + 1);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = Int32Converter(a + 1);
            if (int.Parse(button4.Text) % 2 == 0)
            {
                textBox1.Text = (a + 1);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = Int32Converter(a + 1);
            if (int.Parse(button5.Text) % 2 == 0)
            {
                textBox1.Text = (a + 1);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = Int32Converter(a + 1);
            if (int.Parse(button6.Text) % 2 == 0)
            {
                textBox1.Text = (a + 1);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = Int32Converter(a + 1);
            if (int.Parse(button7.Text) % 2 == 0)
            {
                textBox1.Text = (a + 1);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = Int32Converter(a + 1);
            if (int.Parse(button8.Text) % 2 == 0)
            {
                textBox1.Text = (a + 1);
            }
        }
    }
}
