using System;
using System.Text.RegularExpressions;

namespace UebungBenutzereingabe
{
    class Program
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
         *  - bei Größe ist zu prüfen, ob es sich um ein Zahl handelt
         *  - bei Datum ist zu prüfen, ob es sich um ein Datum handelt 
         *    und es darf kein Datum sein, das in der Zukunft liegt
         *  - bei Email sollt die syntaktische Korrektheit geprüft werden 
         *    (Hinweis: reguläre Ausdrücke und die Klasse 'System.Text.RegularExpressions.RegEx')
         *    
         * Zuletzt sollen die eingeben Daten geeignet ausgegeben werden, wobei zusätzlich noch
         * das Alter (in ganzen Jahren) angegeben bzw. berechnet werden soll.
         */

        static void Main(string[] args)
        {
            string firstName = GetValidatedInput("Vorname", @"^[a-zA-Z\-]{2,}$");
            string lastName = GetValidatedInput("Nachname", @"^[a-zA-Z\-]{2,}$");
            DateTime birthDate = GetValidatedDate("Geburtsdatum (dd.MM.yyyy)");
            double height = GetValidatedDouble("Größe (in cm)");
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

        static double GetValidatedDouble(string fieldName)
        {
            string input;
            double number;
            do
            {
                Console.Write($"{fieldName}: ");
                input = Console.ReadLine();
                if (!double.TryParse(input, out number))
                {
                    Console.WriteLine($"Ungültige Zahl. Bitte erneut versuchen.");
                }
            } while (!double.TryParse(input, out number));
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


//        static void Main(string[] args)
//        {
//            // (1) Eingabe von Vor- und Nachname (zusammen)
//            //
//            Console.Write("\n Name: ");
//            string name = Console.ReadLine();

//            bool ungueltigesZeichen = false;

//#if false
//            for (int zeichenIndex = 0; zeichenIndex < name.Length; zeichenIndex++)
//            {
//                char zeichen = name[zeichenIndex];

//                //if (zeichen != ' ' && zeichen != '-' &&
//                //    (zeichen < 'A' || zeichen > 'z' || (zeichen > 'Z' && zeichen < 'a')))
//                if (zeichen != 32 && zeichen != 45 &&
//                    (zeichen < 65 || zeichen > 122 || (zeichen > 90 && zeichen < 97)))
//                {
//                    ungueltigesZeichen = true;
//                    break;
//                }
//            }
//#endif

//#if false
//            const string alphabetGültigerZeichen = "abcdefghijklmnopqrstuvwxyz";

//            foreach (char zeichen in name)
//            {
//                if (zeichen == ' ' || zeichen == '-')
//                {
//                    continue;
//                }

//                if (alphabetGültigerZeichen.Contains(zeichen.ToString().ToLower()))
//                {
//                    continue;
//                }

//                // falls keine der beiden obigen 'if'-Bedingungen zutrifft,
//                // dann ist es ein ungültiges Zeichen
//                //
//                ungueltigesZeichen = true;
//                break;
//            }
//#endif

//#if false
//            // Reguläre Ausdrücke können insbesondere zum Validieren von Zeichenketten,
//            // sowie für "Suchen-und-Ersetzen"-Vorgänge eingesetzt werden
//            //
//            // in der .NET-Klassenbibliothek findet man im Namensraum
//            // 'System.Text.RegularExpressions' entsprechende Klassen,
//            // insbesondere die Klasse 'Regex'
//            //
//            // Nährere Infos siehe:
//            //
//            //  https://docs.microsoft.com/en-us/dotnet/standard/base-types/regular-expressions
//            //  https://docs.microsoft.com/en-us/dotnet/standard/base-types/regular-expression-language-quick-reference
//            //
//            // {4,50} => es müssen mindestens 4 und maximal 50 Zeichen sein
//            //
//            const string regulaererAusdruckZurNamensprüfung =
//                "^[a-zA-Z]{4,50}$";

//            if (!Regex.IsMatch(name, regulaererAusdruckZurNamensprüfung))
//            {
//                ungueltigesZeichen = true;
//            }
//#endif

//            // unsere bisherigen Lösungsvarianten betrachten nur
//            // das lateinische Alphabet
//            //
//            // um Buchstaben beliebiger Alphabete betrachten zu können
//            // bietet der Strukturtyp 'System.Char' Abhilfe
//            //
//            foreach (char zeichen in name)
//            {
//                if (char.IsLetter(zeichen) || zeichen == ' ' || zeichen == '-')
//                {
//                    continue;
//                }

//                ungueltigesZeichen = true;
//                break;
//            }

//            if (ungueltigesZeichen || name.Length <= 5)
//            {
//                name += " (ungültig)";
//            }

//            // (2) Eingabe der Köpergröße in Meter
//            //
//            Console.Write("Größe: ");

//            double groesse;

//            // falls zum Umwandlung der eingegebenen Zeichenkette in einen 'double'-Wert
//            // die statische Methode 'Parse()' verwendet wird, muss dies zu Fehlerprüfung
//            // im Rahmen einer 'try-catch'-Konstruktion erfolgen
//            //
//            //try
//            //{
//            //    groesse = double.Parse(Console.ReadLine());
//            //}
//            //catch (Exception)
//            //{
//            //}

//            bool hatGeklappt = double.TryParse(Console.ReadLine(), out groesse);
//            if (!hatGeklappt || 
//                groesse < 0.2 || groesse > 2.5 /* Range Validation: Größe muss 0.2 bis 2.5 Meter sein */)
//            {
//                groesse = double.NaN;
//            }

//            // (3) Eingabe der Geburtsdatums
//            //
//            Console.Write(" Geb.: ");

//            DateTime geburtsdatum;

//            hatGeklappt = DateTime.TryParse(Console.ReadLine(), out geburtsdatum);
//            if (!hatGeklappt ||
//                geburtsdatum > DateTime.Now)
//            {
//                geburtsdatum = DateTime.MinValue;
//            }

//            // Berechnung des Alters in ganzen Jahren
//            //
//            DateTime heute = DateTime.Now;
//            int alter = heute.Year - geburtsdatum.Year;
//            if (geburtsdatum.AddYears(alter) > heute)
//            {
//                alter--;
//            }

//            // (4) Eingabe der Emailadresse
//            //
//            Console.Write("\nEmail: ");
//            string email = Console.ReadLine();

//            // das @-Zeichen bewirkt, dass der Backslash in einer Zeichenkette
//            // als normales Zeichen zu betrachten ist
//            //
//            const string emailRegExPattern =
//                @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*" +
//                @"@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";

//            if (!Regex.IsMatch(email, emailRegExPattern, RegexOptions.IgnoreCase))
//            {
//                email += " (ungültig)";
//            }

//            // Hinweis: im Namensraum 'System.Net.Mail' gibt es Klasse 'MailAddress'
//            //
//            try
//            {
//                System.Net.Mail.MailAddress emailAddress =
//                    new System.Net.Mail.MailAddress(email);
//            }
//            catch (FormatException ex)
//            {
//                Console.WriteLine("\nFalsches Format der Email: {0}\n", ex.Message);
//            }

//            Console.WriteLine(
//                "\n Name: {0}\nGröße: {1:F2} Meter\n Geb.: {2:D}\nAlter: {3} Jahre\nEmail: {4}\n",
//                name, groesse, geburtsdatum, alter, email);
//        }
//    }
//}
