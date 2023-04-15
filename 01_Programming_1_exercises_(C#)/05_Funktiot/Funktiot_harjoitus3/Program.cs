using System;

namespace Funktiot_harjoitus3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luvut = palauta_taulukko(5);
            foreach(int luku in luvut) {
                Console.WriteLine(luku);
            }
        }

        static int[] palauta_taulukko(int n) {
            int[] taulukko = new int[n +1];
            for(int i = 0; i < taulukko.Length; i++) {
                taulukko[i] = i;
            }
            return taulukko;
        }
    }
}
