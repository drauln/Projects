using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szemely_osztaly;

namespace Csalados_szemely
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
            DateTime szuletesIdeje;
            
            CsaladosSzemely[] csalados = new CsaladosSzemely[elemszam];
            
            for (int i = 0; i < elemszam; i++)
            {
                vezeteknev = chars[rnd.Next(0, chars.Length)].ToString().ToUpper() + chars[rnd.Next(0, chars.Length)] + chars[rnd.Next(0, chars.Length)];

                keresztnev = chars[rnd.Next(0, chars.Length)].ToString().ToUpper() + chars[rnd.Next(0, chars.Length)] + chars[rnd.Next(0, chars.Length)];

                ev = rnd.Next(1940, 2011);

                honap = rnd.Next(1, 13);

                nap = rnd.Next(1, 28);
                szuletesIdeje = new DateTime(ev, honap, nap);

                fizetes = rnd.Next(60, 200)*1000;

                magassag = Math.Round(rnd.NextDouble() * (max - min) + min, 1); //Kerekítés 1 tizedesjegyre

                if (rnd.Next(0, 1) == 0)
                {
                    hazas = false;
                }
                else
                {
                    hazas = true;
                }

                csalados[i] = new CsaladosSzemely(vezeteknev,keresztnev,szuletesIdeje,fizetes,magassag,hazas, rnd.Next(-5, 10));

            }
            
            for (int i = 0; i < elemszam; i++)
            {
                Console.WriteLine(csalados[i].ToString());
            }

            for (int i = 0; i < elemszam; i++)
            {
                csalados[i].GyerekekKivetel();
            }

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}