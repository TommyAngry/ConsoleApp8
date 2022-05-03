using System;
using ClassLibrary1;

namespace ConsoleApp8
{
    class Program
    {
       
        static void Main(string[] args)
        {

            People people = new();
            Bot bot = new();
            Logic logic = new();
            logic.Game(7, 7, 0, 0, logic.Rand(1, 6), logic.Rand(1, 6));
            logic.Notify += DisplayMessage;
            Console.WriteLine();
            logic.EventsGame(0, 0,  bot, people);

          
          
        }

        private static string DisplayMessage(int message)
        {
            People people = new();
            Bot bot = new();
            switch (message)
            {
                case 0:
                    Console.WriteLine("Продолжаем");
                    return "Продолжаем";

                case 1:
                    Console.WriteLine($"Победил-{people.Name}");
                    return $"Победил{people.Name}";

                case 2:
                    Console.WriteLine($"Победил{bot.Name}");
                    return $"Победил{bot.Name}";

                case 3:
                    Console.WriteLine("стоп");
                    return "Одинаковое количество фишек";
                default: return "hwq";
            }

        }
    }
}
