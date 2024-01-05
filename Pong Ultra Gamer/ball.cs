using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong_Ultra_Gamer
{
    internal class Ball
    {
        public int x = 0;
        public int y = 0;
        public int xVel = 0;
        public int yVel = 0;
     

        public Ball(int x, int y, int xVel, int yVel) 
        {
            this.x = x;
            this.y = y;
            this.xVel = xVel;
            this.yVel = yVel;
        }

        public void HitHorizontalWall()
        {
            xVel *= -1;
        }
        public void HitVerticalWall()
        {
            yVel *= -1;
        }
    }
}
