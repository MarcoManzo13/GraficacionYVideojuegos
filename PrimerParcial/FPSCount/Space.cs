using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad2
{
    internal class Space
    {
        private float spread, speed;
        Random rand;
        float[] x, y, z;
        public Space(int stars, float spread, float speed)
        {
            this.speed = speed;
            this.spread = spread;
            x = new float[stars];
            y = new float[stars];
            z = new float[stars];
            rand = new Random();
            for (int i = 0; i < stars; i++)
            {
                Init(i);
            }
        }
        public void Init(int index)
        {
            x[index] = 2 * ((float)rand.NextDouble() - 0.5f) * spread;
            y[index] = 2 * ((float)rand.NextDouble() - 0.5f) * spread;
            z[index] = ((float)rand.NextDouble() + 0.00001f) * spread;
        }

        public void Render(Canvas target, float delta)
        {
            target.Clear();
            float hWidth = target.Width / 2f;
            float hHeight = target.Width / 2f;
            for (int i = 0; i < x.Length; i++)
            {
                z[i] -= delta * speed;
                if (z[i] <= 0)
                    Init(i);
                int xPos = (int)(x[i]/z[i] * hWidth + hWidth);
                int yPos = (int)(y[i]/z[i] * hHeight + hHeight);
                if (xPos < 0 || xPos >= target.Width || yPos < 0 || yPos >= target.Height)
                {
                    Init(i);
                }
                else
                    target.PutPixel(xPos, yPos, Color.White);
            }
        }

    }
}
