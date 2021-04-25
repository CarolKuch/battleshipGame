using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{


    class BattleArea
    {
        public Point[] pointsInBattleArea;

        public void CreateNewBattleArea()
        {
            Point[] myPoints = new Point[100];
            int myPointsCounter = 0;
            for (int coordinateX = 0; coordinateX < 10; coordinateX++)
            {
                for (int coordinateY = 0; coordinateY < 10; coordinateY++)
                {
                    myPoints[myPointsCounter] = new Point(coordinateX, coordinateY);
                    myPointsCounter++;
                }

            }
            pointsInBattleArea = myPoints;
        }

        public void ShowOceanMap()
        {
            for( int i = 0; i < pointsInBattleArea.Length; i++)
            {
                //if (!points[i].wasShot) 
                //{
                //    Console.Write(" ~ ");
                //}
                if (pointsInBattleArea[i].isFilled)
                {
                    Console.Write(" X ");
                }
                else if (!pointsInBattleArea[i].isAvailable)
                {
                    Console.Write(" B ");
                }
                else if (!pointsInBattleArea[i].isFilled)
                {
                    Console.Write("   ");
                }

                if ((i+1)%10 == 0 && i != 0)
                {
                    Console.WriteLine();
                }
            }

        }

        public Point [] DrawRandomSpot(Battleship battleship) //losuj gdzie umieścić statek
        {
            Point[] randomPoints = DrawRandomPoints(battleship.length);

           
            for (int i = 0; i < randomPoints.Length; i++)
            {
                BlockLeftPoint(randomPoints[i]);
                BlockRightPoint(randomPoints[i]);
                BlockTopPoint(randomPoints[i]);
                BlockBottomPoint(randomPoints[i]);

                BlockTopLeftPoint(randomPoints[i]);
                BlockBottomLeftPoint(randomPoints[i]);
                BlockTopRightPoint(randomPoints[i]);
                BlockBottomRightPoint(randomPoints[i]);
            }

            return randomPoints;
        }

        
       private void BlockLeftPoint(Point point)
        {
            if(point.coordinateY > 1)
            {
                pointsInBattleArea[point.coordinateY + point.coordinateX * 10 - 12].setIsAvailable(false); 
            }
        }
        private void BlockRightPoint(Point point)
        {
            if (point.coordinateY < 10)
            {
                pointsInBattleArea[point.coordinateY + point.coordinateX * 10 - 10].setIsAvailable(false); 
            }
        }
        private void BlockTopPoint(Point point)
        {
            if (point.coordinateX > 1)
            {
                pointsInBattleArea[point.coordinateY + point.coordinateX * 10 - 21].setIsAvailable(false); 
            }
        }
        private void BlockBottomPoint(Point point)
        {
            if (point.coordinateX < 10)
            {
                pointsInBattleArea[point.coordinateY + point.coordinateX * 10 - 1].setIsAvailable(false);
            }
        }
        private void BlockTopLeftPoint(Point point)
        {
            if (point.coordinateY > 1 && point.coordinateX > 1)
            {
                pointsInBattleArea[point.coordinateY + point.coordinateX * 10 - 22].setIsAvailable(false);
            }
        }
        private void BlockBottomLeftPoint(Point point)
        {
            if (point.coordinateY > 1 && point.coordinateX < 10)
            {
                pointsInBattleArea[point.coordinateY + point.coordinateX * 10 - 2].setIsAvailable(false);
            }
        }
        private void BlockTopRightPoint(Point point)
        {
            if (point.coordinateY < 10 && point.coordinateX > 1)
            {
                pointsInBattleArea[point.coordinateY + point.coordinateX * 10 - 20].setIsAvailable(false);
            }
        }
        private void BlockBottomRightPoint(Point point)
        {
            if (point.coordinateY < 10 && point.coordinateX < 10)
            {
                pointsInBattleArea[point.coordinateY + point.coordinateX * 10].setIsAvailable(false);
            }
        }
        public Point [] DrawRandomPoints(int battleshipLength)
        {
            Point[] randomPoints = new Point[battleshipLength];
            Random rotation = new Random();
            bool isRotated = rotation.Next(1, 10) > 5;

            int[] coordinatesX = new int[battleshipLength];

            int[] coordinatesY = new int[battleshipLength];
            int shouldDrawAgain = 0;
            do
            {
                shouldDrawAgain = 0;
                do
                {
                    isRotated = !isRotated;
                        coordinatesX[0] = getRandomDigit(battleshipLength);
                        coordinatesY[0] = getRandomDigit(battleshipLength);
                
                } while (!arePointsAvailable(coordinatesX[0], coordinatesY[0]));


                for (int i = 0; i < battleshipLength; i++)
                {
                    if (isRotated)
                    {
                        coordinatesX[i] = coordinatesX[0] + i;
                        coordinatesY[i] = coordinatesY[0];
                    }
                    else
                    {
                        coordinatesX[i] = coordinatesX[0];
                        coordinatesY[i] = coordinatesY[0] + i;
                    }

                    if(!arePointsAvailable(coordinatesX[i], coordinatesY[i]))
                    {Console.WriteLine("Losuję ponownie!");
                        shouldDrawAgain++;
                        break;
                    }

                }
            } while (shouldDrawAgain > 0);

            for (int i = 0; i < battleshipLength; i++)
            {
                randomPoints[i] = new Point(coordinatesX[i], coordinatesY[i]);
                pointsInBattleArea[coordinatesY[i] + coordinatesX[i] * 10 - 11].setIsAvailable(false);
                pointsInBattleArea[coordinatesY[i] + coordinatesX[i] * 10 - 11].setIsFilled(true);
                Console.WriteLine(randomPoints[i].coordinateX +" " + randomPoints[i].coordinateY);
            }
            return randomPoints;
       }

        public int getRandomDigit(int battleshipLength)
        {
            int coordinate;
            if(battleshipLength > 3)
            {
                Random random2 = new Random();
                if (random2.Next(0,2) > 0)
                {
                    return coordinate = 1;
                }
            }
            Random random = new Random();
            coordinate = random.Next(1, 12 - battleshipLength);
            return coordinate;
        } 

        public bool arePointsAvailable(int coordinateX, int coordinateY)
        {   
            if (pointsInBattleArea[coordinateY + coordinateX * 10 - 11].isAvailable == true) return true;
            else return false;
        }

        public bool checkHit(int coordinateX, int coordinateY)
        {
            return true;
        }
    }
}
