using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colition
{
    public partial class Form1 : Form
    {
        private Bitmap bmp;
        private Graphics g;
        private Circle circle1;
        private Circle circle2;
        private Circle circle3;
        private Circle circle4;
        private Circle circle5;
        private Timer timer;

        public Form1()
        {

            InitializeComponent();

            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);

            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += timer1_Tick;
            timer.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.White, e.ClipRectangle);

            if (circle1 != null)
            {
                circle1.Draw(g);
            }

            if (circle2 != null)
            {
                circle1.Draw(g);
            }

            if (circle3 != null)
            {
                circle3.Draw(g);
            }
            if (circle4 != null)
            {
                circle3.Draw(g);
            }
            if (circle5 != null)
            {
                circle3.Draw(g);
            }

            e.Graphics.DrawImage(bmp, Point.Empty);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (circle1 == null)
            {
                Random rand = new Random();
                int radius = rand.Next(20, 50);
                Brush fillColor = Brushes.Blue;

                int x = 134;
                int y = 343;
                int vx = rand.Next(-15, 15);
                int vy = rand.Next(-15, 15);
                circle1 = new Circle(x, y, radius, fillColor, vx, vy);
            }

            if (circle2 == null)
            {
                Random rand = new Random();
                int radius = rand.Next(20, 50);
                Brush fillColor = Brushes.Red;

                int x = 423;
                int y = 343;
                int vx = rand.Next(-15, 15);
                int vy = rand.Next(-15, 15);
                circle2 = new Circle(x, y, radius, fillColor, vx, vy);
            }

            if (circle3 == null)
            {
                Random rand = new Random();
                int radius = rand.Next(20, 50);
                Brush fillColor = Brushes.Yellow;

                int x = 223;
                int y = 214;
                int vx = rand.Next(-10, 10);
                int vy = rand.Next(-10, 10);
                circle3 = new Circle(x, y, radius, fillColor, vx, vy);
            }

            if (circle4 == null)
            {
                Random rand = new Random();
                int radius = rand.Next(20, 50);
                Brush fillColor = Brushes.Black;

                int x = 123;
                int y = 196;
                int vx = rand.Next(-10, 10);
                int vy = rand.Next(-10, 10);
                circle4 = new Circle(x, y, radius, fillColor, vx, vy);
            }
            if (circle5 == null)
            {
                Random rand = new Random();
                int radius = rand.Next(20, 50);
                Brush fillColor = Brushes.Brown;

                int x = 189;
                int y = 390;
                int vx = rand.Next(-10, 10);
                int vy = rand.Next(-10, 10);
                circle5 = new Circle(x, y, radius, fillColor, vx, vy);
            }


            circle1.Update(pictureBox1.Width, pictureBox1.Height);
            circle2.Update(pictureBox1.Width, pictureBox1.Height);
            circle3.Update(pictureBox1.Width, pictureBox1.Height);
            circle4.Update(pictureBox1.Width, pictureBox1.Height);
            circle5.Update(pictureBox1.Width, pictureBox1.Height);

            // Revisar Colisión
            double distancia1 = Math.Sqrt((circle1.X - circle2.X) * (circle1.X - circle2.X) + (circle1.Y - circle2.Y) * (circle1.Y - circle2.Y));
            if (distancia1 <= circle1.Radius + circle2.Radius)
            {
                // Hacer parecer que rebotan las pelotas cambiando la velocidad
                int tempVx = circle1.VelocityX;
                int tempVy = circle1.VelocityY;
                circle1.VelocityX = circle2.VelocityX;
                circle1.VelocityY = circle2.VelocityY;
                circle2.VelocityX = tempVx;
                circle2.VelocityY = tempVy;
            }

            // Revisar Círculos 1 y 3
            double distancia2 = Math.Sqrt((circle3.X - circle1.X) * (circle3.X - circle1.X) + (circle3.Y - circle1.Y) * (circle3.Y - circle1.Y));
            if (distancia2 <= circle3.Radius + circle1.Radius)
            {
                // Hacer parecer que rebotan las pelotas cambiando la velocidad
                int tempVx = circle3.VelocityX;
                int tempVy = circle3.VelocityY;
                circle3.VelocityX = circle1.VelocityX;
                circle3.VelocityY = circle1.VelocityY;
                circle1.VelocityX = tempVx;
                circle1.VelocityY = tempVy;
            }

            // Revisar Círculos 1 y 4
            double distancia3 = Math.Sqrt((circle4.X - circle1.X) * (circle4.X - circle1.X) + (circle4.Y - circle1.Y) * (circle4.Y - circle1.Y));
            if (distancia3 <= circle4.Radius + circle1.Radius)
            {
                // Hacer parecer que rebotan las pelotas cambiando la velocidad
                int tempVx = circle4.VelocityX;
                int tempVy = circle4.VelocityY;
                circle4.VelocityX = circle1.VelocityX;
                circle4.VelocityY = circle1.VelocityY;
                circle1.VelocityX = tempVx;
                circle1.VelocityY = tempVy;
            }

            // Revisar Círculos 1 y 5
            double distancia4 = Math.Sqrt((circle5.X - circle1.X) * (circle5.X - circle1.X) + (circle5.Y - circle1.Y) * (circle5.Y - circle1.Y));
            if (distancia4 <= circle5.Radius + circle1.Radius)
            {
                // Hacer parecer que rebotan las pelotas cambiando la velocidad
                int tempVx = circle5.VelocityX;
                int tempVy = circle5.VelocityY;
                circle5.VelocityX = circle1.VelocityX;
                circle5.VelocityY = circle1.VelocityY;
                circle1.VelocityX = tempVx;
                circle1.VelocityY = tempVy;
            }

            // Revisar Círculos 2 y 3
            double distancia5 = Math.Sqrt((circle3.X - circle2.X) * (circle3.X - circle2.X) + (circle3.Y - circle2.Y) * (circle3.Y - circle2.Y));
            if (distancia5 <= circle3.Radius + circle2.Radius)
            {
                // Hacer parecer que rebotan las pelotas cambiando la velocidad
                int tempVx = circle3.VelocityX;
                int tempVy = circle3.VelocityY;
                circle3.VelocityX = circle2.VelocityX;
                circle3.VelocityY = circle2.VelocityY;
                circle2.VelocityX = tempVx;
                circle2.VelocityY = tempVy;
            }

            // Revisar Círculos 2 y 4
            double distancia6 = Math.Sqrt((circle4.X - circle2.X) * (circle4.X - circle2.X) + (circle4.Y - circle2.Y) * (circle4.Y - circle2.Y));
            if (distancia6 <= circle4.Radius + circle2.Radius)
            {
                // Hacer parecer que rebotan las pelotas cambiando la velocidad
                int tempVx = circle4.VelocityX;
                int tempVy = circle4.VelocityY;
                circle4.VelocityX = circle2.VelocityX;
                circle4.VelocityY = circle2.VelocityY;
                circle2.VelocityX = tempVx;
                circle2.VelocityY = tempVy;
            }

            // Revisar Círculos 2 y 5
            double distancia7 = Math.Sqrt((circle5.X - circle2.X) * (circle5.X - circle2.X) + (circle5.Y - circle2.Y) * (circle5.Y - circle2.Y));
            if (distancia7 <= circle5.Radius + circle2.Radius)
            {
                // Hacer parecer que rebotan las pelotas cambiando la velocidad
                int tempVx = circle5.VelocityX;
                int tempVy = circle5.VelocityY;
                circle5.VelocityX = circle2.VelocityX;
                circle5.VelocityY = circle2.VelocityY;
                circle2.VelocityX = tempVx;
                circle2.VelocityY = tempVy;
            }

            // Revisar Círculos 3 y 4
            double distancia8 = Math.Sqrt((circle4.X - circle3.X) * (circle4.X - circle3.X) + (circle4.Y - circle3.Y) * (circle4.Y - circle3.Y));
            if (distancia8 <= circle4.Radius + circle3.Radius)
            {
                // Hacer parecer que rebotan las pelotas cambiando la velocidad
                int tempVx = circle4.VelocityX;
                int tempVy = circle4.VelocityY;
                circle4.VelocityX = circle3.VelocityX;
                circle4.VelocityY = circle3.VelocityY;
                circle3.VelocityX = tempVx;
                circle3.VelocityY = tempVy;
            }

            // Revisar Círculos 3 y 5
            double distancia9 = Math.Sqrt((circle5.X - circle3.X) * (circle5.X - circle3.X) + (circle5.Y - circle3.Y) * (circle5.Y - circle3.Y));
            if (distancia9 <= circle5.Radius + circle3.Radius)
            {
                // Hacer parecer que rebotan las pelotas cambiando la velocidad
                int tempVx = circle5.VelocityX;
                int tempVy = circle5.VelocityY;
                circle5.VelocityX = circle3.VelocityX;
                circle5.VelocityY = circle3.VelocityY;
                circle3.VelocityX = tempVx;
                circle3.VelocityY = tempVy;
            }

            // Redibujar el fondo para borrar la versión del círculo anterior
            using (SolidBrush brush = new SolidBrush(Color.White))
            {
                g.FillRectangle(brush, pictureBox1.ClientRectangle);
            }

            // Draw the current circles
            circle1.Draw(g);
            circle2.Draw(g);
            circle3.Draw(g);
            circle4.Draw(g);
            circle5.Draw(g);

            // Update the picture box with the new image
            pictureBox1.Image = bmp;
        }
    }

   
}
