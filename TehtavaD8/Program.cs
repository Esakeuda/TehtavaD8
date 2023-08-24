using System;

namespace Peruslaskutoimitukset2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Pyydetään käyttäjältä syötteet
                Console.Write("Syötä ensimmäinen luku: ");
                double luku1 = double.Parse(Console.ReadLine());

                Console.Write("Syötä toinen luku: ");
                double luku2 = double.Parse(Console.ReadLine());

                // Suoritetaan peruslaskutoimitukset
                double summa = luku1 + luku2;
                double erotus = luku1 - luku2;
                double tulo = luku1 * luku2;

                // Tarkistetaan, ettei nollalla jaeta
                double jakolasku = 0;
                if (luku2 != 0)
                {
                    jakolasku = luku1 / luku2;
                }

                // Tulostetaan tulokset
                Console.WriteLine($"Yhteenlasku: {summa}");
                Console.WriteLine($"Vähennyslasku: {erotus}");
                Console.WriteLine($"Kertolasku: {tulo}");

                // Tarkistetaan, että jakolasku ei aiheuta nollalla jaon virhettä
                if (luku2 != 0)
                {
                    Console.WriteLine($"Jakolasku: {jakolasku}");
                }
                else
                {
                    Console.WriteLine("Jakolasku: Nollalla ei voi jakaa.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Virheellinen syöte. Syötä kaksi numeroa.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Nollalla ei voi jakaa.");
            }
        }
    }
}

