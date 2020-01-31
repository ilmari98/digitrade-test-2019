using System;

namespace Harjoitustyö
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä viitenumero ja sovellus selvittää onko se sopiva numerosarja.\n");
            string refernceNumber = Console.ReadLine();
            if(refernceNumber.Length > 19 )
            {
                Console.WriteLine($"\nViitenumerosi on liian pitkä.");
            }
            if (refernceNumber.Length < 4)
            {
                Console.WriteLine($"\nViitenumerosi on liian lyhyt.");
            }
        }
    }
}
