using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Cs_Sem_1
{
    internal class versuch
    {
        public static void Start ()
        {
            Console.Write("Haben wir genug Zeit um zu Planschen ? Bitte Eingabe als true or false:  ");
            String Zeit = Console.ReadLine();

            Console.Write("Haben wir genug Lust um zu Planschen ? Bitte Eingabe als true or false:  ");
            String Lust = Console.ReadLine();

            if (Zeit =="true" && Lust == "true")
                { Console.WriteLine("yeah, fahr ma zum See!"); }
            else
            { Console.WriteLine("bleima lieber daheim.."); }

        }
    }
}
