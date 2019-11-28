using System;

namespace ArrayTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Taulokko harjoitus 1");
            // Esitellään ja alustellaan taulokko muuttujat
            decimal[] productPrice = new decimal[] { 7.96M, 72.0M, 99.90M };
            int[] productAmount = new int[] { 1, 3, 2 };
            decimal[] productTotalPrice = new decimal[3]; // tässä asetetaan taulokon koko


            productTotalPrice = priceCalculator(productPrice, productAmount);
            PrintTotalPrice(productTotalPrice);

        }
        /// <summary>
        /// The funtion calculates the process of the products using the given arrays
        /// </summary>
        /// <param name="productPrice"></param>
        /// <param name="productAmount"></param>
        /// <returns></returns>
        static decimal[] priceCalculator(decimal[] productPrice, int[] productAmount)
        {
            // Määräritetään taulokko pructTotalPrice. taulukon koko määräytyy tuotteidenmäärän mukaan
            decimal[] ProductTotalPrice = new decimal[productAmount.Length];
            for (int i = 0; i < productAmount.Length; i++)
            {
                ProductTotalPrice[i] = productPrice[i] * productAmount[i];
            }
            return ProductTotalPrice;
        }
        /// <summary>
        /// The funtion prints all data from array.
        /// </summary>
        static void PrintTotalPrice(decimal[] productTotalPrice)
        {
            for (int i = 0; i < productTotalPrice.Length; i++)
            {
                Console.WriteLine($" Tuote {i + 1}: {productTotalPrice[i]:C} ");
            }
        }
    }
}

