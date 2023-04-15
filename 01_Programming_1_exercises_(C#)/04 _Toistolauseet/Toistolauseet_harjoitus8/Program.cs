using System;

namespace Toistolauseet_harjoitus8
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] sanat = {"eka", "toka", "kolmas", "neljäs", "viides"};
            foreach(string sana in sanat) {
                Console.WriteLine(sana);
            }
        }
    }
}
