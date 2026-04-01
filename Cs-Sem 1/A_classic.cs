using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Sem_1
{
    internal class A_classic
    {
        public static void Start()
        {
            //1. Datentypen und Variablen

            int a = 10;
            double b = 5.5;
            string c = "Ihr Name ist: Thomas";
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            //2. Console.WriteLine();

            string ask = "Hallo,\n bitte nennen Sie mir Ihren Nachnamen?";
            Console.Write(ask);
            string name = Console.ReadLine();
            Console.WriteLine("Hallo Mann/Frau/Es/unidivers "+name);
            
            string task = Console.ReadLine();
            string task2 = Console.ReadLine();
            Console.Write ("Sie wollen zwei Zahlen berechnen? \n Bitte teilen Sie mir Zahl 1 mit: "+ task + " und Zahl 2: " + task2); 




        }
    }
}
