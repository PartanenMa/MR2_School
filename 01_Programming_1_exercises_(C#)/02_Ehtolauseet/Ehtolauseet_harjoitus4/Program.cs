using System;

namespace Ehtolauseet_harjoitus4
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku = 201;
            if(luku < 100) {
                Console.WriteLine("arvo on aika pieni");
            }else if(luku == 100) {
                Console.WriteLine("arvo on sata");
            }else if(luku > 100) {
                Console.WriteLine("alkaa olla aika iso luku");
            }else if(luku > 200) {
                Console.WriteLine("nyt ollaan isoissa luvuissa");
            }
        }
    }
}
