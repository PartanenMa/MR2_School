using System;

namespace Funktiot_harjoitus10
{
    class Program
    {
        static void Main(string[] args)
        {
            kertotaulu(1);
            Console.WriteLine();
            kertotaulu(2);
            Console.WriteLine();
            kertotaulu(3);
        }

        static void kertotaulu(int arvo) {
            int[] luvut = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            foreach(int luku in luvut) {
                Console.WriteLine(arvo + " * " + luku + " = " + arvo * luku);
            }
        }
    }
}
