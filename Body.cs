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
        private static int positionTop;
        private static int positionLeft;
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
            Head head = new Head(Length);
            for (int i = positionLeft; i < (positionLeft + Length); i++)
            {
                head.Enqueue(new Position(i, positionTop));
            }

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

        /// <summary>
        /// Sets the movemnet keys for the snake.
        /// </summary>
        /// <param name="d"></param>
        public static void Move(Direction d)
        {
            switch (d)
            {
                case Direction.Up:
                    positionTop--;
                    break;

                case Direction.Left:
                    positionLeft--;
                    break;

                case Direction.Down:
                    positionTop++;
                    break;

                case Direction.Right:
                    positionLeft++;
                    break;
            }
        }
    }
}
