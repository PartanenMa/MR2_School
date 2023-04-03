using System;

namespace Satunnaisuus_harjoitus3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Montako lukua arvotaan?");
            int maara = Convert.ToInt32(Console.ReadLine());
            Random r = new Random();
            for(int i = 0; i < maara; i++) {
                int satunnainen_luku = r.Next(1,50);
                Console.WriteLine(satunnainen_luku);
            }
        }
    }
}
