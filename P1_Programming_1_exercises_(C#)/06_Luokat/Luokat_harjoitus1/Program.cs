using System;

namespace Luokat_harjoitus1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car auto = new Car("Saab");
            Console.WriteLine(auto.valmistaja + ", " + auto.kilometrit);
            auto.drive(100);
            Console.WriteLine(auto.valmistaja + ", " + auto.kilometrit);
        }
    }

    class Car {
        public string valmistaja {private set; get;}
        public int kilometrit {private set; get;}

        public Car(string valmistaja) {
            this.valmistaja = valmistaja;
            this.kilometrit = 0;
        }

        public void drive(int maara) {
            this.kilometrit = this.kilometrit + maara;
        }
    }
}
