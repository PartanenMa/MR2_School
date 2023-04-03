using System;

namespace Muuttujat_harjoitus2
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku = 3;
            int uusi = luku;
            Console.WriteLine(luku);
            Console.WriteLine(uusi);
            luku = 5;
            Console.WriteLine(luku);
            Console.WriteLine(uusi);
        }
    }
}
