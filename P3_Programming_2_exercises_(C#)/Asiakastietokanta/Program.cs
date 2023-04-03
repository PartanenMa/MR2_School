using System;
using System.Collections.Generic;

namespace Asiakastietokanta
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tietokanta:
            List<Henkilo> tietokanta = new List<Henkilo>();

            //10 henkilöä tietokantaan:
            Henkilo henkilo1 = new Henkilo("Pelle", "Hermanni", "Rakennusliitto", 5);
            tietokanta.Add(henkilo1);
            Henkilo henkilo2 = new Henkilo("Jaska", "Jokunen", "Tehdastyöliitto", 3);
            tietokanta.Add(henkilo2);
            Henkilo henkilo3 = new Henkilo("Aatu", "Apina", "Maatalousliitto", 1);
            tietokanta.Add(henkilo3);
            Henkilo henkilo4 = new Henkilo("Aku", "Ankka", "Rakennusliitto", 6);
            tietokanta.Add(henkilo4);
            Henkilo henkilo5 = new Henkilo("Roope", "Ankka", "Tehdastyöliitto", 7);
            tietokanta.Add(henkilo5);
            Henkilo henkilo6 = new Henkilo("Matti", "Meikäläinen", "Maatalousliitto", 2);
            tietokanta.Add(henkilo6);
            Henkilo henkilo7 = new Henkilo("Tapio", "Lapio", "Rakennusliitto", 8);
            tietokanta.Add(henkilo7);
            Henkilo henkilo8 = new Henkilo("Mökki", "Make", "Tehdastyöliitto", 12);
            tietokanta.Add(henkilo8);
            Henkilo henkilo9 = new Henkilo("Pussi", "Jussi", "Maatalousliitto", 9);
            tietokanta.Add(henkilo9);
            Henkilo henkilo10 = new Henkilo("Eetu", "Epäkelpo", "Rakennusliitto", 10);
            tietokanta.Add(henkilo10);

            //UI:
            while(true) {
                Console.WriteLine("Anna valinta:");
                Console.WriteLine("1. Listaa kaikki");
                Console.WriteLine("2. Anna korotus");
                Console.WriteLine("3. Lisää henkilö");
                Console.WriteLine("4. Lopeta");
                Console.WriteLine();
                string valinta = Console.ReadLine();
                Console.WriteLine();
                if(valinta == "4" || valinta == "4.") {
                    break;
                }else if(valinta == "1" || valinta == "1.") {
                    foreach(Henkilo henkilo in tietokanta) {
                        Console.WriteLine(henkilo.etunimi + " " + henkilo.sukunimi + ", " + henkilo.tessi + ", " + henkilo.vero + "%, " + henkilo.kokemus + " vuoden kokemus.");
                        Console.WriteLine("Tienaa yhteensä: " + Convert.ToInt32(henkilo.palkka) + " euroa.");
                        Console.WriteLine("Verojen jälkeen maksetaan: " + Convert.ToInt32(henkilo.kateinen) + " euroa.");
                        Console.WriteLine();
                    }
                    Console.WriteLine("Kaikki henkilöt listattu!");
                    Console.WriteLine();
                }else if(valinta == "2" || valinta == "2.") {
                    foreach(Henkilo henkilo in tietokanta) {
                        henkilo.korotus();
                    }
                    Console.WriteLine();
                    Console.WriteLine("Kaikki henkilöt saivat korotuksen!");
                    Console.WriteLine();
                }else if(valinta == "3" || valinta == "3.") {
                    Henkilo lisattyHenkilo = new Henkilo("Lisätty", "Henkilö", "Rakennusliitto", 1);
                    tietokanta.Add(lisattyHenkilo);
                    Console.WriteLine("Uusi henkilö lisätty tietokantaan!");
                    Console.WriteLine();
                }else{
                    Console.WriteLine("Tuntematon valinta! Yritä uudelleen!");
                    Console.WriteLine();
                }
            }
            //Lopetus:
            Console.WriteLine("Ohjelma lopetettu!");
        }
    }
}
