using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad2
{
    public partial class Form1 : Form
    {
        Canvas canvas;

        Bitmap bmp;
        Graphics g;

        static float delta;
        static DateTime lastTime, currentTime;
        static int framesRendered = 0;
        public static int fps;

        Space f;

        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;
            canvas = new Canvas(bmp);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            f = new Space(4200, 150, 60);
            lastTime = DateTime.Now;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            framesRendered++;
            currentTime = DateTime.Now;
            if ((currentTime - lastTime).TotalSeconds >= 1)
            {
                // one second has elapsed
                fps = framesRendered;
                framesRendered = 0;
                delta = (float)(currentTime - lastTime).TotalMilliseconds / 100000;
                lastTime = currentTime;
            }
            f.Render(canvas, delta);
            label1.Text = fps.ToString();
            pictureBox1.Refresh();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
