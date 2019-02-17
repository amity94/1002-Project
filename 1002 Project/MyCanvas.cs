using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1002_Project
{
    public class MyCanvas
    {
        public const int MAX_WIDTH = 800;
        public const int MAX_HEIGHT = 600;

        private static int buttonCounter = 0;
        private static MyButton[] buttons = new MyButton[MaxButtons];
        private static int MaxButtons = 3;

        public static bool CreateNewButton(int x1, int y1, int x2, int y2)
        {
            if(buttonCounter == MaxButtons)
            {
                return false;
            }

            if(x1 < MAX_WIDTH && y1 < MAX_HEIGHT && x2 < MAX_WIDTH && y2 < MAX_HEIGHT)
            {
                Point pnt1 = new Point(x1, y1);
                Point pnt2 = new Point(x2, y2);
                MyButton btn = new MyButton(pnt1, pnt2);

                buttons[buttonCounter] = btn;
                buttonCounter++;
            }
            return false;
        }

        public static bool MoveButton(int buttonNumber, int x, int y)
        {
            if(buttonNumber > buttonCounter)
            {
                return false;
            }

            int xTopLeft = buttons[buttonNumber].GetTopLeft().GetX();
            int yTopLeft = buttons[buttonNumber].GetTopLeft().GetY();
            int xBottomRight = buttons[buttonNumber].GetBottomRight().GetX();
            int yBottomRight = buttons[buttonNumber].GetBottomRight().GetY();

            if (xBottomRight + x > MyCanvas.MAX_WIDTH)
                return false;

            if (yBottomRight + y > MyCanvas.MAX_HEIGHT)
                return false;

            buttons[buttonNumber].SetTopLeft(new Point(xTopLeft + x, yTopLeft + y));
            buttons[buttonNumber].SetBottomRight(new Point(xBottomRight + x, yBottomRight + y));

            return true;
        }

        public static bool DeleteLastButton()
        {
            if (buttons.Length > 1)
            {
                buttons[MaxButtons] = buttons[MaxButtons-1];
                return true;
            }

            return false;
            
        }

        public static void ClearAllButtons()
        {
            if (buttons.Length > 1)
            {
                buttons[MaxButtons] = buttons[MaxButtons - MaxButtons];
            }
        }

        public static int GetCurrentNumberOfButtons()
        {
            return buttonCounter++;
        }

        public static int GetMaxNuberOfButtons()
        {
            return MaxButtons;
        }

        public static int GetTheMaxWidthOfAButton()
        {
            int i;
            for (i = 0; i < buttons.Length; i++)
            {
                if(buttons[i].GetTopLeft().GetX() > buttons[i++].GetTopLeft().GetX() && buttons[i].GetBottomRight().GetX() > buttons[i++].GetBottomRight().GetX())
                {
                    return i;
                }
                if(buttons[i].GetTopLeft().GetX() < buttons[i++].GetTopLeft().GetX() && buttons[i].GetBottomRight().GetX() < buttons[i++].GetBottomRight().GetX())
                {
                  i++;
                }
            }
            return i;
        }

        public static int GetTheMaxHeightOfAButton()
        {
            int i;
            for (i = 0; i < buttons.Length; i++)
            {
                if (buttons[i].GetTopLeft().GetY() > buttons[i++].GetTopLeft().GetY() && buttons[i].GetBottomRight().GetY() > buttons[i++].GetBottomRight().GetY())
                {
                    return i;
                }
                if (buttons[i].GetTopLeft().GetY() < buttons[i++].GetTopLeft().GetY() && buttons[i].GetBottomRight().GetY() < buttons[i++].GetBottomRight().GetY())
                {
                    i++;
                }
            }
            return i;
        }

        public static bool IsPointInsideAButton(int x, int y)
        {

        }

        public static bool CheckIfAnyButtonIsOverlapping()
        {

        }

        public static void Print()
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                Console.WriteLine(buttons[i].GetBottomRight().GetX());
                Console.WriteLine(buttons[i].GetBottomRight().GetY());
                Console.WriteLine(buttons[i].GetTopLeft().GetX());
                Console.WriteLine(buttons[i].GetTopLeft().GetY());

            }
        }

    }
}
