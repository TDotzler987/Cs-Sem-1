using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Cs_Sem_1
{
    internal class Useringabe
    {

        public static void Start()
        {
            /*
             Ausgabe für Passwort abfrage
             Userinegabe
             Kontrolle ob Passwort Korrekt
             Ausgabe für falsch => automatische wiedereingabe
             Ausgabe für richtig
             
             */

            Console.Write("bitte geben Sie ihr Passwort ein: ");
            string passwort = Console.ReadLine();
            if (passwort.Length < 8)
            {
                Console.WriteLine("Passwort zu kurz, Passwort mindestens 8 Zeichen lang");
            }
            else
            {
                bool hatSonderzeichen = passwort.Any(c => !char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c));
                if (!hatSonderzeichen)
                {
                    Console.WriteLine("Passwort braucht mindestens ein Sonderzeichen");
                    return;
                }
                else
                {
                    Console.Write("bitte wiederholen Sie Ihre Eingabe: ");
                    Console.WriteLine("(achten Sie auf Groß- und Kleinschreibung");
                    string passwort2 = Console.ReadLine();

                    bool passwortübereinstimmung = passwort == passwort2;
                    if (passwortübereinstimmung)
                    {

                        Console.WriteLine("so far so good");
                        Console.WriteLine();
                        Console.WriteLine(" - so, nun drücken Sie eine Taste - ");
                        Console.ReadKey();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write("Username: ");
                        string Username = Console.ReadLine();
                        string[] unzulässigerUsername = {
                    "Teufel",
                    "Hitler",
                    "Gott",
                    "Meister",
                    "Sexgott"
                };

                        if (Username == unzulässigerUsername[0] || Username == unzulässigerUsername[1]
                            || Username == unzulässigerUsername[2] || Username == unzulässigerUsername[3]
                            || Username == unzulässigerUsername[4])
                        {
                            Console.WriteLine(" - unzulässiger User - ");
                            return;

                        }
                        else
                        {

                            bool Usernamezahl = int.TryParse(Username, out int userZahl);
                            if (Usernamezahl)
                            {
                                Console.WriteLine("bitte keine Zahlen eingeben");
                                return;
                            }
                            else
                                Console.Write("Passwort: ");
                            Console.WriteLine("(achten Sie auf Groß- und Kleinschreibung)");
                            string Password = Console.ReadLine();


                            {

                                bool istPassWortFalsch = Password != passwort;

                                {

                                    if (istPassWortFalsch)
                                    {
                                        Console.WriteLine(" - Sie haben Ihr Passwort jetzt schon vergessen! - ");
                                        return;
                                        //Fehlermeldung 
                                    }
                                    else
                                    {
                                        Console.WriteLine("ja und etz? Login geschafft. Gratualtion :) ");
                                        return;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Die Passwörter stimmen nicht überein!");
                        Console.ReadKey();

                    }
                }
            }
        }
    }
}
