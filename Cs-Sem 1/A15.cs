using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Sem_1
{
    internal class A15
    {
          public static void Start()
        {
            Console.WriteLine("Aufgabe 15");
            Console.WriteLine();
            Console.WriteLine("Geben Sie eine Zahl ein: ");
            string eingabe = Console.ReadLine();
            int zahl = Convert.ToInt32(eingabe);
            if (zahl % 2 == 0)
            {
                Console.WriteLine("Die Zahl " + zahl + " ist gerade.");
            }
            else
            {
                Console.WriteLine("Die Zahl " + zahl + " ist ungerade.");
            }
            if (zahl > 0)
            {
                Console.WriteLine("Die Zahl " + zahl + " ist positiv.");
            }
            else if (zahl < 0)
            {
                Console.WriteLine("Die Zahl " + zahl + " ist negativ.");
            }
            else
            {
                Console.WriteLine("Die Zahl ist 0.");
            }
            if (zahl % 7 == 0)
            {
                Console.WriteLine("Die Zahl " + zahl + " ist durch 7 teilbar.");
            }
            else
            {
                Console.WriteLine("Die Zahl " + zahl + " ist nicht durch 7 teilbar.");
            }
            if (zahl > 100)
            {
                Console.WriteLine("Die Zahl " + zahl + " ist größer als 100.");
            }
            else if (zahl < 100)
            {
                Console.WriteLine("Die Zahl " + zahl + " ist kleiner als 100.");
            }
            else
            {
                Console.WriteLine("Die Zahl ist 100.");
            }

            if (zahl <100)
            {
                Console.WriteLine("Die Zahl hat weniger als drei Stellen");
            }
            else if (zahl >= 100 && zahl < 1000)
            {
                Console.WriteLine("Die Zahl hat drei Stellen");
            }
            else
            {
                Console.WriteLine("Die Zahl hat mehr als drei Stellen");
            }
            Console.ReadKey();
        }
    }
}
