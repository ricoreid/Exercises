
namespace SuperheroClash
{
	public class GameControllerAI: GameController
	{
		public GameControllerAI()
			: base(new PlayerAI()) 
		{
		}

        protected override int PickStat(Player player)
        {
            int stat = player.GetStat(player.Hand.CardsInHand[_TOPCARD]);
            return stat;
        }
    }
}

