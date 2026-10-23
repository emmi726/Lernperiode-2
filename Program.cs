using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passwort_knacker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Willkommen beim Passwort knacker!");
            Console.WriteLine("Errate eine Zahl von 1111 bis 9999.");
            Random random = new Random();
            int computerzahl = random.Next(1111, 10000);
            for (int i = 1; i <= 8; i++)
            {
                Console.WriteLine("Gib ein Code ein:");
                int code = Convert.ToInt32(Console.ReadLine());
                if (code < 1111 || code > 9999)
                {
                    Console.WriteLine("Ungültiges Code!");
                }
                else if (code < computerzahl)
                {
                    Console.WriteLine("Der Code ist höher!");
                }
                else if (code > computerzahl)
                {
                    Console.WriteLine("Der Code ist tiefer!");
                }else
                {
                    Console.WriteLine("Richtig! Zugriff erlaubt!");
                }
            }
            Console.WriteLine("Zugriff gesperrt!");
            Console.WriteLine("Die Zahl war " + computerzahl);
        }
    }
}
