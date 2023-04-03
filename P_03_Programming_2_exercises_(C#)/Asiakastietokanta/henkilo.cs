using System;

namespace Asiakastietokanta
{
    class Henkilo {
        public string etunimi {private set; get;}
        public string sukunimi {private set; get;}
        public string tessi {private set; get;}
        public int kokemus {private set; get;}
        public double palkka {private set; get;}
        public double kateinen {private set; get;}
        public double veroprosentti {private set; get;}
        public int vero {private set; get;}

        public Henkilo(string etunimi, string sukunimi, string tessi, int kokemus) {
            this.etunimi = etunimi;
            this.sukunimi = sukunimi;
            this.tessi = tessi;
            this.kokemus = kokemus;
            this.veroprosentti = 0.20;
            this.vero = 20;
            Tyoehtosopimus TES = new Tyoehtosopimus(this.tessi, this.kokemus);
            this.palkka = TES.pohjapalkka;
            this.kateinen = this.palkka - (this.palkka * this.veroprosentti);
        }

        public void korotus() {
            this.palkka = this.palkka + (this.palkka * 0.03);
            this.kateinen = this.palkka - (this.palkka * this.veroprosentti);
            Console.WriteLine(this.etunimi + " " + this.sukunimi +  " sai korotuksen!");
        }
    }
}