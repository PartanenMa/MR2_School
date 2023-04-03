using System;

namespace Ehtolauseet_harjoitus8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valitse joko a tai b.");
            string vastaus = Console.ReadLine();
            if(vastaus == "a") {
                Console.WriteLine("hieno valinta");
            }else if(vastaus == "b") {
                Console.WriteLine("loistava valinta");
            }else{
                Console.WriteLine("Virheellinen syöte!");
            }
        }
    }
}
