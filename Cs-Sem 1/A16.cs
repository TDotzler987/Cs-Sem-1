using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
            int eingabeZahl;
            bool eingabeIstZahl = int.TryParse(eingabe, out eingabeZahl);
            
            if (eingabeZahl%2==0)
            
                {
                    Console.WriteLine("Ihr eingegebener Wert ist " + eingabeZahl + " und die Hälfte des Wertes ist " + eingabeZahl / 2 + ".");

                }
                else if (eingabeZahl%2!=0)
                {
                    Console.WriteLine("Ihr eingegebener Wert ist "+eingabeZahl+" die Hälfte hier von ist "+eingabeZahl/2+" mit dem Rest " + eingabeZahl % 2 + ".");
                }
            int text = eingabe.Length;

            else
                {
                    Console.WriteLine("Ihre Eingabe war das Wort/der String " + eingabe+("wenn wir dies teilen, ist der erste Teil"));
                }
            Console.WriteLine("Taste zum beenden!");
            Console.ReadKey();
        }




    }
}
