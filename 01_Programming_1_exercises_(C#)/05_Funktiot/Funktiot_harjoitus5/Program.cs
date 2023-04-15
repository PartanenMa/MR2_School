using System;

namespace Funktiot_harjoitus5
{
    class Program
    {
        static void Main(string[] args)
        {
        int[] luvut = {1, 2, 3, 4, 5};
        Console.WriteLine(suurin(luvut));
        }

        static int  suurin(int[] taulukko) {
            int suurin = 0;
            foreach(int rivi in taulukko) {
                if(rivi > suurin) {
                    suurin = rivi;
                }
            }
            return suurin;
        }
    }
}
