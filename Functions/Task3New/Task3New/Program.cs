using System;

namespace Task3New
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sovellus kysyy kaksi lukua ja antaa niiden välistä numeron!");
            Console.Write("Syötä ensimmäinen numero: ");
            int numberOne = int.Parse(Console.ReadLine());
            Console.Write("Syötä Toinen numero: ");
            int numberTwo = int.Parse(Console.ReadLine());
            Console.WriteLine("Syötä Kolmas luku jonka ohjelma tarkistaa ensimmästen kahden luvun välistä");
            int number = int.Parse(Console.ReadLine());
            int temporayThirdNumber = 0;
            if (numberOne > numberTwo)
            {
                temporayThirdNumber = numberTwo;
                numberTwo = numberOne;
                numberOne = temporayThirdNumber;
            }
                bool returnedValue = NumberFromRange(numberOne, number, numberTwo);
            if (returnedValue == true)
            {
                Console.WriteLine($"{number} on {numberOne} ja {numberTwo} välissä!");
            }
            else
            {
                Console.WriteLine($"Syöttämä numero {number} ei ollut aikaisempien numeroiden välissä");
            }
        }

        static bool NumberFromRange(int lowerBound, int number, int upperBound)
        {

            if (lowerBound < number && number < upperBound)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
