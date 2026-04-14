using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Sem_1
{
    internal class Kon_Aufg
    {
        public static void Start()
        {
            Console.WriteLine("Konvert - Aufgabe");
            Console.WriteLine();
            Console.WriteLine("Aufgabe 1");
            Console.WriteLine();

            Console.Write("U in Volt= ");
            string UinV = Console.ReadLine();
            Console.WriteLine("U in Volt: " + UinV);
            Console.Write("I in Ampere= ");
            string IinA = Console.ReadLine();
            Console.WriteLine("I in Ampere= " + IinA);
            
            double UinV2 = Convert.ToDouble(UinV);
            double IinA2 = Convert.ToDouble(IinA);
            
            Console.WriteLine();
            Console.WriteLine("Ergebnisse:");
            Console.WriteLine("elektrische Leistung: " + (UinV2 * IinA2) + " Watt");
            Console.WriteLine("elektrischer Widerstand: " + (UinV2 / IinA2) + " Ohm");

            Console.WriteLine();
            string n1 = Console.ReadLine();
            string n2 = Console.ReadLine();
            string n3 = Console.ReadLine();
            string n4 = Console.ReadLine();

            Console.WriteLine("Nennen Sie Ihre 4 Zahlen:");
            Console.WriteLine("Zahl 1: " + n1);
            Console.WriteLine("Zahl 2: " + n2);
            Console.WriteLine("Zahl 3: " + n3);
            Console.WriteLine("Zahl 4: " + n4);

            double n1d = Convert.ToDouble(n1);
            double n2d = Convert.ToDouble(n2);
            double n3d = Convert.ToDouble(n3);
            double n4d = Convert.ToDouble(n4);

            double res = ((n1d + n2d + n3d + n4d) / 4);
            Console.WriteLine("Der Durchschnitt der 4 Zahlen ist: " + res);

            Console.ReadKey();
        }
    }
}
