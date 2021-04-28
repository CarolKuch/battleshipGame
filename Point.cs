using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Point
    {
        public int coordinateX;
        public int coordinateY;
        public bool isAvailable;
        public bool isFilled;
        public bool wasShot;
       
        public Point(int X, int Y)
        {
            coordinateX = X;
            coordinateY = Y;
            isAvailable = true;
            isFilled = false;
            wasShot = false;
        }

        public void setIsShot(int x, int y)
        {
            wasShot = true;
        }

        public void setIsFilled(bool isItFilled)
        {
           isFilled = isItFilled;
        }

        public void setIsAvailable(bool isItAvailable)
        {
            isAvailable = isItAvailable;
        }

    }
}
