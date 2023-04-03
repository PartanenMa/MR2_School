using System;

namespace Ehtolauseet_harjoitus1
{
    class Program
    {
        static void Main(string[] args)
        {
            string etunimi = "Manu";
            int ika = 23;
            if(etunimi ==  "Manu" && ika == 23) {
                Console.WriteLine("Moi " + etunimi + "!");
            }else{
                Console.WriteLine("henkilö ei tunnistettu");
            }
        }
    }
}
