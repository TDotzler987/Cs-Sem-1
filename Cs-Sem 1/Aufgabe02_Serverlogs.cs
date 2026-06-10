// ============================================================
//  ECKERT SCHULEN – Berufsförderungswerk
//  C# Grundlagen | Schleifen & Arrays
// ------------------------------------------------------------
//  Aufgabe 02: Serverlog-Auswertung
//  Klasse:     Fachinformatiker/in (FIAE / FISI)
// ------------------------------------------------------------
//  SZENARIO:
//  Du arbeitest im IT-Support eines Unternehmens. Ein
//  Webserver hat in der letzten Stunde 50 Anfragen bearbeitet.
//  Die Antwortzeiten (in ms) und HTTP-Statuscodes wurden
//  automatisch protokolliert. Deine Aufgabe ist es, die Daten
//  auszuwerten, um Probleme zu identifizieren.
//
//  HINWEIS: Verändere NICHT die vorgegebenen Arrays!
//           Schreibe deinen Code ausschließlich in den
//           mit TODO markierten Abschnitten.
// ============================================================

using System;

class Aufgabe02_Serverlogs
{
    public static void Start()
    {
        // ----------------------------------------------------------
        // VORGEGEBENE DATEN
        // ----------------------------------------------------------

        // Antwortzeiten in Millisekunden (50 Anfragen)
        int[] antwortzeiten = {
             142,  87, 203,  55, 412,  98, 177,  63, 521,  44,
             189, 302,  71, 144,  88, 437,  56, 293,  99, 618,
             201,  73, 158,  84, 349,  67, 482,  92, 133,  78,
             274, 101,  59, 388,  65, 217,  83, 145, 503,  77,
              91, 162,  48, 329,  88, 195,  72, 411,  53, 244
        };

        // HTTP-Statuscodes zu jeder Anfrage (gleicher Index!)
        // 200 = OK | 301 = Redirect | 404 = Not Found | 500 = Server Error
        int[] statuscodes = {
            200, 200, 200, 301, 500, 200, 200, 200, 404, 200,
            200, 301, 200, 200, 200, 500, 200, 200, 200, 500,
            200, 200, 200, 200, 301, 200, 404, 200, 200, 200,
            200, 200, 200, 500, 200, 200, 200, 200, 404, 200,
            200, 200, 200, 301, 200, 200, 200, 500, 200, 200
        };

        // Endpunkte, die aufgerufen wurden (gleicher Index!)
        string[] endpunkte = {
            "/home",       "/login",      "/api/data",   "/home",       "/api/upload",
            "/dashboard",  "/profile",    "/login",      "/api/delete", "/home",
            "/api/data",   "/home",       "/settings",   "/dashboard",  "/login",
            "/api/upload", "/home",       "/api/data",   "/profile",    "/api/upload",
            "/dashboard",  "/login",      "/api/data",   "/home",       "/home",
            "/settings",   "/api/delete", "/dashboard",  "/login",      "/api/data",
            "/profile",    "/home",       "/login",      "/api/upload", "/home",
            "/dashboard",  "/api/data",   "/login",      "/api/upload", "/home",
            "/settings",   "/profile",    "/login",      "/home",       "/dashboard",
            "/api/data",   "/login",      "/api/delete", "/home",       "/profile"
        };

        Console.WriteLine("=== Serverlog-Auswertung | Letzde Stunde ===");
        Console.WriteLine($"Ausgewertete Anfragen: {antwortzeiten.Length}");
        Console.WriteLine();


        // ----------------------------------------------------------
        // AUFGABE 1 (★☆☆) – Durchschnittliche Antwortzeit
        // ----------------------------------------------------------
        // Berechne die durchschnittliche Antwortzeit aller Anfragen.
        // Format: "Durchschnittliche Antwortzeit: 183,5 ms"
        // ----------------------------------------------------------

        Console.WriteLine("--- Performance-Überblick ---");

        // TODO Aufgabe 1 – dein Code hier:
        double avg = 0;
        for (int i = 0; i < endpunkte.Length; i++)
        {
            avg += antwortzeiten[i];

        }
        Console.WriteLine($"Durchschnittliche Antwortzeit: {avg/antwortzeiten.Length} ms");
        Console.WriteLine();


        Console.WriteLine();


        // ----------------------------------------------------------
        // AUFGABE 2 (★☆☆) – Schnellste und langsamste Anfrage
        // ----------------------------------------------------------
        // Finde die schnellste und die langsamste Antwortzeit.
        // Gib zusätzlich den zugehörigen Endpunkt aus.
        // Format: "Schnellste Anfrage: 44 ms  -> /home"
        //         "Langsamste Anfrage: 618 ms -> /api/upload"
        // ----------------------------------------------------------

        // TODO Aufgabe 2 – dein Code hier:

        uint min = (uint)antwortzeiten[0], max = 0, maxIndex = 0, minIndex = 0;
        for (int i= 0; i<antwortzeiten.Length; i++)
        {
            if (antwortzeiten[i] > max)
            {
                max = (uint)antwortzeiten[i];
                maxIndex = (uint)i;
            }
            if (antwortzeiten[i] < min)
            {
                min = (uint)(antwortzeiten[i]);
                minIndex = (uint)i;
            }
        }
        string ausgabe = $"schnellste Anfrage: {min} ms -> {endpunkte[minIndex]} \n" + $"langsamste Anfrage: {max} ms -> {endpunkte[maxIndex]}";
        Console.WriteLine(ausgabe);
        Console.WriteLine();


        Console.WriteLine();


        // ----------------------------------------------------------
        // AUFGABE 3 (★★☆) – Statuscodes auswerten
        // ----------------------------------------------------------
        // Zähle, wie oft jeder Statuscode vorkommt.
        // Gib die Ergebnisse übersichtlich aus.
        // Format: "200 OK:           38 Anfragen"
        //         "301 Redirect:      4 Anfragen"
        //         "404 Not Found:     3 Anfragen"
        //         "500 Server Error:  5 Anfragen"
        //
        // Hinweis: Vier separate Zählvariablen verwenden.
        //          Kein Array oder Dictionary nötig.
        // ----------------------------------------------------------

        Console.WriteLine("--- Statuscode-Verteilung ---");

        // TODO Aufgabe 3 – dein Code hier:
        
        int count200 = statuscodes.Count(x => x == 200);
        int count301 = statuscodes.Count(x => x == 301);
        int count404 = statuscodes.Count(x => x == 404);
        int count500 = statuscodes.Count(x => x == 500);

        Console.WriteLine("200 OK:           " + count200 + " Anfragen");
        Console.WriteLine("301 Redirect:      " + count301 + " Anfragen");
        Console.WriteLine("404 Not Found:     " + count404 + " Anfragen");
        Console.WriteLine("500 Server Error:  " + count500 + " Anfragen");

        Console.WriteLine();


        // ----------------------------------------------------------
        // AUFGABE 4 (★★☆) – Fehlerhafte Anfragen anzeigen
        // ----------------------------------------------------------
        // Gib alle Anfragen aus, die KEINEN Statuscode 200 hatten.
        // Format:
        //   "Anfrage  5: /api/upload   | Status 500 | 412 ms  ← FEHLER"
        //   "Anfrage 10: /api/delete   | Status 404 |  44 ms  ← FEHLER"
        //   ...
        //
        // Denkanstoß: Wie viele dieser Fehler sind kritisch (500)?
        //             Gib diese Zahl am Ende aus.
        // ----------------------------------------------------------

        Console.WriteLine("--- Fehlerhafte Anfragen ---");

        // TODO Aufgabe 4 – dein Code hier:

        for (int i = 0; i < statuscodes.Length; i++)
        {
            if (statuscodes[i] != 200)
            {
                string fehler = statuscodes[i] == 500 ? " ← FEHLER (kritisch)" : " ← FEHLER";
                Console.WriteLine($"Anfrage {i + 1}: {endpunkte[i],-15} | Status {statuscodes[i],-3} | {antwortzeiten[i],4} ms{fehler}");
            }
        }


        Console.WriteLine();


        // ----------------------------------------------------------
        // AUFGABE 5 (★★★) – SLA-Verletzungen erkennen
        // ----------------------------------------------------------
        // Das SLA (Service Level Agreement) des Unternehmens legt
        // fest: Antwortzeiten über 400 ms gelten als Verletzung.
        // Über 500 ms gelten als kritisch.
        //
        // Berechne und gib aus:
        //   a) Anzahl und Anteil (%) aller SLA-Verletzungen (> 400 ms)
        //   b) Anzahl kritischer Verletzungen (> 500 ms)
        //   c) Alle kritischen Anfragen mit Endpunkt und Statuscode
        //
        // Format: "SLA-Verletzungen: 7 von 50 (14,0 %)"
        //         "Davon kritisch (>500 ms): 3"
        // ----------------------------------------------------------

        Console.WriteLine("--- SLA-Auswertung ---");

        // TODO Aufgabe 5 – dein Code hier:




        Console.WriteLine();


        // ----------------------------------------------------------
        // AUFGABE 6 (★★★) – Häufigster Endpunkt
        // ----------------------------------------------------------
        // Finde den Endpunkt, der am häufigsten aufgerufen wurde.
        // Gib Endpunkt und Anzahl der Aufrufe aus.
        //
        // Format: "Häufigster Endpunkt: /home (15 Aufrufe)"
        //
        // Hinweis: Lege ein zweites string-Array mit allen
        //          eindeutigen Endpunkten an und zähle dann
        //          mit einer verschachtelten Schleife.
        //
        // Eindeutige Endpunkte:
        string[] einzigartig = {
            "/home", "/login", "/api/data", "/api/upload",
            "/api/delete", "/dashboard", "/profile", "/settings"
        };
        // ----------------------------------------------------------

        Console.WriteLine("--- Endpunkt-Häufigkeit ---");

        // TODO Aufgabe 6 – dein Code hier:




        Console.WriteLine();
        Console.WriteLine("=== Auswertung abgeschlossen ===");
    }
}
