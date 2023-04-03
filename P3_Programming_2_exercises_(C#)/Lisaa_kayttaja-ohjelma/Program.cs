using System;
using System.Collections.Generic;

namespace Lisaa_kayttaja_ohjelma
{
    class Program
    {
        static void Main(string[] args)
        {
            //Käyttäjälistojen luominen:
            List<Admin> adminit = new List<Admin>();
            List<Peruskayttaja> peruskayttajat = new List<Peruskayttaja>();
           
            //Kayttäjien luominen ja lisääminen listoihin:
            Admin administrator = new Admin("admin", "adminsalasana");
            adminit.Add(administrator);
            Console.WriteLine(administrator.luo());
            Peruskayttaja peruskayttaja1 = new Peruskayttaja("perus1", "salasana1");
            peruskayttajat.Add(peruskayttaja1);
            Console.WriteLine(peruskayttaja1.luo());
            Peruskayttaja peruskayttaja2 = new Peruskayttaja("perus2", "salasana2");
            peruskayttajat.Add(peruskayttaja2);
            Console.WriteLine(peruskayttaja2.luo());
            Console.WriteLine();
            
            //Kirjautuminen:
            Console.WriteLine("Anna käyttäjätunnus");
            string tunnus = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Anna salasana");
            string salasana = Console.ReadLine();
            Console.WriteLine();
            
            //Käyttäjän tarkistaminen:
            while(true) {
                bool lopeta = false;
                bool onkoAdmin = false;
                //Onko admin:
                foreach(Admin kayttajaA in adminit) {
                    if(kayttajaA.testaa(tunnus, salasana) == true) {
                        Console.WriteLine("Kirjautuminen tunnuksella " + kayttajaA.tunnus + " onnistui!");
                        onkoAdmin = true;
                        break;
                    }
                }
                //Jos on admin:
                if(onkoAdmin == true) {
                    //Konsolinäkymä:
                    while(true) {
                        Console.WriteLine("Kirjautunut käyttäjä admin");
                        Console.WriteLine();
                        Console.WriteLine("Mitä haluat tehdä?");
                        Console.WriteLine("1. Listaa käyttäjät");
                        Console.WriteLine("2. Lisää käyttäjä");
                        Console.WriteLine("Lopeta(Enter)");
                        string komento = Console.ReadLine();
                        //Lopettaminen:
                        if(komento == "") {
                            lopeta = true;
                            break;
                        //Listaa käyttäjät:
                        }else if(komento == "1") {
                            Console.WriteLine("---Perus---");
                            foreach(Peruskayttaja kayttajaP in peruskayttajat) {
                                Console.WriteLine(kayttajaP.tunnus);
                            }
                            Console.WriteLine();
                            Console.WriteLine("---Admin---");
                            foreach(Admin kayttajaA in adminit) {
                                Console.WriteLine(kayttajaA.tunnus);
                            }
                            Console.WriteLine();
                        //Luo käyttäjä:
                        }else if(komento == "2") {
                            Console.WriteLine("Anna käyttäjätunnus");
                            string uusiTunnus = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("Anna salasana");
                            string uusiSalasana = Console.ReadLine();
                            Console.WriteLine("Admin oikeudet: Kyllä (K) / Ei (Enter)");
                            string adminoikeudet = Console.ReadLine();
                            if(adminoikeudet == "K" || adminoikeudet == "k") {
                                Admin uusiAdmin = new Admin(uusiTunnus, uusiSalasana);
                                adminit.Add(uusiAdmin);
                                Console.WriteLine(uusiAdmin.luo());
                                Console.WriteLine();
                            }else{
                                Peruskayttaja uusiPeruskayttaja = new Peruskayttaja(uusiTunnus, uusiSalasana);
                                peruskayttajat.Add(uusiPeruskayttaja);
                                Console.WriteLine(uusiPeruskayttaja.luo());
                                Console.WriteLine();
                            }
                        }
                    }            
                }
                if(lopeta == true) {
                    break;
                }
                //Onko peruskäyttäjä:
                foreach(Peruskayttaja kayttajaP in peruskayttajat) {
                    if(kayttajaP.testaa(tunnus, salasana) == true) {
                        Console.WriteLine("Kirjautuminen tunnuksella " + kayttajaP.tunnus + " onnistui!");
                        lopeta = true;
                        break;
                    }
                }
                if(lopeta == true) {
                    break;
                }else{
                    Console.WriteLine("Kirjautuminen epäonnistui!");
                    break;
                }
            }
            //Ohjelma päättyy:
            Console.WriteLine("Ohjelma lopetettu!");
        }
    }
}
