using System;
using System.Threading;

namespace Snake
{
    /// <summary>
    /// Creates a board with obstacles for the
    /// snake to navigate.
    /// </summary>
    public class Board
    {
        private readonly int Top;
        private readonly int Left;
        private readonly int Length;
        public Body body = new Body();
        private readonly Random randX = new Random();
        private readonly Random randY = new Random();
        public static Direction snakeDirction;

        public Board()
        {
            Top = 3;
            Left = 5;
            Length = 60;
            snakeDirction = Direction.None;
        }

        /// <summary>
        /// Paints the board 20 by 60.
        /// </summary>
        public void PaintBoard()
        {
            Console.CursorTop = Top;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            for (int i = 0; i < 20; i++)
            {
                Console.CursorLeft = Left;
                Console.WriteLine(new string(' ', Length));
            }

            for (int i = 0; i < 3; i++)
            {
                PaintObstacle(new Position(randX.Next(5, 64), randY.Next(4, 23)));
            }

            body.PaintSnake();
            snakeMove();
        }

        /// <summary>
        /// Paints obstacles onto the board.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void PaintObstacle(Position p)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(p.Left, p.Top);
            Console.Write(" ");
            Console.WriteLine();
        }

        /// <summary>
        /// Moves the snake around on the board while the user
        /// has an available key.
        /// </summary>
        public void snakeMove()
        {
            ConsoleKeyInfo key = Console.ReadKey();
            do
            {
                if (key.Key == ConsoleKey.W)
                    snakeDirction = Direction.Up;
                else if (key.Key == ConsoleKey.S)
                    snakeDirction = Direction.Down;
                else if (key.Key == ConsoleKey.A)
                    snakeDirction = Direction.Left;
                else if (key.Key == ConsoleKey.D)
                    snakeDirction = Direction.Right;

                Body.Move(snakeDirction);
                Thread.Sleep(500);
            }
            while (Console.KeyAvailable == false);
        }

        public bool finished()
        {

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 60; j++)
                {
                    // TODO
                    return true;
                }
            }
            return false;
        }
    }
}
