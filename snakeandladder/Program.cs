using System;

namespace snakeandladder
{
    class Program
    {
        public const int ladder = 2;
         public const int snake = 1;
        public const int no_play = 0;
         public const int die_RollTime = 0;
         public const int Win_position = 100;
       // public const int position = 0;
        //int ChoiceOfPlayer = 0;
        
          static void Main(string[] args)
          {
            int position = 0 ; //local variable 
            int player = 1 ;
            //int Choice = 3;
           // int Ladder = 2;
            int count = 0;
            int i = 0;
          //  int pos;
            //int WIN = 1;
           //int PlayerChoice;
            Random random = new Random();
            int dieInput = random.Next(1, 7);
            int choice = random.Next(1, 3);
            while (i>0 || i<=100 )
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

            {      if (position < 100)
                    {
                        Console.WriteLine("move by adding the number ");
                    }
                    else if (position == 100)
                    {
                    Console.WriteLine("stay there");
                     
                    }
                    else
                    {
                        position = position++;
                    }


                    count++;
            }
            {
                if (int position = Win_position)
               {
                    Console.WriteLine("Player 1 win at " + die_RollTime + " move");
               }
            
                else
                {
                    Console.WriteLine("Player 2 win at " + die_RollTime + " move");
                }
            }
           
               Console.Read();
          }
    }
}
