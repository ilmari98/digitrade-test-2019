using System;

namespace Harjoitustyö
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä viitenumero ja sovellus selvittää onko se sopiva numerosarja.\n");
            int refTotal = 0;
            int[] BBANvalseries = { 1, 3, 7, 1, 3, 7, 1, 3, 7, 1, 3, 7, 1, 3, 7, 1, 3, 7, 1 };

            char userChoice;
            do
            {
                userChoice = UI();
                switch (userChoice)
                {
                    case '1':
                        Console.WriteLine("\n\nSyötä viitenumero ja sovellus selvittää sen viimeisen numeron");
                        string refSansLast = Console.ReadLine();
                        string newRefNumber = RemoveSpaces(refSansLast);
                        SumOfRefNum(newRefNumber);
                        Console.WriteLine($"Viimeinen numero viitesarjallesi olisi {RoundUp(refTotal) - refTotal}.");
                        break;
                    case '2':
                        break;
                    case '3':
                        return;
                    default:
                        Console.WriteLine($"\nError! Valintasi [{userChoice}] ei ole vaihtoehto!\n");
                        break;
                }
            } while (((userChoice != '1') && (userChoice != '2') && (userChoice != '3')));

    {

            }

            string SumOfRefNum(string refSansLast)
            {
                int Length = refSansLast.Length;
                for (int i = 0; i < Length; i++)
                {
                    refTotal += (refSansLast[i] * BBANvalseries[i]) - BBANvalseries[i] * 48;
                }
                return $"Viimeinen numero on {refTotal}";
            }

            static string RemoveSpaces(string userInput)
            {
                string result = userInput.Replace(" ", "");
                return result;
            }

            int RoundUp(int roundUp)
            {
                if (roundUp % 10 == 0) return roundUp;
                return (10 - roundUp % 10) + roundUp;
            }

            static char UI()
            {
                Console.WriteLine("Viitenumero sovellus");
                Console.WriteLine("[1] Hanki viitenumerollesi viimeinen numero.");
                Console.WriteLine("[2] Testaa viitenumerosi aitouden.");
                Console.WriteLine("[3] Sulje ohjelma.");
                Console.Write("valitse mitä tehdään: \n\n");
                return char.ToUpper(Console.ReadKey().KeyChar);
            }
        }
    }
}
