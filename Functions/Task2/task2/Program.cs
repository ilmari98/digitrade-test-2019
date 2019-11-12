using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ohjelma!");
            Console.Write("Syötä 1.luku : ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Syötä 2.Luku : ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine($"Luku {GetMinNumber(x, y)} on pienempi kuin {GetMaxNumber(x, y)}");
        }



        static int GetMinNumber(int firstnumber, int lastnumber)
        {
            if(firstnumber < lastnumber)
                {
                return firstnumber;
                }
                else
                {
                return lastnumber;
                }
        }
        static int GetMaxNumber(int lastNumber,int firstNumber)
        {
            if (firstNumber < lastNumber)
            {
                return lastNumber;
            }
            else
            {
                return firstNumber;
            }
        }
    }
}
