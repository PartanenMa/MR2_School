using System;

namespace Laskin
{
    class Program
    {
        static int kahden_summa(int eka, int toka) {
            return eka + toka;
        }

        static int kahden_erotus(int eka, int toka) {
            return eka - toka;
        }

        static int kahden_kertominen(int eka, int toka) {
            return eka * toka;
        }

        static int kahden_jako(int eka, int toka) {
            return eka / toka;
        }
        static void Main(string[] args)
        {
            //Aloitustoimenpiteet:
            Console.WriteLine("Valitse laskin");
            Console.WriteLine("1. Kahden luvun laskin");
            Console.WriteLine("2. n luvun laskin");
            int valinta = Convert.ToInt32(Console.ReadLine());

            //Kohta 1:
            if(valinta == 1) {
                Console.WriteLine("Anna luku 1");
                int luku1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Anna luku 2");
                int luku2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Valitse laskutoimitus:");
                Console.WriteLine("1. Summaa (+)");
                Console.WriteLine("2. Miinusta (-)");
                Console.WriteLine("3. Kerro (*)");
                Console.WriteLine("4. Jaa (/)");
                int laskutoimitus = Convert.ToInt32(Console.ReadLine());
                if(laskutoimitus == 1) {
                    Func<int, int, int> summa = kahden_summa;
                    Console.WriteLine("Vastaus: " + summa(luku1, luku2));
                }else if(laskutoimitus == 2) {
                    Func<int, int, int> miinusta = kahden_erotus;
                    Console.WriteLine("Vastaus: " + miinusta(luku1, luku2));
                }else if(laskutoimitus == 3) {
                    Func<int, int, int> kerro = kahden_kertominen;
                    Console.WriteLine("Vastaus: " + kerro(luku1, luku2));
                }else if(laskutoimitus == 4) {
                    Func<int, int, int> jaa = kahden_jako;
                    Console.WriteLine("Vastaus: " + jaa(luku1, luku2));
                }

            //Kohta 2:
            }else if(valinta == 2) {
                bool lopeta = false;
                int lopputulos = 0;
                while(true) {
                    Console.WriteLine("Anna luku:");
                    int luku1 = Convert.ToInt32(Console.ReadLine());
                    while(true) {
                        Console.WriteLine("Anna luku:");
                        int luku2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Valitse laskutoimitus:");
                        Console.WriteLine("1. Summaa (+)");
                        Console.WriteLine("2. Miinusta (-)");
                        Console.WriteLine("3. Kerro (*)");
                        Console.WriteLine("4. Jaa (/)");
                        Console.WriteLine("5. Lopeta");
                        int laskutoimitus = Convert.ToInt32(Console.ReadLine());
                        if(laskutoimitus == 1) {
                            Func<int, int, int> summa = kahden_summa;
                            luku1 = summa(luku1, luku2);
                            lopputulos = luku1;
                            Console.WriteLine("Tulos: " + luku1);
                        }else if(laskutoimitus == 2) {
                            Func<int, int, int> miinusta = kahden_erotus;
                            luku1 = miinusta(luku1, luku2);
                            lopputulos = luku1;
                            Console.WriteLine("Tulos: " + luku1);
                        }else if(laskutoimitus == 3) {
                            Func<int, int, int> kerro = kahden_kertominen;
                            luku1 = kerro(luku1, luku2);
                            lopputulos = luku1;
                            Console.WriteLine("Tulos: " + luku1);
                        }else if(laskutoimitus == 4) {
                            Func<int, int, int> jaa = kahden_jako;
                            luku1 = jaa(luku1, luku2);
                            lopputulos = luku1;
                            Console.WriteLine("Tulos: " + luku1);
                        }else if(laskutoimitus == 5) {
                            lopeta = true;
                            break;
                        }
                        Console.WriteLine("Jatka laskemista, paina Enter");
                        Console.WriteLine("Lopeta kirjoittamalla Lopeta tai L");
                        string lopetetaanko = Console.ReadLine();
                        if(lopetetaanko == "Lopeta" || lopetetaanko == "L") {
                            lopeta = true;
                            break;
                        }else if(lopetetaanko == "") {
                            continue;
                        }
                    }
                    if(lopeta == true) {
                        break;
                    }
                }
                Console.WriteLine("Lopputulos: " + lopputulos);
            }
            //Lopetus:
            Console.WriteLine("Ohjelma lopetettu!");
        }
    }
}
