using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clase_20_febrero
{
    public partial class Form1 : Form
    {
        Canvas canvas;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            canvas = new Canvas(PCT_CANVAS.Size);
            PCT_CANVAS.Image = canvas.bitmap;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            canvas.DrawLine(new Point(10, 50), new Point(100, 610), Color.Yellow);
            PCT_CANVAS.Invalidate();
        }

        private void PCT_CANVAS_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = e.Location.ToString() + canvas.bitmap.Size;
        }

        
    }
}
