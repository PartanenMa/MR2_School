using System;

namespace Toistolauseet_harjoitus4
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] merkkijonot = {"eka", "toka", "kolmas", "neljäs", "viides"};
            int i = 0;
            while(i < 5) {
                Console.WriteLine(merkkijonot[i]);
                i++;
            }
        }
    }
}
