using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Sem_1
{
    internal class arrforSchl
    {
        public static void Start()
        {
            Console.WriteLine("Aufg 1");
            int[] array =  [10, 4, 22, 6, 63, 34, 67, 87, 74, 28 ];
            int erg = 0;
            for (int i = 0; i < array.Length; i++)
            {
                erg = erg + array[i]; //ist das selbe wie:  erg += array [i];
                Console.Write($"{array[i]}+");
            }
            Console.Write("\b= "+erg);
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("Aufg 2");
            int[] werte = [10, 4, 22, 6, 63, 34, 67, 87, 74, 28];
            int max = werte[1];
            int min = werte[1];
            for (int i = 0;i < werte.Length; i++)
            {
                if (werte[i] >= max) { max = werte[i]; }
                if (werte[i] <= min) { min = werte[i]; }

            }
            Console.WriteLine($"min-Wert= {min} und max-Wert = {max}");

            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("Aufg 3");

            int[] noten = [10, 4, 22, 6, 63, 34, 67, 87, 74, 28];
            double mitt = 0;
            double sum = 0;
            for (int i = 0;i<noten.Length;i++)
            {
                sum += noten[i];
                mitt++;
            }
            
            Console.WriteLine("Der Mittelwert ist: "+ (sum/mitt));


            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("Aufg 4");

            int[] zahlen = [10, 4, 22, 6, 63, 6, 4, 34, 67, 87, 74, 28];
            for (int i = 0; i < zahlen.Length;i++)
                {
                Console.Write(zahlen[zahlen.Length-i-1]+", ");
                
                }
            Console.Write("\b\b");



            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("Aufg 5");

            int[] zahl = [10, 4, 22, 6, 63, 6, 4, 34, 67, 87, 74, 28];
            Console.Write("Bitte geben Sie eine Zahl ein: ");
            string eing = Console.ReadLine();
            int anz1 = 0;
            int anz2 = 0;
            bool zahle = int.TryParse(eing, out int uzahl);
            if (zahle)
            {

                for (int i = 0; i < zahl.Length; i++)
                {
                    if (uzahl == zahl[i]){ anz1++; };
                    if (uzahl == zahl[i]) { anz2++; }
                    ;

                }


            }
            else
            {
                Console.WriteLine("war keine Zahl");
            }


        }
    }
}
