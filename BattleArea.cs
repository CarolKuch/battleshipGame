using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{


    class BattleArea
    {
        Point[] points;        

        public void CreateNewBattleArea()
        {
            Point[] myPoints = new Point[100];
            for (int i = 0; i < 100; i++)
            {
                myPoints[i] = new Point();
            }
            points = myPoints;
            foreach( Point point in points) {

                Console.WriteLine("HABA"+point.coordinateY);
            }
            
        }

        public void ShowOceanMap()
        {
            Console.WriteLine("Ocean map shown");
        }

        public void DrawRandomSpot()
        {
            Console.WriteLine("Drawn!");
        }
    }
}
