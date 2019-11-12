using System;

namespace LoopTask4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma arpoo oikean voitto rivin.");
            Console.WriteLine(" 1 = kotivoitto\n X = tasapeli\n 2 = vierasvoitto\n");
            Random rnd = new Random();
            rnd.NextDouble();


            for (int i = 1; i < 14; i++)
            {
                if (rnd.NextDouble() < 0.4)
                {
                    Console.WriteLine($"{i}. 1");
                }

                else if (rnd.NextDouble() < 0.6)
                {
                    Console.WriteLine($"{i}. X");
                }

                else if (rnd.NextDouble() > 0.6)
                {
                    Console.WriteLine($"{i}. 2");

                }

            }
        }
    }
}
