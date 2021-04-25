using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bot firstBot = new Bot();
            Bot secondBot = new Bot();
            Bot[] botsInGame = new Bot[] { firstBot, secondBot };
            foreach(Bot bot in botsInGame)
            {
                bot.prepareToBattle();
            }

            StartTheBattle(botsInGame);

            Console.ReadLine();
        }

        static void StartTheBattle(Bot[] botsInGame)
        {
            //int a = 10;
            //do
            //{
            //    botsInGame[0].randomShot();
            //    botsInGame[1].randomShot();
            //    a--;
            //} while (a>0);
        }

        static void EndTheBattle()
        {
            Console.WriteLine("ended!");
        }

    }
}
