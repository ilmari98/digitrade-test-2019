using System;

namespace ArrayTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Taulokko harjoitus 1");
            // Esitellään ja alustellaan taulokko muuttujat
            decimal[] productPrice = new decimal[] { 7.96M, 72.0M, 99.90M };
            int[] productAmount = new int[] { 1, 3, 2 };
            decimal[] productTotalPrice = new decimal[3]; // tässä asetetaan taulokon koko

            for (int i = 0; i < 3; i++)
            {
                productTotalPrice[i] = productPrice[i] * productAmount[i];
            }
            Console.WriteLine($"{productTotalPrice}");
        }
        static decimal[] priceCalculator(decimal[] productPriceX, int[] productAmountY)
        {
            decimal[] ProductTotalPrice = new decimal[productAmountY.Length];
            for (int i = 0; i < productAmountY.Length; i++)
            {
                ProductTotalPrice[i] = productPriceX[i] * productAmountY[i];
            }
        }
        static void printPrices()
        {

        }
    }
}
