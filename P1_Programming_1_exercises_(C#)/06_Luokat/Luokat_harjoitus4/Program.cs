using System;

namespace Luokka_harjoitus4
{
    class Program
    {
        static void Main(string[] args)
        {
            Hissi hissi = new Hissi(10);
            while(true) {
                Console.WriteLine("Valitse kerros[1 - 10]: ");
                int kohde = Convert.ToInt32(Console.ReadLine());
                if(kohde == 0) {
                    break;
                }
                hissi.start(kohde);
            }
            Console.WriteLine("Ohjelma lopetettu!");
        }
    }

    class Hissi {
        public int kerrokset {private set; get;}
        public int kerros {private set; get;}
        public bool onko_liikkeella {private set; get;}

        public Hissi(int max_kerrokset) {
            this.kerrokset = max_kerrokset;
            this.kerros = 1;
            this.onko_liikkeella = false;
        }

        public void start(int kohde) {
            Console.WriteLine("Starting up...");
            this.onko_liikkeella = true;
            if(kohde > this.kerros && kohde <= this.kerrokset) {
                for(int i = this.kerros; i <= this.kerrokset; i++) {
                    if(i == kohde) {
                        break;
                    }else if(i > this.kerros && i < kohde) {
                        hissin_sijainti();
                    }
                }
                this.kerros = kohde;
                this.onko_liikkeella = false;
                Console.WriteLine("Target floor " + "[" + kohde + "]" + " reached!");
            }else if(kohde < this.kerros && kohde >= 1) {
                for(int i = this.kerros; i >= 1; i--) {
                    if(i == kohde) {
                        break;
                    }else if(i < this.kerros && i > kohde) {
                        hissin_sijainti();
                    }
                }
                this.kerros = kohde;
                this.onko_liikkeella = false;
                Console.WriteLine("Target floor " + "[" + kohde + "]" + " reached!");
            }else {
                Console.WriteLine("ERROR!");
            }
        }

        public void hissin_sijainti() {
            for(int i = 1; i <= this.kerrokset; i++) {
                if(i == this.kerros) {
                    Console.Write("[" + i + "]");
                }
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
