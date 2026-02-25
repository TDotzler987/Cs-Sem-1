using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Sem_1
{
    internal class StrOperationen
    {
        public static void Start()
        {
            string vName, nName, mail;
            vName = "Thomas";
            nName = "Dotzler";
            mail = "Thomas.Dotzler@tn.eckert-bfw.de";

            string zusammen = string.Format ("Herr {0} {1} hat die Mail: {2}", vName, nName, mail);
            string zusammen2 = ("Herr "+vName +" " + nName+" hat die Mail: " +mail);

            Console.WriteLine(zusammen);
            Console.WriteLine(zusammen2);
            Console.WriteLine();
            Console.WriteLine("Hallo Herr Schmal\n das ist ja sehr interessant \n");
            Console.WriteLine("ein Test \t Test"); //=tabulator
            Console.WriteLine("ein Test \n Test"); //=neue Zeile
            Console.WriteLine("ein Test \\ Test"); //=nächstes Zeichen anzeigen
            Console.WriteLine("ein Test \b Test"); //=Backspace letztes Zeichen löschen
            Console.WriteLine("ein Test \" Test"); //=Anführungszeichen anzeigen

            string testSTR = $"Herr {vName} {nName} hat die Mail: {mail}";
            string testSTR2 = "Herr {vName} {nName} hat die Mail: {mail}";

            Console.WriteLine(testSTR);
            Console.WriteLine(testSTR2);
    
            //@ - Verbatim -Id-Zeichen
            string urlString = @"https://www.youtube.com/watch?v=dQw4w9WgXcQ";
            string test = @"\ @${str1} das ist ein Test {}";
            
            Console.WriteLine(test);

            string einLangesWort = "Donaudampfschifffahrtsgesellschaftskapitänmützenaufkleberkleber";
            Console.WriteLine(einLangesWort);
            Console.WriteLine(einLangesWort.Length);
            int anzahlZeichen = einLangesWort.Length;

            Console.WriteLine();
            Console.WriteLine($"Das Wort {einLangesWort} hat {anzahlZeichen} Zeichen.");

            //string.ToUpper() alle Zeichen in Großbuchstaben umwandeln
            //string.ToLower() alle Zeichen in Kleinbuchstaben umwandeln

            Console.WriteLine(einLangesWort.ToUpper());
            Console.WriteLine(einLangesWort.ToLower());

            Console.WriteLine();

            //string.Trim() entfernt alle Leerzeichen am Anfang und Ende eines Strings
            string dau = "    dümmster anzunehmender User aller Zeiten      ";
            Console.WriteLine(dau + " hat die Länge " + dau.Length);
            dau = dau.Trim();
            Console.WriteLine(dau + "hat die Länge " + dau.Length);


            Console.ReadKey();

        }
    }
}
