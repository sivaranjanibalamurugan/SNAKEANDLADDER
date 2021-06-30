using System;

namespace snakeandladder
{
    class Program
    {
        //public const int ladder = 2;
        // public const int snake = 1;
        //  public const int no_play = 0;
        public const int die_RollTime = 0;
      // public const int Win_position = 100;
      
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder World");
            int player = 1;
            int position = 0;
            int dieRoll = 0;
            int die_RollTime = 0;
            int Choice= 3;
            Random random = new Random();
             Choice = random.Next(1, 3);
      
         
            {
                if (position > 0)
                {
                    position = Choice(Choice, position, dieRoll);
                    position = position;
                    Console.WriteLine("Position of player " + (player + 1) + " is : " + position);
                }
                else
                {
                    Console.WriteLine("stay in same position");
                }
            }
            
            die_RollTime++;
            Console.WriteLine("Total number of time die rolled to reach WIN: " + die_RollTime);
            Console.Read();


        }
    }
}
