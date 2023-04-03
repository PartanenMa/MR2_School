using System;

namespace Satunnaisuus_harjoitus1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int random_int = r.Next(0,100);
            Console.WriteLine(random_int);
        }
    }
}
