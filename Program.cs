using System;

namespace ConsoleApp1
{
    class Program
    {      
        static void Main(string[] args)
        {
            Bot firstBot = new Bot();
            Bot secondBot = new Bot();
            Bot [] botsInGame = new Bot[] { firstBot, secondBot };
            foreach(Bot bot in botsInGame)
            {
                bot.prepareToBattle();
            }

            StartTheBattle();

            Console.ReadLine();
        }

        static void StartTheBattle()
        {
            Console.WriteLine("started!");
        }

        static void EndTheBattle()
        {
            Console.WriteLine("ended!");
        }

    }
}
