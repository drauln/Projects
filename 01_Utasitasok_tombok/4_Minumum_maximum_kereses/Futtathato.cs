using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szemely_osztaly;

namespace Minumum_maximum_kereses
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
            long[] fizetesek = new long[elemszam];
            double[] magassagok = new double[elemszam];
            double maxMagas =0;
            long minFizetes = 0;
            int magasIndex = 0;
            int fizetesIndex = 0;
            

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

                magassag = Math.Round(rnd.NextDouble() * (max - min) + min, 2); //Kerekítés 1 tizedesjegyre

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
                fizetesek[i] = ember[i].Fizetes;
                magassagok[i] = ember[i].Magassag;
            }

            minFizetes = ember[0].Fizetes;
            maxMagas= ember[0].Magassag;
            for (int i = 1; i < elemszam; i++)
            {
                if (minFizetes>ember[i].Fizetes)
                {
                    minFizetes = ember[i].Fizetes;
                    fizetesIndex = i;
                }
                if (maxMagas<ember[i].Magassag)
                {
                    maxMagas = ember[i].Magassag;
                    magasIndex = i;
                }
            }
            
            for (int i = 0; i < elemszam; i++)
            {
                Console.WriteLine(ember[i].ToString());
            }

            Console.WriteLine("Legmagasabb ember indexe: " + magasIndex + " sorszáma: " + magasIndex); //0-val kezdődik a sorszám is és az index is
            Console.WriteLine("Legalacsonyabb fizetésű ember indexe: " + fizetesIndex + " sorszáma: " + fizetesIndex); 

            Console.ReadKey();
        }
    }
}
