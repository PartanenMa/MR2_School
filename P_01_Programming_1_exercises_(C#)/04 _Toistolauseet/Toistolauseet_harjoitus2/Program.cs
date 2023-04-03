using System;

namespace Toistolauseet_harjoitus2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] luvut = {1.2, 2.2, 3.2};
            double summa = 0.0;
            for(int i = 0; i < 3; i++) {
                summa = summa + luvut[i];
            }
            Console.WriteLine(summa);
        }
    }
}
