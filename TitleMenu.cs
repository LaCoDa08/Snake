using System;
namespace Snake
{
    /// <summary>
    /// Creates the menu and game for snake.
    /// With controls for the user to move the snake.
    /// </summary>
    public class TitleMenu
    {
        public Board board = new Board();
        public TitleMenu()
        {
        }

        /// <summary>
        /// Creates the start menu for the game.
        /// </summary>
        public void CreateMenu()
        {
            TitleScreen();
            Console.CursorTop = 3;
            Console.CursorLeft = 32;
            Console.WriteLine("Controls:");
            Console.CursorLeft = 30;
            Console.WriteLine("WASD to move");
            Console.CursorLeft = 27;
            Console.WriteLine("Press Enter to Start");
        }

        /// <summary>
        /// Paints the title screen.
        /// </summary>
        public void TitleScreen()
        {
            Console.Clear();
            Console.CursorLeft = 33;
            Console.CursorTop = 2;
            Console.WriteLine("SNAKE");
        }

        /// <summary>
        /// Starts the game by painting the board and title screen.
        /// </summary>
        public void StartGame()
        {
            TitleScreen();
            board.PaintBoard();
        }
    }
}
