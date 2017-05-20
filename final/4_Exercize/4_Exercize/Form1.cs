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
        Bitmap bmp;
        bool mouse_clicked = false;
        int x;
        int y;

        public Form1()
        {
            InitializeComponent();
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            
        }
        


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(new Pen(Color.Red), x, y, 15, 15);
            


        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
           mouse_clicked = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        { if (mouse_clicked== true)
            {
                



            }

        }
    }
}
