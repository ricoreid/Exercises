using System;

namespace DataTypeEg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ricardo!");
            /*
            Car Tayota = new Car();
            Tayota.HorsePower = 340;

            Car Hunda = new Car();
            Hunda.HorsePower = 350;

            Car Suzuki = new Car();
            Suzuki = Tayota;

            Console.WriteLine("***BEFORE***");
            Console.WriteLine("Tayota Horse Power: {0}\n Hunda Horse Power: {1}\n Suzuki Horse Power: {2}\n", Tayota.getHorsePower(), Hunda.getHorsePower(), Suzuki.getHorsePower());
            Suzuki.HorsePower = 325;
            Console.WriteLine("***AFTER***");
            Console.WriteLine("Tayota Horse Power: {0}\n Hunda Horse Power: {1}\n Suzuki Horse Power: {2}\n", Tayota.getHorsePower(), Hunda.getHorsePower(), Suzuki.getHorsePower());
            */

            int a = 3;
            int b = 5;
            int c = b;
            Console.WriteLine("A: {0}\nB: {1}\nC: {2}", a, b, c);

            b = 7;
            c = b;

            Console.WriteLine("A: {0}\nB: {1}\nC: {2}", a, b, c);

        }
    }

    public class Car
    {
        public int HorsePower { get; set; }

        public int getHorsePower()
        {
            return HorsePower;
        }

        public void Print()
        {
            Console.Write(HorsePower);
        }
    }
}
