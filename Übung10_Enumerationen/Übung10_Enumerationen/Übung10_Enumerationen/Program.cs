////////////////////////////////////////////90////////////////////////////////////////////
using System;

namespace Übung10_Enumerationen
{
    /*
     * Aufgabe: Deklarieren Sie einen Aufzählungstyp 'Monat', der alle Monate
     *          des Jahres in aufsteigender Reihenfolge auflistet, sowie eine
     *          Enumeration 'Jahreszeit', welche die Namen der vier Jahreszeiten
     *          enthält. Implementieren Sie dazu eine IO-Schnittstelle, bei der ein
     *          Benutzer bei Eingabe eines Jahreszeitenindixes und eines 
     *          Monatsindexes bei Entsprechung die zugehörigen Namen ausgegeben 
     *          bekommt und bei Nichtentsprechung darüber informiert wird.
     */

    class Program
    {
        enum Monat
        {
            Januar = 1,
            Februar,
            März,
            April,
            Mai,
            Juni,
            Juli,
            August,
            September,
            Oktober,
            November,
            Dezember
        }

        enum Jahreszeit
        {
            Winter = 1,
            Frühling,
            Sommer,
            Herbst
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben Sie den Index der Jahreszeit ein (1: Winter, 2: Frühling, 3: Sommer, 4: Herbst): ");
            if (int.TryParse(Console.ReadLine(), out int jahreszeitIndex) && Enum.IsDefined(typeof(Jahreszeit), jahreszeitIndex))
            {
                Jahreszeit jahreszeit = (Jahreszeit)jahreszeitIndex;

                Console.WriteLine("Bitte geben Sie den Index des Monats ein (1: Januar, 2: Februar, ..., 12: Dezember): ");
                if (int.TryParse(Console.ReadLine(), out int monatIndex) && Enum.IsDefined(typeof(Monat), monatIndex))
                {
                    Monat monat = (Monat)monatIndex;

                    Console.WriteLine($"Die gewählte Jahreszeit ist: {jahreszeit}");
                    Console.WriteLine($"Der gewählte Monat ist: {monat}");

                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Ungültiger Monatsindex. Bitte geben Sie eine Zahl zwischen 1 und 12 ein.");
                }
            }
            else
            {
                Console.WriteLine("Ungültiger Jahreszeitenindex. Bitte geben Sie eine Zahl zwischen 1 und 4 ein.");
            }
        }
    }
}

