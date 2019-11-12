using System;

namespace Loop.Task4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma heittää noppaa 1000 kertaa ja kertoo kuinka monta kertaa heitti kutosen.");
            Random rnd = new Random();
            int noppaKuusi = 0;

            for (int i = 1; i < 1001; i++)
            {
                int heittokerta = rnd.Next(6);
                Console.WriteLine($"{i}. {heittokerta + 1}");

                if (heittokerta + 1 == 6)
                {
                    noppaKuusi++;
                }
            }

            Console.WriteLine();
            Console.Write($"Numero kuusi osui {noppaKuusi} kertaa.");
            return; ;
        }
    }
}
