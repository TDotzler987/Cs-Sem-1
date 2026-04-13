namespace Cs_Sem_1
{
    internal class A16
    {
        public static void Start()
        {
            Console.WriteLine("Aufgabe 16");
            Console.WriteLine();
            Console.WriteLine("Ich bitte um Eingabe: ");
            string eingabe = Console.ReadLine();
            int eingabeZahl;
            bool eingabeIstZahl = int.TryParse(eingabe, out eingabeZahl);//wird überprüft, ob die eingabe zu einer int konvertiert werden kann
            //eingabe = usereingabe
            // => überprüfen ob useringabe in eine int konvertioert werden kann z.B( 123)
            //  - wenn konvertierung erfolgreich => eingabeIstZahl = true und der wert wird in eingabeZahl gespeichert
            //  - wenn nicht dann eingabeIstZahl = false
            int längeDerEingabe = eingabe.Length;
            int string1 = längeDerEingabe % 2;
            int string2 = 
         
            if (eingabeZahl % 2 == 0)

            {
                Console.WriteLine("Ihr eingegebener Wert ist " + eingabeZahl + " und die Hälfte des Wertes ist " + eingabeZahl / 2 + ".");

            }
            else if (eingabeZahl % 2 != 0)
            {
                Console.WriteLine("Ihr eingegebener Wert ist " + eingabeZahl + " die Hälfte hier von ist " + eingabeZahl / 2 + " mit dem Rest " + eingabeZahl % 2 + ".");
            }
            else
            {
                if (längeDerEingabe % 2 == 0)
                {

                    Console.WriteLine("Ihre Eingabe war das Wort/der String " + eingabe + (" wenn wir dies teilen, ist der erste Teil") + string1 + " und dem zweiten Teil " + string2);
                }
                else
                {
                    Console.WriteLine("Ihre Eingabe war das Wort/der String " + eingabe + (" wenn wir dies teilen, ist der erste Teil") + string3 + " und dem zweiten Teil " + string4" der mittlere Buchstabe ist: "+stringm);
                }

            Console.WriteLine("Taste zum beenden!");
            Console.ReadKey();
        }




    }
}
