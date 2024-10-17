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
            int versuche = 0;
            while (versuche < 3)
            {
                // Stelle Frage
                Console.WriteLine("\nMöchten Sie weitermachen (j oder n)?");

                string strAntwort;
                char cAntwort;
                bool antwortBool = false;

                // Lese Antwort aus dem Eingabe-Stream (Konsole)
                strAntwort = Console.ReadLine();
                // Nehme davon nur das erste Zeichen
                cAntwort = strAntwort[0];

                // Verarbeite Antwort
                switch (cAntwort)
                {
                    case 'j':
                        antwortBool = true;
                        Console.WriteLine("\nIhre Antwort war 'ja' => " + antwortBool);
                        return;
                    case 'n':
                        antwortBool = false;
                        Console.WriteLine("\nIhre Antwort war 'nein' => " + antwortBool);
                        return;
                    default:
                        Console.WriteLine("\nIch verstehe Sie leider nicht.\n");
                        versuche = versuche + 1;
                        break;
                }
            }
            Console.WriteLine("\nIch halte das fuer ein 'nein'\n");
        }
    }
}
