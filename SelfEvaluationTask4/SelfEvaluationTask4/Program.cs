using System;

namespace SelfEvaluationTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee kaksi eri syöttämää numero toinen toisella monella eri tavalla!");
            Console.Write("Syötä numero 1 :");
            float num01 = float.Parse(Console.ReadLine());
            Console.Write("Syötä numero 2 :");
            float num02 = float.Parse(Console.ReadLine());

            Console.WriteLine($"\nNumero 1. {num01}\nNumero 2. {num02}\n{num01} + {num02} = {num01 + num02}\n{num01} - {num02} = {num01 - num02}\n{num01} * {num02} = {num01*num02}\n{num01} / {num02} = {num01/num02}");
        }
    }
}
