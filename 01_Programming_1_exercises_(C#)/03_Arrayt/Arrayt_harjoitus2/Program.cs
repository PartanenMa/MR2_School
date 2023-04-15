using System;

namespace Arrayt_harjoitus2
{
    class Program
    {
        static void Main(string[] args)
        {
            double vastaus = 0.0;
            double[] taulukko = {1.0, 2.0, 3.0};
            foreach(double luku in taulukko) {
                vastaus = vastaus + luku;
            }
            Console.WriteLine(vastaus);
        }
    }
}
