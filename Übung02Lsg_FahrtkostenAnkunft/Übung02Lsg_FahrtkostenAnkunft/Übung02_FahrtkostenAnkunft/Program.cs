////////////////////////////////////////////90////////////////////////////////////////////

using System;

namespace Fahrtkosten
{
    /* 
     * Übung: Verwendung der Datentypen 'int' und 'double', 
     *        sowie der arithmetischen Operatoren
     * 
     *        1.Aufgabe
     * 
     *          Angenommen, ein Fahrzeug Ihrer Wahl habe:
     * 
     *            - einen Kraftstoffverbrauch von 'double ltrPro100Km' (z.B. 7.4)
     *            - einen Kraftstoffpreis 'double spritPreis' (€/ltr, z.B. 1.149)
     * 
     *          Sie fahren damit jeweils eine Strecke 'int strecke' (in km)
     *          und ein Monat hat 22 Schultage.
     * 
     *          Was kostet Sie die Fahrt hin und zurück zu alfatraining in einem Monat?
     * 
     *        2.Aufgabe
     * 
     *          Angenommen, Sie fahren die folgende Route:
     * 
     *            - Abfahrt ist um 14:15h in Ravensburg
     *            - zunächst fahren Sie 50 km Landstrasse, mit einem Schnitt von 60 km/h
     *            - dann 90 km mit einem Schnitt von 110 km/h
     *            - dann 10 km mit einem Schnitt von 70 km/h
     *            - dann 30 km mit einem Schnitt von 120 km/h
     *            - dann 10 km mit einem Schnitt von 50 km/h
     *            - dann 60 km mit einem Schnitt von 90 km/h
     *            
     *          Nach diesen Fahrtabschnitten sind Sie in Karlsruhe,
     *          aber zu welcher Uhrzeit (im Format 'Stunden:Minuten')?
     * 
     *        Hinweis: Verwenden Sie die explizite Konvertierung von Datentypen
     * 
     *                 Beispiel: Konvertierung von 'double' nach 'int'
     * 
     *                           double kosten = (double)strecke * ...
     */
    class Program
    {
        static void Main(string[] args)
        {
            // 1.Aufgabe: Fahrtkosten berechnen
            double ltrPro100km = 7.4;
            double spritPreis = 1.149;
            int strecke = 35;
            int tage = 22;

            double kosten = (double)strecke * (ltrPro100km / 100 * spritPreis) * tage * 2;
            Console.WriteLine("\nBerechnete Fahrtkosten: " + kosten + " Euro");

            // 2.Aufgabe: Ankunftszeit berechnen
            int stunde = 14, minute = 15;

            // wir rechnen in km/min, d.h. Multiplikation mit 60
            // z.B.: 30km / 120km/h = 0.25h * 60 = 15min
#if true
            int dauer = (50 * 60 / 60) +
                        (90 * 60 / 110) +
                        (10 * 60 / 70) +
                        (30 * 60 / 120) +
                        (10 * 60 / 50) +
                        (60 * 60 / 90);
#else
            int dauer = Convert.ToInt32((((double)50 / 60) +
                                         ((double)90 / 110) +
                                         ((double)10 / 70) +
                                         ((double)30 / 120) +
                                         ((double)10 / 50) +
                                         ((double)60 / 90)) * 60);
#endif
            Console.WriteLine("\nFahrtdauer in Minuten: " + dauer + Environment.NewLine);

            minute = minute + dauer;
            stunde = stunde + minute / 60;
            minute = minute % 60;

            String strStunde = stunde.ToString();
            String strMinute = minute.ToString();

            if (minute < 10)
                strMinute = "0" + strMinute;

            Console.WriteLine("Abfahrtszeit: 14:15 Uhr");
            Console.Write("Ankunftszeit: ");
            Console.Write(strStunde);
            Console.Write(":");
            Console.WriteLine(strMinute + " Uhr" + Environment.NewLine);
        }
    }
}
