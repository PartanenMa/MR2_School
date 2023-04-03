using System;

namespace Ehtolauseet_harjoitus6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjoita teksti: ");
            string teksti = Console.ReadLine();
            int maara = teksti.Length;
            Console.WriteLine("Kiva juttu! " + "Kirjoitit " + maara + " merkkiä pitkän tekstin!");
        }
    }
}
