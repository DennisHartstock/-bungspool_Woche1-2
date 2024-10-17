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

            Random random = new Random();
            int durchlaeufe = 0;
            double a, b, c;

            while (true)
            {
                a = random.NextDouble();
                b = random.NextDouble();
                c = random.NextDouble();
                durchlaeufe++;

                Console.WriteLine($"Durchlauf {durchlaeufe}: a = {a:F4}, b = {b:F4}, c = {c:F4}");

                bool bedingungA = a > b;
                bool bedingungB = (c > b && c < a) || (c > a && c < b);
                double mittelwert = (a + b + c) / 3;
                bool bedingungC = mittelwert > 0.6;

                if (bedingungA && bedingungB && bedingungC)
                {
                    Console.WriteLine("Bedingungen erfüllt!");
                    break;
                }
            }

            Console.WriteLine($"Anzahl der Durchläufe: {durchlaeufe}");

            Console.ReadLine();
        }
    }
}

