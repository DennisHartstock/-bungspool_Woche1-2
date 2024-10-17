////////////////////////////////////////////90////////////////////////////////////////////
using System;

namespace Übung05_BodymassIndex
{
    /*
     * Berechnen Sie nochmals den bereits eingeführten Bodymassenindex bmi,
     * allerdings mit Benutzereingabe von Gewicht und Größe (beides 'double')
     *
     *     Bodymassenindex: bmi = gewicht[kg]/groesse[m]^2
     *
     * Werten Sie den errechneten bmi anhand der folgenden Kriterien aus:
     *
     *     - bmi < 10       => Überprüfen Sie ihre Eingabe
     *     - 10 <= bmi < 15 => Magersucht
     *     - 15 <= bmi < 20 => Untergewicht
     *     - 20 <= bmi < 25 => Normalgewicht
     *     - 25 <= bmi < 30 => Übergewicht
     *     - 30 <= bmi < 40 => Fettsucht
     *     - 40 <= bmi < 50 => morbide Fettsucht
     *     - bmi >= 50      => Überprüfen Sie ihre Eingabe
     *
     * Geben Sie bei erfüllter Bedingung jeweils den entsprechenden Text aus
     */

    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Aufgabe 1: Implementieren Sie eine geeignete Benutzerschnittstelle
             *            zur Eingabe der benötigten Werte. Fangen Sie eventuelle
             *            fehlerhafte Benutzereingaben mittels 'try-catch'-Blöcken
             *            ab. Falls der Benutzer irrtümlicherweise bei der Eingabe von
             *            Gleitkommawerten zur Trennung von Ganzzahl- und Nachkommaanteil
             *            die Punktnotation verwendet, ersetzen Sie den Punkt durch ein
             *            Komma.
             */
            double bmi, gewicht, groesse;

            Console.Write("\nGewicht in kg: ");
            try
            {
                gewicht = Double.Parse(Console.ReadLine().Replace('.', ','));
            }
            catch (ArgumentNullException argNullEx)
            {
                Console.WriteLine(argNullEx.Message);
                return;
            }
            catch (FormatException formatEx)
            {
                Console.WriteLine(formatEx.Message);
                return;
            }
            catch (OverflowException overFlowEx)
            {
                Console.WriteLine(overFlowEx.Message);
                return;
            }

            Console.Write("\nGröße in m: ");
            try
            {
                groesse = Double.Parse(Console.ReadLine().Replace('.', ','));
            }
            catch (ArgumentNullException argNullEx)
            {
                Console.WriteLine(argNullEx.Message);
                return;
            }
            catch (FormatException formatEx)
            {
                Console.WriteLine(formatEx.Message);
                return;
            }
            catch (OverflowException overFlowEx)
            {
                Console.WriteLine(overFlowEx.Message);
                return;
            }

            bmi = gewicht / groesse / groesse;

            Console.WriteLine("\nBerechneter Bodymassen-Index: {0:F2}\n", bmi);

            /*
             * Aufgabe 2: Werten Sie den Bodymassen-Index einfach mittels if-Anweisungen
             *            und logischen Vergleichs- und Verknüpfungs-Operatoren aus
             */
            if (bmi < 10 || bmi >= 50)
                Console.WriteLine("Bitte Überprüfen Sie ihre Eingabewerte.\n");
            if (10 <= bmi && bmi < 15)
                Console.WriteLine("Magersucht\n");
            if (15 <= bmi && bmi < 20)
                Console.WriteLine("Untergewicht\n");
            if (20 <= bmi && bmi < 25)
                Console.WriteLine("Normalgewicht\n");
            if (25 <= bmi && bmi < 30)
                Console.WriteLine("Übergewicht\n");
            if (30 <= bmi && bmi < 40)
                Console.WriteLine("Fettsucht\n");
            if (40 <= bmi && bmi < 50)
                Console.WriteLine("Morbide Fettsucht\n");


            /*
             * Aufgabe 3: Führen Sie eine möglichst effiziente Auswertung durch,
             *            d.h. vermeiden Sie möglichst viele Bedingungsauswertungen
             */
#if true
            // dieser if-Zweig könnte natürlich auch umgekehrt formuliert werden,
            // die Effizienz hängt letztendlich vom Wert für 'bmi' ab
            if (bmi < 10 || bmi >= 50)
                Console.WriteLine("Bitte Überprüfen Sie ihre Eingabewerte.\n");
            else if (bmi < 15)
                Console.WriteLine("Magersucht\n");
            else if (bmi < 20)
                Console.WriteLine("Untergewicht\n");
            else if (bmi < 25)
                Console.WriteLine("Normalgewicht\n");
            else if (bmi < 30)
                Console.WriteLine("Übergewicht\n");
            else if (bmi < 40)
                Console.WriteLine("Fettsucht\n");
            else
                Console.WriteLine("Morbide Fettsucht\n");
#else
            // dieser if-Zweig ist zum obigen völlig äquivalent, nur anders formatiert
            if (bmi < 10 || bmi >= 50)
                Console.WriteLine("Bitte Überprüfen Sie ihre Eingabewerte.\n");
            else
                if (bmi < 15)
                    Console.WriteLine("Magersucht\n");
                else
                    if (bmi < 20)
                        Console.WriteLine("Untergewicht\n");
                    else
                        if (bmi < 25)
                            Console.WriteLine("Normalgewicht\n");
                        else
                            if (bmi < 30)
                                Console.WriteLine("Übergewicht\n");
                            else
                                if (bmi < 40)
                                    Console.WriteLine("Fettsucht\n");
                                else
                                    Console.WriteLine("Morbide Fettsucht\n");
#endif
            /*
             * Erinnerung: 'dangling else'
             */ 
            if (bmi > 25)
                if (bmi < 30) // erste Anweisung des obigen if-Zweiges
                    Console.WriteLine("Übergewicht\n");
                else          // 'dangling else' gehört immer zum vorherigen if 
                    Console.WriteLine("Fettsucht oder morbide Fettsucht\n");

            Console.ReadLine();
        }
    }
}
