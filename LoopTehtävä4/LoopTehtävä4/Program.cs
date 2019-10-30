using System;

namespace LoopTehtävä4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee n ensimmäisein lukua yhteen!");
            Console.Write("Syötä luku:");
            int userInput = int.Parse(Console.ReadLine());
            int sumOfNumbers = 0;

            if (userInput > 0)
            {
                Console.WriteLine("Virheellinen numero");
            }
            else
            {
                for (int i = 0; userInput < 0; userInput++)
                {
                    sumOfNumbers = sumOfNumbers + userInput;
                }

                Console.WriteLine($"Vastaus: {sumOfNumbers}");
            }
        }
    }
}
