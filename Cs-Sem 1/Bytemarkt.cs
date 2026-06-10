using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Sem_1
{
    internal class Bytemarkt
    {
        public static void Start()
        {
            string[] vorname ={"Jana","Stefan","August"};
            string[] nachname ={"Berger","Hermann","Böbel"};
            int[] alter ={29, 27, 43 };
            string[] Abteilung ={"Lager","Einkauf","Empfang"};
            decimal [] gehalt = {2800, 3800, 3900};
            bool [] teilzeit = { false, false, false };
            char[] kuerzel = { 'J', 'S', 'A' };
            string[] personalnr = { "100000042B", "10000044H", "10000001B" };

            int f = 0;
            
            while (f < vorname.Length)
            {
                Console.WriteLine($" Vorname: {vorname[f],8}\n Name: {nachname[f],12}\n Alter: " +
                    $"{alter[f],6}\n Abteilung: {Abteilung[f]}\n Monatsgehalt: {gehalt[f]}\n Teilzeit? {teilzeit[f]}\n" +
                    $" Kürzel: {kuerzel[f],6}\n Personalnummer: {personalnr[f]}");
                Console.WriteLine();
                f++;
            }


        }
    }
}
