using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManGame
{
    public class Collision
    {

        public bool CollisionLevel1(int x, int y)
        {
            if (Map.map0[y,x] == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CollisionLevel2(int x, int y)
        {
            if (Map.map2[y, x] == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CollisionLevel3(int x, int y)
        {
            if (Map.map3[y, x] == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
