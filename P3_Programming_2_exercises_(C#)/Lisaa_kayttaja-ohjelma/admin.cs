using System;

namespace Lisaa_kayttaja_ohjelma
{
    class Admin
    {
        public string tunnus {private set; get;}
        public string salasana {private set; get;}

        public Admin(string tunnus, string salasana) {
            this.tunnus = tunnus;
            this.salasana = salasana;
        }

        public bool testaa(string onkoTunnus, string onkoSalasana) {
            if(this.tunnus == onkoTunnus && this.salasana == onkoSalasana) {
                return true;
            }
            return false;
        }

        public string luo() {
            return "Käyttajä: " + this.tunnus + " luotu" ;
        } 

        public string ohje() {
            return "--Kirjautuminen--" + "\n" + "Syötä käyttäjätunnus ja salasana!";

        }
    }
}