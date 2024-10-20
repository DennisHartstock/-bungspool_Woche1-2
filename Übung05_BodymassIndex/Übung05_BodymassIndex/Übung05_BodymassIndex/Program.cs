﻿////////////////////////////////////////////90////////////////////////////////////////////
using System;

namespace Übung05_BodymassIndex
{
    /*
     * Berechnen Sie nochmals den bereits eingeführten Bodymassenindex bmi,
     * allerdings mit Benutzereingabe von Gewicht und Größe (beides 'double')
     *
     *     Bodymassenindex: bmi = gewicht[kg]/groesse[m]^2
     *
     * Werten Sie den errechneten bmi anhand der folgenden Kriterien aus:
     *
     *     - bmi < 10       => Überprüfen Sie ihre Eingabe
     *     - 10 <= bmi < 15 => Magersucht
     *     - 15 <= bmi < 20 => Untergewicht
     *     - 20 <= bmi < 25 => Normalgewicht
     *     - 25 <= bmi < 30 => Übergewicht
     *     - 30 <= bmi < 40 => Fettsucht
     *     - 40 <= bmi < 50 => morbide Fettsucht
     *     - bmi >= 50      => Überprüfen Sie ihre Eingabe
     *
     * Geben Sie bei erfüllter Bedingung jeweils den entsprechenden Text aus
     */

    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Aufgabe 1: Implementieren Sie eine geeignete Benutzerschnittstelle
             *            zur Eingabe der benötigten Werte. Fangen Sie eventuelle
             *            fehlerhafte Benutzereingaben mittels 'try-catch'-Blöcken
             *            ab. Falls der Benutzer irrtümlicherweise bei der Eingabe von
             *            Gleitkommawerten zur Trennung von Ganzzahl- und Nachkommaanteil
             *            die Punktnotation verwendet, ersetzen Sie den Punkt durch ein
             *            Komma.
             */



            /*
             * Aufgabe 2: Werten Sie den Bodymassen-Index einfach mittels if-Anweisungen
             *            und logischen Vergleichs- und Verknüpfungs-Operatoren aus
             */



            /*
             * Aufgabe 3: Führen Sie eine möglichst effiziente Auswertung durch,
             *            d.h. vermeiden Sie möglichst viele Bedingungsauswertungen
             */

            Console.Write("Bitte geben Sie Ihr Gewicht in kg ein: ");
            double gewicht = Convert.ToDouble(Console.ReadLine());

            Console.Write("Bitte geben Sie Ihre Größe in Metern ein: ");
            double groesse = Convert.ToDouble(Console.ReadLine());

            double bmi = gewicht / (groesse * groesse);

            Console.WriteLine($"Ihr BMI beträgt: {bmi:F2}");

            if (bmi < 10)
            {
                Console.WriteLine("Überprüfen Sie Ihre Eingabe.");
            }
            else if (bmi >= 10 && bmi < 15)
            {
                Console.WriteLine("Magersucht");
            }
            else if (bmi >= 15 && bmi < 20)
            {
                Console.WriteLine("Untergewicht");
            }
            else if (bmi >= 20 && bmi < 25)
            {
                Console.WriteLine("Normalgewicht");
            }
            else if (bmi >= 25 && bmi < 30)
            {
                Console.WriteLine("Übergewicht");
            }
            else if (bmi >= 30 && bmi < 40)
            {
                Console.WriteLine("Fettsucht");
            }
            else if (bmi >= 40 && bmi < 50)
            {
                Console.WriteLine("Morbide Fettsucht");
            }
            else if (bmi >= 50)
            {
                Console.WriteLine("Überprüfen Sie Ihre Eingabe.");
            }

            Console.ReadLine();
        }
    }
}
