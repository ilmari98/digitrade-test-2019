using System;

namespace IfTask_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInputNumber = 0;
            Console.WriteLine("Syötä kokonaisluku: ");
            userInputNumber = int.Parse(Console.ReadLine());

            if (userInputNumber % 2 == 0)
            {
                Console.WriteLine($"Luku {userInputNumber} on parillinen");
            }

            else
            {
                Console.WriteLine($"Luku {userInputNumber} on pariton");
            }
        }
    }
}
