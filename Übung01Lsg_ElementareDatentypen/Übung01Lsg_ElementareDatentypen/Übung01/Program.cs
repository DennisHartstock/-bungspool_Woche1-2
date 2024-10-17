////////////////////////////////////////////90////////////////////////////////////////////

using System;

namespace Übung01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1.Aufgabe: Finden Sie die genaue positive und negative Grenze
             *            für den Datentyp 'int' heraus
             *
             *    (a) durch fortgesetztes Addieren bis zum Überlauf 
             *        (Hinweis: while-Schleife)
             *    (b) durch Nachdenken über das erforderliche Bitmuster
             *
             *    Ausgabe des jeweiligen Resultats bitte sowohl dezimal
             *    als auch hexadezimal
             */

            // (a)
            int intNew = 1, intOld = 0;
            while (intOld <= intNew)
            {
	            intOld = intNew;
	            intNew = intNew + 1;
            }

            // (b)
            int maxInt = 0x7FFFFFFF;
            int minInt;

            // C# statements can execute in either checked or unchecked context:
            //   - in a checked context (which is on by default),
            //     arithmetic overflow raises an exception 
            //   - in an unchecked context, arithmetic overflow is ignored
            //     and the result is truncated. 
            unchecked
            {
                // der Hexadezimal-Wert '0x80000000' wird als 'uint'-Typ interpretiert,
                // hat also den Dezimal-Wert '2147483648' und überschreitet somit die
                // obere Schranke von 'int', kann also eigentlich (für den Compiler)
                // nicht nach 'int' konvertiert werden
                minInt = (int)0x80000000;
            }

            Console.WriteLine("\n(a) Positive Grenze (dezimal):     " + intOld);
            Console.WriteLine("(a) Positive Grenze (hexadezimal): {0:X08}", intOld);
            Console.WriteLine("(b) Positive Grenze (dezimal):     " + maxInt);
            Console.WriteLine("(b) Positive Grenze (hexadezimal): {0:X08}", maxInt);

            Console.WriteLine("\n(a) Negative Grenze (dezimal):     " + intNew);
            Console.WriteLine("(a) Negative Grenze (hexadezimal): {0:X08}", minInt);
            Console.WriteLine("(b) Negative Grenze (dezimal):     " + intNew);
            Console.WriteLine("(b) Negative Grenze (hexadezimal): {0:X08}", minInt);

	        /*
	         * 3.Aufgabe: Speichern Sie in Variablen der Datentypen
	         *
	         *            (a) sbyte, byte
	         *            (b) short, ushort
             *            (c) long, ulong
	         *
	         *            den jeweils größten und kleinsten darstellbaren Wert ab
	         *            und geben Sie diesen aus.
	         *
	         *            Prüfen Sie jeweils, was beim Überlauf passiert.
	         */

            // (a) sbyte/byte
	        sbyte sb = 0x7f;
	        Console.WriteLine("\nObere Schranke von 'sbyte':     " + sb);
            Console.WriteLine("Inkrement der oberen Schranke:  " + ++sb);
            unchecked
            {
                sb = (sbyte)0x80;
            }
	        Console.WriteLine("Untere Schranke von 'sbyte':    " + sb);
            Console.WriteLine("Dekrement der unteren Schranke: " + --sb);

	        byte b = 0xff;
	        Console.WriteLine("\nObere Schranke von 'byte':      " + b);
            Console.WriteLine("Inkrement der oberen Schranke:  " + ++b);
            b = 0x00;
	        Console.WriteLine("Untere Schranke von 'byte':     " + b);
            Console.WriteLine("Dekrement der unteren Schranke: " + --b);

            // (b) short/ushort
            short s = 0x7fff;
            Console.WriteLine("\nObere Schranke von 'short':     " + s);
            Console.WriteLine("Inkrement der oberen Schranke:  " + ++s);
            unchecked
            {
                s = (short)0x8000;
            }
            Console.WriteLine("Untere Schranke von 'short':    " + s);
            Console.WriteLine("Dekrement der unteren Schranke: " + --s);

            ushort us = 0xffff;
            Console.WriteLine("\nObere Schranke von 'ushort':    " + us);
            Console.WriteLine("Inkrement der oberen Schranke:  " + ++us);
            us = 0x0000;
            Console.WriteLine("Untere Schranke von 'ushort':   " + us);
            Console.WriteLine("Dekrement der unteren Schranke: " + --us);

            // (c) long/ulong
            long l = 0x7fffffffffffffff;
            Console.WriteLine("\nObere Schranke von 'long':      " + l);
            Console.WriteLine("Inkrement der oberen Schranke:  " + ++l);
            unchecked
            {
                l = (long)0x8000000000000000;
            }
            Console.WriteLine("Untere Schranke von 'long':     " + s);
            Console.WriteLine("Dekrement der unteren Schranke: " + --s);

            ulong ul = 0xffffffffffffffff;
            Console.WriteLine("\nObere Schranke von 'ulong':     " + ul);
            Console.WriteLine("Inkrement der oberen Schranke:  " + ++ul);
            us = 0x0000000000000000;
            Console.WriteLine("Untere Schranke von 'ulong':    " + ul);
            Console.WriteLine("Dekrement der unteren Schranke: " + --ul);

            /*
             * 3.Aufgabe: Berechnen Sie die Wahrscheinlichkeit, 
             *            einen "Sechser" im Lotto zu tippen:
             *
             *            (a) Berechnen Sie zunächst die Anzahl der Möglichkeiten
             *                6 Zahlen/Kreuze auf 49 Felder zu verteilen 
             *
             *                Hinweis: Der Binomialkoeffizienz "n über k" ist eine
             *                         mathematische Funktion, mit der sich eine der
             *                         Grundaufgaben der Kombinatorik lösen lässt.
             *
             *                         Er gibt an, auf wie viele verschiedene Arten
             *                         man k Objekte aus einer Menge von n verschiedenen
             *                         Objekten auswählen kann (ohne Zurücklegen und
             *                         ohne Beachtung der Reihenfolge)
             *
             *                         "n über k" == n! / k! * (n-k)!
             *
             *                In unserer Aufgabe:
             *
             *						   49*48*47*46*45*44 / 1*2*3*4*5*6
             *
             *            (b) Die Wahrscheinlichkeit auf einen "Sechser"
             *                ist "1 / Anzahl der Möglichkeiten"
             *
             *            Geben Sie beide Ergebnisse aus.
             */
            double anzVar = ((double)49 * 48 * 47 * 46 * 45 * 44) / (1 * 2 * 3 * 4 * 5 * 6);
            Console.WriteLine("\nAnzahl der Lotto-Ziehungsvarianten: " + anzVar);
            double probability = 1 / anzVar;
            Console.WriteLine("Sechser-Wahrscheinlichkeit: {0:F24}", probability);
        }
    }
}
