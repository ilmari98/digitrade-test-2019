using System;

namespace StringTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sovellus laskee kirjoittaman tekstin kirjain määrän!");
            String userInput = Console.ReadLine();

            Console.WriteLine($"Tekstissä: {userInput} on {userInput.Length} kirjainta.");
        }
    }
}
