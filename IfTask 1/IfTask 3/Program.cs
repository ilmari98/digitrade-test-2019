using System;

namespace IfTask_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInputNumber = 0;
            Console.WriteLine("Ohjelma selvittää onko numero pariton tai parillinen ja positiivinen tai negatiivinen!");
            Console.WriteLine("Syötä luku: ");
            userInputNumber = int.Parse(Console.ReadLine());

            if (userInputNumber < 0)

                Console.Write($"Numero {userInputNumber} on negatiivinen");

            else
                Console.Write($"Numero {userInputNumber} on positiivnen");
            {
                if (userInputNumber % 2 == 0)
                    Console.WriteLine(" ja parillinen");
                else
                    Console.WriteLine(" ja pariton");

            }

        }
    }
}
