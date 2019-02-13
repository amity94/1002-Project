using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1002_Project
{
    internal class MyButton
    {
        protected Point topLeft;
        protected Point bottomRight;

        private int width;
        private int height;

        internal MyButton(Point topLeft, Point bottomRight)
        {
            this.topLeft = topLeft;
            this.bottomRight = bottomRight;
        }

        internal int GetWidth()
        {
            return this.width;
        }

        internal int GetHeight()
        {
            return this.height;
        }

        internal bool SetTopLeft(Point pnt)
        {
            if (pnt.GetX() < bottomRight.GetX() && pnt.GetY() > bottomRight.GetY())
            {
                this.topLeft = pnt;
                this.width = bottomRight.GetX() - topLeft.GetX();
                this.height = topLeft.GetY() - bottomRight.GetY();
                return true;
            }
            return false;
        }

        internal bool SetBottomRight(Point pnt)
        {
            if (pnt.GetX() > bottomRight.GetX() && pnt.GetY() < bottomRight.GetY())
            {
                this.topLeft = pnt;
                this.width = bottomRight.GetX() - topLeft.GetX();
                this.height = topLeft.GetY() - bottomRight.GetY();
                return true;
            }
            return false;
        }

        internal Point GetTopLeft()
        {
            return topLeft;
        }

        internal Point GetBottomRight()
        {
            return bottomRight;
        }

    }
}
