using System;

namespace Toistolauseet_harjoitus10
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku = 0;
            for(int i = 1; i < 11; i++) {
                luku = i * i;
                Console.WriteLine(luku);
            }
        }
    }
}
