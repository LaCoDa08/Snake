using System;
namespace Snake
{
    /// <summary>
    /// Creates the snake and where it will start
    /// on the board.
    /// </summary>
    public class Body
    {
        private ConsoleColor bodyColor;
        private ConsoleColor headColor;
        private int positionTop;
        private int positionLeft;
        private int speed;
        private readonly int Length;
        public Body()
        {
            positionTop = 12;
            positionLeft = 30;
            Length = 12;
            bodyColor = ConsoleColor.DarkRed;
            headColor = ConsoleColor.Green;
        }

        /// <summary>
        /// Paints the Snake head Green and the body dark red.
        /// </summary>
        public void PaintSnake()
        {
            Console.SetCursorPosition(positionLeft, positionTop);
            Console.BackgroundColor = bodyColor;
            Console.WriteLine(new string(' ', Length));
            SnakeHead();
        }

        /// <summary>
        /// Paints Snake Head dark blue.
        /// </summary>
        public void SnakeHead()
        {
            Head head = new Head(Length);
            for (int i = positionLeft; i < (positionLeft + Length); i++)
            {
                head.Enqueue(new Position(i, positionTop));
            }

            int headLength = 1;
            Console.SetCursorPosition(positionLeft, positionTop);
            Console.BackgroundColor = headColor;
            Console.WriteLine(new string(' ', headLength));
        }

        private static void Move(ConsoleKeyInfo direction)
        {
            switch (direction.Key)
            {
                case ConsoleKey.W:
                    //move up
                    break;

                case ConsoleKey.A:
                    //move left
                    break;

                case ConsoleKey.S:
                    //move down
                    break;

                case ConsoleKey.D:
                    //move right
                    break;
            }
        }
    }
}
