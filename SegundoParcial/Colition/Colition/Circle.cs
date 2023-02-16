using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colition
{
    public class Circle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Radius { get; set; }
        public Brush FillColor { get; set; }
        public int VelocityX { get; set; }
        public int VelocityY { get; set; }

        public Circle(int x, int y, int radius, Brush fillColor, int velocityX = 0, int velocityY = 0)
        {
            X = x;
            Y = y;
            Radius = radius;
            FillColor = fillColor;
            VelocityX = velocityX;
            VelocityY = velocityY;
        }

        public void Draw(Graphics g)
        {
            g.FillEllipse(FillColor, X - Radius, Y - Radius, Radius * 2, Radius * 2);
        }

        public void Update(int maxX, int maxY)
        {
            X += VelocityX;
            Y += VelocityY;

            // Bounce off the walls
            if (X - Radius < 0 || X + Radius > maxX)
            {
                VelocityX = -VelocityX;
            }
            if (Y - Radius < 0 || Y + Radius > maxY)
            {
                VelocityY = -VelocityY;
            }


        }


    }
}
