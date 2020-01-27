using System;

namespace ArrayTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma arpoo 100 lukua 0-50 välistä ja kertoo niiden keskiarvon");
            Random rnd = new Random(); //rnd.Next(50);
            double average = 0;

            int[] iT = new int[100];

            for (int i = 0; i < iT.Length; ++i)
            {
                Console.WriteLine($"{i+1}. {rnd.Next(50)}");
            }

            double total = 0.0;
            for (int i = 0; i < iT.Length; ++i)
            {
                total += rnd.Next(50);
            }
            average = total / iT.Length; //Laskee keskiarvon
            Console.WriteLine($"keskiarvo on {average}");
        }
    }
}
