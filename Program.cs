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
            List<string> kleidung = new List<string>();
            string auswahl = "";

            List<string> oberteile = new List<string>();
            List<string> hosen = new List<string>();
            List<string> schuhe = new List<string>();

            List<string> outfitVerlauf = new List<string>();

            string letztesOutfit = "";
            Random zufall = new Random();

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
                Console.WriteLine("4. Eigenes Outfit zusammenstellen");
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
                    Console.Clear();
                    Console.WriteLine("KLEIDUNGSSTÜCK HINZUFÜGEN");
                    Console.WriteLine();

                    Console.WriteLine("1.Oberteil");
                    Console.WriteLine("2.Hose");
                    Console.WriteLine("3.Schuhe");

                    Console.WriteLine("Kategorie auswählen: ");
                    string kategorie = Console.ReadLine();

                    Console.WriteLine("Wie viele Kleidungsstücke besitzt du? ");
                    int anzahl = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < anzahl; i++)
                    {
                        Console.WriteLine("Name des Kleidungsstücks " + (i + 1) + ": ");
                        string name = Console.ReadLine();

                        if (name.Trim() != "")
                        {
                            if (kategorie == "1")
                            {
                                oberteile.Add(name);
                            }
                            else if (kategorie == "2")
                            {
                                hosen.Add(name);
                            }
                            else if (kategorie == "3")
                            {
                                schuhe.Add(name);
                            }
                                
                            Console.WriteLine("Kleidungsstück wurde hinzugefügt!");
                        }
                        else
                        {
                            Console.WriteLine("Der Name darf nicht leer sein.");
                            i--;
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("Alle Kleidungsstücke wurden eingegeben.");
                    Console.ReadKey();
                }
                else if (auswahl == "2")
                {
                    Console.Clear();
                    Console.WriteLine("ALLE KLEIDUNGSSTÜCKE ANZEIGEN");
                    Console.WriteLine();

                    Console.WriteLine("\nOBERTEILE:");
                    for(int i = 0; i< oberteile.Count; i++)
                    {
                        Console.WriteLine((i+1) + ". " + oberteile[i]);
                    }

                    Console.WriteLine("\nHOSEN:");
                    for(int i = 0; i < hosen.Count; i++)
                    {
                        Console.WriteLine((i+1) + ". " + hosen[i]);
                    }

                    Console.WriteLine("\nSCHUHE:");
                    for (int i = 0; i < schuhe.Count; i++)
                    {
                        Console.WriteLine((i + 1) + ". " + schuhe[i]);
                    }

                }
                else if (auswahl == "3")
                {
                    Console.Clear();
                    Console.WriteLine("KLEIDUNGSSTÜCK SUCHEN");

                    Console.Write("Was suchst du? ");
                    string suche = Console.ReadLine().ToLower();

                    bool gefunden = false;

                    for (int i = 0; i < oberteile.Count; i++)
                    {
                        if (oberteile[i].ToLower().Contains(suche))
                        {
                            Console.WriteLine("Oberteil: " + oberteile[i]);
                            gefunden = true;
                        }
                    }
                    for(int i = 0; i < hosen.Count; i++)
                    {
                        if (hosen[i].ToLower().Contains(suche))
                        {
                            Console.WriteLine("Hosen: " +  hosen[i]);   
                            gefunden = true;
                        }
                    }
                    for (int i = 0;i < schuhe.Count; i++)
                    {
                        if (schuhe[i].ToLower().Contains(suche))
                        {
                            Console.WriteLine("Schuhe: " + schuhe[i]);
                            gefunden = true;
                        }
                    }
                    if(gefunden == false)
                    {
                        Console.WriteLine("Keine Kleidungsstücke gefunden.");
                    }
                }
                else if (auswahl == "4")
                {
                    Console.Clear();
                    Console.WriteLine("EIGENES OUTFIT ZUSAMMENSTELLEN");

                    if(oberteile.Count > 0 && hosen.Count > 0 && schuhe.Count > 0)
                    {
                        Console.WriteLine("\nOBERTEILE:");
                        for(int i= 0; i< oberteile.Count; i++)
                        {
                            Console.WriteLine((i + 1) + ". " + oberteile[i]);
                        }
                        Console.WriteLine("Wähle ein Oberteil: ");
                        int oberteil = Convert.ToInt32(Console.ReadLine()) - 1;

                        Console.WriteLine("\nHOSEN:");
                        for(int i= 0; i< hosen.Count; i++)
                        {
                            Console.WriteLine((i + 1) + ". " + hosen[i]);
                        }
                        Console.WriteLine("Wähle eine Hose: ");
                        int hose = Convert.ToInt32(Console.ReadLine()) - 1;

                        Console.WriteLine("\nSCHUHE:");
                        for (int i = 0; i < schuhe.Count; i++)
                        {
                            Console.WriteLine((i + 1) + ". " + schuhe[i]);
                        }
                        Console.WriteLine("Wähle Schuhe: ");
                        int schuh = Convert.ToInt32(Console.ReadLine()) - 1;

                        if (oberteil >= 0 && oberteil < oberteile.Count && hose >= 0 && hose < hosen.Count && schuh >= 0 && schuh < schuhe.Count)
                        {
                            Console.WriteLine("\nDEIN OUTFIT:");
                            Console.WriteLine("Oberteil: " + oberteile[oberteil]);
                            Console.WriteLine("Hose: " + hosen[hose]);
                            Console.WriteLine("Schuhe: " + schuhe[schuh]);

                            letztesOutfit = oberteile[oberteil] + ", " +
                                            hosen[hose] + ", " + schuhe[schuh];

                            outfitVerlauf.Add(letztesOutfit);

                        }
                        else
                        {
                            Console.WriteLine("Ungültige Auswahl!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Du brauchst mindestens ein Oberteil, eine Hose und Schuhe!");
                    }

                }
                else if (auswahl == "5")
                {
                    Console.Clear();
                    Console.WriteLine("ZUFÄLLIGES OUTFIT ERSTELLEN");

                    if (oberteile.Count > 0 && hosen.Count > 0 && schuhe.Count > 0)
                    {
                        int oberteil = zufall.Next(oberteile.Count);
                        int hose = zufall.Next(hosen.Count);
                        int schuh = zufall.Next(schuhe.Count);

                        Console.WriteLine("\nDEIN ZUFÄLLIGES OUTFIT:");
                        Console.WriteLine("Oberteil: " + oberteile[oberteil]);
                        Console.WriteLine("Hose: " + hosen[hose]);
                        Console.WriteLine("Schuhe: " + schuhe[schuh]);

                        letztesOutfit = oberteile[oberteil] + ", " +
                                        hosen[hose] + ", " + schuhe[schuh];

                        outfitVerlauf.Add(letztesOutfit);
                    }
                    else
                    {
                        Console.WriteLine("Du brauchst mindestens ein Kleidungsstück pro Kategorie!");
                    }
                }
                else if (auswahl == "6")
                {
                    Console.Clear();
                    Console.WriteLine("OUTFIT NACH WETTER");

                    Console.WriteLine("1. Sonnig");
                    Console.WriteLine("2. Regnerisch");
                    Console.WriteLine("3. Kalt");

                    Console.Write("Wie ist das Wetter? ");
                    string wetter = Console.ReadLine();

                    string oberteil = "";
                    string hose = "";
                    string schuh = "";

                    if (wetter == "1")
                    {
                        oberteil = "T-Shirt";
                        hose = "Shorts";
                        schuh = "Sneakers";
                    }
                    else if (wetter == "2")
                    {
                        oberteil = "Regenjacke";
                        hose = "Lange Hose";
                        schuh = "Wasserdichte Schuhe";
                    }
                    else if (wetter == "3")
                    {
                        oberteil = "Pullover";
                        hose = "Jeans";
                        schuh = "Winterstiefel";
                    }
                    else
                    {
                        Console.WriteLine("Ungültige Wetterauswahl.");
                    }

                    if (oberteil != "")
                    {
                        Console.WriteLine("\nDEIN WETTER-OUTFIT:");
                        Console.WriteLine("Oberteil: " + oberteil);
                        Console.WriteLine("Hose: " + hose);
                        Console.WriteLine("Schuhe: " + schuh);

                        letztesOutfit = oberteil + ", " + hose + ", " + schuh;
                        outfitVerlauf.Add(letztesOutfit);
                    }
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
