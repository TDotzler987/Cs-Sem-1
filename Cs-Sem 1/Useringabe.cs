using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
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
            bool pwSchalter = true;

            Console.WriteLine(
              "Passwort-Speicherung und Überprüfung mit Username-Eingabe \n"+
               "\n"+
            "Bitte beachten Sie die Richtlinien der Passworteingabe");
            Console.WriteLine();
            Console.WriteLine();
            while (pwSchalter) 
            { 
            Console.WriteLine("bitte geben Sie nun bitte ihr Passwort ein für die Richtlinien drücke zuerst F8: ");
            
                
                //jetzt verschluckt er den ersten Buchstaben
                //nun wird die erste Taste angeschaut abgefangen und gespeichert und überprüft ob F8

                StringBuilder password1 = new StringBuilder();
                ConsoleKeyInfo firstKey = Console.ReadKey(true); // Erste Taste abfangen (unsichtbar)

                if (firstKey.Key == ConsoleKey.F8)

                {
                    Console.WriteLine();
                    Console.WriteLine(
                        "Richtlinien Usereingabe \n" +
                        "Bei der Usereingabe sind  Usernamen wie Herr, Gott, Teufel, Chef, Meister, Sexgott oder Hitler nicht zulässig \n" +
                        "\n" +
                        "Richtlinien Passworteingabe \n" +
                        "Bei der Passworteingabe benötigen Sie ein Wort mit mindestens acht Zeichen, ein Sonderzeichen und einer Zahl"
                        );
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("-- weiter mit beliebiger Taste --");
                    Console.ReadKey();
                    Console.Clear();
                    password1.Clear();
                    continue ;


                }
                else 
                    {
                        password1.Append(firstKey.KeyChar);
                        Console.Write("*"); // Erstes Zeichen maskieren
                    }

                    ConsoleKeyInfo key;


                    do
                    {
                        key = Console.ReadKey(true);
                        if (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Backspace)
                        {
                            password1.Append(key.KeyChar);
                            Console.Write("*"); // Zeigt * statt Zeichen
                        }
                        else if (key.Key == ConsoleKey.Backspace && password1.Length > 0)
                        {
                            password1 = password1.Remove(password1.Length -1, 1);
                            Console.Write("\b \b"); // Löscht das letzte Sternchen in der Konsole
                        }
                    } while (key.Key != ConsoleKey.Enter);
                
                    Console.WriteLine();
                    string password = password1.ToString();
                    if (password.Length < 8)
                    {
                        Console.WriteLine("Passwort zu kurz, Passwort mindestens 8 Zeichen lang");
                    }
                    else
                    {
                        bool hatSonderzeichen = password.ToString().Any(c => !char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c));
                        if (!hatSonderzeichen)
                        {
                            Console.WriteLine("Passwort braucht mindestens ein Sonderzeichen");
                            return;
                        }
                        else
                        {
                            Console.Write("bitte wiederholen Sie Ihre Eingabe: ");
                            Console.WriteLine("(achten Sie auf Groß- und Kleinschreibung)");
                            string password2 = "";
                            do
                            {
                                key = Console.ReadKey(true);
                                if (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Backspace)
                                {
                                    password2 += key.KeyChar;
                                    Console.Write("*"); // Zeigt * statt Zeichen
                                }
                                else if (key.Key == ConsoleKey.Backspace && password2.Length > 0)
                                {
                                    password2 = password2.Substring(0, (password2.Length - 1));
                                    Console.Write("\b \b"); // Löscht das Sternchen in der Konsole
                                }
                            } while (key.Key != ConsoleKey.Enter);
                            
                            Console.WriteLine();

                            if (password == password2)
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
                                "Chef",
                                "chef",
                                "Sexgott"
                    };


                                if (Username == unzulässigerUsername[0] || Username == unzulässigerUsername[1]
                                    || Username == unzulässigerUsername[2] || Username == unzulässigerUsername[3]
                                    || Username == unzulässigerUsername[4] || Username == unzulässigerUsername[5]
                                    || Username == unzulässigerUsername[6])
                                {
                                    Console.WriteLine(" - unzulässiger User - ");
                                    return;

                                }
                                else
                                {
                                
                                {
                                    
                                }
                                bool Usernamezahl = int.TryParse(Username, out int userZahl);
                                if (Usernamezahl)
                                {
                                    Console.WriteLine("bitte keine Zahlen eingeben");
                                    return;
                                }
                                else
                                    
                                      
                                    Console.Write("Passwort: ");
                                    Console.WriteLine("(achten Sie auf Groß- und Kleinschreibung)");
                                    string Password = "";
                                    do
                                    {
                                        key = Console.ReadKey(true);
                                        if (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Backspace)
                                        {
                                            Password += key.KeyChar;
                                            Console.Write("*"); // Zeigt * statt Zeichen
                                        }
                                        else if (key.Key == ConsoleKey.Backspace && Password.Length > 0)
                                        {
                                            Password = Password.Substring(0, (Password.Length - 1));
                                            Console.Write("\b \b"); // Löscht das Sternchen in der Konsole
                                        }
                                    } while (key.Key != ConsoleKey.Enter);
                                

                                    Console.WriteLine();


                                    bool istPassWortFalsch = Password != password;

                                    {

                                        if (istPassWortFalsch)
                                        {
                                            Console.WriteLine(" - Sie haben Ihr Passwort jetzt schon vergessen! - ");
                                        
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
    }

