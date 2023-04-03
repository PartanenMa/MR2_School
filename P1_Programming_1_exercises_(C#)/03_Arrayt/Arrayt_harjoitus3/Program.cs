using System;

namespace Arrayt_harjoitus3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] taulukko = new string[3]; 
            Console.WriteLine("Kirjoita eka sana:");
            string sana1 = Console.ReadLine();
            taulukko[0] = sana1; 
            Console.WriteLine("Kirjoita toka sana:");
            string sana2 = Console.ReadLine();
            taulukko[1] = sana2; 
            Console.WriteLine("Kirjoita kolmas sana:");
            string sana3 = Console.ReadLine();
            taulukko[2] = sana3;         
            for(int i = 2; i > -1; i--) {
                Console.WriteLine(taulukko[i]);
            }
        }    
    }
}
