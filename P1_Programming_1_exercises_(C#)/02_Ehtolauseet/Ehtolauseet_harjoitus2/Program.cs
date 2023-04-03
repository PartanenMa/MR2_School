using System;

namespace Ehtolauseet_harjoitus2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool moottori = false;
            int lampotila = 31;
            if(lampotila > 30) {
                moottori = true;
            }
            if(moottori == true) {
                Console.WriteLine("motor is running");
            }else{
                Console.WriteLine("motor is not running");
            }
        }
    }
}
