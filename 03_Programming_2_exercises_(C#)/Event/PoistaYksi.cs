using System;
namespace Event{
    
    class PoistaYksi
    {
        public delegate void PoistaHandler();
        public event PoistaHandler PoistoTriggeri;

        public void Poista()
        { 
            PoistaHandler poisto = PoistoTriggeri;
            PoistoTriggeri?.Invoke();
        }
    }
}