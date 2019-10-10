using System;

namespace IfTask2New
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kuinka paljon maksa lippu");
            Console.WriteLine("Syötä ikäsi");
            int userInputAge = int.Parse(Console.ReadLine());
            int normalTicket = 16;
            double discount = 0;
            double servicemanDiscount, childDiscount, retiredDiscount = 0.5;
            double mtkMemberDiscount = 0.15;
            double studentDiscount = 0.45;
            string isConscript, isStudent, isMtkMember = "";
            if (userInputAge <= 7)
            {
                Console.WriteLine($"Hinta on {normalTicket * discount} Euroa ");
            }
            else if (userInputAge > 7 && userInputAge < 15)
            {
                Console.WriteLine($"Hinta on {normalTicket * childDiscount} Euroa ");
            }
            else if (userInputAge >= 15 && userInputAge < 65)
            {
                Console.WriteLine($"Oletko varusmis? y/n");
                isConscript = Console.ReadLine();
                if (isConscript == "y")
                {
                    Console.WriteLine($"Hinta on {normalTicket - (normalTicket * servicemanDiscount)} Euroa ");
                }
                else
                {
                    Console.WriteLine($"Oletko opiskelia? y/n");
                    isStudent = Console.ReadLine();
                    if (isStudent == "y")
                    {
                        Console.WriteLine($"Oletko Mtk jäsen? y/n");
                        isMtkMember = Console.ReadLine();
                        if (isMtkMember == "y")
                        {
                            Console.Write($"Hinta on {normalTicket - (normalTicket * (studentDiscount + mtkMemberDiscount))} Euroa ");
                        }
                        else
                        {
                            Console.WriteLine($"Hinta on {normalTicket - (normalTicket * studentDiscount)} Euroa");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Oletko Mtk jäsen? y/n");
                        isMtkMember = Console.ReadLine();
                        if (isMtkMember == "y")
                        {
                            Console.Write($"Hinta on {normalTicket - (normalTicket * mtkMemberDiscount)} Euroa ");
                        }
                        else
                        {
                            Console.WriteLine($"Hinta on {normalTicket} Euroa");
                        }
                    }
                }
            }
            else if (userInputAge >= 65)
            {
                Console.WriteLine($"Hinta on {normalTicket - (normalTicket * retiredDiscount)} Euroa ");
            }
        }
    }
}
