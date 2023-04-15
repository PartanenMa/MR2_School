using System;

namespace Ehtolauseet_harjoitus9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjoita eka sana: ");
            string eka = Console.ReadLine();
            Console.WriteLine("Kirjoita toka sana: ");
            string toka = Console.ReadLine();
            if(eka == "koulu" && toka == "ohjelmointi" || eka == "ohjelmointi" && toka == "koulu") {
                Console.WriteLine("Hienot sanat!");
            }else{
                Console.WriteLine("Ei huonot sanat.");
            }
        }
    }
}
