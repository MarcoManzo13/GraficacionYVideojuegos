using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad5
{
    public partial class Form1 : Form
    {
        Canvas canvas;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //canvas.DrawLine(new Point(10,50), new Point(100, 610), Color.Yellow);
            pictureBox2.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            canvas = new Canvas(pictureBox2.Size);
            pictureBox2.Image = canvas.bitmap;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            label1.Text = e.Location.ToString() + canvas.bitmap.Size;
        }
    }
}
