using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Sem_1
{
    internal class A_5
    {
        public static void Start()
        {
            string gesamtString = " werPolizeidjsue ";

            gesamtString = gesamtString.Trim();
            Console.WriteLine(gesamtString);
            Console.WriteLine("Anzahl: "+gesamtString.Length);
            string neuerstring = gesamtString.Substring(3, 7);
            Console.WriteLine(neuerstring);
            Console.WriteLine(neuerstring.ToUpper());


            //Start - string
            string input = " werPolizeidjsue ";
            //führende und endende Leerzeichen entfernen
            string inputohneLeerzeichen = input.Trim();
            Console.WriteLine(inputohneLeerzeichen);
            //substring bilden
            string polizei = inputohneLeerzeichen.Substring(3, 7);
            Console.WriteLine("Anzahl: "+inputohneLeerzeichen.Length);
            Console.WriteLine(polizei);
            Console.WriteLine (polizei.ToUpper());




            Console.ReadKey();
        }
    }
}
