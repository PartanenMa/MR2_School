using System;

namespace Satunnaisuus_harjoitus4
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(int luku in lottorivi()) {
                Console.Write(luku + " ");
            }
        }

        static int[] lottorivi() {
            int[] lottorivi = new int[7];
            Random r = new Random();
            for(int i = 0; i < 7; i++) {
                int satunnainen_luku = r.Next(1,40);
                lottorivi[i] = satunnainen_luku;
            }
            return lottorivi;
        }
    }
}
