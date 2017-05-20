using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace _4_Exercize
{
    public partial class Form1 : Form
    {
        Graphics g; 
        bool mouse_clicked = false;
        int x=0;
        int y=0;

        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            
            
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(new Pen(Color.Red), 250+x, 250+y, 15, 15);
            e.Graphics.DrawEllipse(new Pen(Color.Red), 30+x, 20+y, 15, 15);
            e.Graphics.DrawEllipse(new Pen(Color.Red), 150+x, 180+y, 15, 15);
            e.Graphics.DrawEllipse(new Pen(Color.Red), 190+x, 90+y, 15, 15);



        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
           mouse_clicked = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            {
                y++;
                if (y == 500)
                {
                    y = 0;

                }
                Refresh();

            }
                


    }

        }
    }

