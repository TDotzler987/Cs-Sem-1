using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Sem_1
{
    internal class Schleifchen
    {
        public static void Start()
        {
            Console.WriteLine("Hier ist eine Übung mit Schleifen und Schleifchen");
            Console.WriteLine("""
                 
                ~~    ___        ___     ~~ 
                   /       \  /       \    
                  |         ||         |
                   \  ___  /  \  ___  /   
                ~~                      ~~
                
                """);
            Console.WriteLine();
            Console.WriteLine("die While - Schleife");
            Console.WriteLine();
            Console.WriteLine();

            //int x = 66/4;
            /*
            Kontrollstrukturen
            if; if-else, if-elseif-elseif-else, 
            switch (...){case 1, case 2,...}

            */
            /*
            if (true) // true => immer wahr
            {
                Console.WriteLine("das ist ein if");
            }
            bool b = true;
            */
            /*
            while (b)
            {
                Console.WriteLine("das ist eine While - Schleife");
                Console.WriteLine();

            }
            */

            /*
            bool istSchleifeAktiv = true;
            int counter = 0;
            while (!Console.KeyAvailable && istSchleifeAktiv)
            {
              
                Console.WriteLine("Hallo! Bitte geben Sie etwas ein:");
                Console.WriteLine("Durchgang " + counter);
                //string eingabe = Console.ReadLine();
                counter++;
                if (counter == 1000)
                {
                    istSchleifeAktiv=false;
                    Console.WriteLine("zu langsam");
                    
                }
            }
            
            Console.WriteLine("Schleife ist fertig");
            */
            /*
            int zähler = 0;
            var key = Console.ReadKey();
            while (zähler < 120000)
                
                {
                    Console.WriteLine(zähler);
                    zähler++;
                    
                }
            */
            /*
            Beispiel für ein Menü mit switch und while
                1. neue zufahlszahl erstellen
                2. zahl anzeigen
                3. exit
            */
            /*
            Random rnd = new Random();
            int zufallszahl = 0;
            bool istAktiv = true;
            while (istAktiv)
            {
                Console.WriteLine("_____________");
                Console.WriteLine("1. Neue Zahl ");
                Console.WriteLine("2. Anzeigen  ");
                Console.WriteLine("3. !!Exit!!  ");
                Console.WriteLine("_____________");
                Console.WriteLine("");
                string eingabeString = Console.ReadLine();
                Console.Clear();

                switch (eingabeString)
                {
                    case "1":
                        Console.WriteLine("Sie haben sich für eine neue Zufallszahl entschieden");
                        zufallszahl = rnd.Next(-100, 101);  //Zufallszahl zwischen -100 und 100
                        break;
                    case "2":
                        Console.WriteLine("Hier die Zahl: ");
                        Console.WriteLine("=> " + zufallszahl);
                        break;
                    case "3": Console.WriteLine("Tschüss");
                        istAktiv = false;
                        break;
                    case "4": Console.WriteLine("falsche Zahl");
                        istAktiv = false;
                        break;
                    default:
                        Console.WriteLine("default");
                        break;
                }
                */
            /*
            int i = 0;
            string[] strArr = {"W","A","S","D"};
            Random rnd = new Random();
            while (i < 10000)

            {
                i++;
                int zufallszahl = rnd.Next(0, 4);
                Console.Write(strArr[zufallszahl] + " ");
                if (i % 10 == 0)
                {
                    Console.WriteLine("");
                }
                  
            }
            */

            /*
               Console.WriteLine("nun werden alle gerade Zahlen zwischen 0 und 20 ausgegeben:");
               Console.WriteLine("weiter mit beliebiger Taste");
               Console.Clear();

               Console.WriteLine();

               int zahl1 = 0;
               while (zahl1 <= 21)
               {

                   Console.WriteLine("Durchgang " + zahl1);
                   zahl1 = zahl1 + 2;
               }
               Console.WriteLine();
               Console.WriteLine("fertsch");


              int counter = 0;
              while (counter <= 20)
               {
                  if (counter % 2 == 0)
                  {
                      Console.WriteLine (counter);
                  }
                  counter ++;
               }
   */

            /*
             */
            /*

            Console.WriteLine("bis zu welcher Zahl soll es denn ausgegeben werden?");
            string eing = Console.ReadLine();
            int summe = 0;
            int zahl = 0;
        

            bool eingzahl = int.TryParse(eing, out zahl);
            if (eingzahl)
            {
                for (int i = 0; i <= zahl; i++)
                { 
                    summe += i;
                }

                Console.WriteLine();
                Console.WriteLine("Ergebnis der Summe von 0 bis " + eing + " = " + summe);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

            }
            else
            {
                Console.WriteLine("bitte gib eine Zahl ein");
            }
            */
            /*
            Console.WriteLine("bitte eine Zahl zwischen 1 - 25 eingeben");
            int eingabZ = -1;
            int produkt = 1;
            while (!int.TryParse(Console.ReadLine(), out eingabZ) || eingabZ > 25 || eingabZ <= 0);
            {
                Console.WriteLine("falsche Eingabe");
            }
            Console.Clear();

            while (eingabZ > 0)
            {
                produkt *= eingabZ;
                Console.Write(eingabZ + " * ");
                eingabZ -= 1;
                
            }
            Console.WriteLine("\b\b = " + produkt);
            
            bool schalter = true;
            while (schalter) //wiederhole das in den Klammern solange bis es (true) wird
            {
                if (TASTE GEDRÜCKT)  //müste man mit Console.ReadKey/ReadLine implementieren
                        {
                    schalter = false;
                }
            }

            */




            //while-Schleife
            // tue etwas, solange (true) steht

            int x = 0;
            while (x <10)
            {
                Console.WriteLine(x);
                x++;
            }
            // for- Schleife 
            //variable, Boolscher Ausdruck, Variablenveränderung
            //Zählergesteuerte Schleife
            for (int y = 0; y < 10; y++)
            {
                Console.WriteLine(y);
            }
            int[] intARR = { 666, 42, 6, 7, 88, 90, 103, 4};
            string[] stringARR = { "Test", "Hallo", "Lagerregal", "Platzhalter", "Mütze", "Kopf", "Projekt", "Management" };
            for (int i = 0; i < stringARR.Length; i++)
            {
                Console.WriteLine($"Auf Position {i} gilt für die Nummer: {intARR[i]} gilt der string: {stringARR[stringARR.Length - 1 - i]}");
                intARR[i] = i * i;
            }


            for ( int y = 1; y>= 0;  y *= 10 )
            {
                Console.WriteLine(y);
            }

            //foreach - Schleife
            //nur lese-Zugriff
            //foreach (Variable in Array/Liste)
            foreach (int i in intARR)
            {
                Console.WriteLine(i);
            }
            foreach(string str in stringARR)
            { 
                Console.WriteLine(str);
            }

            //Alternativ: 
            foreach (var i in  intARR)
            {
                Console.WriteLine(i);
            }
            /*
            while (false)
            {
                Console.WriteLine("ich bin die while-Schleife");
            }
            */

            string? pswd = "passwort 123";
            bool falschesPasswort = true;
            int pwVersuche = 0;
            string ende = ("ende gut, alles gut");
            string stopp = ("nix gut");

            do
            {
                Console.WriteLine("Bitte Passwort eingeben: ");
                string? eing = Console.ReadLine();
                if (eing == pswd) 
                {
                    falschesPasswort = false;
                    Console.WriteLine(ende);
                    
                }                
                else
                {
                    pwVersuche++;
                }
                Console.Clear();
                if (pwVersuche >= 3)
                {
                    Console.WriteLine("zu viele Versuche");
                    falschesPasswort = false;
                    Console.WriteLine(stopp);
                }
                    
            }

            while (falschesPasswort);


        }
    }

}