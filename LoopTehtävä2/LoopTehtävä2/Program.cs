using System;

namespace LoopTehtävä2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee n ensimmäisein lukua yhteen!");
            Console.Write("Syötä luku:");
            int userInput = int.Parse(Console.ReadLine());
            int sumOfNumbers = 0;

            if (userInput < 0)
            {
                Console.WriteLine("Virheellinen numero");
            }
            else
            {
                for (int i = 0; i < userInput; i++)
                {
                    sumOfNumbers = sumOfNumbers + (i + 1);
                }

                Console.WriteLine($"Vastaus: {sumOfNumbers}");
            }
        }
    }
}
