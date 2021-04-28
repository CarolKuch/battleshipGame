using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Bot
    {
        private Battleship[] myBattleships = new Battleship[15];
        public BattleArea myBattleArea;

        public int shotsCounter = 0;

        public void prepareToBattle() {
            createBattleships();
            deployBattleshipsToBattleArea(myBattleships);
        }

        private void createBattleships()
        {
            int battleshipsArrayLength = 15;

            int lengthOfShipPlusNumberOfShipsInThisType = 6;
            for(int i = 5 ; i > 1 ; i--)
            {
                int j = lengthOfShipPlusNumberOfShipsInThisType - i;
                for (; j > 0; j--)
                {
                    myBattleships[battleshipsArrayLength-1] = new Battleship(i);
                    battleshipsArrayLength--;
                }
            }
        }

        private void deployBattleshipsToBattleArea (Battleship [] battleships)
        {
            myBattleArea = new BattleArea();
            myBattleArea.CreateNewBattleArea();
            for(int i = battleships.Length-1; i > 4; i--)
            {
                myBattleships[i].battleshipLocationPoints = myBattleArea.DrawRandomSpot(battleships[i]);
            }
            myBattleArea.ShowOceanMap();
        }

        public Point randomShot()
        {
            Random x = new Random();
            int coordinateX = x.Next(1, 10);
            int coordinateY = x.Next(1, 10);
            return new Point(coordinateX, coordinateY);
        }


        public bool loseTheBattle()
        {
            if (myBattleArea.destroyedPointsCounter == 30) return true;
            else return false;
        }

    }
}
