////////////////////////////////////////////90////////////////////////////////////////////
using System;

namespace Übung06_PasswortEingabe
{
    /*
     * Aufgabe: Identifizieren Sie die Eingabe des Passworts "geheim" wie folgt:
     *
     *            - mit einem Zähler (int count) zählen Sie die aktuell bereits 
     *              eingegeben Zeichen bzw. die Gesamtanzahl des/der Zeichen
     *            - mit der ersten Anweisung prüfen Sie, ob es ein 'g' ist
     *            - wenn dies nicht der Fall ist verlassen Sie die main-Routine
     *              mit 'return'
     *            - ansonsten wird das nächste Zeichen wird eingegeben
     *            - eine switch-Anweisung prüft, ob es sich um ein korrektes
     *              Zeichen handelt (d.h. 'e', 'h', 'e', 'i', 'm')
     *            - die Anweisung im jeweiligen case-Zweig prüft, ob die Nummer,
     *              d.h. die Stelle des eingegebenen Zeichens stimmt
     *            - wenn ein Zeichen falsch ist (falsches Zeichen oder falsche Stelle),
     *              setzen Sie ein zuvor auf 'false' gesetztes Flag 'bool verkehrt'
     *              auf 'true'
     *
     *            - verwenden Sie zur Eingabesteuerung eine geeignete Wiederholungschleife
     */
    class Program
    {
        static void Main(string[] args)
        {
            char passwd;
            int count = 0;
            bool verkehrt = false;

            Console.WriteLine("\nGeben Sie nacheinander einzeln die Buchstaben " +
                              "des Passwortes ein:\n");

            do
            {
                // dies geht komischerweise nicht, weiss jemand warum?
                //passwd = Convert.ToChar(Console.Read());

                passwd = (Console.ReadLine())[0];
                count++;

                if (!('g' == passwd) && (1 == count))
                {
                    Console.WriteLine("Falsches erstes Zeichen!\n");
                    return;
                }

                switch (passwd)
                {
                    case 'g':
                        if (count != 1)
                            verkehrt = true;
                        break;
                    case 'e':
                        if (!(2 == count || 4 == count))
                            verkehrt = true;
                        break;
                    case 'h':
                        if (count != 3)
                            verkehrt = true;
                        break;
                    case 'i':
                        if (count != 5)
                            verkehrt = true;
                        break;
                    case 'm':
                        if (count != 6)
                            verkehrt = true;
                        break;
                    default:
                        verkehrt = true;
                        if (1 == count)
                        {
                            Console.WriteLine("Falsches erstes Zeichen!\n");
                            return;
                        }
                        break;
                }

            } while (count < 6);

            if (!verkehrt)
                Console.WriteLine("\nPasswort korrekt!\n");
            else
                Console.WriteLine("\nPasswort nicht korrekt!\n");

            Console.ReadLine();
        }
    }
}
