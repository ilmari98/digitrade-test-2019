using System;

namespace LoopTehtävä1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee kertoman luvun itsellään kasvaen n lukuun asti!");
            Console.WriteLine("syötä luku!");
            int userInput = int.Parse(Console.ReadLine());
            int fact = 1;
            int n = userInput;


            if (n < 0)
            {
                Console.WriteLine("Virheellinen syöte!");
            }
            else
            {
                while (n > 0)
                {
                    fact = fact * n;
                    n--;
                }
            }
            Console.WriteLine("Vastaus: " + fact);
        }
    }
}
