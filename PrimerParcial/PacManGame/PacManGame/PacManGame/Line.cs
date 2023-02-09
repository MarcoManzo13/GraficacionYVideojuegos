using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManGame
{
    public class Line
    {
        public PointF a, b;

        public Line (PointF a, PointF b)
        {
            this.a = a;
            this.b = b;
        }
    }
}
