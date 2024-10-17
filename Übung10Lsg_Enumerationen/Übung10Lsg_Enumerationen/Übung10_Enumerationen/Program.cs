////////////////////////////////////////////90////////////////////////////////////////////
using System;

namespace Übung10_Enumerationen
{
    /*
     * Aufgabe: Deklarieren Sie einen Aufzählungstyp 'monate', der alle Monate
     *          des Jahres in aufsteigender Reihenfolge auflistet, sowie eine
     *          Enumeration 'jahreszeiten', welche die Namen der vier Jahreszeiten
     *          enthält. Implementieren Sie dazu eine IO-Schnittstelle, bei der ein
     *          Benutzer bei Eingabe eines Jahreszeitenindixes und eines 
     *          Monatsindexes bei Entsprechung die zugehörigen Namen ausgegeben 
     *          bekommt und bei Nichtentsprechung darüber informiert wird.
     */
    class Program
    {
        enum monat
        {
            Januar = 1,
            Februar,
            Maerz,
            April,
            Mai,
            Juni,
            Juli,
            August,
            September,
            Oktober,
            November,
            Dezember,
        };

        enum jahreszeit
        {
            Fruehling = 1,
            Sommer,
            Herbst,
            Winter
        };

        static void Main(string[] args)
        {
            Console.Write("\nBitte geben Sie den Index einer Jahreszeit ein [1..4]: ");
            jahreszeit j = (jahreszeit)Int32.Parse(Console.ReadLine());
            Console.Write("\nBitte geben Sie den Index eines Monats ein [1..12]: ");
            monat m = (monat)Int32.Parse(Console.ReadLine());

            switch (j)
            {
                case jahreszeit.Fruehling:
                    Console.Write(Environment.NewLine + jahreszeit.Fruehling);
                    switch (m)
                    {
                        case monat.Maerz:
                            Console.WriteLine(" im Monat " + monat.Maerz);
                            break;
                        case monat.April:
                            Console.WriteLine(" im Monat " + monat.April);
                            break;
                        case monat.Mai:
                            Console.WriteLine(" im Monat " + monat.Mai);
                            break;
                        default:
                            Console.WriteLine(" wäre schön.\n");
                            break;
                    }
                    break;
                case jahreszeit.Sommer:
                    Console.Write(Environment.NewLine + jahreszeit.Sommer);
                    switch (m)
                    {
                        case monat.Juni:
                            Console.WriteLine(" im Monat " + monat.Juni);
                            break;
                        case monat.Juli:
                            Console.WriteLine(" im Monat " + monat.Juli);
                            break;
                        case monat.August:
                            Console.WriteLine(" im Monat " + monat.August);
                            break;
                        default:
                            Console.WriteLine(" wäre richtig schön.\n");
                            break;
                    }
                    break;
                case jahreszeit.Herbst:
                    Console.Write(Environment.NewLine + jahreszeit.Herbst);
                    switch (m)
                    {
                        case monat.September:
                            Console.WriteLine(" im Monat " + monat.September);
                            break;
                        case monat.Oktober:
                            Console.WriteLine(" im Monat " + monat.Oktober);
                            break;
                        case monat.November:
                            Console.WriteLine(" im Monat " + monat.November);
                            break;
                        default:
                            Console.WriteLine(" könnte schon wieder vorbei sein.\n");
                            break;
                    }
                    break;
                case jahreszeit.Winter:
                    Console.Write(Environment.NewLine + jahreszeit.Winter);
                    switch (m)
                    {
                        case monat.Dezember:
                            Console.WriteLine(" im Monat " + monat.Dezember);
                            break;
                        case monat.Januar:
                            Console.WriteLine(" im Monat " + monat.Januar);
                            break;
                        case monat.Februar:
                            Console.WriteLine(" im Monat " + monat.Februar);
                            break;
                        default:
                            Console.WriteLine(", puh ganz schoen kalt.\n");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("\nDie Indices liegen ausserhalb " +
                                      "des gültigen Bereichs!\n");
                    break;
            }

            Console.ReadLine();
        }
    }
}
