using System;

namespace Funktiot_harjoitus9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 4;
            Console.WriteLine(palauta_summa(a, b));
        }

        static int palauta_summa(int eka, int toka) {
            int summa = 0;
            for(int i = 0; i < toka; i++) {
                summa = summa + eka;
            }
            return summa;
        }
    }
}
