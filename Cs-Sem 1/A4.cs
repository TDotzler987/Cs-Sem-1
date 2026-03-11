using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Sem_1
{
    internal class A4
    {
        public static void Start()
        {
            Console.WriteLine("Aufgabe 4");
            Console.WriteLine();

            int int1 = 10;
            double double1 = 5.5;
            string Name = "Dotzler";
            Console.WriteLine(int1);
            Console.WriteLine(double1);
            Console.WriteLine(Name);
            Console.WriteLine();

            Console.Write("Hallo,\nBitte nennen Sie mir ihren Namen:");
            string name = Console.ReadLine();
            Console.WriteLine("Hallo "+name);
            Console.WriteLine();

            Console.WriteLine("bitte geben Sie nun Ihre erste Zahl ein:");
            string zahl1= Console.ReadLine();
            
            Console.WriteLine("bitte geben Sie nun Ihre zweite Zahl ein:");
            string zahl2 = Console.ReadLine();
            double z1 = Convert.ToDouble(zahl1); //String in Integer umwandeln
            double z2 = Convert.ToDouble(zahl2); //String in Integer umwandeln
            var res3 = (z1 + z2);
            Console.WriteLine("Summe= "+res3);
            Console.WriteLine();
            Console.Write("und wie alt sind Sie?");
            string age = Console.ReadLine();
            Console.WriteLine("Sie sind "+age+" Jahre alt und heißen "+name);
            Console.WriteLine();

            Console.ReadKey();

            int ganzzahl1 = 10;
            double dblZahl = Convert.ToDouble(ganzzahl1); //Integer in Double umwandeln
            Console.WriteLine("Int: ");
            Console.WriteLine(ganzzahl1);
            Console.WriteLine(ganzzahl1/3);
            Console.WriteLine("Double: ");
            Console.WriteLine(dblZahl);
            Console.WriteLine(dblZahl / 3);

            string zahlenstring = "12345";
            int zahlenAlsZahl = Convert.ToInt32(zahlenstring); //String in Integer umwandeln
            Console.WriteLine("String: "+zahlenAlsZahl);
            Console.WriteLine();

            double gleitKommaZahl = 5.25;
            int gleitKommaAlsInt = Convert.ToInt32(gleitKommaZahl); //Double in Integer umwandeln
            Console.WriteLine("Double: "+gleitKommaZahl);

            Console.WriteLine();

            Console.ReadKey();

            string wort1 = "Hallo";
            string wort2 = "Welt";
            Console.WriteLine(wort1+" "+wort2);
            string satz = "Das Wort Lagerregal ist ein Palindrom.";
            Console.WriteLine(satz);
            Console.WriteLine("Dieser Satz hat "+satz.Length+" Zeichen");
            Console.WriteLine();

            string gesamt = "Hallo, ich bin Root.";
            string name2 = gesamt.Substring(0,15);
            Console.WriteLine(gesamt);
            Console.WriteLine(name2+name);

            string mitReplace = gesamt.Replace("Root", name);
            Console.WriteLine(mitReplace);
            Console.WriteLine();

            Console.ReadKey();


        }
    }
}
