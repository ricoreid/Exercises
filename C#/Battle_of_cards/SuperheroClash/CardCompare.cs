using System.Collections.Generic;

namespace SuperheroClash
{
    public class CardComparer : IComparer<Card>
    {
        public int Compare(Card card1, Card card2 )
        {
            if (card1.StatToCompare > card2.StatToCompare)
                return 1;
            if (card1.StatToCompare < card2.StatToCompare)
                return -1;
            else
                return 0;
        }
    }
}