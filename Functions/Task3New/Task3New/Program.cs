using System;

namespace Task3New
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sovellus kysyy kaksi lukua ja laskee käykö kolmas syöttö käy niiden väliin!");
            Console.Write("Syötä ensimmäinen numero: ");
            int numberOne = int.Parse(Console.ReadLine());
            Console.Write("Syötä Toinen numero: ");
            int numberTwo = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Syötä Kolmas luku jonka ohjelma tarkistaa ensimmästen kahden luvun välistä: ");
                bool isValidNumber = int.TryParse(Console.ReadLine(), out int number);
                if (isValidNumber = true)
                {

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
                        Console.WriteLine($"\nSyöttämäsi luku {number} on numeroiden {numberOne} ja {numberTwo} välissä!");
                    }
                    else
                    {
                        Console.WriteLine($"Syöttösi ei käy aikaisempien numeroiden väliin");
                    }
                }
                else
                {
                    Console.WriteLine($"Sovellukseen ei käy teksti, kirjoita jokin numero");
                }
            } while (true);
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
