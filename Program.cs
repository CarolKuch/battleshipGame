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
            EndTheBattle(botsInGame);
            Console.ReadLine();
        }

        static void StartTheBattle(Bot[] botsInGame)
        {
            int a = 10;
            do
            {
                Console.WriteLine("Wciśnij dowolny przycisk, aby rozpocząć rundę!");
                Console.ReadKey();
                Console.WriteLine();
                botsInGame[1].myBattleArea.checkHit(botsInGame[0].randomShot());
                botsInGame[0].myBattleArea.checkHit(botsInGame[1].randomShot());
                a--;
                botsInGame[0].myBattleArea.ShowOceanMap();
                botsInGame[1].myBattleArea.ShowOceanMap();
            } while ( !( botsInGame[0].loseTheBattle() || botsInGame[1].loseTheBattle() ) );
        }

        static void EndTheBattle(Bot[] botsInGame)
        {
            if(botsInGame[0].loseTheBattle() && !botsInGame[1].loseTheBattle())
            {
                Console.WriteLine("Wygrał pierwszy bot");
            }else if (!botsInGame[0].loseTheBattle() && botsInGame[1].loseTheBattle())
            {
                Console.WriteLine("Wygrał drugi bot");
            }
            else
            {
                Console.WriteLine("Mamy remis!");
            }
        }

    }
}
