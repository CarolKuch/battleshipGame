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
            Console.WriteLine("Prepared!");
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
        }

        private void deployBattleshipsToBattleArea (Battleship [] battleships)
        {
            BattleArea battlearea = new BattleArea();
            battlearea.CreateNewBattleArea();
            battlearea.ShowOceanMap();
            battlearea.DrawRandomSpot();
        }

        private void randomShot()
        {
            Random x = new Random();
            Random y = new Random();
            int A = x.Next(1, 10);
            int B = y.Next(1, 10);
            checkHit(A, B);
        }

        private bool checkHit(int A, int B)
        {
            return false;
        }

        private void loseTheBattle()
        {
            Console.WriteLine("Lost!");
        }

    }
}
