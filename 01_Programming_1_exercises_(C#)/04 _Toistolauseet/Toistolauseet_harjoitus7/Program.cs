using System;

namespace Toistolauseet_harjoitus7
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] taulukko = new string[10];
            int i = 0;
            int vahennys = 10;
            while(true) {
                Console.WriteLine("Kirjoita sana: ");
                string sana = Console.ReadLine();
                if(sana == "lopeta" || i == 10) {
                    break;
                }
                taulukko[i] = sana;
                i++;
                vahennys--;
            }
            int sanat = 0;
            foreach(String rivi in taulukko) {
                sanat++;
            }
            sanat = sanat - vahennys;
            Console.WriteLine("Syötit " + sanat + " sanaa");
            string ensimmainen = taulukko[0];
            Console.WriteLine(ensimmainen);
            int viimeinen = taulukko.Length - vahennys - 1;
            Console.WriteLine(taulukko[viimeinen]);
            /*String pisin = "";
            foreach(String onkoPisin in taulukko) {
                if(onkoPisin.Length > pisin.Length) {
                    pisin = onkoPisin;
                }
            }
            Console.WriteLine(pisin);
            String lyhin = "";
            foreach(String onkoLyhin in taulukko) {
                if(onkoLyhin.Length < lyhin.Length) {
                    lyhin = onkoLyhin;
                }
            }
            Console.WriteLine(lyhin);*/
        }
    }
}
