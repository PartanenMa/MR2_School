using System;

namespace Toistolauseet_harjoitus1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sanat = {"eka", "toka", "kolmas", "neljäs", "viides"};
            for(int i = 0; i < 5; i++) {
                Console.WriteLine(sanat[i]);
            }
        }
    }
}
