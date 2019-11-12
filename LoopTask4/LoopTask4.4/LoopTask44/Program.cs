using System;

namespace LoopTask44
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int kruunu = 0;
            int klaava = 0;
            
            Console.WriteLine("Sovellus laskee kolikon heiton loppu tulokset 20 heiton jälkeen.");


            for (int i = 0; i < 20; i++)
            {
                int heittokerta = rnd.Next(2);

                if (heittokerta == 0)
                {
                    klaava++;
                }
                else if (heittokerta == 1)
                {
                    kruunu++;
                }

            }
            Console.WriteLine($"Kruunu heitettiin {kruunu} ja klaava heitettiin {klaava}");
        }
    }
}
