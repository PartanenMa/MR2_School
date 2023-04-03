using System;

namespace Toistolauseet_harjoitus15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Montako arvoa syötetään?");
            int maara = Convert.ToInt32(Console.ReadLine());
            string sanat = "";
            for(int i = 0; i < maara; i++) {
                Console.WriteLine("Syötä merkkijono:");
                string sana = Console.ReadLine();
                if(sana == "") {
                    i--;
                    continue;
                }
                sanat = sanat + sana;
            }
            Console.WriteLine(sanat.Length);
        }
    }
}
