using System;

namespace Ehtolauseet_harjoitus5
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku = 10;
            if(luku % 2 == 0) {
                Console.WriteLine("parillinen");
            }else{
                Console.WriteLine("pariton");
            }
        }
    }
}
