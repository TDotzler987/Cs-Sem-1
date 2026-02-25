using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Sem_1
{
    internal class WH_Vari
    {
        public static void Start()
        {
            //Datentypen und Varibalen

            //Variable anlegen
            //Datentyp Namen = Wert;
            string name = "Dotzler";
            string vorname = "Thomas";
            Console.WriteLine(name);
            Console.WriteLine(vorname);
            Console.WriteLine("Hello World");
            vorname = "Max";
            Console.WriteLine(vorname);
            Console.WriteLine(vorname + " und " + name);

            int zahl = 666;
            Console.WriteLine(zahl);
            zahl = 42;
            Console.WriteLine(zahl);

            char frage = '?';
            Console.WriteLine(frage);

            double kontostand = -42.66;
            Console.WriteLine(kontostand/6);
            Console.WriteLine("Kontostand"+kontostand*8);
            kontostand *= (-2);
            kontostand /= 2;
            kontostand += 1;
            kontostand += 666;
            Console.WriteLine("Kontostand: "+kontostand);
            kontostand++;
            Console.WriteLine("Kontostand: "+kontostand);


        }
    }
}
