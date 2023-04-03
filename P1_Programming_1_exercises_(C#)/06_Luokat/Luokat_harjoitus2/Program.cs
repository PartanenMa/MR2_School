using System;

namespace Luokat_harjoitus2
{
    class Program
    {
        static void Main(string[] args)
        {
            Address osoite = new Address("Apinankatu", 69);
            osoite.print();
            osoite.change_address("Jokukatu", 11);
            osoite.print();
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
