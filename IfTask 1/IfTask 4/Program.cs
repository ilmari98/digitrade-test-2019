using System;

namespace IfTask_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolmen luvun lajittelia");
            // Tietojen Kysely
            Console.WriteLine("Syötä 1. luku: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Syötä 2. luku: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Syötä 3. luku: ");
            int z = int.Parse(Console.ReadLine());

            if (x > y && x > z && y > z)
            {
                Console.WriteLine($" {x} > {y} > {z}");
            }
            if (y > z && y > x && z > x)
            {
                Console.WriteLine($" {y} > {z} {x}");
            }
            if (z > x && z > y && x > y)
            {
                Console.WriteLine($" {z} > {x} > {y}");
            }
            if (y > x && y > z && x > z)
            {
                Console.WriteLine($" {y} > {x} > {z}");
            }
            if (x > z && x > y && z > y)
            {
                Console.WriteLine($" {x} > {z} {y}");
            }
        }
    }
}
