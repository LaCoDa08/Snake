using System;

namespace Snake
{
    class Program
    {

        static void Main(string[] args)
        {
            TitleMenu game = new TitleMenu();
            do
            {
                game.CreateMenu();
            } while (Console.ReadKey().Key != ConsoleKey.Enter);

            game.StartGame();

            //press an key..
            Console.CursorTop += 50;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine();
        }
    }
}
