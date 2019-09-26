using System;

namespace ReadWriteExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ReadWriteExample"); // Tulostaa näytölle vakioviestin ReadWriteExample
            Console.Write("Moi, Kirjoita nimesi: "); // Tulosta näytölle vakkioviestin
            // Luetaan Käyttäjän syöttämät merkin niin pitkään kunnes painetaan Enter
            // Sijoitetaan merkit merkkijonomuuttujaan userImput
            string userimput = Console.ReadLine();

            Console.WriteLine("----------------");// Tulosta näytölle vakkioviestin

            // Tulosta näytölle vakkioviestin ja muutujn userImput arvon
            Console.WriteLine("Moi " + userimput + "!");
            Console.WriteLine("Moi {0}!", userimput);
            Console.WriteLine($"Moi {Console.ReadLine()}!");

            //Tulostuksen muotoilu ja muuttajien käyttö 
            //tulostuksen yhteydessä $-merkin avulla = String.Format()

        }
    }
}
