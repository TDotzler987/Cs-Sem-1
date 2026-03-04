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

            string wh_und_Test_Variable = "      Das ist ein Test!    ";
            Console.WriteLine(wh_und_Test_Variable.Trim().ToLower());

            bool strTest3 = "Hallo" == "hallo";
            Console.WriteLine(strTest3);
            bool strtTest2 = "Hallo".ToLower() == "hallo".ToLower();
            Console.WriteLine(strtTest2);

            //string => Zeichenkette, Text
            //string = char+char+char+char...
            string strRandom = "Hallo!";
            //     charArray =  'H' + 'a' + 'l' + 'l' + 'o'
            Console.WriteLine(strRandom[0]);
            Console.WriteLine(strRandom[1]);
            Console.WriteLine(strRandom[2]);
            Console.WriteLine(strRandom[3]);
            Console.WriteLine(strRandom[4]);
            Console.WriteLine(strRandom[5]);
            Console.WriteLine(strRandom[strRandom.Length -1]);
            //                strRandom[strRandom.Length -1]
            Console.WriteLine(strRandom[^1]);
            Console.WriteLine(strRandom[^2]);
            // string.substring(Start, Wie_viele_Zeichen);
            string gesamtString = "Hallo, mein Name ist Thomas!";
                                   //01234567891011121314151617181920212223242526272829
            string nameExtrahiert = gesamtString.Substring(21,7);
            Console.WriteLine(nameExtrahiert);



            Console.ReadKey();

        }
    }
}
