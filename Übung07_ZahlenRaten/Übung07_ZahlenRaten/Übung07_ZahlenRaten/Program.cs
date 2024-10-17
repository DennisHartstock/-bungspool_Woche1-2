////////////////////////////////////////////90////////////////////////////////////////////
using System;

namespace Übung07_ZahlenRaten
{
    /*
     * Aufgabe: Der Benutzer dieser Anwendung soll eine vom System generierte Zufallszahl
     *          zwischen 1 und 100 in maximal 7 Versuchen erraten.
     * 
     *          Dabei sollen als Lösungstipps nach jedem Rateversuch ein entsprechender
     *          Hinweis "zu groß" bzw. "zu klein" ausgegeben werden. Nach 7 Versuchen,
     *          oder bei Eingabe der gesuchten Zahl, soll abgebrochen werden.
     */

        class Program
        {
            static void Main(string[] args)
            {
                Random random = new Random();
                int zufallszahl = random.Next(1, 101);
                int versuche = 0;
                const int maxVersuche = 7;
                bool erraten = false;

                Console.WriteLine("Willkommen zum Zahlenratespiel!");
                Console.WriteLine("Ich habe eine Zahl zwischen 1 und 100 gewählt. Versuchen Sie, sie in maximal 7 Versuchen zu erraten.");

                while (versuche < maxVersuche && !erraten)
                {
                    Console.Write($"Versuch {versuche + 1}: Geben Sie Ihre Zahl ein: ");
                    int benutzerZahl;
                    if (int.TryParse(Console.ReadLine(), out benutzerZahl))
                    {
                        versuche++;
                        if (benutzerZahl == zufallszahl)
                        {
                            erraten = true;
                            Console.WriteLine("Herzlichen Glückwunsch! Sie haben die Zahl erraten.");
                        }
                        else if (benutzerZahl < zufallszahl)
                        {
                            Console.WriteLine("Zu klein.");
                        }
                        else
                        {
                            Console.WriteLine("Zu groß.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein.");
                    }
                }

                if (!erraten)
                {
                    Console.WriteLine($"Leider haben Sie die Zahl nicht erraten. Die richtige Zahl war {zufallszahl}.");
                }

                Console.ReadLine();
            }
        }
    }

