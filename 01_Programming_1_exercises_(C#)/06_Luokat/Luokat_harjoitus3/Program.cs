using System;

namespace Luokat_harjoitus3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person henkilo = new Person("Jaska", 21);
            Console.WriteLine(henkilo.etunimi + ", " + henkilo.ika);
            henkilo.make_older();
            Console.WriteLine(henkilo.etunimi + ", " + henkilo.ika);
            henkilo.set_address(new Address("Apinankatu", 69));
            Console.WriteLine(henkilo.osoite);
        }
    }

    class Person {
        public string etunimi {private set; get;}
        public int ika {private set; get;}
        public Address osoite {private set; get;}

        public Person(string etunimi, int ika) {
            this.etunimi = etunimi;
            this.ika = ika;
        }

        public void set_address(Address uusi_osoite) {
            this.osoite = uusi_osoite;
        }

        public int make_older() {
            this.ika = this.ika + 1;
            return this.ika;
        }
    }

    class Address {
        public string katu {private set; get;}
        public int tontti {private set; get;}
        public Address(string katu, int tontti) {
            this.katu = katu;
            this.tontti = tontti;
        }

        public void change_address(string uusi_katu, int uusi_tontti) {
            this.katu = uusi_katu;
            this.tontti = uusi_tontti;
        }

        public void print() {
            Console.WriteLine(this.katu + ", " + this.tontti);
        }
    }
}
