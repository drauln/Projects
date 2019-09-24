using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szemely_osztaly
{
    class Futtathato
    {
        static async void Muveletvegzes(List<Szemely> lista)
        {
            var fizetes = await Task<double>.Factory.StartNew(() => AtlagFizetes(lista));
            var magassag = await Task<double>.Factory.StartNew(() => AtlagMagassag(lista));

            Console.WriteLine("Az átlagfizetés: " + fizetes);
            Console.WriteLine("Az átlagmagasság: " + magassag);
        }

        static double AtlagFizetes(List<Szemely> lista)
        {
            double osszeg = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                osszeg += lista[i].Fizetes;
            }
            return Math.Round(osszeg / lista.Count, 2);
        }

        static double AtlagMagassag(List<Szemely> lista)
        {
            double szum = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                szum += lista[i].Magassag;
            }
            return Math.Round(szum / lista.Count,2);
        }

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
            List<Szemely> lista = new List<Szemely>();

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
                lista.Add(ember[i]);
            }

            for (int i = 0; i < elemszam; i++)
            {
                Console.WriteLine(ember[i].ToString());
            }

            Console.WriteLine();

            Muveletvegzes(lista);

            Console.ReadKey();
        }
    }
}