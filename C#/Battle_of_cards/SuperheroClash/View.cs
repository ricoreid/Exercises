using System;
using System.Drawing;
using System.Text;
using System.Security.Principal;


namespace SuperheroClash
{
	public class View 
	{
        public const int _TOPCARD = 0;

		public View()
		{
		}

        public void DispalyingTable(Player actualPlayer, Player player1, Player player2)
        {
            Console.Clear();
            Console.WriteLine("{0} turn\n", actualPlayer.Name);
            Console.WriteLine("Number of cards in {0}'s hand: {1}", player1.Name, player1.Hand.CardsInHand.Count);
            Console.WriteLine("{0}'s card\n", player1.Name);
            Console.WriteLine(player1.Hand.CardsInHand[_TOPCARD]);
            Console.WriteLine("Number of cards in {0}'s hand: {1}", player2.Name, player2.Hand.CardsInHand.Count);
            Console.WriteLine("{0}'s card\n", player2.Name);
            Console.WriteLine(player2.Hand.CardsInHand[_TOPCARD]);
        }

        public void GameRules()
        {
            Console.WriteLine("********** GAME RULES **********");
            Console.WriteLine("1.   Each player gets a total of 15 cards");
            Console.WriteLine("2.   All cards have different features/capabilities that are ranked");
            Console.WriteLine("3.   The active player will choose a feature of the current card to compare with the second player's current card");
            Console.WriteLine("4.   The player with the highest ranking card wins");
            Console.WriteLine("5.   If there is a tie, both players compare the next card in their hands and repeat the above steps");
            Console.WriteLine("6.   The player who wins takes all the cards on the board");
            Console.WriteLine("7.   This process is repeated until one play has no cards left");

        }

    }
}