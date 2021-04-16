using System;
using System.Text;

namespace SuperheroClash
{
    public class Card
    {
        public int Rank;
        public int Power;
        public int Inteligence;
        public int Strength;
        public string Name;
        public string Team;
        public int StatToCompare { get; set;}

        public Card(int rank, int power, int inteligence, int strength, string name, string team)
        {
            this.Rank = rank;
            this.Power = power;
            this.Inteligence = inteligence;
            this.Strength = strength;
            this.Name = name;
            this.Team = team;
            StatToCompare = 0;
        }


        public override string ToString()
        {
            string outsideLine = "##=======================##";
            string insideLine = "||-----------------------||";
            string emptyLine = "||                       ||";

            StringBuilder cardStr = new StringBuilder();
            cardStr.AppendLine(outsideLine);
            cardStr.AppendLine($"|| Name: {Name}");
            cardStr.AppendLine($"|| Team: {Team}");
            cardStr.AppendLine($"|| Rank: {Rank}");
            cardStr.AppendLine(emptyLine);
            cardStr.AppendLine(emptyLine);
            cardStr.AppendLine(insideLine);
            cardStr.AppendLine($"|| Power: {Power}              ||");
            cardStr.AppendLine(insideLine);
            cardStr.AppendLine($"|| Inteligence: {Inteligence}        ||");
            cardStr.AppendLine(insideLine);
            cardStr.AppendLine($"|| Strength: {Strength}           ||");
            cardStr.AppendLine(outsideLine);

            return cardStr.ToString();
        }
    }
}

