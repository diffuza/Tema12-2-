using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema12_2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Graphics g;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();
            g.Clear(Color.Silver);

            g.DrawLine(Pens.Black, 20, 30, 200, 30);



            Brush blueBrush = new SolidBrush(Color.Blue);


            Color cl = Color.FromArgb(255, 255, 255); g.Clear(cl);

            Pen Pen1 = new Pen(Color.Black, 1); int dx = 0;
            g.DrawRectangle(Pen1, 10 + dx, 10, 100, 50); dx += 120;
            g.DrawEllipse(Pen1, 10 + dx, 10, 100, 50);
            dx += 120;
            g.DrawArc(Pen1, 10 + dx, 10, 100, 50, 0, 315);
            dx += 120;
            g.DrawPie(Pen1, 10 + dx, 10, 100, 50, 0, 315);
        }

    }
}
