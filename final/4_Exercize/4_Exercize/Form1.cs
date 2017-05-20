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
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();

        }
        


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(new Pen(Color.Red), 100, 250, 15, 15);
            e.Graphics.DrawEllipse(new Pen(Color.Red), 250, 100, 15, 15);
            e.Graphics.DrawEllipse(new Pen(Color.Red), 210, 170, 15, 15);
            e.Graphics.DrawEllipse(new Pen(Color.Red), 90, 500, 15, 15);


        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
           mouse_clicked = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
