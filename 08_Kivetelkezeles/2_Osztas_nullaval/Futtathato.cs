using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szemely_osztaly;

namespace Tomb_hasznalata
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
            double[] magassagok=new double[elemszam];
            long osszes_fizetes=0;
            double osszes_magassag = 0;

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

                if (rnd.Next(0, 2) == 0)
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
                fizetesek[i]=ember[i].Fizetes;
                magassagok[i] = ember[i].Magassag;
            }
            for (int i = 0; i < elemszam; i++)
            {
                osszes_fizetes += fizetesek[i];
                osszes_magassag += magassagok[i];
            }

            for (int i = 0; i < elemszam; i++)
            {
                Console.WriteLine(ember[i].ToString());
            }

            bool ujra = false;
            do
            {
                ujra = false;
                Console.WriteLine("Adjon meg egy új elemszámot a teszthez.");
                elemszam = int.Parse(Console.ReadLine());

                try
                {
                    if (elemszam < 1)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        Console.WriteLine("Az emberek átlag fizetése: " + osszes_fizetes / elemszam);
                        Console.WriteLine("Az emberek átlag magassága: " + osszes_magassag / elemszam);
                    }

                }
                catch (Exception)
                {
                    ujra = true;
                    if (elemszam < 0)
                    {
                        Console.WriteLine("Negatív számmal való osztást kísérelt meg.");
                    }
                    else
                    {
                        Console.WriteLine("Nullával való osztást kísérelt meg.");
                    }
                }
            } while (ujra);

            Console.ReadKey();
        }
    }
}
