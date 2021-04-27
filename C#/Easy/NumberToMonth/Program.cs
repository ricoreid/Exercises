using System;

namespace NumberToMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create a function that takes a number (from 1 to 12) and " +
                "returns its corresponding month name as a string. For example, if you're given " +
                "3 as input, your function should return \"March\", because March is the 3rd month.!");
            int userInput = 0;

            Console.WriteLine();
            Console.WriteLine("Enter the integer representation for the month: ");
            userInput = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write(MonthName(userInput - 1));
        }

        public static string MonthName(int index)
        {
            string[] month = new string[] {"January", "February", "March", "Apring", "May",
                "June", "July", "August", "September", "October", "November", "December"};

            return month[index];
        }
    }
}
