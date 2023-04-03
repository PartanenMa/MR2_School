using System;

namespace Muuttujat_harjoitus6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            a = 12;
            b = a*4;
            a = 25;
            c = (b+a)/a;
            Console.WriteLine(c);
        }
    }
}
