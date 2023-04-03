using System;

namespace Toistolauseet_harjoitus12
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int luku = 0; luku < 21; luku++) {
                if(luku % 3 != 0) {
                    Console.WriteLine(luku);
                }
            }
        }
    }
}
