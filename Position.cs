using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    public class Position
    {
        public int Left { get; }
        public int Top { get; }

        public Position(int left, int top)
        {
            Left = left;
            Top = top;
        }
    }
}
