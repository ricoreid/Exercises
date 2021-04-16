using System;
using System.Collections.Generic;
using System.Threading;

namespace SuperheroClash
{
    public abstract class Player
    {
        public string Name { get; set; }
        public Hand Hand { get; set; }
        public bool HasLost { get; set; }
        private enum Stats
        {
            Power = 1,
            Inteligence = 2,
            Strength = 3
        }

        public Player(string name)
        {
            Name = name;
            Hand = new Hand();
        }

        public Player()
        {
            Hand = new Hand();
        }


        public abstract int GetStat(Card card);

        public void SetStatToCompare(int stat)
        {
            switch (stat)
            {
                case 1:
                    Hand.CardsInHand[0].StatToCompare = Hand.CardsInHand[0].Power;
                    break;
                case 2:
                    Hand.CardsInHand[0].StatToCompare = Hand.CardsInHand[0].Inteligence;
                    break;
                case 3:
                    Hand.CardsInHand[0].StatToCompare = Hand.CardsInHand[0].Strength;
                    break;
            }
        }
    }
}
