using System;

namespace Satunnaisuus_harjoitus2
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true) {
                Console.WriteLine("Kirjoita eka luku:");
                int eka = Convert.ToInt32(Console.ReadLine());
                if(eka is int) {
                    Console.WriteLine("Kirjoita toka luku:");
                    int toka = Convert.ToInt32(Console.ReadLine());
                    if(toka is int) {
                        Random r = new Random();
                        int satunnainen_luku = r.Next(eka,toka);
                        Console.WriteLine(satunnainen_luku);
                    }else{
                        break;
                }
                }else{
                    break;
                }
            }
            Console.WriteLine("Ohjelma lopetettu!");
        }
    }
}
