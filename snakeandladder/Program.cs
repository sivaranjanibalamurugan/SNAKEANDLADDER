using System;

namespace snakeandladder
{
    class Program
    {
        public const int ladder = 2;
        public const int snake = 1;
        public const int no_play = 0;
        public const int position = 0;
        public const int Win_position = 100;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder World");
            int player = 1;
           // int position = 0;
           // int i = position;
            Random random = new Random();
            int dieInput = random.Next(1, 7);
            int choice = random.Next(1, 3);
            for(int position = 0; position  <= Win_position; position ++)
            switch (choice)
            {
                case ladder:
                    Console.WriteLine("move forward ");
                    break;
                case snake:
                    Console.WriteLine("move backward");
                    break;
                case no_play:
                    Console.WriteLine("don't move stay");
                    break;
            }

            Console.WriteLine("Player " + player + " is in position " + position + " initially");
            Console.Read();
        }    
        
    }
}
