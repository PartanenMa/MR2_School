using System;

namespace Toistolauseet_harjoitus11
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int luku = 0; luku < 101; luku++) {
                if(luku % 16 == 0) {
                    Console.WriteLine(luku);
                }
            }
        }
    }
}
