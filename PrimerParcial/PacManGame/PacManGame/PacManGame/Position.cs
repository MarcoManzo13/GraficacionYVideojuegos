using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManGame
{
    public class Position
    {
        // X position
        public int X { get; set; }
        public int XE1 { get; set; }
        public int XE2 { get; set; }
        public int XE3 { get; set; }
        public int XE4 { get; set; }


        // Y position
        public int Y { get; set; }
        public int YE1 { get; set; }
        public int YE2 { get; set; }
        public int YE3 { get; set; }
        public int YE4 { get; set; }

        //Distance that the PacMan moved
        public int Path { get; set; }

        public int Pathe { get; set; }
        
    }
}
