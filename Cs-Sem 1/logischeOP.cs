using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Cs_Sem_1
{
    internal class logischeOP
    {
        public static void Start()
        {
            Console.WriteLine("######### logische Operationen ########");
            Console.WriteLine(" ");
            Console.WriteLine("take it easy");
            Console.WriteLine("by Thomas Dotzler");
            Console.WriteLine(" ");
            Console.WriteLine(24*2*6>777-23*6);
            Console.WriteLine(42 > 666 || 5 < 42);
            //Kleiner <
            Console.WriteLine(42<666);
            Console.WriteLine(6 * 6 < 5 * 7);
            //Größer >
            Console.WriteLine(77 > 11 * 7);
            Console.WriteLine(99 > 6 + 3 + 5 + 7 + 8 + 5 + 3 + 3 + 45 + 2);
            //Größer/Kleiner gleich >= / =<
            Console.WriteLine(0>=0);
            Console.WriteLine((5-2+5-7+3)*34<=666);
            //Nicht (Umkehrung/Negation) !
            Console.WriteLine();
            Console.WriteLine(!true);
            Console.WriteLine(42 != 42);
            //Verknüpfungen:
            //Oder: || Alt Gr <
            Console.WriteLine(7>7 || 8>8);
            Console.WriteLine(2==3 || 32<42||666<=3||true);
            //und: &&
            Console.WriteLine(12>2 && 6<12);
            Console.WriteLine(2>1 && 66%2==0&&42*3<=5*66);
            Console.ReadKey();
        }
        

    }
}
 