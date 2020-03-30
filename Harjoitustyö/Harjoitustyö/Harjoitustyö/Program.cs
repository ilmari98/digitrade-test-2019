using System;

namespace Harjoitustyö
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä viitenumero ja sovellus selvittää onko se sopiva numerosarja.\n");
            int lastNumber, refTotal = 0;
            int[] BBANvalseries = { 1, 3, 7, 1, 3, 7, 1, 3, 7, 1, 3, 7, 1, 3, 7, 1, 3, 7, 1 };
            string refNumberSansLast, refNumber, newRefNumber, correctRefNumber;

            char userChoice;
            do
            {
                userChoice = UI();
                switch (userChoice)
                {
                    case '1':
                        Console.WriteLine("\n\nSyötä mahdollinen viitenumero ja sovellus selvittää sen viimeisen numeron.\n\n");
                        refNumberSansLast = Console.ReadLine();
                        newRefNumber = RemoveSpaces(refNumberSansLast);
                        SumOfRefNum(newRefNumber);
                        lastNumber = RoundUp(refTotal) - refTotal;
                        correctRefNumber = (newRefNumber.ToString() + lastNumber);
                        Console.WriteLine($"\n\nViimeinen numero on {lastNumber}, eli viitenumero on {correctRefNumber}.\n\n");
                        refTotal = 0;
                        break;
                    case '2':
                        Console.WriteLine("\n\nSyötä viitenumero ja sovellus tarkistaa sen todellisuuden.\n");
                        refNumber = Console.ReadLine();
                        refNumberSansLast = refNumber.Remove(refNumber.Length - 1, 1);
                        SumOfRefNum(refNumberSansLast);
                        lastNumber = RoundUp(refTotal) - refTotal;
                        correctRefNumber = refNumberSansLast.ToString() + lastNumber.ToString();
                        RefChecker(refNumber, correctRefNumber, lastNumber);
                        refTotal = 0;
                        break;
                    case '3':
                        Console.WriteLine("\n\nKuinka monta satunnaista viitenumeroa haluat luoda.\n");
                        int randomAmount = int.Parse(Console.ReadLine());
                        Random rnd = new Random();
                        int randonRefrenceNumber;
                        string randomizedReferenceNumber;
                        for (int i = 0; i < randomAmount; i++)
                        {
                            randonRefrenceNumber = rnd.Next(100000000, 999999999);
                            randomizedReferenceNumber = randonRefrenceNumber.ToString();
                            SumOfRefNum(randomizedReferenceNumber);
                            lastNumber = RoundUp(refTotal) - refTotal;
                            correctRefNumber = randomizedReferenceNumber + lastNumber.ToString();
                            Console.WriteLine($"\n{i + 1}. {correctRefNumber}");
                        }
                        refTotal = 0;
                        Console.WriteLine();
                        break;
                    case '4':
                        return;
                    default:
                        Console.WriteLine($"\nError! Valintasi [{userChoice}] ei ole vaihtoehto!\n");
                        break;
                }
            } while (userChoice != '4');

            string SumOfRefNum(string refSansLast)
            {
                int Length = refSansLast.Length;
                for (int i = 0; i < Length; i++)
                {
                    refTotal += (refSansLast[i] * BBANvalseries[i]) - BBANvalseries[i] * 48;
                }
                return refTotal.ToString();
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

            void RefChecker(string x, string y, int z)
            {
                if (x != y)
                {
                    Console.WriteLine($"\nSinun viitenumerossa on virheellinen viimeinen numero, sen pitäisi olla {z}.\n");
                }
                else if (x == y)
                {
                    Console.WriteLine($"\n\nSinun viitenumerosi {x} on todellinen.\n\n");
                }
            }

            static char UI()
            {
                Console.WriteLine("Viitenumero sovellus");
                Console.WriteLine("[1] Hanki viitenumerollesi viimeinen numero.");
                Console.WriteLine("[2] Testaa viitenumerosi aitouden.");
                Console.WriteLine("[3] Luo satunnainen viitenumero.");
                Console.WriteLine("[4] Sullje sovellus.");
                Console.Write("valitse mitä tehdään: \n\n");
                return char.ToUpper(Console.ReadKey().KeyChar);
            }
        }
    }
}