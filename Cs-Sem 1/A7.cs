using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Sem_1
{
    internal class A7
    {
        public static void Start()
        {
            
            
            Console.Write("Hallo,\nBitte geben Sie einen String ein:");//Ausgabe ohne Zeilenumbruch
            string eing = Console.ReadLine();                          //Variable vom Typ string definieren
            eing = eing.Trim().ToUpper();                              //String trimmen und in Großbuchstaben umwandeln
            Console.WriteLine("Länge: "+eing.Length);                  //Ausgabe der Länge des Strings

            Console.WriteLine("Erster Buchstabe: " + eing[0]);         //Ausgabe des ersten Buchstabens
            Console.WriteLine("Letzer Buchstabe: " + eing[^1]);        //Ausgabe des letzten Buchstabens


            Console.ReadKey();

        }
    }
}
