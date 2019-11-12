using System;

namespace IfTask4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int a = rnd.Next(1,50);
            int b = rnd.Next(1,50);
            int c = rnd.Next(1,50);
            int d = rnd.Next(1,50);
            int f = rnd.Next(1,50);
            int g = rnd.Next(1,50);
            int h = rnd.Next(1,50);
            int i = rnd.Next(1,50);
            int j = rnd.Next(1,50);
            int k = rnd.Next(1,50);
            Console.WriteLine($"Vastaus on:\nRivi 1: {a}, {b}, {c}, {d}, {f}\nRivi 2; {g}, {h}, {i}, {j}, {k}");
        }
    }
}
