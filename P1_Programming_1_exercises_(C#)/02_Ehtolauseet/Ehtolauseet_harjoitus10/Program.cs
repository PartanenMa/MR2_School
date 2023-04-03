using System;

namespace Ehtolauseet_harjoitus10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjoita eka luku: ");
            int eka = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kirjoita toka luku: ");
            int toka = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(eka + toka);
        }
    }
}
