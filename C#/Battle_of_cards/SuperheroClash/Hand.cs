using System;
using System.Collections.Generic;
using System.Linq;

namespace SuperheroClash
{
    public class Hand
    {
        public List<Card> CardsInHand { get; set; }
        public bool IsEmpty { get; set; }

        public Hand()
        {
            List<Card> CardsInHand = new List<Card>();
        }


        public void AddCard(Card card)
        {
            CardsInHand.Add(card);
        }

        public void RemoveCard(Card card)
        {
            CardsInHand.Remove(card);
        }
    }
}
