using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Sem_1
{
    internal class Sch4
    {
        public static void Start()
        {
            Console.WriteLine("Aufgabe 4 Schleife");
            Console.WriteLine("es sollen  unterschiedliche Zahlen verglichen werden \n der größte, kleinste und mittlere Wert soll ausgegeben werden");
            Console.WriteLine();
            Console.WriteLine( "weiter mit beliebiger Taste");
            Console.ReadKey();
            Console.WriteLine();
            Console.Write("Wie viele Zahlen möchten Sie vergleichen?");
            Console.WriteLine();
            
            Console.WriteLine();
            int anz = 0;
            if (int.TryParse(Console.ReadLine(), out anz))
            {
                
                int schleifenzähler = 0;
                int maxZahl = int.MinValue;
                int minZahl = int.MaxValue;
                int summe = 0;
                while (schleifenzähler < anz)
                {
                    Console.WriteLine();
                    Console.WriteLine($"bitte geben Sie die {schleifenzähler + 1}. Zahl ein: ");
                    int eingab4zahl = 0;
                    while (!int.TryParse(Console.ReadLine(), out eingab4zahl))
                    {
                        Console.WriteLine("falsche Eingabe!");
                        Console.WriteLine($"Bitte {schleifenzähler+1}. Zahl eingeben: ");
                    }
                    summe += eingab4zahl;
                    if (eingab4zahl > maxZahl)
                    {
                        maxZahl = eingab4zahl;
                    }
                    if (eingab4zahl < minZahl)
                    {
                        minZahl = eingab4zahl ;
                    }

                    schleifenzähler++;
                }
                summe = summe / schleifenzähler;
                Console.WriteLine();
                Console.WriteLine("Größte Zahl: " + maxZahl);
                Console.WriteLine("Kleinste Zahl: "+minZahl);
                Console.WriteLine("Durchschnittswert: " + summe);
                Console.WriteLine();
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("falsche Eingabe!");
            }
            }
    }
}
