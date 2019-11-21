using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sovellus pyytää 10 numeroa ja kertoo takaisin niistä suurimman");
            Console.WriteLine("Syötä 10 Lukua:");
            int largestNumber = 0;
            int largestNumberPosition = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}.  ");
                int userNumber = int.Parse(Console.ReadLine());
                bool number = NegativeNumberChecker(userNumber);
                if (number == false)
                {
                    Console.WriteLine($"Syöttämäsi {userNumber} ei sovi, koska se on negatiivinen, Syötä jokin toinen luku");
                    i--;
                }
                

                if (userNumber > largestNumber)
                {
                    largestNumber = userNumber;
                    largestNumberPosition = i + 1;
                }

                
            }
            Console.WriteLine($"Suurin numero oli {largestNumber} sija {largestNumberPosition}.");
        }

        static bool NegativeNumberChecker(int inputNumber)
        {
            if (inputNumber < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
