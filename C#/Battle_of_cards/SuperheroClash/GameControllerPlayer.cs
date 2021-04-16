using System.Collections.Generic;
using System;

namespace SuperheroClash
{
    public class GameControllerPlayer: GameController
    {
        public GameControllerPlayer()
            :base(new PlayerHuman() )
        {
            Player1.Name = GetName();
            Player2.Name = GetName();
        }


        protected override int PickStat(Player player)
        {
            int stat = player.GetStat(player.Hand.CardsInHand[_TOPCARD]);
            return stat;
        }

    }
}