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
            string passwort = "geheim";
            int count = 0;
            bool verkehrt = false;

            while (count < passwort.Length && !verkehrt)
            {
                Console.Write($"Bitte geben Sie das {count + 1}. Zeichen des Passworts ein: ");
                char eingabe = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (count == 0)
                {
                    if (eingabe != 'g')
                    {
                        Console.WriteLine("Falsches Passwort.");
                        Console.ReadLine();
                    }
                }
                else
                {
                    switch (eingabe)
                    {
                        case 'e':
                            if (count != 1 && count != 3)
                            {
                                verkehrt = true;
                            }
                            break;
                        case 'h':
                            if (count != 2)
                            {
                                verkehrt = true;
                            }
                            break;
                        case 'i':
                            if (count != 4)
                            {
                                verkehrt = true;
                            }
                            break;
                        case 'm':
                            if (count != 5)
                            {
                                verkehrt = true;
                            }
                            break;
                        default:
                            verkehrt = true;
                            break;
                    }
                }

                if (verkehrt)
                {
                    Console.WriteLine("Falsches Passwort.");
                    return;
                }

                count++;
            }

            if (!verkehrt && count == passwort.Length)
            {
                Console.WriteLine("Passwort korrekt eingegeben!");
                Console.ReadLine();
            }
        }
    }
}

