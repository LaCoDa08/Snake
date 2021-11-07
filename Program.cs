using System;
using System.Threading;

namespace Snake
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            TitleMenu game = new TitleMenu();
            do
            {
                game.CreateMenu();
            } while (Console.ReadKey().Key != ConsoleKey.Enter);

            while (true)
            {
               if(Console.ReadKey().Key != ConsoleKey.Escape)
                game.StartGame();
            }

            //press an key..
            //Console.CursorTop += 50;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine();
        }
    }
}
