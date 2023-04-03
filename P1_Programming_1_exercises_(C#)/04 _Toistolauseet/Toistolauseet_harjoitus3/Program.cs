using System;

namespace Toistolauseet_harjoitus3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sanat = new string[3]; 
            for(int i = 0; i < 3; i++) {
                Console.WriteLine("Kirjoita sana: ");
                string sana = Console.ReadLine();
                sanat[i] = sana;
            }
            for(int i = 2; i > -1; i--) {
                Console.WriteLine(sanat[i]);
            }
        }
    }
}
