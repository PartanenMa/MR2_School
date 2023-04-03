using System;

namespace Funktiot_harjoitus11
{
    class Program
    {
        static void Main(string[] args)
        {
            kertotaulujen_maara(8);
        }

        static void kertotaulu(int arvo) {
            int[] luvut = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            foreach(int luku in luvut) {
                Console.WriteLine(arvo + " * " + luku + " = " + arvo * luku);
            }
            Console.WriteLine();
        }

        static void kertotaulujen_maara(int maara) {
            for(int i = 1; i <= maara; i++) {
                kertotaulu(i);
            }
        }
    }
}
