using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Sem_1
{
    internal class SchlArr
    {
        public static void Start () 
        {
            //Arrays;
            string[] Array = { "Hans", "Peter", "Sophia", "Stefan", "Jules", "Sky", "Petronas", "Georg", "Amelie", "Sebastian" };
            int[] lottoZahlen = new int[6];

            Random rnd = new Random();
            int zufallszahl = rnd.Next(1, 50);     // ( >= , <)

            //Programm, das jedem Spieler aus strArray 6 Zufallszahlen gibt und das lottoZahlen-Array mit 6 Werten füllt
            Console.WriteLine("Bitte nennen Sie einen der folgenden Namen:");
            Console.WriteLine("Hans, Peter, Sophia, Stefan, Jules, Sky, Petronas, Georg, Amelie, Sebastian");
            string name = Console.ReadLine().Trim();
            bool nameGefunden = Array.Contains(name, StringComparer.OrdinalIgnoreCase);
            if (nameGefunden ) 
                
                {
                    Console.WriteLine($"Hallo {name} ihre Lottozahlen sind " + rnd.Next(0,50)+" , "+ rnd.Next(0, 50) + " , " + rnd.Next(0, 50) + " , " + rnd.Next(0, 50) + " , " + rnd.Next(0, 50) + " , " + rnd.Next(0, 50));
                }
            else
                {
                    Console.WriteLine("falsche Eingabe");
                }
        }
    }
}
