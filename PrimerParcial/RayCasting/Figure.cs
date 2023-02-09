using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayCasting
{
    public class Figure
    {
        public List<Line> Lines;
        public Figure()
        {
            Lines = new List<Line>();
        }

        public Figure(List<Line> lines)
        {
            Lines = lines;
        }
    }
}
