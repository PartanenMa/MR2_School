using System;
namespace Event{
    class OmenaKori
    {

        private int omenoita = 4;
        public bool otaYksi(){
            if(this.omenoita == 0) {
                return true;
            }else if(this.omenoita > 0) {
                omenoita--;
                return false;
            }           
        }  
        public void omenoitaNyt(){
            Console.WriteLine("Omenoita korissa jäljellä " + omenoita); 
        }  
    }
    class Program
    {

        static void Main()
        { 
            OmenaKori omenakori = new OmenaKori();
            omenakori.omenoitaNyt();

            PoistaYksi yhdenpoisto = new PoistaYksi();
            
            
            omenavaras1 v1 = new omenavaras1(yhdenpoisto,"Sheppo");
            omenavaras1 v2 = new omenavaras1(yhdenpoisto,"Ismo");
            omenavaras1 v3 = new omenavaras1(yhdenpoisto, "Ulla");
            omenavaras1 v4 = new omenavaras1(yhdenpoisto, "Oona");
            punahilkka punahilkka = new punahilkka(yhdenpoisto);

            yhdenpoisto.Poista();

            omenakori.omenoitaNyt();
            Console.WriteLine("Haluatko, että Punahilkka vie muiden omenat?");
            Console.WriteLine("k = kyllä");
            string vastaus = Console.ReadLine();
            if(vastaus == "k") {
                v1.poista();
                v2.poista();
                v3.poista();
                v4.poista();
                punahilkka.varasta();
            }else if(vastaus == "e") {
                Console.WriteLine("Jääköön ilman");
            }
        }
    }
}