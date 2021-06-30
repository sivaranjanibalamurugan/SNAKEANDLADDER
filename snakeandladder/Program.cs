﻿using System;

namespace snakeandladder
{
    class Program
    {
        //public const int ladder = 2;
        // public const int snake = 1;
        //  public const int no_play = 0;
         public const int die_RollTime = 0;
        // public const int Win_position = 100;
        int ChoiceOfPlayer = 0;
        
        public void StepToWin()
        {
            Random random = new Random();
            int[] playerPos = new int[2];
            int[] dieRollTime = new int[2];
            int player;
            int pos;
            int WIN;
            int PlayerChoice;
            {
           
                    
       while (playerPos[0] < ChoiceOfPlayer.WIN && playerPos[1]< ChoiceOfPlayer.WIN)
            {
                player = 0;
                while (player <= 1)
                {
                    pos = playerPos[player];

                    //Generating DieRoll using Next method
                    int dieRoll = random.Next(1, 7);

                    //Generating the player choice
                    int playerChoice = random.Next(0, 3);

                    //current position of player
                    pos = ChoiceOfPlayer.PlayerChoice(playerChoice, pos, dieRoll);
                    playerPos[player]=pos;

                    Console.WriteLine("Position of player "+(player+1)+" is : "+playerPos[player]);

                    dieRollTime[player]++;

                    //checks whether player reache win
                    if (playerPos[player] == 100)
                    {
                        break;
                    }

                    //If choice is ladder then player can take two turns
                    if (playerChoice!=ChoiceOfPlayer.LADDER )
                    {
                        player++;
                    }


                }
            }
            if(playerPos[0]==ChoiceOfPlayer.WIN)
            {
                Console.WriteLine("Player 1 win at "+dieRollTime[0]+" move");
            }
            else
            {
                Console.WriteLine("Player 2 win at "+dieRollTime[1]+" move");
            }

        }

    }

}
            Console.Read();


        }
    }
}
