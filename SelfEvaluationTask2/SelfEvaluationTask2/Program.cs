using System;

namespace SelfEvaluationTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa kirjoitetut sanat niin monta kertaa kuin kirjoitetuissa sanoissa on kirjaimia.");
            Console.Write("Kirjoita jotain: ");
            string userinput = Console.ReadLine();

            for (int i = 0; i < userinput.Length; i++)
            {
                Console.WriteLine("Rivi " + i + ". " + userinput);
            }
        }
    }
}
