using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Bot
    {
        private Battleship[] myBattleships = new Battleship[15];
        private BattleArea myBattleArea;
        public BattleArea opponentsBattleArea;

        public int shotsCounter = 0;

        public void prepareToBattle() {
            createBattleships();
            deployBattleshipsToBattleArea(myBattleships);
            for (int i = 0; i < myBattleships.Length; i++)
            {
                //Console.WriteLine(myBattleships[i].battleshipLocationPoints[0].coordinateY+"TO JEST Y");
            }
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
            myBattleArea.ShowOceanMap();
            for(int i = battleships.Length-1; i > 4; i--)
            {
                Console.WriteLine("Długość okrętu wynosi" + battleships[i].length);
                myBattleships[i].battleshipLocationPoints = myBattleArea.DrawRandomSpot(battleships[i]);
                myBattleArea.ShowOceanMap();
            }

            
            myBattleArea.ShowOceanMap();
        }

        public void randomShot()
        {
            Random x = new Random();
            Random y = new Random();
            int A = x.Next(1, 10);
            int B = y.Next(1, 10);
            myBattleArea.ShowOceanMap();
            myBattleArea.checkHit(A, B);
        }

        private void loseTheBattle()
        {
            Console.WriteLine("Lost!");
        }

    }
}
