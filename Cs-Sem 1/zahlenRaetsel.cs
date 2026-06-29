using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Cs_Sem_1
{
    internal class zahlenRaetsel
    {
        public static void Start()
        {
            const uint ANZAHL_MAXIMALER_VERSUCHE = 5;
            uint anzahlgemachterVersuche = 0;
            int[] eingabenArray = new int[ANZAHL_MAXIMALER_VERSUCHE];
            bool spieläuft = true;
            bool zahlValide = false;
            uint rdZähler = 0;
            Random rnd = new Random();
            int gesuchteZahl = rnd.Next(4, 8); //erzeugt Zufallszahl zw. -1000 u. 1000)
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("=============  Herzlich Willkommen  =============");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine();
            Console.WriteLine(" - weiter mit beliebiger Taste - ");
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Bitte gib eine zwischen Zahl -1000 und 1000 ein: ");

            do
            {

                string uein = Console.ReadLine();
                bool zahl = int.TryParse(uein, out int uzahl);
                if (rdZähler != ANZAHL_MAXIMALER_VERSUCHE)
                {
                    if (zahl)
                    {
                        if (-1000 > uzahl && uzahl < 1000)
                        {
                            if (uzahl == gesuchteZahl)
                            {
                                Console.WriteLine("Treffer");
                                Console.WriteLine();

                                Console.WriteLine($" \n \n *** \n sie haben die Zahl mit {rdZähler+1}von {ANZAHL_MAXIMALER_VERSUCHE} erraten");
                                zahlValide = true;
                            }
                            else
                            {
                                if (uzahl > gesuchteZahl)
                                {
                                    rdZähler++;
                                    Console.WriteLine("Ihre Zahl ist zu groß <<<<");
                                    Console.WriteLine();
                                    Console.WriteLine($" \n \n ==> übrige Versuche {rdZähler+1}von {ANZAHL_MAXIMALER_VERSUCHE}");


                                }
                                else
                                {
                                    rdZähler++;
                                    Console.WriteLine("Ihre Zahl ist zu klein >>>>");
                                    Console.WriteLine();
                                    Console.WriteLine($" \n \n ==> übrige Versuche {rdZähler+1}von {ANZAHL_MAXIMALER_VERSUCHE}");
                                }

                            }

                        }

                        else
                        {
                            rdZähler++;
                            Console.WriteLine($"Bitte nur zwischen -1000 und 1000 Zahlen eingeben! \n \n ==> Versuche {rdZähler+1}von {ANZAHL_MAXIMALER_VERSUCHE}");

                        }


                    }
                    else
                    {
                        rdZähler++;
                        Console.WriteLine($"Bitte nur Zahlen eingeben! \n \n ==> Versuche {rdZähler + 1}von {ANZAHL_MAXIMALER_VERSUCHE}");

                    }
                }
                else
                {
                    Console.WriteLine($"Die Anzahl deiner Versuche({ANZAHL_MAXIMALER_VERSUCHE}) ist erreicht. ");
                }

            }
            while (!zahlValide);
            {
                Console.WriteLine($"Herzlichen Glückwunsch! \n  du hast die Zahl beim {rdZähler+1}. Versuch erraten");
            }



        }
    }
}
