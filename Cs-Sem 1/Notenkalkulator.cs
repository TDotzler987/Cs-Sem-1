using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Sem_1
{
    internal class Notenkalkulator
    {
        public static void Start()
        {
            Console.WriteLine("Willkommen zum Notenkalkulator");
            Console.WriteLine();
            int note = 0;
            string[] ausgabe = {
                "UNGÜLTIGE EINGABE!",   //ausgabe[0]
                "Note 1: Sehr Gut",     //ausgabe[1]
                "Note 2: Gut",          //ausgabe[2]
                "Note 3: Befriedigend", //ausgabe[3]
                "Note 4: Ausreichend",  //ausgabe[4]
                "Note 5: Mangelhaft",   //ausgabe[5]
                "Note 6: Ungenügend"    //ausgabe[6]
            };
            //Console.WriteLine(ausgabe[1]);
            //string str = ".-.";
            //string[] strArray = new string[10];
            Console.Write("Bitte geben Sie die Punkte(0-100) als Ganzzahl ein: ");
            string eingabeST = Console.ReadLine();
            Console.Write("und nun geben Sie bitte die maximal erreichbaren Punkte als Ganzzahl ein: ");
            string maxPunkteSTR = Console.ReadLine();

            bool istEingabGanzzahl = int.TryParse(eingabeST, out int punkt);
            bool istEingabeGanzzahl = int.TryParse(maxPunkteSTR, out int maxPunkte);

            if (istEingabGanzzahl && istEingabeGanzzahl)
            {
                int punkte = (punkt * 100 / maxPunkte);

                if (punkte >= 0 && punkte <= 100)
                {
                    if (punkte >= 92) note = 1;
                    else if (punkte >= 81) note = 2;
                    else if (punkte >= 67) note = 3;
                    else if (punkte >= 50) note = 4;
                    else if (punkte >= 30) note = 5;
                    else note = 6;

                    Console.WriteLine(ausgabe[note] + " - sie erreichten :" + punkte + "%");
                }
                else
                {
                    Console.WriteLine(ausgabe[note]);
                }
            }
            else

            {
                Console.WriteLine(ausgabe[0]);
            }
            
          
            

        }
    }
}
