using System;

namespace snakeandladder
{
    class Program
    {
       
        static void Main(string[] args)
        { 
               Console.WriteLine("Welcome to Snake and Ladder World");
            int player = 1;
            int position = 0;
            Random random = new Random();
            int dieInput = random.Next(1, 7);
            Console.WriteLine("Player " + player + " is in position " + position  + " initially");
            Console.Read();
        }
    }
}
