using System;

namespace StringTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sovellus lakee halutun kirjain määrän tekstistä.\nKirjoita teksti: ");
            String userInput = Console.ReadLine();
            Console.WriteLine("Minkä kirjaimen määrän haluat etsiä tekstistä?");
            string letter = Console.ReadLine().ToUpper();
            string text = userInput.ToUpper();
            int letterCounter = 0;

            foreach (char a in text)
            {
                if (letter == a.ToString())
                    letterCounter++;
            }
            Console.WriteLine($"Kirjaimia {letter} tekstissä on {letterCounter}");
        }
    }
}
