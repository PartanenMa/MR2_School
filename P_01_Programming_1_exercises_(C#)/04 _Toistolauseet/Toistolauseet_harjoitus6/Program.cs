using System;

namespace Toistolauseet_harjoitus6
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] sanat = new string[3];
            int i = 0;
            while(i < 3) {
                Console.WriteLine("Kirjoita sana:");
                String sana = Console.ReadLine();
                sanat[i] = sana;
                i++;
            }
            int i2 = 2;
            while(i2 > -1) {
                Console.WriteLine(sanat[i2]);
                i2--;
            }
        }
    }
}
