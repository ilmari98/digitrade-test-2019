using System;

namespace LoopTehtävä5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee N:n ensimmäisen parittoman ja parillisen lukujen summan.");
            Console.Write("Syötä luku: ");
            int userInput = int.Parse(Console.ReadLine());
            int parillinen = 0;
            int pariton = 0;

            {
                for (int i = -1; i >= userInput; i--)
                {
                    if (i % 2 == 0)
                        parillinen = parillinen + i;
                    else
                        pariton = pariton + i;
                }
            }

            Console.WriteLine($"Parillisten summa = {parillinen}\n" +
                $"Parittomien summa = {pariton}");
        }
    }
}
