using System;

namespace SelfEvaluationTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma toistaa kirjoittaman tekstin viisi kertaa!");
            Console.Write("Kirjoita teksti tähän: ");
            string userinput = Console.ReadLine();

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Rivi " + i + ". " + userinput);
            }


        }
    }
}
