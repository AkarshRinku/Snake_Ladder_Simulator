using System;
using System.Collections.Generic;
using System.Text;

namespace Snakes_And_Ladders
{
    class UC_6NumberOfDicePlayed
    {
		public static int No_Play = 1;
		public static int LadderCount = 2;
		public static int SnakeCount = 3;
		public static int Winning_position = 100;
		public static int Position_check = 0;
		public static void snakeAndLadder5()
		{
			Console.WriteLine("Welcome to SnakeAndLadder program");
			int noOfDiceRoll = 0;
			int position = 0;

			Console.WriteLine("Start position of player :	" + position);

			while (position < Winning_position)
			{

				Random random = new Random();
				int Diceroll = 0;
				while (true)
				{
					Diceroll = random.Next(7);
					if (Diceroll != 0) break;
				}

				Console.WriteLine("Number of dice : " + Diceroll);

				Random ran = new Random();
				noOfDiceRoll++;
				int option = 0;
				while (true)
				{
					option = random.Next(4);
					if (option != 0)
				break;
				}

				Console.WriteLine("====OPTIONS======\nOption 1 : No Play\nOption 2 : Ladder \nOption 3 : Snake \n");

				Console.WriteLine("Option : " + option);
				//Switch statement
				switch (option)
				{
					case 1:
						Console.WriteLine("Current Position of Player:" + position);
						Console.WriteLine("Player stays in the same position : " + position);
					break;

					case 2:
						if ((position + Diceroll) > Winning_position)
						{
							position = Winning_position;
						}
						else
						{
							position += Diceroll;
						}
						Console.WriteLine("Current Position of Player:" + position);
						Console.WriteLine("Player moves ahead by : " + position);
					break;

					case 3:
						position -= Diceroll;
						if ((position - Diceroll) < Position_check)
						{
							position = Position_check;
						}
						Console.WriteLine("Current Position of Player:" + position);
						Console.WriteLine("Player moves behind by : " + position);
					break;

					default:
						Console.WriteLine("Current Position of Player:" + position);
						Console.WriteLine("Enter correct value");
						break;
				}
			}

			Console.WriteLine("Number Of Times The Dice Was Played To Win The Game Is : " + noOfDiceRoll);
		}
	}
}
    

