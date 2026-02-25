using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Sem_1
{
    internal class Aufg8C_
    {
        public static void Start()
        {
            Console.WriteLine("Aufgabe 8c");
            Console.WriteLine();
            string str1, str2, str3, str4, str5, str6, str7, str8;
            str1 = "wie";
            str2 = "dir";
            str3 = "es";
            str4 = "Danke";
            str5 = "Hallo";
            str6 = "geht";
            str7 = "gut";
            str8 = "mir";
            Console.WriteLine("{0}, {1} {2} {3} {4}?", str5, str1, str6, str3, str2);
            Console.WriteLine("{0}, {1} {2} {3} {4}!", str4, str8, str6, str3, str7);

            Console.WriteLine();

            string zusammen = string.Format("{0}, {1} {2} {3} {4}?", str5, str1, str6, str3, str2);
            string zusammen2 = string.Format("{0}, {1} {2} {3} {4}!", str4, str8, str6, str3, str7);
           
            Console.WriteLine(zusammen);
            Console.WriteLine(zusammen2);

            Console.WriteLine();

            Console.WriteLine($"{str5}, {str1} {str6} {str3} {str2}?\n{str4}, {str8} {str6} {str3} {str7}!");
          
            Console.ReadKey();
        }
    }
}
