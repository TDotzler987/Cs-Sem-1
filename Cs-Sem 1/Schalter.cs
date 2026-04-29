using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Sem_1
{
    internal class Schalter
    {
        public static void Start()
        {
            // short ifs = ternäre Operatoren
            // BEDINGUNG ? AUSDRUCK (WAHR) : AUSDRUCK (FALSCH)
            //string eingabe = Console.ReadLine () == null ? " " : "0";
            /* int y = 0;
            int z = 0;
            string b = Console.ReadLine();
            if (int.TryParse(b, out int x))
            {
                if (x >= 5)
                {
                    y = x % 2;
                    z = y != 0 ? x / y : 1;
                }


                else if (y != 0)
                {
                    z = x / y;
                }
                else
                {
                    z = 1;

                }
                
                 oder verschachtelt: int zahl = (x>3) ? x < 100 ? 1:2:3;
                
            
            int value = Console.Read();
            Console.WriteLine(value);
            int zahl = -1;
            switch (value)
            {
                case 48:
                    zahl = 0;
                    break;
                case 49: 
                    zahl = 1; 
                    break;
                case 50: 
                    zahl = 2;
                    break;
                default:
                    Console.WriteLine("das ist eine Zahl"); ;
                    break;
            }
      
            Console.ReadKey();

            
            
            while (true)
            {

                switch (Console.ReadKey().Key)   //Eingabe einer Taste => .Key ist die Information über die Taste
                {
                    case ConsoleKey.W:
                        Console.Clear();
                        Console.WriteLine("Sie gehen nach Norden");
                        break;
                    case ConsoleKey.A:
                        Console.Clear();
                        Console.WriteLine("Sie gehen nach Westen");
                        break;
                    case ConsoleKey.D:
                        Console.Clear();
                        Console.WriteLine("Sie gehen nach Osten");
                        break;
                    case ConsoleKey.S:
                        Console.Clear();
                        Console.WriteLine("Sie gehen nach Süden");
                        break;
                    case ConsoleKey.Enter:
                        Console.WriteLine("Mahlzeit");
                        Console.Clear();
                        break;
                    case ConsoleKey.G:
                        Console.Clear();
                        Console.WriteLine("Sie gehen gerade aus");
                        break;
                    case ConsoleKey.Escape:
                        Console.Clear();
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("sie bleiben kurz stehen");
                        break;
                }
            }
            Console.WriteLine("Bitte Vornamen eingeben:");
            string eingabeString = Console.ReadLine();

            switch (eingabeString)
            {
                case "Roman":
                    Console.WriteLine("Dozent");
                    break;
                case "Thomas":
                    Console.WriteLine("Yeahi Ich bins!");
                    break;
                case "Sebastian":
                    Console.WriteLine("Buh Sebi");
                    break;

                default:
                    Console.WriteLine(eingabeString + " wer??");
                    break;
            }*/
            
           
            while (true)
            {
                
                Console.WriteLine("Bitte geben Sie eine Begrüßung ein:");
                string eingabe = Console.ReadLine();
                eingabe = eingabe.ToLower().Trim();
                {
                    switch (eingabe)
                    {
                        case "servus" or "habadere" or "haba dere" or "habe die ehre" or "griaß di" or "griass di":
                            Console.Clear();
                            Console.WriteLine("Kenne, Griaß Di!");
                            break;
                        case "hi" or "hallo" or "guten tag" or "grüß sie" or "grüß dich" or "gruess dich":
                            Console.Clear();
                            Console.WriteLine("Diese Eingabe ist mir bekannt, Guten Tag auch");
                            break;
                        case "end" or "ende"or "tschüss" or "auf hearn" or "aufhearn" or "stop" or "stopp":
                            return;
                        default:
                            Console.WriteLine("Stoffl! Schreibs gscheid oda laus! ");
                            break;
                    }
                }
                Console.WriteLine("Beliebige Taste drücken: ");
                if(Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    return;
                }
                Console.Clear();
            }
        }
    }

}

