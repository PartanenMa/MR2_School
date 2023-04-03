using System;

namespace Funktiot_harjoitus1
{
    class Program
    {
        static void Main(string[] args)
        {
            string etunimi = "Manu";
            tulosta_etunimi(etunimi);
        }

        static void tulosta_etunimi(string nimi) {
            Console.WriteLine(nimi);
        }
    }
}
