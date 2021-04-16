using System;
using System.Collections.Generic;
using System.IO;

namespace SuperheroClash
{
    public class CardsDAO
    {
        private string FilePath;

        public CardsDAO(string filePath)
        {
            this.FilePath = filePath;
        }


        public List<string[]> SplittingFile()
        {
            List<string[]> heroArray = new List<string[]>();
            var newFile = File.ReadAllText(FilePath);
            var cards = newFile.Split(";\r\n");
            foreach (var line in cards)
            {
                var hero = line.Split(", ");
                heroArray.Add(hero);
            }
            return heroArray;
        }

        public List<Card> CreatingNewCards(List<string[]> heroArray)
        {
            List<Card> cards = new List<Card>();
            foreach(var hero in heroArray)
            {
                var rank = Convert.ToInt32(hero[0]);
                var power = Convert.ToInt32(hero[1]);
                var intelligence = Convert.ToInt32(hero[2]);
                var strength = Convert.ToInt32(hero[3]);
                var name = hero[4];
                var team = hero[5];

                var newCard = new Card(rank, power, intelligence, strength, name, team);
                cards.Add(newCard);
                cards.Add(newCard);
            }

            return cards;
        }

        public Deck GetDeck()
        {
            var CardsDao = new CardsDAO(@"D:\VisualStudio\CodeCool\SuperheroClash\SuperheroClash\Cards.csv");
            var Array = CardsDao.SplittingFile();
            var NewCards = CardsDao.CreatingNewCards(Array);
            var Deck = new Deck(NewCards);
            return Deck;
        }

    }
}

