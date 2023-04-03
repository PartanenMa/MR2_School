using System;
namespace Event{
    
    class omenavaras1
    {
        private string varkaanNimi;
        private int varkaanKori = 0; 
        OmenaKori omenakori = new OmenaKori();
        //////////////
        private readonly PoistaYksi _poistayksi;
        public omenavaras1(PoistaYksi _poistayksi, string varkaannimi) {
            this.varkaanNimi = varkaannimi;
            this._poistayksi = _poistayksi;
            this._poistayksi.PoistoTriggeri += handlaaPoisto;
        }

        public void handlaaPoisto(){ 
            Console.WriteLine("1 poistettiin");
            omenakori.otaYksi();           
            varkaanKori++;
            Console.WriteLine("Omenoita " + varkaanNimi + ":" + varkaanKori);
        }

        public void poista() {
            this.varkaanKori--;
        }
    }
}