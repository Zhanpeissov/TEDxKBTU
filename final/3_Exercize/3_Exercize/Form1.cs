using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_Exercize
{
    public partial class Form1 : Form
    {


        bool button1_MouseClik = false;
        bool button2_MouseClik = false;
        bool button3_MouseClik = false;
        public Form1()
        {
            InitializeComponent();
            int i = 0;
            Button[] s = { button1, button2, button3 };
        }

        
        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            while (true) {
               
                if ((button3_MouseClik = true) ||
                    (button1_MouseClik = true) ||
                    (button2_MouseClik = true))
                {   
                    
                    for (int j = 0;  j<2; j++)
                    {
                        if (j == 0)
                        {
                            button1.Visible = true;
                            button2.Visible = false;
                            button3.Visible = false;
                        }

                        if (j == 1)
                        {
                            button1.Visible = false;
                            button2.Visible = true;
                            button3.Visible = false;
                        }
                        if (j == 2)
                        {
                            button1.Visible = false;
                            button2.Visible = false;
                            button3.Visible = true;
                        }
                    }

                }
            }
        }

        private void button_Click(object sender, EventArgs e)
        {

        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {

        }

        
    }
}
