namespace Cs_Sem_1
{
    internal class ArithmetischeOP
    {
        public static void Start()
        {
            Console.WriteLine("###### Arithmetische Operationen ######");
            Console.WriteLine("  ");
            Console.WriteLine("  alles easy");
            Console.WriteLine("by Thomas Dotzler");
            Console.WriteLine(" ");

            // => Mathematische Möglichkeiten:
            // Addieren:        +
            Console.WriteLine(19 + 7);
            Console.WriteLine(42 + 666 + 5 + 2);
            Console.WriteLine("19+7" + 19 + 7);
            //Subtrahieren:     -
            Console.WriteLine(19 - 7);
            Console.WriteLine(22 - 6 - 5);
            Console.WriteLine(66.6 - 0.7);
            //Multiplizieren:   *
            Console.WriteLine(17 * 2);
            Console.WriteLine(42 * 6);
            Console.WriteLine(7.6 * 4.2);
            //Dividieren:       /
            Console.Write("6/2=");
            Console.WriteLine(6 / 2);
            Console.WriteLine(22.0 / 2 / 8);
            Console.WriteLine(7.2 / 3.1);
            //Modulo-Operator:  %
            Console.WriteLine(5 % 2);
            Console.WriteLine(22 % 26 % 25);
            Console.WriteLine(12 % 7);
            Console.WriteLine(10 % 5);
            Console.WriteLine(12 % 7);
            Console.WriteLine(12820 % 5);
            Console.WriteLine(123 % 7);
            Console.WriteLine(5 % 123);
            //Math
            Console.WriteLine(Math.Abs(-42));               //Absolut bzw. Betrag
            Console.WriteLine(Math.Sqrt(144));              //Quadratwurzel, squareroot
            Console.WriteLine(Math.Pow(42,2));              //Power, Potenz
            Console.WriteLine(Math.Round(144.2356433,2));   //runden, Anzahl an Stellen hinterm Komma
            Console.WriteLine(Math.Pow(Math.Pow(3, 2),5));  //Potenz hoch Potenz

        }
    }
}
