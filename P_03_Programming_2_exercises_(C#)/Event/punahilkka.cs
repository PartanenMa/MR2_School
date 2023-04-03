using System;
namespace Event{
    
    class punahilkka
    {
        int punahilkanKori = 0;
        OmenaKori omenakori = new OmenaKori();
        //////////////
        private readonly PoistaYksi _poistayksi;
        public punahilkka(PoistaYksi _poistayksi){
            this._poistayksi = _poistayksi;
            this._poistayksi.PoistoTriggeri += handlaaPoisto;
        }

        public void handlaaPoisto(){
            bool onko_tyhja = false;
            Console.WriteLine("Yksi poistettiin");
            if(omenakori.otaYksi() == true) {
                onko_tyhja = true;
            }
            if(onko_tyhja == true) {
                Console.WriteLine("Nyt jäi Punahilkka ilman omenaa :(");
            }else if(onko_tyhja == false) {
                punahilkanKori++;
                Console.WriteLine("Omenoita Punahilkka: " + punahilkanKori);
            }
        }

        public void varasta() {
            this.punahilkanKori = this.punahilkanKori + 4;
            Console.WriteLine("Punahilkan korissa omenoita " + this.punahilkanKori);
        }
    }
}