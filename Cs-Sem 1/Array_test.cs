using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Sem_1
{
    internal class Array_test
    {
        public static void Start()
        {
            int[] zahlen = new int[5]; //Array mit 5 Elementen erstellen
            zahlen[0] = 42;           //Element an Index 0 den Wert 42 zuweisen
            zahlen[1] = 666;
            zahlen[2] = 1234;
            zahlen[3] = 9876;
            zahlen[4] = 42;
            Console.WriteLine(zahlen[0]); //Element an Index 0 ausgeben
            Console.WriteLine(zahlen[1]);
            Console.WriteLine(zahlen[2]);
            Console.WriteLine(zahlen[3]);
            Console.WriteLine(zahlen[4]);
            Console.WriteLine();
            Console.WriteLine("Länge des Arrays: " + zahlen.Length); //Länge des Arrays ausgeben
            //Array mit Werten erstellen:
            string[] namen = new string[] { "Thomas", "Max", "Lisa", "Anna", "Tim" };
            Console.WriteLine(namen[2]); //Element an Index 2 ausgeben
            //Array mit Werten erstellen - Kurzschreibweise:
            double[] noten = { 1.0, 2.5, 3.7, 4.0, 5.5 };
            Console.WriteLine(noten[3]); //Element an Index 3 ausgeben

            //Arrays - viele Variablen auf einmal
            string str = "hallo";
            //char-Array = { 'h', 'a', 'l', 'l', 'o' };
            Console.WriteLine(str[0]); //string an der Stelle 0 => 'h'
            int längeDesStrings = str.Length; //Länge des Strings => 5
            Console.WriteLine(längeDesStrings);
            Console.WriteLine();

            //=> Mehrdimensionale Arrays:
            int[,] matrix = new int[3, 3]; //2D-Array mit 3 Zeilen und 3 Spalten erstellen
            matrix[0, 0] = 1; //Element in Zeile 0, Spalte 0 den Wert 1 zuweisen
            matrix[0, 1] = 2;
            matrix[0, 2] = 3;
            matrix[1, 0] = 4;
            matrix[1, 1] = 5;
            matrix[1, 2] = 6;
            matrix[2, 0] = 7; //Element in Zeile 2, Spalte 3 den Wert 7 zuweisen => Fehler: Index außerhalb des Bereichs
            matrix[2, 1] = 8;
            matrix[2, 2] = 9;

            Console.WriteLine(matrix[2, 2]); //Element in Zeile 0, Spalte 0 ausgeben

            //=>[] = hierbei handelt es sich um ein Array
            //Datentyp[] nameArray = new Datentyp[AnzahlElemente]{wert1, wert2,...};
            char[]charArray = new char[5] { 'h', 'a', 'l', 'l', 'o' };
            Console.WriteLine(charArray);
            //ähnlich zu:
            char a= 'h';
            char b= 'a';
            char c= 'l';
            char d= 'l';
            char e= 'o';

            //Andere Möglichkeiten:
            //int - Array deklarieren
            //int[] intArray1;
            int[] intArray2 = new int[4]; //ein int-Array mit 4 Elementen erstellen
            int[] intArray3 = { 1, 2, 3, 4, 5, 6, 7 }; //ein int-Array mit 7 Werten erstellen
            //int[] intArray4 = new int[3] { -53, 7, 34 };
            intArray2[0] = 666;
            //Die erste Stelle des intArray2 mit einem Wert gefüllt

            /*
            string[] kapitel = new string [100000]
            string-Array mit Platz für 100000 strings
            Console.WriteLine(intArray3[0]); //Element an Index 0 ausgeben
            Console.WriteLine(intArray3[5]);
            */
            Console.WriteLine("Bitte die Personalnummer von 0 - 4 eingeben:");
            
            string[] vornamen = new string[5]
            {
                "Alex", "Max", "Lisa", "Anna", "Tim",
            };

            string[] nachnamen = new string[5]
            {
                "Stein", "Müller", "Schmidt", "Meier", "Schneider",
            };
            int[] alter = new int[5]
            {
                28, 34, 22, 19, 42,
            };

            int auswahl = 0;
            auswahl = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(vornamen[auswahl]);
                Console.WriteLine(nachnamen[auswahl]);
                Console.WriteLine(alter[auswahl]);
            /*
            Console.WriteLine("Vorname: ");
            vornamen[0] = Console.ReadLine();
            Console.WriteLine("Nachname: ");
            nachnamen[0] = Console.ReadLine();
            Console.WriteLine("Alter: ");
            alter[0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(vornamen[0]);
            Console.WriteLine(nachnamen[0]);
            Console.WriteLine(alter[0]);
            */

            Console.ReadKey();

        }
    }
}
