using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diak_osztaly;
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
            int gyerekekSzama = 0;
            long zsebpenz;
            
            //Diák
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

            zsebpenz = rnd.Next(2000, 5001);

            gyerekekSzama = rnd.Next(0, 4);

            Diak diak = new Diak(vezeteknev, keresztnev, szuletesIdeje, magassag, zsebpenz);

            //Szülő
            vezeteknev = chars[rnd.Next(0, chars.Length)].ToString().ToUpper() + chars[rnd.Next(0, chars.Length)] + chars[rnd.Next(0, chars.Length)];

            keresztnev = chars[rnd.Next(0, chars.Length)].ToString().ToUpper() + chars[rnd.Next(0, chars.Length)] + chars[rnd.Next(0, chars.Length)];

            ev = rnd.Next(1940, 2011);

            honap = rnd.Next(1, 13);

            nap = rnd.Next(1, 28);
            szuletesIdeje = new DateTime(ev, honap, nap);

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

            Szulo szulo = new Szulo(vezeteknev, keresztnev, szuletesIdeje, magassag, fizetes, hazas,gyerekekSzama);

            Console.WriteLine(diak.ToString());
            Console.WriteLine(szulo.ToString());

            if (szulo.Magassag>diak.Magassag)
            {
                Console.WriteLine("Szülő magasabb.");
            }
            else
            {
                if (diak.Magassag>szulo.Magassag)
                {
                    Console.WriteLine("Diák magasabb.");
                }
                else
                {
                    Console.WriteLine("Ugyan olyan magasak.");
                }
            }

            Console.WriteLine();
            
            Console.ReadKey();
        }
    }
}
