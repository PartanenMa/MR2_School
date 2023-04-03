using System;

namespace Toistolauseet_harjoitus5
{
    class Program
    {
        static void Main(string[] args)
        {
            Double[] desimaalit = {1.2, 2.2, 3.2};
            int i = 0;
            double summa = 0.0;
            while(i < 3) {
                summa = summa + desimaalit[i];
                i++;
            }
            Console.WriteLine(summa);
        }
    }
}
