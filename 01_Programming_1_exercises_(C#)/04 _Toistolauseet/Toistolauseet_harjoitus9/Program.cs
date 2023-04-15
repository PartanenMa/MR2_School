using System;

namespace Toistolauseet_harjoitus9
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] luvut = {1.2, 2.2, 3.2};
            double summa = 0.0;
            foreach(double luku in luvut) {
                summa = summa + luku;
            }
            Console.WriteLine(summa);
        }
    }
}
