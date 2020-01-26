using System;

namespace ArrayTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma arpoo 100 lukua 0-50 välistä ja kertoo niiden keskiarvon");
            Random rnd = new Random();
            double average = 0;
            int numberRange = 100;
            int[] iT = { numberRange };

            for (int i = 0; i < numberRange; i++)
            {
                Console.WriteLine($"{i+1}. {rnd.Next(50)}");
            }
        }
    }
}
