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
                Console.Clear();
                userChoice = UI();
                switch (userChoice)
                {
                    case 'T':
                    break;
                    case 'U':
                    break;
                    default:
                        Console.WriteLine("Tarkasta mitä painoit!");
                        break;
                }
            } while (userChoice != 'X');

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
                Console.WriteLine("Tarkasta HETUn oikeellisuus - liikaa merkkejä");
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
            string month = userInput.Substring(2, 4);
            string year = userInput.Substring(4, 6);
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
                Console.WriteLine("Väärä vuosisata");
                return result;
            }
            try
            {
                DateTime birthday = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day));
                result = true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);

            }
            return result = false;
        }

        static bool IsValidLength(string userInput)
        {
            return userInput.Length == 11;
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
            string removed = stringParser.Remove(10, 1);
            removed = removed.Remove(6, 1);

            return int.Parse(removed);
        }
        static void PrintResult(bool IsValidID)
        {
            if (IsValidID)
                Console.WriteLine("Sotu on oikein!");
            else
                Console.WriteLine("Sotu on väärin!");
        }
    }
}
