using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Sem_1
{
    internal class A6
    {
        public static void Start()
        {
            Console.WriteLine("Aufgabe 6");
            Console.WriteLine();
            Console.Write("Geben Sie Ihren Namen ein: ");
            string name = Console.ReadLine();
            Console.WriteLine("Grüß Dich "+name);
            Console.WriteLine();
            Console.Write("Geben Sie Ihr Alter ein: ");
            string age = Console.ReadLine();
            Console.WriteLine("mit " + age + " liegt das Leben noch vor Dir :) ");
            string alterString = Console.ReadLine();
            Console.WriteLine(  );

            string str1 = "", str2 = "", str3 = "", str4 = " ";
            
            Console.Write ("zuständiger Lehrer: ");
            str1 = Console.ReadLine();
            Console.Write("Schüler: ");
            str2 = Console.ReadLine();
            Console.Write("gefehlt/Mist gebaut/toll aufgepasst/eine Belobigung erhalten: ");
            str3 = Console.ReadLine();
            Console.Write("Meldender Schülernachname: ");
            str4 = Console.ReadLine();
            Console.WriteLine();

            string eingabeTest = $"Hallo Herr {str1}!\n\nIch habe eine Nachricht für Sie.\n \n{str2} hat " +
                $"gestern im Unterricht {str3}.\n\nBeste Grüße \n{name +" "+ str4} \n";
            Console.WriteLine(eingabeTest);



            Console.ReadKey();
        }
    }
}
