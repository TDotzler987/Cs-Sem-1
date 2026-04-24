using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Sem_1
{
    internal class A16
    {
        public static void Start()
        {
            Console.WriteLine("Aufgabe 16");
            Console.WriteLine();
            Console.WriteLine("Ich bitte um Eingabe: ");
            string eingabe = Console.ReadLine();

            if (string.IsNullOrEmpty(eingabe))
            {
                Console.WriteLine("Keine Eingabe erhalten.");
                Console.WriteLine("Taste zum beenden!");
                Console.WriteLine();
                Console.ReadKey();
                return;
            }

            int eingabeZahl;
            bool eingabeIstZahl = int.TryParse(eingabe, out eingabeZahl);
            // prüft ob die Eingabe eine Zahl ist
            // Wenn die Eingabe eine Zahl ist, wird sie in eingabeZahl gespeichert und eingabeIstZahl ist true.
            // Wenn die Eingabe keine Zahl ist, bleibt eingabeZahl 0 und eingabeIstZahl ist false.
            // eingabe bleibt eingabe
            
            // Berechnung der Länge der Eingabe und der Hälfte der Länge
            int längeDerEingabe = eingabe.Length;
            int half = längeDerEingabe / 2;

            if (eingabeIstZahl)  //da wird geprüft ob eingabeIstZahl true ist, also hier if "true"
            {
                if (eingabeZahl % 2 == 0)
                {
                    Console.WriteLine($"Ihr eingegebener Wert ist {eingabeZahl} und die Hälfte des Wertes ist {eingabeZahl / 2}.");
                }
                else
                {
                    Console.WriteLine($"Ihr eingegebener Wert ist {eingabeZahl} der halbierte Wert ist {eingabeZahl / 2} mit Rest 1.");
                }
            }
            else              //hier ist es dann false, somit ist es Text und keine Zahl
            {
                if (längeDerEingabe % 2 == 0)
                {
                    string first = eingabe.Substring(0, half);
                    string second = eingabe.Substring(half, half);
                    Console.WriteLine($"Ihre Eingabe war das Wort/der String {eingabe} wenn wir dies teilen, ist der erste Teil {first} und der zweite Teil {second}");
                }
                else
                {
                    string first = eingabe.Substring(0, half);
                    string middle = eingabe.Substring(half, 1);
                    string second = eingabe.Substring(half + 1, half);
                    Console.WriteLine($"Ihre Eingabe war das Wort/der String {eingabe} wenn wir dies teilen, ist der erste Teil {first} und der zweite Teil {second} der mittlere Buchstabe ist: {middle}");
                }
            }

            Console.WriteLine("Taste zum beenden!");
            Console.WriteLine();
            Console.ReadKey();
        }



    }
}
