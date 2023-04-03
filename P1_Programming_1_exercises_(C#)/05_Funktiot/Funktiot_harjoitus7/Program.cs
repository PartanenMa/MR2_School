using System;

namespace Funktiot_harjoitus7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luvut = {1, 2, 3, 4, 5};
            Console.WriteLine(luvut[0]);
            Console.WriteLine(luvut[luvut.Length - 1]);
            summa(luvut);
        }

        static void summa(int[] taulukko) {
            int summa = 0;
            for(int i = 0; i < taulukko.Length; i++) {
                summa = summa + taulukko[i];
            }
            Console.WriteLine(summa);
        }
    }
}
