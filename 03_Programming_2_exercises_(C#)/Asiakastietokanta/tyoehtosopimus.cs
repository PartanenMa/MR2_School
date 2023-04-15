using System;

namespace Asiakastietokanta
{
    class Tyoehtosopimus {
        public string nimi {private set; get;}
        public int kokemus {private set; get;}
        public double pohjapalkka {private set; get;}
        public double kokemuslisa {private set; get;}

        public Tyoehtosopimus(string nimi, int kokemus) {
            this.nimi = nimi;
            this.kokemus = kokemus;
            if(this.nimi == "Rakennusliitto") {
                this.pohjapalkka = 2000;
                if(this.kokemus >= 5) {
                    this.kokemuslisa = 0.05;
                    this.pohjapalkka = this.pohjapalkka + (this.pohjapalkka * this.kokemuslisa);
                }else if(this.kokemus >= 10) {
                    this.kokemuslisa = 0.10;
                    this.pohjapalkka = this.pohjapalkka + (this.pohjapalkka * this.kokemuslisa);
                }
            }else if(this.nimi == "Tehdastyöliitto") {
                this.pohjapalkka = 1600;
                if(this.kokemus >= 5) {
                    this.kokemuslisa = 0.05;
                    this.pohjapalkka = this.pohjapalkka + (this.pohjapalkka * this.kokemuslisa);
                }else if(this.kokemus >= 10) {
                    this.kokemuslisa = 0.10;
                    this.pohjapalkka = this.pohjapalkka + (this.pohjapalkka * this.kokemuslisa);
                }
            }else if(this.nimi == "Maatalousliitto") {
                this.pohjapalkka = 1300;
                if(this.kokemus >= 5) {
                    this.kokemuslisa = 0.05;
                    this.pohjapalkka = this.pohjapalkka + (this.pohjapalkka * this.kokemuslisa);
                }else if(this.kokemus >= 10) {
                    this.kokemuslisa = 0.10;
                    this.pohjapalkka = this.pohjapalkka + (this.pohjapalkka * this.kokemuslisa);
                }
            }else{
                this.pohjapalkka = 0;
                this.kokemuslisa = 0;
            }
        }
    }
}