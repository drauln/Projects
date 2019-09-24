using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szemely_osztaly;

namespace Konstruktor
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
            int hatarEv;
            int hatarHonap;
            int hatarNap;
            int hatarOra;
            int hatarPerc;

            Szemely[] ember = new Szemely[elemszam];

            for (int i = 0; i < elemszam; i++)
            {
                vezeteknev = chars[rnd.Next(0, chars.Length)].ToString().ToUpper() + chars[rnd.Next(0, chars.Length)] + chars[rnd.Next(0, chars.Length)];

                keresztnev = chars[rnd.Next(0, chars.Length)].ToString().ToUpper() + chars[rnd.Next(0, chars.Length)] + chars[rnd.Next(0, chars.Length)];

                ev = rnd.Next(1940, 2011);

                honap = rnd.Next(1, 13);

                nap = rnd.Next(1, 28);
                DateTime szuletesIdeje = new DateTime(ev, honap, nap);

                hatarEv = rnd.Next(2017, 2021);

                hatarHonap = rnd.Next(1, 13);

                hatarNap = rnd.Next(1, (DateTime.DaysInMonth(hatarEv,hatarHonap)+1));

                hatarOra = rnd.Next(0, 24);

                hatarPerc = rnd.Next(0, 60);
                DateTime hatarIdo = new DateTime(hatarEv,hatarHonap,hatarNap,hatarOra,hatarPerc,0);

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

                ember[i] = new Szemely(vezeteknev, keresztnev, szuletesIdeje, fizetes, magassag, hazas, "feladat megnevezése" , hatarIdo);
            }

            for (int i = 0; i < elemszam; i++)
            {
                Console.WriteLine(ember[i].ToString());
            }

            Console.WriteLine();

            int minHatarIdoIndex = 0;
            for (int i = 1; i < elemszam; i++)
            {
                if (ember[minHatarIdoIndex].KesobbiHatarIdo(ember[i])==false)
                {
                    minHatarIdoIndex = i;
                }
            }

            Console.WriteLine(ember[minHatarIdoIndex].ToString());

            Console.ReadKey();
        }
    }
}
/*Készítsen egy futtatható osztályt, amelyben
beolvassa 5 Szemely adatait és eltárolja egy tömbbe,
kiírja a szemelyek adatait,
kiírja a legkorábbi határidővel rendelkező személy adatait!
*/