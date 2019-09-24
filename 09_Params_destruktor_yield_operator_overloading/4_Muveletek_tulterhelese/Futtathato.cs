using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szemely_osztaly;

namespace Muveletek_tulterhelese
{
    class Futtathato
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adja meg, hogy hány Személy adatait szeretné eltárolni.");
            int elemszam = int.Parse(Console.ReadLine());
            string vezeteknev;
            string keresztnev;
            int ev;
            int honap;
            int nap;
            long fizetes;
            double magassag;
            bool hazas;
            string chars = "abcdefghijklmnopqrstuvwxyz";
            Random rnd = new Random();
            double min = 1.5;
            double max = 2.2;

            Szemely[] ember = new Szemely[elemszam];

            for (int i = 0; i < elemszam; i++)
            {
                vezeteknev = chars[rnd.Next(0, chars.Length)].ToString().ToUpper() + chars[rnd.Next(0, chars.Length)] + chars[rnd.Next(0, chars.Length)];

                keresztnev = chars[rnd.Next(0, chars.Length)].ToString().ToUpper() + chars[rnd.Next(0, chars.Length)] + chars[rnd.Next(0, chars.Length)];

                ev = rnd.Next(1940, 2011);

                honap = rnd.Next(1, 13);

                nap = rnd.Next(1, 28);
                DateTime szuletesIdeje = new DateTime(ev, honap, nap);

                fizetes = rnd.Next(60001, 200001);

                magassag = Math.Round(rnd.NextDouble() * (max - min) + min, 1); //Kerekítés 1 tizedesjegyre

                if (rnd.Next(0, 1) == 0)
                {
                    hazas = false;
                }
                else
                {
                    hazas = true;
                }

                ember[i] = new Szemely(vezeteknev, keresztnev, szuletesIdeje, fizetes, magassag, hazas);
            }

            for (int i = 0; i < elemszam; i++)
            {
                Console.WriteLine(ember[i].ToString());
            }

            Console.WriteLine();

            Szemely gyerek;
            Szemely gyerek2;

            gyerek = ember[0] + ember[1];
            gyerek2 = ember[0] - ember[1];

            gyerek++;
            gyerek2--;

            Console.WriteLine(gyerek.ToString());
            Console.WriteLine(gyerek2.ToString());

            string keresztnevTeszt=gyerek;
            long fizetesTeszt=gyerek;
            double magassagTeszt=gyerek;
            bool hazasTeszt=gyerek;
            DateTime szuletettTeszt=gyerek;

            Console.WriteLine("\nTesztgyerek adatai:");
            Console.WriteLine("keresztnev: " + keresztnevTeszt + " fizetes: " + fizetesTeszt + " magassag: " + magassagTeszt + " hazas: " + hazasTeszt + " született: " + szuletettTeszt);

            if (gyerek != gyerek2)
            {
                Console.WriteLine("\nTényleg nem egyeznek");
            }

            gyerek = gyerek2;
            if (gyerek == gyerek2)
            {
                Console.WriteLine("Már egyeznek");
            }

            Console.ReadKey();
        }
    }
}
