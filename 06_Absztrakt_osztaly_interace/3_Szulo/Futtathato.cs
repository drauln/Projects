using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szemely_osztaly;
using Szulo_osztaly;

namespace Metodusok
{
    class Futtathato
    {
        static void Main(string[] args)
        {
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
            int gyerekekSzama=0;

            Szulo[] szulo = new Szulo[2];

            for (int i = 0; i < 2; i++)
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

                gyerekekSzama = rnd.Next(0, 4);

                szulo[i] = new Szulo(vezeteknev, keresztnev, szuletesIdeje, magassag, fizetes, hazas, gyerekekSzama);
            }

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(szulo[i].ToString());
            }

            if (szulo[0].Magassag>szulo[1].Magassag)
            {
                Console.WriteLine("Magasabb: " + szulo[0].ToString());
            }
            else
            {
                Console.WriteLine("Magasabb: " + szulo[1].ToString());
            }

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}