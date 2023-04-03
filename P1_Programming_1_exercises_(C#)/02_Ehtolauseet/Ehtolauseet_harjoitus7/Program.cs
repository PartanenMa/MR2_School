using System;

namespace Ehtolauseet_harjoitus7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjoita eka sana: ");
            string eka_sana = Console.ReadLine();
            Console.WriteLine("Kirjoita toka sana: ");
            string toka_sana = Console.ReadLine();
            int ekan_pituus = eka_sana.Length;
            int tokan_pituus = toka_sana.Length;
            if(ekan_pituus > tokan_pituus) {
                Console.WriteLine(eka_sana);
            }else if(tokan_pituus > ekan_pituus) {
                Console.WriteLine(toka_sana);
            }else{
                Console.WriteLine(ekan_pituus + tokan_pituus);
            }
        }
    }
}
