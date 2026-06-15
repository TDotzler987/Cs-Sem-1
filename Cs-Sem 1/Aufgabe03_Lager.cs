// ============================================================
//  ECKERT SCHULEN – Berufsförderungswerk
//  C# Grundlagen | Schleifen & Arrays
// ------------------------------------------------------------
//  Aufgabe 03: Lagerbestandsverwaltung
//  Klasse:     Fachinformatiker/in (FIAE / FISI)
// ------------------------------------------------------------
//  SZENARIO:
//  Du entwickelst ein einfaches Auswertungsprogramm für das
//  Lager eines IT-Händlers. Alle Artikeldaten sind in
//  parallelen Arrays gespeichert – Index 0 in ALLEN Arrays
//  gehört zum selben Artikel.
//
//  HINWEIS: Verändere NICHT die vorgegebenen Arrays!
//           Schreibe deinen Code ausschließlich in den
//           mit TODO markierten Abschnitten.
// ============================================================

using System;

internal class Aufgabe03_Lager
{

    public static void Start()
        {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
    
        // ----------------------------------------------------------
        // VORGEGEBENE DATEN (40 Artikel)
        // ----------------------------------------------------------

        string[] artikelnummer = {
            "ART-001", "ART-002", "ART-003", "ART-004", "ART-005",
            "ART-006", "ART-007", "ART-008", "ART-009", "ART-010",
            "ART-011", "ART-012", "ART-013", "ART-014", "ART-015",
            "ART-016", "ART-017", "ART-018", "ART-019", "ART-020",
            "ART-021", "ART-022", "ART-023", "ART-024", "ART-025",
            "ART-026", "ART-027", "ART-028", "ART-029", "ART-030",
            "ART-031", "ART-032", "ART-033", "ART-034", "ART-035",
            "ART-036", "ART-037", "ART-038", "ART-039", "ART-040"
        };

        string[] bezeichnung = {
            "Laptop Business 14\"",    "Laptop Gaming 17\"",     "Laptop Ultrabook 13\"",
            "Desktop PC Office",       "Desktop PC Workstation",  "Monitor 24\" FHD",
            "Monitor 27\" QHD",        "Monitor 32\" 4K",         "Tastatur kabellos",
            "Tastatur mechanisch",     "Maus kabellos",           "Maus Gaming",
            "Headset USB",             "Headset Bluetooth",       "Webcam HD",
            "Webcam 4K",               "USB-Hub 7-Port",          "Dockingstation",
            "SSD 256 GB",              "SSD 512 GB",              "SSD 1 TB",
            "HDD 2 TB",                "HDD 4 TB",                "RAM 8 GB DDR5",
            "RAM 16 GB DDR5",          "RAM 32 GB DDR5",          "Grafikkarte Mittelklasse",
            "Grafikkarte High-End",    "Netzteil 550W",           "Netzteil 750W",
            "Router WiFi 6",           "Switch 8-Port",           "Switch 24-Port",
            "Patchkabel Cat6 1m",      "Patchkabel Cat6 5m",      "Patchkabel Cat7 2m",
            "USV 600VA",               "USV 1500VA",              "Druckerpatrone Schwarz",
            "Druckerpatrone Farbe"
        };

        string[] kategorie = {
            "Notebook",    "Notebook",    "Notebook",
            "Desktop",     "Desktop",     "Monitor",
            "Monitor",     "Monitor",     "Eingabe",
            "Eingabe",     "Eingabe",     "Eingabe",
            "Audio",       "Audio",       "Kamera",
            "Kamera",      "Zubehoer",    "Zubehoer",
            "Speicher",    "Speicher",    "Speicher",
            "Speicher",    "Speicher",    "Speicher",
            "Speicher",    "Speicher",    "Grafik",
            "Grafik",      "Netzteil",    "Netzteil",
            "Netzwerk",    "Netzwerk",    "Netzwerk",
            "Netzwerk",    "Netzwerk",    "Netzwerk",
            "Strom",       "Strom",       "Verbrauch",
            "Verbrauch"
        };

        double[] einkaufspreis = {
             649.00,  1089.00,   799.00,   329.00,   879.00,
             159.00,   249.00,   419.00,    34.00,    79.00,
              19.00,    44.00,    39.00,    69.00,    29.00,
              89.00,    18.00,   129.00,    39.00,    69.00,
             109.00,    44.00,    79.00,    29.00,    54.00,
             109.00,   249.00,   489.00,    49.00,    79.00,
              89.00,    39.00,   149.00,     2.50,     5.90,
               4.20,   119.00,   229.00,     4.80,     7.20
        };

        double[] verkaufspreis = {
             899.00,  1499.00,  1099.00,   479.00,  1249.00,
             219.00,   349.00,   599.00,    49.00,   109.00,
              29.00,    64.00,    59.00,    99.00,    44.00,
             129.00,    26.00,   179.00,    55.00,    95.00,
             149.00,    62.00,   109.00,    42.00,    79.00,
             149.00,   349.00,   699.00,    69.00,   109.00,
             129.00,    59.00,   209.00,     3.90,     8.90,
               6.50,   169.00,   329.00,     7.50,    10.90
        };

        int[] bestand = {
              12,   5,   8,  23,   4,
              31,  18,   7,  55,  22,
              89,  43,  37,  19,  62,
              11,  78,   9,  44,  31,
              25,  67,  38,  92,  58,
              27,   3,   1,  34,  21,
              16,  48,   6, 210, 143,
             187,   8,   4, 320, 280
        };

        // Mindestbestand: Unter diesem Wert soll nachbestellt werden
        int[] mindestbestand = {
              5,   3,   3,  10,   2,
             10,   5,   3,  20,  10,
             30,  15,  15,   8,  20,
               5,  25,   4,  15,  10,
             10,  20,  10,  30,  20,
             10,   2,   1,  10,   8,
              6,  15,   3,  50,  50,
             50,   3,   2, 100, 100
        };

        Console.WriteLine("=== Lagerverwaltung IT-Händler GmbH ===");
        Console.WriteLine($"Artikel im System: {artikelnummer.Length}");
        Console.WriteLine();


        // ----------------------------------------------------------
        // AUFGABE 1 (★☆☆) – Vollständige Artikelliste ausgeben
        // ----------------------------------------------------------
        // Gib alle Artikel als formatierte Tabelle aus.
        // Format (Kopfzeile + Trennlinie + Daten):
        //
        // Nr.   | Artikelnr. | Bezeichnung                 | Kat.      | Bestand
        // ------|------------|-----------------------------|-----------|--------
        // 001   | ART-001    | Laptop Business 14"         | Notebook  |      12
        // ...
        //
        // Tipp: {bezeichnung[i],-30} linksbündig, 30 Zeichen
        //       {bestand[i],7} rechtsbündig, 7 Zeichen
        // ----------------------------------------------------------

        Console.WriteLine("--- Artikelliste ---");

        // TODO Aufgabe 1 – dein Code hier:

        Console.WriteLine("Nr.   | Artikelnr. | Bezeichnung | Kat.      | Bestand");
        Console.WriteLine("------|------------|-----------------------------|-----------|--------");
      for (int i=0; i< artikelnummer.Length; i++)
        {
            Console.WriteLine($"{(i + 1).ToString("d3"),-6}| {artikelnummer[i],-11}| {bezeichnung[i],-28}| {kategorie[i],-10}| {bestand[i],7}");
        }


        Console.WriteLine();


        // ----------------------------------------------------------
        // AUFGABE 2 (★☆☆) – Gesamtwert des Lagers berechnen
        // ----------------------------------------------------------
        // Berechne den Gesamtwert des Lagers.
        // Lagerwert = Summe aller (einkaufspreis[i] * bestand[i])
        //
        // Format: "Gesamter Lagerwert (EK): 47.832,50 €"
        //         Zusatz: Berechne auch den Lagerwert zu VK-Preisen
        //         Format: "Gesamter Lagerwert (VK): 67.419,80 €"
        //
        // Tipp: Verwende {wert:N2} für Tausenderpunkte + 2 Dezimalstellen.
        // ----------------------------------------------------------

        Console.WriteLine("--- Lagerwert ---");

        // TODO Aufgabe 2 – dein Code hier:
        double summeEK = 0, summeVK = 0;
        for (int i=0;i<einkaufspreis.Length;i++)
        {
            summeEK += einkaufspreis[i] * bestand[i];
            summeVK += einkaufspreis[i] * bestand[i];
        }

        Console.WriteLine($"Lagerwert (EK): {summeEK: f2} €");
        Console.WriteLine($"Lagerwert (VK): {summeVK: f2} €");



        Console.WriteLine();


        // ----------------------------------------------------------
        // AUFGABE 3 (★★☆) – Nachbestellliste (Bestand unter Minimum)
        // ----------------------------------------------------------
        // Gib alle Artikel aus, bei denen der aktuelle Bestand
        // unter dem Mindestbestand liegt.
        //
        // Format:
        // "!!! NACHBESTELLEN: ART-002 | Laptop Gaming 17\"    | Bestand:  5 | Minimum:  3"
        //
        // Zähle am Ende, wie viele Artikel nachbestellt werden müssen.
        // Format: "Anzahl nachzubestellender Artikel: 7"
        //
        // Denkanstoß: Warum ist ein Mindestbestand wichtig?
        //             Was könnte passieren, wenn kein System diese
        //             Grenze überwacht?
        // ----------------------------------------------------------

        Console.WriteLine("--- Nachbestellliste ---");

        // TODO Aufgabe 3 – dein Code hier:
        int bestellAnzahl = 0;
        for (int i = 0; i<bestand.Length; i++)
        {
            if (bestand[i] <= mindestbestand[i])
            {
                bestellAnzahl++;
                Console.WriteLine(($"!!! Nachbestellen: {artikelnummer[i]}|{bezeichnung[i]}|Bestand: {bestand[i]}| Minimum: {mindestbestand[i]}"));
            }
        }



        Console.WriteLine();


        // ----------------------------------------------------------
        // AUFGABE 4 (★★☆) – Artikelsuche (Lineare Suche)
        // ----------------------------------------------------------
        // Implementiere eine Suchfunktion nach Artikelnummer.
        // Der Suchbegriff ist unten vorgegeben – NICHT ändern!
        //
        // Wird der Artikel gefunden, gib alle Details aus:
        //   Artikelnummer, Bezeichnung, Kategorie,
        //   Einkaufspreis, Verkaufspreis, Bestand, Mindestbestand
        //   und die Handelsspanne in % ( (VK-EK)/EK * 100 )
        //
        // Wird er nicht gefunden: passende Meldung ausgeben.
        // ----------------------------------------------------------

        string suchbegriff = "ART-028";   // <- NICHT ändern

        Console.WriteLine($"--- Artikelsuche: {suchbegriff} ---");

        // TODO Aufgabe 4 – dein Code hier:

        Console.Write("Gib eine Artikelnummer ein: ");
        suchbegriff = Console.ReadLine();
        Console.WriteLine($"---Artikelsuche: {suchbegriff}---");

        for (int i = 0; i < artikelnummer.Length; i++)
        {
            if (suchbegriff == artikelnummer[i])
            {
                Console.WriteLine($"Nr. [{artikelnummer[i]}");
                Console.WriteLine($"Bez. {bezeichnung[i]}");
                Console.WriteLine($"Kat. {kategorie[i]}");
                Console.WriteLine($"EK. {einkaufspreis[i]}");
                Console.WriteLine($"VK. {verkaufspreis[i]}");
                Console.WriteLine($"Best. {bestand[i]}");
                Console.WriteLine($"Best. Mind. {mindestbestand[i]}");
                Console.WriteLine($"Handelsspanne: {(verkaufspreis[i] - einkaufspreis[i]) / einkaufspreis[i] * 100} %");
            }
        }



        Console.WriteLine();


        // ----------------------------------------------------------
        // AUFGABE 5 (★★★) – Umsatzpotenzial je Kategorie
        // ----------------------------------------------------------
        // Berechne das Umsatzpotenzial (VK * Bestand) für jede
        // Kategorie separat.
        // Gib die Kategorien mit ihrem jeweiligen Umsatzpotenzial aus,
        // sortiert nach dem höchsten Wert (manuell, KEIN Array.Sort!).
        //
        // Vorgegebene Kategorien (eindeutig, nicht ändern!):
        string[] alleKategorien = {
            "Notebook", "Desktop", "Monitor", "Eingabe", "Audio",
            "Kamera",   "Zubehoer", "Speicher", "Grafik", "Netzteil",
            "Netzwerk", "Strom",   "Verbrauch"
        };
        //
        // Format: "Notebook   : 23.415,00 €"
        //         "Desktop    :  6.493,00 €"
        //         ...
        //
        // Denkanstoß: Welche Kategorie bringt dem Händler voraussichtlich
        //             den meisten Umsatz? Überrascht dich das Ergebnis?
        // ----------------------------------------------------------

        Console.WriteLine("--- Umsatzpotenzial je Kategorie ---");

        // TODO Aufgabe 5 – dein Code hier:

        int katAnz = alleKategorien.Length;
        for (int i = 0; i <= alleKategorien.Length; i++)
        {
            katAnz++;
            //katAnz =  ( verkaufspreis[i] - einkaufspreis[i] );
        }
     


        Console.WriteLine();


        // ----------------------------------------------------------
        // AUFGABE 6 (★★★) – Gewinnmarge & teuerster Artikel je Kategorie
        // ----------------------------------------------------------
        // Finde für jede Kategorie den Artikel mit der höchsten
        // absoluten Handelsspanne (VK - EK).
        //
        // Format:
        // "Notebook  -> Laptop Gaming 17\"        | Marge: 410,00 € (37,7 %)"
        // "Desktop   -> Desktop PC Workstation    | Marge: 370,00 € (42,1 %)"
        // ...
        //
        // Hinweis: Iteriere über alleKategorien (Aufgabe 5),
        //          suche dann mit einer inneren Schleife den Artikel
        //          mit der höchsten Marge in dieser Kategorie.
        // ----------------------------------------------------------

        Console.WriteLine("--- Höchste Marge je Kategorie ---");

        // TODO Aufgabe 6 – dein Code hier:




        Console.WriteLine();
        Console.WriteLine("=== Lagerauswertung abgeschlossen ===");
    }
}
