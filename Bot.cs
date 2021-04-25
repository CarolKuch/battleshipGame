using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Bot
    {
        private Battleship[] myBattleships;
        private BattleArea myBattleArea;
        public BattleArea opponentsBattleArea;

        public int shotsCounter = 0;

        public void prepareToBattle() {
            createBattleships();
            Console.WriteLine("Długość: " + myBattleships.Length);
            deployBattleshipsToBattleArea(myBattleships);
        }

        private void createBattleships()
        {
            int battleshipsArrayLength = 15;
            Battleship[] ships = new Battleship[battleshipsArrayLength];
            int lengthOfShipPlusNumberOfShipsInThisType = 6;
            for(int i = 5 ; i > 0 ; i--)
            {
                int j = lengthOfShipPlusNumberOfShipsInThisType - i;
                for (; j > 0; j--)
                {
                    ships[battleshipsArrayLength-1] = new Battleship(i);
                    battleshipsArrayLength--;
                }
            }
            myBattleships = ships;
            Console.WriteLine("Długość: " + myBattleships.Length);
        }

        private void deployBattleshipsToBattleArea (Battleship [] battleships)
        {
            myBattleArea = new BattleArea();
            myBattleArea.CreateNewBattleArea();
            myBattleArea.ShowOceanMap();
            for(int i = battleships.Length-1; i > 4; i--)
            {
                Console.WriteLine("Długość okrętu wynosi" + battleships[i].length);
                battleships[i].battleshipLocationPoints = myBattleArea.DrawRandomSpot(battleships[i]);
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
