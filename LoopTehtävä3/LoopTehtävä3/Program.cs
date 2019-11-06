using System;

namespace LoopTehtävä3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tee ohjelma, joka laskee N:n ensimmäisen parittoman ja parillisen lukujen summan");
            Console.Write("Syötä luku: ");
            int userInput = int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < userInput; i++)
            {
                if (i % 2 == 0)
                {
                    evenSum = evenSum + i;
                }
                else
                {
                    oddSum = oddSum + i;
                }
            }
            Console.WriteLine($"Parillisten summa = {evenSum}\n" +
                $"parittomien summa = {oddSum}");
        }
    }
}
