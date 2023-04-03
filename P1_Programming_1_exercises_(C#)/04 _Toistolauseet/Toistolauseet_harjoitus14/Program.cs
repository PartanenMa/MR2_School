using System;

namespace Toistolauseet_harjoitus14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luvut = new int[10];
            int luku = 1;
            for(int i = 0; i < 10; i++) {
                luvut[i] = luku;
                luku++;
            }
            int i2 = 0;
            for(int i3 = 0; i3 < 10; i3++) {
                Console.Write(luvut[i2] + ", ");
                i2++;
                Console.WriteLine(luvut[i2]);
                i2++;
            }
        }
    }
}
