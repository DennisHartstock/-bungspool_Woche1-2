////////////////////////////////////////////90////////////////////////////////////////////

using System;

namespace Übung01
{
    class Program
    {
        static void Main(string[] args)
        {

#if false
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

            int positiveBoundary = 0;
            int negativeBoundary = 0;

            // Positive Grenze finden
            try
            {
                while (true)
                {
                    positiveBoundary = checked(positiveBoundary + 1);
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine($"Positive Grenze (dezimal): {positiveBoundary}");
                Console.WriteLine($"Positive Grenze (hexadezimal): {positiveBoundary:X}");
            }

            // Negative Grenze finden
            try
            {
                while (true)
                {
                    negativeBoundary = checked(negativeBoundary - 1);
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine($"Negative Grenze (dezimal): {negativeBoundary}");
                Console.WriteLine($"Negative Grenze (hexadezimal): {negativeBoundary:X}");
            }
            Console.ReadLine();

#endif

#if false

            /*
             * 2.Aufgabe: Speichern Sie in Variablen der Datentypen
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

            // (a) sbyte, byte
            sbyte minSByte = sbyte.MinValue;
            sbyte maxSByte = sbyte.MaxValue;
            byte minByte = byte.MinValue;
            byte maxByte = byte.MaxValue;

            Console.WriteLine($"sbyte: Min = {minSByte}, Max = {maxSByte}");
            Console.WriteLine($"byte: Min = {minByte}, Max = {maxByte}");

            // (b) short, ushort
            short minShort = short.MinValue;
            short maxShort = short.MaxValue;
            ushort minUShort = ushort.MinValue;
            ushort maxUShort = ushort.MaxValue;

            Console.WriteLine($"short: Min = {minShort}, Max = {maxShort}");
            Console.WriteLine($"ushort: Min = {minUShort}, Max = {maxUShort}");

            // (c) long, ulong
            long minLong = long.MinValue;
            long maxLong = long.MaxValue;
            ulong minULong = ulong.MinValue;
            ulong maxULong = ulong.MaxValue;

            Console.WriteLine($"long: Min = {minLong}, Max = {maxLong}");
            Console.WriteLine($"ulong: Min = {minULong}, Max = {maxULong}");

            // Überlauf prüfen
            CheckOverflow();
        }

        static void CheckOverflow()
        {
            // sbyte Überlauf
            try
            {
                sbyte sbyteOverflow = sbyte.MaxValue;
                sbyteOverflow++;
                Console.WriteLine($"sbyte Überlauf: {sbyteOverflow}");
            }
            catch (OverflowException)
            {
                Console.WriteLine("sbyte Überlauf erkannt!");
            }

            // byte Überlauf
            try
            {
                byte byteOverflow = byte.MaxValue;
                byteOverflow++;
                Console.WriteLine($"byte Überlauf: {byteOverflow}");
            }
            catch (OverflowException)
            {
                Console.WriteLine("byte Überlauf erkannt!");
            }

            // short Überlauf
            try
            {
                short shortOverflow = short.MaxValue;
                shortOverflow++;
                Console.WriteLine($"short Überlauf: {shortOverflow}");
            }
            catch (OverflowException)
            {
                Console.WriteLine("short Überlauf erkannt!");
            }

            // ushort Überlauf
            try
            {
                ushort ushortOverflow = ushort.MaxValue;
                ushortOverflow++;
                Console.WriteLine($"ushort Überlauf: {ushortOverflow}");
            }
            catch (OverflowException)
            {
                Console.WriteLine("ushort Überlauf erkannt!");
            }

            // long Überlauf
            try
            {
                long longOverflow = long.MaxValue;
                longOverflow++;
                Console.WriteLine($"long Überlauf: {longOverflow}");
            }
            catch (OverflowException)
            {
                Console.WriteLine("long Überlauf erkannt!");
            }

            // ulong Überlauf
            try
            {
                ulong ulongOverflow = ulong.MaxValue;
                ulongOverflow++;
                Console.WriteLine($"ulong Überlauf: {ulongOverflow}");
            }
            catch (OverflowException)
            {
                Console.WriteLine("ulong Überlauf erkannt!");
            }

            Console.ReadLine();

#endif

#if true
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
            long combinations = CalculateCombinations(49, 6);
            double probability = 1.0 / combinations;

            Console.WriteLine($"Anzahl der Möglichkeiten: {combinations}");
            Console.WriteLine($"Wahrscheinlichkeit auf einen \"Sechser\": {probability}");

            Console.ReadLine();
        }

        static long CalculateCombinations(int n, int k)
        {
            long numerator = 1;
            for (int i = 0; i < k; i++)
            {
                numerator *= (n - i);
            }

            long denominator = 1;
            for (int i = 1; i <= k; i++)
            {
                denominator *= i;
            }

            return numerator / denominator;


#endif
        }
    }
}

