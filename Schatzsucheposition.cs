using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schatzsuche_mit_Positionen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Willkommen bei der Schatzsuche!");
            Random random = new Random();
            int computerzahl = random.Next(1, 51);
            int guesser = 0;
            while (guesser != computerzahl)
            {
                Console.WriteLine("Position eingeben: ");
                guesser = Convert.ToInt32(Console.ReadLine());
                int entfernung = Math.Abs(guesser - computerzahl);
                if (entfernung > 15)
                {
                    Console.WriteLine("Sehr weit weg! ");
                }
                else if (entfernung >= 6)
                {
                    Console.WriteLine("Du kommst näher!");
                }
                else if (entfernung >= 1)
                {
                    Console.WriteLine("Sehr heiss!");
                }
                else
                {
                    Console.WriteLine("Schatz gefunden");
                }

            }
        }
     }
}
