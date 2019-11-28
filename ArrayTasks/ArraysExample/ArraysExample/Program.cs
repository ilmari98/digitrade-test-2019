using System;

namespace ArraysExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Taulukko esimerkki!"); 
            // Esitellään number taulukko
            int[] number = new int[] { 1, 3, 5, 7, 9 };

            // Asetetaan arvo number taulukko
            number[4] = 11;

            // Luetaan arvo taulukossa
            Console.WriteLine(number[2]);

            // Luetaan arvot silmukassa
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(number [i]);
            }

            // Kutsutaan funktiota, joka asetta arvor taulukkoon
            number = SetNumbers(5);

            Console.WriteLine("Kakkosen potenssi");
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i]);
            }


        }

        static int[] SetNumbers(int arraySize)
        {
            int[] arrayPower = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                arrayPower[i] = (int)Math.Pow(2, i);
            }
            return arrayPower;
        }
    }
}
