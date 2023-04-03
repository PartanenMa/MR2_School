using System;

namespace Arrayt_harjoitus1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] taulukko = {"eka", "toka", "kolmas", "neljäs", "viides"};
            foreach(string rivi in taulukko) {
                Console.WriteLine(rivi);
            }
        }
    }
}
