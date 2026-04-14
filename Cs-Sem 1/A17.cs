using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Sem_1
{
    internal class A17
    {
        public static void Start()
        {
            Console.WriteLine("Willkommen bei Aufgabe A17");
            Console.WriteLine();
            Console.WriteLine("Ich möchte Sie hiermit um Ihre Eingabe bitten:");
            string eing = Console.ReadLine();
            int eingabeZahl = 0;
            if (int.TryParse(eing, out eingabeZahl))
            {
            int erg1 = eingabeZahl% 10;
            }
            else
            {
            int eingabe =eing.Length;
            int erg1 = eingabe*2%10;
            }
                 
            Console.WriteLine( "Hier bitte ich Sie um die zweite Eingabe:");
            string eing2 = Console.ReadLine();
            int eingabeZahl2 = 0;
            if (int.TryParse(eing2, out eingabeZahl2))
            {
            int erg2 = eingabeZahl2 *3;
            }
            else
            {
            int LängeDerEingabe2 = eing2.Length;
            int erg2 = LängeDerEingabe2 * 5 % 100;
            }
            Console.WriteLine("Hier ist das Ergebnis:");
            Console.WriteLine($" { erg1} / {erg2} = {erg1/erg2} );



        }
    }
}
