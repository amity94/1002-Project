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
                
        }

        public static bool DeleteLastButton()
        {
            
        }

        public static void ClearAllButtons()
        {
            buttonCounter = 0;
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

        }

        public static int GetTheMaxHeightOfAButton()
        {

        }

        public static bool IsPointInsideAButton(int x, int y)
        {

        }

        public static bool CheckIfAnyButtonIsOverlapping()
        {

        }


    }
}
