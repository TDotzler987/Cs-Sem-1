using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Sem_1
{
    internal class For5
    {
        public static void Start()
        {


            double[] dblArray = new double[5];
            //ein leeren Zahlenarray mit 5 freien Plätzen anlegen
            double  min=double.MaxValue, 
                    max=double.MinValue , 
                    mtlwert=0,  
                    sum=0;
            for (int i = 0; i < dblArray.Length; i++)
            {
                Console.Write($"Bitte geben Sie die {i + 1}. Zahl ein: ");
                double eingabeZahl = -1;
                string? eingabe = Console.ReadLine();
                bool istEingabeValideZahl = double.TryParse(eingabe, out eingabeZahl);
                if (!istEingabeValideZahl)
                {
                    eingabeZahl = -1;
                }
                dblArray[i] = eingabeZahl;
            }
            for (int i = 0; i < dblArray.Length; i++)
            {
                sum += dblArray[i];
                if (max < dblArray[i]) max = dblArray[i];
                if (min > dblArray[i]) min = dblArray[i];
            }
            mtlwert = sum/dblArray.Length;
            Console.WriteLine("Die Summe der Zahlen: "+sum);
            Console.WriteLine("Die größte Zahl: " + max);
            Console.WriteLine("Die kleinste Zahl: " + min);
            Console.WriteLine("Der Mittelwert: "+mtlwert);


            /*
            Console.WriteLine("Aufgabe A19C");
            Console.WriteLine();

            Console.WriteLine("Bitte geben Sie verschiedene Zahlen ein.");
            Console.WriteLine("Am Schluss wird der kleinste, der größte und der Mittelwert ausgegeben");
            Console.WriteLine();
            Console.Write("Wieviele Zahlen möchten Sie vergleichen?");
            int zahl = 0;
            int summe = 0;
            int mittlwert = 0;
            int maxZahl = int.MinValue;
            int minZahl = int.MaxValue;

            

            if (int.TryParse(Console.ReadLine(), out int value))
            
            {
                
                for (int i = 0; i < value; ++i)
                
                {

                    Console.Write($"Bitte geben Sie nun Ihre {i + 1} Zahl ein: ");
                   

                    if (int.TryParse(Console.ReadLine(), out zahl))
                    {
                     
                        if (zahl > maxZahl)
                        {
                            maxZahl = zahl;
                        }
                        if (zahl < minZahl)
                        {
                            minZahl = zahl;
                        }
                    }
                    

                    else
                    {
                        zahl = -1;
                    }
                    summe += zahl;
                }
                mittlwert = summe / (value);


                Console.WriteLine();
                    Console.WriteLine($"Größte Zahl: " + maxZahl);
                    Console.WriteLine($"Kleinste Zahl: " + minZahl);
                    Console.WriteLine($"Durchschnittswert: " + mittlwert);
                    Console.WriteLine();
                    Console.WriteLine();

                
            }
            else
            {
                Console.WriteLine("falsche Eingabe!");
            }
            */
              
            
        }
    }
}
