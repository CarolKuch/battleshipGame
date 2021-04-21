using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Point
    {
        public int coordinateX;
        public int coordinateY;
        private bool isAvailable;
        private bool isFilled;
        private bool wasShot;

        public Point()
        {
            isAvailable = true;
            isFilled = false;
            wasShot = false;
        }

        public void setIsShot(int x, int y)
        {
            wasShot = true;
        }

        public void setIsFilled(int x, int y)
        {
            isAvailable = true;
        }

        public void setIsAvailable(int x, int y)
        {
            isAvailable = false;
        }

    }
}
