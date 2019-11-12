using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ohjelma tulostaa syötetyn numeron mukaisen määrän tähtiä!");
            Console.Write("Syötä kokonaisluku: ");
            int userInput = int.Parse(Console.ReadLine());
            if (IsValidNumber(userInput))
            {
                string strStars = GenerateAmountOfStars(userInput);
                Console.WriteLine(strStars);
            }
            else
            {
                Console.WriteLine($"Numero {userInput} ei ole sallittu luku!");
            }

        }

        static bool IsValidNumber(int userInput)
        {
            if (userInput > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static string GenerateAmountOfStars(int starCount)
        {
            string stars = "";
            for (int i = 0; i < starCount; i++)
            {
                stars = stars + "*";
            }
            return stars;
        }
    }
}
