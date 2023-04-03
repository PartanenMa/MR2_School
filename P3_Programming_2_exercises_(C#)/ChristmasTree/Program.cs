using System;

namespace ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int korkeus = 10;
            PrintChristmasTree(korkeus);
        }
        // Toiminta:
        //   Metodi tulostaa halutun korkuisen joulukuusen.
        // Parametrit:
        //   height = joulukuusen korkeus riveinä
        static void PrintChristmasTree(int height)
        {
            char space = Convert.ToChar(" ");
            char star = Convert.ToChar("*");
            PrintChars(height - 1, space, false);
            PrintChars(1, star, true);
            for(int i = 2; i<= height; i++) {
                PrintChars(height - i, space, false);
                PrintChars(i + (i - 1), star, true);
            }
            for(int i = 1; i <= 2; i++) {
                PrintChars(height - 2, space, false);
                PrintChars(3, star, true);
            }
        }
        // Toiminta:
        //   Metodi tulostaa yksittäistä merkkiä tietyn määrän. Metodi voi myös tulostaa rivinvaihdon, jos halutaan.
        // Parametrit:
        //   count = tulostettavien merkkien lukumäärä
        //   printChar = tulostettava merkki
        //   newLine = tulostetaanko lopuksi rivinvaihto, oletuksena true
        static void PrintChars(int count, char printChar, bool newLine = true)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(printChar);
            }
            if (newLine)   // Huom. pelkkä newLine tuottaa saman totuusarvon kuin lauseke newLine == true
            {
                Console.WriteLine();
            }
        }
    }
}
