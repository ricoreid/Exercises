using System;
using System.Collections.Generic;
using System.Threading;

namespace SuperheroClash
{
	public abstract class GameController
	{
        public List<Card> DrawHand = new List<Card>();
        public Deck Deck { get; set; }
		protected IComparer<Card> Comparer { get; set; }
        public Player Player1;
        public Player Player2;
        public Player ActualPlayer;
		public Player Winner;
        protected const int _TOPCARD = 0;

        public GameController(Player player) 
		{
			this.Deck = GetDeck();
			this.Comparer = new CardComparer();
			this.Player1 = new PlayerHuman();
			Player1.Hand.CardsInHand = Deck.CreatingNewHand();
			this.Player2 = player;
			Player2.Hand.CardsInHand = Deck.CreatingNewHand();
			this.ActualPlayer = Player1;
		}


        public bool GameOn()
		{
			if (Player1.Hand.CardsInHand.Count == 0 || Player2.Hand.CardsInHand.Count == 0)
			{
				return false;
			}
			else
				return true;
		}

		public void GetWinner(Player player1, Player player2)
        {
			if (player1.Hand.CardsInHand.Count == 0)
				Winner = player2;
			if (player2.Hand.CardsInHand.Count == 0)
				Winner = player1;
        }

		public void Game()
		{
			while (GameOn())
			{
				OneRound(Player1, Player2);
				ChangePlayer(Player1, Player2);
			}
			Console.Clear();
			GetWinner(Player1, Player2);
            Console.WriteLine("{0} won the game!!!", Winner.Name);
			Thread.Sleep(5000);
		}

		public void OneRound(Player player1, Player player2)
		{
			var View = new View();
			View.DispalyingTable(ActualPlayer, Player1, Player2);
			int stat = PickStat(ActualPlayer);
			if (ActualPlayer == player1)
				player2.SetStatToCompare(stat);
			player1.SetStatToCompare(stat);
			int comparisonResult = Comparer.Compare(player1.Hand.CardsInHand[_TOPCARD], player2.Hand.CardsInHand[_TOPCARD]);
			GetRoundWinner(comparisonResult, player1, player2);
			if (comparisonResult == 0)
				OneRound(player1, player2);
		}

		private void MoveCards(Player playerWon, Player playerLost)
		{
			playerWon.Hand.AddCard(playerWon.Hand.CardsInHand[_TOPCARD]);
			playerWon.Hand.RemoveCard(playerWon.Hand.CardsInHand[_TOPCARD]);
			playerWon.Hand.AddCard(playerLost.Hand.CardsInHand[_TOPCARD]);
			playerLost.Hand.RemoveCard(playerLost.Hand.CardsInHand[_TOPCARD]);
			foreach (var card in DrawHand)
			{
				playerWon.Hand.AddCard(card);
			}
			DrawHand.Clear();
		}

		private void GetRoundWinner(int comparisonResult, Player Player1, Player Player2)
		{
			if (comparisonResult == 1)
			{
				Console.WriteLine("\n{0} won the round!", Player1.Name);
				MoveCards(Player1, Player2);
			}
			if (comparisonResult == -1)
			{
				Console.WriteLine("\n{0} won the round!", Player2.Name);
				MoveCards(Player2, Player1);
			}
			if (comparisonResult == 0)
			{
				Console.WriteLine("\nIt is a draw");
				MoveCardsToDrawHand(Player1, Player2);
			}
		}

		private void MoveCardsToDrawHand(Player player1, Player player2)
		{
			DrawHand.Add(player1.Hand.CardsInHand[_TOPCARD]);
			player1.Hand.RemoveCard(player1.Hand.CardsInHand[_TOPCARD]);
			DrawHand.Add(player2.Hand.CardsInHand[_TOPCARD]);
			player2.Hand.RemoveCard(player2.Hand.CardsInHand[_TOPCARD]);
		}

		protected abstract int PickStat(Player player);

		private Deck GetDeck()
		{
			var CardsDao = new CardsDAO(@"D:\VisualStudio\CodeCool\SuperheroClash\SuperheroClash\Cards.csv");
			var Array = CardsDao.SplittingFile();
			var NewCards = CardsDao.CreatingNewCards(Array);
			var Deck = new Deck(NewCards);
			return Deck;
		}

		protected string GetName()
        {
			Console.WriteLine("\nEnter your name:");
			var name = Console.ReadLine();
			return name;
		}

		private void ChangePlayer(Player player1, Player player2)
		{
			if (ActualPlayer == player1)
				ActualPlayer = player2;
			else if(ActualPlayer == player2)
				ActualPlayer = player1;
		}

	}
}

