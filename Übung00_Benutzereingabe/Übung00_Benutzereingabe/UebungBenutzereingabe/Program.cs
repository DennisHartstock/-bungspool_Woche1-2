using System;
using System.Text.RegularExpressions;

namespace UebungBenutzereingabe
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Übungsvorschlag: Eingabeschnittstelle
             * 
             * Benutzer soll seinen Vor- und Nachnamen sowie sein Geburtsdatum
             * (ggf. auch Größe und Emailadresse) über die Konsole eingeben.
             * 
             * Dabei sollen die eingebenen Daten wie folgt überprüft werden:
             * 
             *  - bei Vor- und Nachname sind nur alphabetische Buchstaben sowie '-' zulässig
             *    und es müssen mindestens fünf Zeichen sein
             *    
             *  - bei Größe ist zu prüfen, ob es sich um ein Zahl handelt (Bereich 20cm-250cm)
             *  - bei Datum ist zu prüfen, ob es sich um ein Datum handelt 
             *    und es darf kein Datum sein, das in der Zukunft liegt
             *  - bei Email sollt die syntaktische Korrektheit geprüft werden 
             *    (Hinweis: reguläre Ausdrücke und die Klasse 'System.Text.RegularExpressions.RegEx')
             *    
             * Zuletzt sollen die eingeben Daten geeignet ausgegeben werden, wobei zusätzlich noch
             * das Alter (in ganzen Jahren) angegeben bzw. berechnet werden soll.
             */


            string firstName = GetValidatedInput("Vorname", @"^[a-zA-Z\-]{5,}$");
            string lastName = GetValidatedInput("Nachname", @"^[a-zA-Z\-]{5,}$");
            DateTime birthDate = GetValidatedDate("Geburtsdatum (dd.MM.yyyy)");
            double height = GetValidatedHeight("Größe (in cm, 20-250)", @"^[0-9]{3,}$");
            string email = GetValidatedInput("Email", @"^[^@\s]+@[^@\s]+\.[^@\s]+$");

            int age = CalculateAge(birthDate);

            Console.WriteLine("\nEingegebene Daten:");
            Console.WriteLine($"Vorname: {firstName}");
            Console.WriteLine($"Nachname: {lastName}");
            Console.WriteLine($"Geburtsdatum: {birthDate:dd.MM.yyyy}");
            Console.WriteLine($"Alter: {age} Jahre");
            Console.WriteLine($"Größe: {height} cm");
            Console.WriteLine($"Email: {email}");

            Console.ReadLine();
        }

        static string GetValidatedInput(string fieldName, string pattern)
        {
            string input;
            Regex regex = new Regex(pattern);
            do
            {
                Console.Write($"{fieldName}: ");
                input = Console.ReadLine();
                if (!regex.IsMatch(input))
                {
                    Console.WriteLine($"Ungültige Eingabe für {fieldName}. Bitte erneut versuchen.");
                }
            } while (!regex.IsMatch(input));
            return input;
        }

        static DateTime GetValidatedDate(string fieldName)
        {
            string input;
            DateTime date;
            do
            {
                Console.Write($"{fieldName}: ");
                input = Console.ReadLine();
                if (!DateTime.TryParse(input, out date) || date > DateTime.Now)
                {
                    Console.WriteLine($"Ungültiges Datum. Bitte erneut versuchen.");
                }
            } while (date > DateTime.Now || !DateTime.TryParse(input, out date));
            return date;
        }

        static double GetValidatedHeight(string fieldName, string pattern)
        {
            string input;
            Regex regex = new Regex(pattern);
            double number = 0;
            do
            {
                Console.Write($"{fieldName}: ");
                input = Console.ReadLine();
                if (!regex.IsMatch(input) && !double.TryParse(input, out number) || number < 20 || number > 250)
                {
                    Console.WriteLine($"Ungültige Zahl. Bitte eine Zahl zwischen 20 und 250 eingeben.");
                }
            } while (!double.TryParse(input, out number) || number < 20 || number > 250);
            return number;
        }

        static int CalculateAge(DateTime birthDate)
        {
            int age = DateTime.Now.Year - birthDate.Year;
            if (DateTime.Now.DayOfYear < birthDate.DayOfYear)
            {
                age--;
            }
            return age;
        }
    }
}