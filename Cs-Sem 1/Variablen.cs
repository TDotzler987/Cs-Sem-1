using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Sem_1
{
    internal class Variablen
    {
        public static void Start()
        {
            //Datentypen: 
            //Integer: int<=> Ganzzahlen
            int zahl1 = 42;             //Variable zahl1 erstellen und den Wert 42 zuweisen
            int zahl2 = 666;
            int summ = zahl1 + zahl2;
            Console.WriteLine(zahl1);  //Variable zahl1 aufrufen <=> Wert auslesen 
            Console.WriteLine("+");
            Console.WriteLine(zahl2);
            Console.WriteLine("=");
            Console.WriteLine(summ);    //Variable einen anderen Wert zuweisen:
            zahl1 = 2398471;
            Console.WriteLine(zahl1);

            //Double:double <=> Gleitkommazahl
            double pi = 3.14159265389;
            Console.WriteLine("pi=" + pi);
            Console.WriteLine("MATH.PI=" + Math.PI);

            //String: string <=> Zeichenketten
            string vorname = "Thomas";
            string nachname = "Dotzler";
            Console.WriteLine(vorname);
            Console.WriteLine(nachname);
            Console.WriteLine();
            vorname = "Chef";
            Console.WriteLine(vorname);
            
            //Charakter: char <=> einzelne Zeichen:
            char ausrufezeichen = '!';
            Console.WriteLine(ausrufezeichen);
            Console.WriteLine((int)ausrufezeichen);
            int test = 146;
            Console.WriteLine((char)test);

            int zuGroß = 2147483647;        // natürliche Zahlen bis 2^31-1
            Console.WriteLine(zuGroß);
            zuGroß = zuGroß + 10;
            Console.WriteLine(zuGroß);

            int zuklein = -2147483648;
            Console.WriteLine(zuklein);
            zuklein = zuklein - 1;
            Console.WriteLine(zuklein);

            short klein = 32767;            //(2^15)-1
            Console.WriteLine(klein);
            //klein = klein + 1; // geht nicht weil: short != int
            //Console.WriteLine(klein);

            //Boolean: bool <=> Wahrheitswert
            int deinAlter = 18;
            bool altGenug = deinAlter >= 18;
            Console.WriteLine("Alt genug? =>"+altGenug);

            var ortsname = "Regensburg";    //hier wird var zu einem string!
            var postleitzahl = 93057;       //hier wird  var zu einem int!
            //ortsname = 55;                //geht nicht, da die variable bereits als string hinterlegt
            int datum;
            string anrede;
            //geht nicht
            //var testi;

            Console.WriteLine(55);
            Console.WriteLine("55");        //55 (int) ist nicht gleich "55" (string)

            double x = 0.5;
            double y = 0.7;
            x = x * 2;
            x = x*y * 5;
            Console.Write("x = x * y * 5 = ");
            Console.WriteLine(x);





            Console.ReadKey();
        }
    }
}
