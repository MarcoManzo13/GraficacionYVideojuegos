using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManGame
{
    public class Map
    {
        public static byte[,] map0 = new byte[,]
        {
          {1,1,1,1,1,1,1,1,1,1,1,1,3,1,1,1,1,1,1,1,1,1,1,1,1},
          {1,0,0,0,0,0,0,0,0,0,0,1,1,1,0,0,0,0,0,0,0,0,0,0,1},
          {1,0,1,1,1,1,0,1,1,1,0,1,0,1,0,1,1,1,0,1,1,1,1,0,1},
          {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
          {1,0,1,1,1,1,0,1,0,1,1,1,1,1,1,1,0,1,0,1,1,1,1,0,1},
          {1,0,0,0,0,0,0,1,0,0,0,0,1,0,0,0,0,1,0,0,0,0,0,0,1},
          {1,1,1,1,1,1,0,1,1,1,1,0,1,0,1,1,1,1,0,1,1,1,1,1,1},
          {1,0,0,0,0,1,0,1,0,0,0,2,2,0,0,0,0,1,0,1,0,0,0,0,1},
          {1,0,1,1,0,1,0,1,0,1,1,1,1,1,1,1,0,1,0,1,0,1,1,0,1},
          {1,0,0,0,0,0,0,0,0,1,2,2,2,2,2,1,0,0,0,0,0,0,0,0,1},
          {1,0,1,1,1,1,0,1,0,1,2,2,2,2,2,1,0,1,0,1,1,1,1,0,1},
          {1,0,0,0,0,0,0,1,0,1,2,2,2,2,2,1,0,1,0,0,0,0,0,0,1},
          {1,1,1,0,1,1,0,1,0,1,1,1,1,1,1,1,0,1,0,1,1,0,1,1,1},// Mitad
          {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1}, 
          {1,0,1,0,1,1,1,1,1,0,1,1,0,1,1,0,1,1,1,1,1,0,1,0,1},
          {1,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,1},
          {1,0,1,0,1,1,1,1,1,1,1,0,1,0,1,1,1,1,1,1,1,0,1,0,1},
          {1,0,1,0,0,0,0,0,1,0,0,0,2,0,0,0,1,0,0,0,0,0,1,0,1},
          {1,0,0,0,0,1,1,0,1,0,1,1,1,1,1,0,1,0,1,1,0,0,0,0,1},
          {1,1,0,1,0,1,1,0,1,0,0,0,1,0,0,0,1,0,1,1,0,1,0,1,1},
          {1,1,0,1,0,1,1,0,1,0,1,0,1,0,1,0,1,0,1,1,0,1,0,1,1},
          {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
          {1,0,1,1,0,1,1,1,1,1,0,1,0,1,0,1,1,1,1,1,0,1,1,0,1},
          {1,0,0,0,0,0,0,0,0,0,0,1,0,1,0,0,0,0,0,0,0,0,0,0,1},
          {1,1,1,1,1,1,1,1,1,1,1,1,3,1,1,1,1,1,1,1,1,1,1,1,1}
        };
        public static byte[,] map2 = new byte[,]
        {
          {1,1,1,1,1,1,1,1,1,1,1,1,3,1,1,1,1,1,1,1,1,1,1,1,1},
          {1,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,1},
          {1,0,1,0,1,0,1,1,1,1,1,1,0,1,1,1,1,1,1,0,1,0,1,0,1},
          {1,0,1,0,1,0,0,0,0,0,0,1,0,1,0,0,0,0,0,0,1,0,1,0,1},
          {1,0,1,0,1,0,1,1,1,1,0,1,0,1,0,1,1,1,1,0,1,0,1,0,1},
          {1,0,1,0,1,0,1,1,1,1,0,1,0,1,0,1,1,1,1,0,1,0,1,0,1},
          {1,0,1,0,1,0,0,0,0,0,0,1,0,1,0,0,0,0,0,0,1,0,1,0,1},
          {1,0,1,0,1,0,1,0,1,1,1,1,0,1,1,1,1,0,1,0,1,0,1,0,1},
          {1,1,1,0,1,0,1,0,1,0,0,0,0,0,0,0,1,0,1,0,1,0,1,1,1},
          {1,0,1,0,1,1,1,0,1,0,1,1,1,1,1,0,1,0,1,1,1,0,1,0,1},
          {1,0,1,0,0,0,1,0,1,0,1,2,2,2,1,0,1,0,1,0,0,0,1,0,1},
          {1,0,1,1,1,0,1,0,1,0,2,2,2,2,1,0,1,0,1,0,1,1,1,0,1},
          {1,0,0,0,0,0,0,0,1,0,2,2,2,2,1,0,1,0,0,0,0,0,0,0,1},
          {1,0,1,1,1,0,1,0,1,0,2,2,2,2,1,0,1,0,1,0,1,1,1,0,1},
          {1,0,1,0,0,0,1,0,1,0,1,2,2,2,1,0,1,0,1,0,0,0,1,0,1},
          {1,0,1,0,1,1,1,0,1,0,1,1,1,1,1,0,1,0,1,1,1,0,1,0,1},
          {1,1,1,0,1,0,1,0,1,0,0,0,0,0,0,0,1,0,1,0,1,0,1,1,1},
          {1,0,1,0,1,0,1,0,1,1,1,1,2,1,1,1,1,0,1,0,1,0,1,0,1},
          {1,0,1,0,1,0,0,0,0,0,0,1,0,1,0,0,0,0,0,0,1,0,1,0,1},
          {1,0,1,0,1,0,1,1,1,1,0,1,0,1,0,1,1,1,1,0,1,0,1,0,1},
          {1,0,1,0,1,0,1,1,1,1,0,1,0,1,0,1,1,1,1,0,1,0,1,0,1},
          {1,0,1,0,1,0,0,0,0,0,0,1,0,1,0,0,0,0,0,0,1,0,1,0,1},
          {1,0,1,0,1,0,1,1,1,1,1,1,0,1,1,1,1,1,1,0,1,0,1,0,1},
          {1,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,1},
          {1,1,1,1,1,1,1,1,1,1,1,1,3,1,1,1,1,1,1,1,1,1,1,1,1}
        };
        public static byte[,] map3 = new byte[,]
        {
          {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},//1
          {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
          {1,0,1,1,1,0,1,1,1,0,1,1,0,1,1,0,1,1,1,0,1,1,1,0,1},
          {1,0,1,0,1,0,1,0,1,0,1,0,0,0,1,0,1,0,1,0,1,0,1,0,1},
          {1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1},
          {1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1},
          {1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1},
          {1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1},
          {1,0,1,0,1,0,1,0,1,1,1,0,1,0,1,1,1,0,1,0,1,0,1,0,1},
          {1,0,1,0,1,0,1,0,0,0,0,0,0,0,0,0,0,0,1,0,1,0,1,0,1},//10
          {1,0,1,0,1,1,1,0,1,1,1,2,2,2,1,1,1,0,1,1,1,0,1,0,1},
          {1,0,1,0,0,0,0,0,1,2,2,2,2,2,2,2,1,0,0,0,0,0,1,0,1},
          {3,0,0,0,1,1,1,0,1,2,2,2,2,2,2,2,1,0,0,0,0,0,1,0,1},//13
          {1,0,1,1,1,0,0,0,1,2,1,1,1,1,1,2,1,0,0,0,1,1,1,0,1},
          {1,0,0,0,1,1,1,0,1,1,1,0,0,0,1,1,1,0,1,1,1,0,1,0,1},
          {1,0,1,0,0,0,1,0,0,0,0,0,1,0,0,0,0,0,1,0,0,0,1,0,1},
          {1,0,1,1,1,0,1,0,1,1,1,1,1,1,1,1,1,0,1,1,0,1,1,0,1},
          {1,0,1,0,0,0,1,0,0,0,0,0,2,0,0,0,0,0,1,0,0,0,1,0,1},
          {1,0,1,0,1,1,1,1,0,1,1,1,1,1,1,1,1,1,1,0,1,0,1,0,1},
          {1,0,1,0,0,0,0,0,0,1,0,0,0,0,0,1,0,0,0,0,1,0,1,0,1},//20
          {1,0,1,1,1,0,1,0,1,1,0,1,0,1,0,1,0,1,1,0,1,0,1,0,1},
          {1,0,1,0,0,0,1,0,0,0,0,1,0,1,0,0,0,1,1,0,1,0,1,0,1},
          {1,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,1,1,1,0,1},
          {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
          {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}//25
         //1                    //13           //20      //25
        };
    }
}
