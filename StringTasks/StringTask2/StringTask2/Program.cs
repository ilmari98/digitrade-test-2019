using System;

namespace StringTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sovellus vaihtaa kirjoittamasi tekstin a kirjaimen @ -merkiksi!");
            string userInput = Console.ReadLine();
            
            Console.WriteLine($"\nInput: {userInput}");
            Console.WriteLine($"\nOutput: {userInput.Replace('e','@')} ");
        }
    }
}
