using System;

namespace Ehtolauseet_harjoitus3
{
    class Program
    {
        static void Main(string[] args)
        {
            int eka = 3;
            int toka = 5;
            if(eka == 42 || toka == 42) {
                Console.WriteLine("42 löytyi!");
            }else{
                Console.WriteLine("42 ei löytynyt!");
            }
        }
    }
}
