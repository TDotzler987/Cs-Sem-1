using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Sem_1
{
    internal class Try
    {
        public static void Start()
        {
            while (true)
            {
                Console.Write("Bitte geben Sie ein Wort ein: ");
                string eingabe = Console.ReadLine();
                char zeichenDT;
                zeichenDT = eingabe[eingabe.Length - 1];

                Console.WriteLine("letzter Buchstabe ist: " + zeichenDT);


                Console.Write("Bitte teilen Sie mir eine Eingabe mit:");
                string eingabe2 = Console.ReadLine();
                int wortZahl = eingabe2.Length;
                bool buhlwert = int.TryParse(eingabe2, out int eingabeZahl);
                if (buhlwert)   //ist true
                {
                    int durchzwei = eingabeZahl % 2;
                    if (durchzwei == 0)
                    {
                        Console.WriteLine("die eingegebene Zahl ist durch 2 teilbar");
                    }
                    else
                    {
                        Console.WriteLine("die eingegebene Zahl ist nicht durch 2 teilbar");
                    }
                }
                else // false
                {
                    if ((eingabe2.Length) < 10)
                    {
                        char endbuchstabe = eingabe2[wortZahl - 1];
                        char vorletzterbuchstabe = eingabe2[wortZahl - 2];
                        Console.WriteLine("die letzten Buchstaben umgedreht sind: " + endbuchstabe + vorletzterbuchstabe);
                    }
                    else
                    {
                        Console.WriteLine(eingabe2.Substring(eingabe2.Length - 3));
                    }
                }
                
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("- zum Beenden beliebige Taste drücken -");
            Console.ReadKey();

        }
    }
}
