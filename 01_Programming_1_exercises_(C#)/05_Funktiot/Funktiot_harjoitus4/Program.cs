using System;

namespace Funktiot_harjoitus4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luvut = {1, 2, 3, 4, 5};
            Console.WriteLine(palauta_luku(3, luvut));
        }

        static int palauta_luku(int k, int[] the_list) {
            int maara = 0;
            foreach(int luku in the_list) {
                if(luku >= k) {
                    maara++;
                }
            }
            return maara;
        }
    }
}
