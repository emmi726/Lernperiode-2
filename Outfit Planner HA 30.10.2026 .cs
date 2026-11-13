using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outfit_Planner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string auswahl = "";
            while (auswahl != "15")
            {
                Console.WriteLine("=================================================");
                Console.WriteLine("           ULTIMATE OUTFIT PLANNER");
                Console.WriteLine("      Plan your outfit, find your style!");
                Console.WriteLine("=================================================");


                Console.WriteLine("MEIN KLEIDERSCHRANK");
                Console.WriteLine("1. Kleidungsstück hinzufügen");
                Console.WriteLine("2. Alle Kleidungsstücke anzeigen");
                Console.WriteLine("3. Kleidungsstück suchen");
                Console.WriteLine();

                Console.WriteLine("OUTFIT STUDIO");
                Console.WriteLine("4. Outfit selbst zusammenstellen");
                Console.WriteLine("5. Zufälliges Outfit erstellen");
                Console.WriteLine("6. Outfit nach Wetter auswählen");
                Console.WriteLine("7. Outfit nach Anlass auswählen");
                Console.WriteLine("8. Outfit nach Farbe und Style auswählen");
                Console.WriteLine();

                Console.WriteLine("MEINE OUTFITS");
                Console.WriteLine("9. Outfit als Favorit speichern");
                Console.WriteLine("10. Favoriten anzeigen");
                Console.WriteLine("11. Outfit-Verlauf anzeigen");
                Console.WriteLine("12. Letztes Outfit nochmals anzeigen");
                Console.WriteLine();

                Console.WriteLine("WEITERE FUNKTIONEN");
                Console.WriteLine("13. Outfit-Statistik anzeigen");
                Console.WriteLine("14. Hilfe und Informationen");
                Console.WriteLine("15. Programm beenden");
                Console.WriteLine();

                Console.WriteLine("Deine Auswahl:");
                auswahl = Console.ReadLine();

                if (auswahl == "1")
                {
                    Console.WriteLine("Hier kannst du Kleidung hinzufügen.");
                }
                else if (auswahl == "2")
                {
                    Console.WriteLine("Hier wird deine Kleidung angezeigt.");
                }
                else if (auswahl == "3")
                {
                    Console.WriteLine("Hier kannst du Kleidung suchen.");
                }
                else if (auswahl == "4")
                {
                    Console.WriteLine("Hier stellst du dein eigenes Outfit zusammen.");
                }
                else if (auswahl == "5")
                {
                    Console.WriteLine("Hier wird ein zufälliges Outfit erstellt.");
                }
                else if (auswahl == "6")
                {
                    Console.WriteLine("Hier wählst du ein Outfit passend zum Wetter.");
                }
                else if (auswahl == "7")
                {
                    Console.WriteLine("Hier wählst du ein Outfit passend zum Anlass.");
                }
                else if (auswahl == "8")
                {
                    Console.WriteLine("Hier wählst du Farbe und Style.");
                }
                else if (auswahl == "9")
                {
                    Console.WriteLine("Hier speicherst du ein Outfit als Favorit.");
                }
                else if (auswahl == "10")
                {
                    Console.WriteLine("Hier werden deine Favoriten angezeigt.");
                }
                else if (auswahl == "11")
                {
                    Console.WriteLine("Hier siehst du deinen Outfit-Verlauf.");
                }
                else if (auswahl == "12")
                {
                    Console.WriteLine("Hier wird dein letztes Outfit angezeigt.");
                }
                else if (auswahl == "13")
                {
                    Console.WriteLine("Hier siehst du deine Outfit-Statistik.");
                }
                else if (auswahl == "14")
                {
                    Console.WriteLine("Willkommen beim Ultimate Outfit Planner!");
                }
                else if (auswahl == "15")
                {
                    Console.WriteLine("Danke, dass du den Outfit Planner benutzt!");
                }
                else
                {
                    Console.WriteLine("Ungültige Auswahl. Bitte wähle 1 bis 15.");
                }

                if (auswahl != "15")
                {
                    Console.WriteLine();
                    Console.WriteLine("Drücke eine Taste, um zum Menü zurückzukehren.");
                    Console.ReadKey();
                }

            }
        }
    }
}
