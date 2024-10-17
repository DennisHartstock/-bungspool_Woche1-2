////////////////////////////////////////////90////////////////////////////////////////////
using System;

namespace Übung03ZufallsBedingungen
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Aufgabe:
             * 
             *   Erzeugen Sie innerhalb einer Schleife pro Durchlauf jeweils 
             *   3 Gleitkommazufallszahlen. Ihre Schleife soll abbrechen, 
             *   wenn die folgenden 3 Bedingungen alle erfüllt sind:
             * 
             *     - Bedingung A lautet, dass a grösser ist als b
             *     - Bedingung B lautet, dass c zwischen a und b liegt
             *     - Bedingung C lautet, dass der Mittelwert 
             *                           von a, b und c grösser als 0.6 ist
             * 
             *   Geben Sie innerhalb der Schleife die Werte für a, b und c 
             *   jeweils zur Kontrolle aus und stellen Sie fest, wieviele 
             *   Durchläufe notwendig waren, um die Schleife zu beenden, 
             *   d.h. bis die Schleifenbedingung zu 'false' ausgewertet wurde.
             */
            bool bedA, bedB, bedC;
            double a, b, c;
            int anzahl = 0;

            // Zufallsalgorithmus initialisieren
            Random zufall = new Random();

            do
            {
                a = zufall.NextDouble();
                b = zufall.NextDouble();
                c = zufall.NextDouble();

                bedA = a > b;
                bedB = c > b && c < a;
                bedC = (a + b + c) / 3 > 0.6;

                anzahl = anzahl + 1;
                //anzahl++;

                // Formatierung: - {0,3}  -> 0-tes Argument hat die Ausgabenbreite 3
                //               - {1:F4} -> 1-tes Argument ist Gleitkommazahl 
                //                           mit 4 Nachkommastellen Genauigkeit
                //               - {2:F4}, {3:F4} dto.
                Console.WriteLine(" {0,3}  {1:F4}  {2:F4}  {3:F4}", anzahl, a, b, c);

            } while (!(bedA && bedB && bedC));

            Console.ReadLine();
        }
    }
}
