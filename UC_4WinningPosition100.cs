using System;
using System.Collections.Generic;
using System.Text;

namespace Snakes_And_Ladders
{
    class UC_4WinningPosition100
    {
        public static int No_Play = 1;
        public static int LadderCount = 2;
        public static int SnakeCount = 3;
        public static int Winning_position = 100;
        public static int Position_check = 0;
        public static void SnakeAndLadder3()
        {
            Console.WriteLine("Welcome to Snake And LAdder program");

            int position = 0;
            Console.WriteLine("Start position of player : " + position);

            Random random = new Random();

            int Diceroll = 0;
            while (true)
            {
                Diceroll = random.Next(7);
                if (Diceroll != 0) break;
            }

            Console.WriteLine("Number of dice : " + Diceroll);

            //options
            while (position < Winning_position)
            {
                Random ran = new Random();

                int option = 0;
                while (true)
                {
                    option = random.Next(4);
                    if (option != 0)
                        
                break;

                }
                Console.WriteLine("====OPTIONS=====\n Option 1 : No Play\nOption 2 : Ladder \nOption 3 : Snake \n");
                Console.WriteLine("Option : " + option);

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Current Position is: " + position);
                        Console.WriteLine("Player stays in the same position : " + position);
                        break;

                    case 2:
                        position = position + Diceroll;
                        Console.WriteLine("Current Position is: " + position);
                        Console.WriteLine("Player moves ahead by : " + position);
                        break;

                    case 3:
                        position = position - Diceroll;
                        if ((position - Diceroll) < Position_check)
                        {
                            position = Position_check;
                        }
                        Console.WriteLine("Current Position is: " + position);
                        Console.WriteLine("Player moves behind by : " + position);
                        break;

                    default:
                        Console.WriteLine("Current Position is: " + position);
                        Console.WriteLine("Enter correct value");
                        break;
                }



            }
        }
    }
}


