using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Sem_1
{
    internal class A9
    {
        public static void Start()
        {
            Console.WriteLine("Aufgabe 9");
           
            int [] zahlen = new int[4];
            zahlen[0] = 70;          
            zahlen[1] = 30;
            zahlen[2] = 89;
            zahlen[3] = 13;
            
            Console.WriteLine(zahlen[0]);
            Console.WriteLine(zahlen[1]);
            Console.WriteLine(zahlen[2]);
            Console.WriteLine(zahlen[3]);

            zahlen[2] = 110;
            zahlen[3] = 13+17;

            int[] zahlen2 = new int[6];
            zahlen2[0] = 70*2/5;
            zahlen2[1] = 30*2/5;
            zahlen2[2] = 110 * 2/5;
            zahlen2[3] = 30 /5*2;
            zahlen2[4] = 200*2;
            zahlen2[5] = 500 *2;

            Console.WriteLine("Erstes Element: " + zahlen2[0]);
            Console.WriteLine("Zweites Element: " + zahlen2[1]);
            Console.WriteLine("Drittes Element: " + zahlen2[2]);
            Console.WriteLine("Viertes Element: " + zahlen2[3]);
            Console.WriteLine("Fünftes Element: " + zahlen2[4]);
            Console.WriteLine("Sechstes Element: " + zahlen2[5]);

            





            Console.ReadKey();
        }
    }
}
