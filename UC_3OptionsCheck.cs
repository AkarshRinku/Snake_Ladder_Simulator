using System;
using System.Collections.Generic;
using System.Text;

namespace Snakes_And_Ladders
{
    class UC_3OptionsCheck
    {
        public static int No_Play = 1;
        public static int LadderCount = 2;
        public static int SnakeCount = 3;

        public static void snakeAndLadder2()
        {
            Console.WriteLine("Welcome to Snake And Ladder program:");

            int position = 0;
            Console.WriteLine("Starting position of player : " + position);

            Random random = new Random();
            int Diceroll = 0;
            while (true)
            {
                Diceroll = random.Next(7);
                if (Diceroll != 0) break;
            }
            // Console.WriteLine("Number of dice :" + droll);

            Random ran = new Random();
            int option = 0;
            while (true)
            {
                option = ran.Next(4);
                if (option != 0) break;
            }
            Console.WriteLine("====OPTIONS======\nOption 1 : No Play\nOption 2 : Ladder \nOption 3 : Snake \n");
            Console.WriteLine("Option : " + option);

            switch (option)
            {
                case 1:
                    Console.WriteLine("Current Position is :" + position);
                    Console.WriteLine("Player stays in the same position : " + position);
                    break;

                case 2:
                    Console.WriteLine("Current Position is :" + position);
                    position = position + Diceroll;
                    Console.WriteLine("Player moves ahead by : " + position);
                    break;

                case 3:
                    Console.WriteLine("Current Position is :" + position);
                    position = position - Diceroll;
                    Console.WriteLine("Player moves behind by : " + position);
                    break;

            }
        }
    }
}
    

