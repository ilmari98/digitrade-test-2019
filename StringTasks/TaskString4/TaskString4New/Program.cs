using System;

namespace TaskString4New
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sovellus selvittää onko syöttämä teksti palindromi");
            string userInput = Console.ReadLine();

            char[] temp = userInput.ToCharArray();
            Array.Reverse(temp);
            string reversed = new string(temp);

            if (userInput.ToLower().Equals(reversed.ToLower()))
            {
                Console.WriteLine($"{userInput} ja {reversed} ovat palindromi");
            }
            else
            {
                Console.WriteLine($"{userInput} ja {reversed} rivät ole palindromi");
            }
        }
    }
}
