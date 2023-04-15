using System;

namespace Funktiot_harjoitus2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numero_taulukko = {1, 2, 3, 4, 5};
            tulosta_taulukko(numero_taulukko);
        }

        static void tulosta_taulukko (int[] numerot) {
            foreach(int luku in numerot) {
                Console.WriteLine(luku);
            }
        }
    }
}
