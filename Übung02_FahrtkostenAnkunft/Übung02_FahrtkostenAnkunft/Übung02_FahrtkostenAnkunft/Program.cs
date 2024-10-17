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

#if false

            double ltrPro100Km = 7.4;
            double spritPreis = 1.149;
            int strecke = 30;
            int schultage = 22;

            // Berechnung der Gesamtkilometer pro Monat (hin und zurück)
            int gesamtKilometer = strecke * 2 * schultage;

            // Berechnung des Gesamtverbrauchs in Litern
            double gesamtVerbrauch = (ltrPro100Km / 100) * gesamtKilometer;

            // Berechnung der Gesamtkosten
            double gesamtKosten = gesamtVerbrauch * spritPreis;

            Console.WriteLine($"Die Fahrtkosten für einen Monat betragen: {gesamtKosten:F2} Euro");

            Console.ReadLine();

#endif

#if true

            DateTime abfahrtZeit = new DateTime(2024, 10, 17, 14, 15, 0);

            double[] strecken = { 50, 90, 10, 30, 10, 60 };
            double[] geschwindigkeiten = { 60, 110, 70, 120, 50, 90 };

            double gesamtZeitInStunden = 0;

            for (int i = 0; i < strecken.Length; i++)
            {
                gesamtZeitInStunden += strecken[i] / geschwindigkeiten[i];
            }

            TimeSpan gesamtZeit = TimeSpan.FromHours(gesamtZeitInStunden);
            DateTime ankunftZeit = abfahrtZeit.Add(gesamtZeit);

            Console.WriteLine($"Die Ankunftszeit in Karlsruhe ist: {ankunftZeit:HH:mm}");

            Console.ReadLine();

#endif
        }
    }
}
