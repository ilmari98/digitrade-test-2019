using System;

namespace SelfEvaluationTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma kerää numeroita ja laskee ne yhteen, kunnes sovellus havaitsee negatiivisen numeron, ja vähentää sen eddellisistä summasta!");
            Console.WriteLine("Syötä numeroita: ");
            int userNumber = 0;
            int sumOfNumbers = 0;

            do
            {
                userNumber = int.Parse(Console.ReadLine());
                sumOfNumbers += userNumber;
            } 
            while (userNumber > 0);

            Console.WriteLine($"Yhteinen summa on: {sumOfNumbers-userNumber}");

        }
    }
}
