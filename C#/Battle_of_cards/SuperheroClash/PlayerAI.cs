using System;

namespace SuperheroClash
{ 
	public class PlayerAI: Player
	{
		public PlayerAI()
            :base ("Computer")
		{
		}

        public override int GetStat(Card card)
        {
            var rnd = new Random();
            var stat = rnd.Next(1, 3);
            SetStatToCompare(stat);
            return stat;
        }
    }

}


