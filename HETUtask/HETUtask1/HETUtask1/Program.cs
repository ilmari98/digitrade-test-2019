using System;

namespace HETUtask1
{
    class Program
    {
        static void Main(string[] args)
        {
            char userChoice;
            do
            {
                //Console.Clear();
                userChoice = UI();
                switch (userChoice)
                {
                    case 'T':
                        SSNCheck(); // Kutsutaan Sotun tarkastus funktiota
                        break;
                    case 'U':
                        SSNCreator(); // Kutsutaan Sotun luonti funktiota
                        break;
                    case 'X':
                        break;
                    default:
                        Console.WriteLine("\nTarkasta mitä painoit! Enter jatkaa ohjelman suoritusta.");
                        Console.ReadLine();
                        break;
                }
                Console.ReadLine();
            } while (userChoice != 'X');
        }//Main Program END

            static void SSNCreator()
            {
                Console.Write("\nAnna tarkastettava sotu: ");
                string userInput = Console.ReadLine();

                userInput = RemoveSpaces(userInput);
                if (IsValidLength(userInput, 10))
                {
                    if (IsValidDate(userInput))
                    {
                        int idNumber = InputParser(userInput);
                        char getValidationMark = GetValidationMark(idNumber);
                        PrintCreatedSSNumber($"{userInput}{getValidationMark}");
                    }

                }
            }

            static void SSNCheck()
            {

                Console.Write("\nAnna tarkastettava sotu [PPKKVV-XXXT] ");
                string userInput = Console.ReadLine();

                userInput = RemoveSpaces(userInput);
                if (IsValidLength(userInput))
                {
                    if (IsValidDate(userInput))
                    {
                        int idNumber = InputParser(userInput);
                        char getLastChar = GetUserInputCheckMark(userInput);
                        bool isOK = IsValidID(idNumber, getLastChar);
                        PrintResult(isOK);
                    }
                }
                else
                {
                    Console.WriteLine("\nTarkasta HETUn oikeellisuus - liikaa merkkejä");
                }
            }


            static char UI()
            {
                Console.WriteLine("Henkilötunnuksen käsittely.");
                Console.WriteLine("[T] Tarkastaa henkilötunnuksen oikeellisuus.");
                Console.WriteLine("[U] Luo uusi henkilötunnus.");
                Console.WriteLine("[X] Sulje ohjelma.");
                Console.Write("valitse mitä tehdään: ");

                return char.ToUpper(Console.ReadKey().KeyChar);

            }

            static bool IsValidDate(string userInput)
            {
                bool result = false;
                string day = userInput.Substring(0, 2);
                string month = userInput.Substring(2, 2);
                string year = userInput.Substring(4, 2);
                string century = userInput.Substring(6, 1);

                if (century == "-")
                {
                    year = "19" + year;
                }
                else if (century == "A")
                {
                    year = "20" + year;
                }
                else
                {
                    Console.WriteLine("\nVäärä vuosisata");
                    return result;
                }
                try
                {
                    DateTime birthday = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day));
                    result = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
                return result;
            }
            /// <summary>
            /// Check is userInput correct length
            /// Variable length is correct length.
            /// </summary>
            /// <param name="userInput"></param>
            /// <param name="length"></param>
            /// <returns></returns>
            static bool IsValidLength(string userInput, int length)
            {
                return userInput.Length == length;
            }
            /// <summary>
            /// Check is userInput correct length.
            /// Correct length is 11.
            /// </summary>
            /// <param name="userInput"></param>
            /// <returns></returns>
            static bool IsValidLength(string userInput)
            {
                return userInput.Length == 11;
            }

            static char GetValidationMark(int idNumber)
            {
                string chkMark = "0123456789ABCDEFHJKLMNPRSTUVWXY";
                int modChecker = idNumber % 31;

                return chkMark[modChecker];
            }
            static bool IsValidID(int idNumber, char userInputChkMark)
            {
                string chkMark = "0123456789ABCDEFHJKLMNPRSTUVWXY";

                int modChecker = idNumber % 31;

                if (chkMark[modChecker] == userInputChkMark)
                    return true;
                else
                    return false;
            }

            static string RemoveSpaces(string userInput)
            {
                string result = userInput.Replace(" ", "");
                return result;
            }

            static char GetUserInputCheckMark(string userInput)
            {
                return userInput[userInput.Length - 1];
            }


            static int InputParser(string stringParser)
            {
                string removed = stringParser;
                //Testataan stringParser -muutujan pituuus
                // Jos pituus yli 10 niin poistetaan viimeinen merkki
                if (stringParser.Length > 10)
                {
                    removed = stringParser.Remove(10, 1);
                }
                removed = removed.Remove(6, 1);

                return int.Parse(removed);
            }
            static void PrintResult(bool IsValidID)
            {
                if (IsValidID)
                    Console.WriteLine("\nSotu on oikein!");
                else
                    Console.WriteLine("\nSotu on väärin!");
            }
            static void PrintCreatedSSNumber(string newSSNumber)
            {
                Console.WriteLine($"Luotu sotu on: {newSSNumber}");
            }
        }
    }
