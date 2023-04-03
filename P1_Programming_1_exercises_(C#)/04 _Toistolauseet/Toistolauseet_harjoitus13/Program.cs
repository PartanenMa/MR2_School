using System;

namespace Toistolauseet_harjoitus13
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] sanat = {"no", "eka", "toka", "kolmas", "neljäs", "viides"};
            foreach(string sana in sanat) {
                if(sana.Length >= 3) {
                    Console.WriteLine(sana);
                }
            }
        }
    }
}
