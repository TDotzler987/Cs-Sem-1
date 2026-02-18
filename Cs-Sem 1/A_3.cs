using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Sem_1
{
    internal class A_3
    {
        public static void Start()
        {
            Console.WriteLine("Aufgabe 3");
            Console.WriteLine();
            int var1 = 160;
            int var2 = 20;

            string string1 = ("Willkommen im 1. Sommersemester für IT 2026");
            string string2 = ("Hier kommt das Ergebnis:");

            Console.WriteLine(string1);
            Console.WriteLine(string2);

            int res = (var1 / var2 / 2 * var2 - var1) + (3 * var2);
            Console.WriteLine(res % 27);

            var1 = 3600;
            var2 = 360;
            res = (var1 / var2 / 2 * var2 - var1) + (3 * var2);
            Console.WriteLine(res % 27);

            Console.ReadKey();
        }
    }
}