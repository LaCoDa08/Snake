using System;


namespace Snake
{
    class Head
    {
        private int front;
        private int rear;
        private int n;
        private int capacity;
        private Position[] elements;

        public Head (int capacity)
        {
            this.capacity = capacity;
            this.elements = new Position[capacity];
            n = 0;
            front = rear = -1;
        }

        public bool Empty()
        {
           return n == 0;
        }

        public bool Full()
        {
            return n == capacity;
        }

        public void Enqueue(Position p)
        {
            if (Full())
                throw new InvalidOperationException("Can't add a new element to a full queue.");

            rear = ++rear % capacity;
            elements[rear] = p;

            if (Empty())
                front = rear;

            n++;
        }

        public Position Dequeue()
        {
            if (Empty())
                throw new InvalidOperationException("Can't remove an element from an empty queue.");

            Position p = elements[front];
            elements[front] = null;
            n--;

            if (!Empty())
                front = ++front % capacity;

            return p;
        }
    }
}
