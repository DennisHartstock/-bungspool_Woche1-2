////////////////////////////////////////////90////////////////////////////////////////////
using System;

namespace Übung04_BenutzerInteraktion
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1.Aufgabe: Schreiben Sie ein Programm, das einen Benutzer befragt, 
             *            ob er fortfahren will und seine Antwort "(j)a oder (n)ein"
             *            als Booleschen Wert ausgibt. Um falschen Eingaben (z.B. 'y')
             *            vorzubeugen, soll dem Benutzer ein dreimalige Wiederholung
             *            ermöglicht werden
             *
             */

            bool? fortfahren = null;
            int versuche = 0;
            const int maxVersuche = 3;

            while (fortfahren == null && versuche < maxVersuche)
            {
                Console.Write("Möchten Sie fortfahren? (j)a oder (n)ein: ");
                string eingabe = Console.ReadLine().Trim().ToLower();

                if (eingabe == "j" || eingabe == "ja")
                {
                    fortfahren = true;
                }
                else if (eingabe == "n" || eingabe == "nein")
                {
                    fortfahren = false;
                }
                else
                {
                    versuche++;
                    Console.WriteLine($"Ungültige Eingabe. Sie haben noch {maxVersuche - versuche} Versuch(e).");
                }
            }

            if (fortfahren != null)
            {
                Console.WriteLine($"Ihre Antwort: {(fortfahren.Value ? "Ja" : "Nein")}");
            }
            else
            {
                Console.WriteLine("Maximale Anzahl an Versuchen erreicht. Programm wird beendet.");
            }

            Console.ReadLine();
        }
    }
}
