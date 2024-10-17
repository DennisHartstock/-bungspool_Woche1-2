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
            // Zufallszahlengenerator initialisieren
            Random zufall = new Random();

            // die gesuchte Zahl bestimmen (1 <= gesucht <= 100)
            int gesucht = (zufall.Next() % 100) + 1;

            int geraten, versuch = 1;

            Console.WriteLine();
            do
            {
                geraten = Int32.Parse(Console.ReadLine());

                if (geraten < gesucht)
                    Console.WriteLine("({0}) zu klein", versuch);
                else
                    if (geraten > gesucht)
                        Console.WriteLine("({0}) zu gross", versuch);
                    else
                        Console.WriteLine("({0}) richtig", versuch);
                
                versuch++;
                
                if (versuch > 7)
                    break;

            } while (geraten != gesucht);

            Console.WriteLine("\nDie gesuchte Zahl war {0}\n", gesucht);

            Console.ReadLine();
        }
    }
}
