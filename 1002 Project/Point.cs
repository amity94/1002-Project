using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1002_Project
{
    internal class Point
    {
        private int x;
        private int y;

        internal Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        internal int GetX()
        {
            return this.x;
        }

        internal int GetY()
        {
            return this.y;
        }

        internal void SetX(int x)
        {
            if (x < 0 || x > MyCanvas.MAX_WIDTH)
            {
                Console.WriteLine("out of bounds");
                return;
            }
            this.x = x;

        }

        internal void SetY(int y)
        {
            if (y < 0 ||  y > MyCanvas.MAX_HEIGHT)
            {
                Console.WriteLine("out of bounds");
                return;
            }
            this.y = y;
        }


    }
}
