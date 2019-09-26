using System;

namespace IfTask_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma selvitää käyttäjän syöttämästä luvusta, onko se positiivinen vai negatiivinen!");
            Console.Write("Syötä kokonaisluku: ");
            int userInputNumber = int.Parse(Console.ReadLine());

            if( userInputNumber == 0)
            {
                Console.WriteLine($"Luku {userInputNumber} on nolla!");
            }
            else
            {
                if(userInputNumber > 0)
                {
                    Console.WriteLine($"Luku {userInputNumber} on positiivinen");
                }
                else
                {
                    Console.WriteLine($"Luku {userInputNumber} on negatiivinen");
                }
            }

        }
    }
}
