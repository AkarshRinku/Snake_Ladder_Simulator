using System;
using System.Collections.Generic;
using System.Text;

namespace Snakes_And_Ladders
{
    class UC2_PlayerRollsDice
    {
        public static void snake1()
        {
            int position = 0;
            Console.WriteLine("Player is at position: " + position);
            Random random = new Random();
            int diceroll = 0;
            while (true)
            {
                diceroll = random.Next(6);
                if (diceroll != 0)

             break;

            }
            Console.WriteLine(diceroll);
        }
    }
}

