using System;
using System.Collections.Generic;
using System.Threading;

namespace SuperheroClash
{
	public class PlayerHuman: Player
	{
		public PlayerHuman()
            :base()
        {
        }

        public override int GetStat(Card card)
        {
            var digits = new List<int>() { 1, 2, 3 };
            int choice = 0;
            var isChosing = true;
            while (isChosing)
            {
                Console.WriteLine("\nEnter a valid number to choose a statistic to fight");
                Console.WriteLine("{0}) {1} - {2}", 1, card.Power, "Power");
                Console.WriteLine("{0}) {1} - {2}", 2, card.Inteligence, "Inteligence");
                Console.WriteLine("{0}) {1} - {2}", 3, card.Strength, "Strength");
                try
                {
                    choice = int.Parse(Console.ReadKey().KeyChar.ToString());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("\nInvalid value! Try again.");
                    continue;
                }

                if (!digits.Contains(choice))
                {
                    Console.WriteLine("\nInvalid number! Try again.");
                    continue;
                }
                SetStatToCompare(choice);
                isChosing = false;
            }
            return choice;
        }
    }
}


