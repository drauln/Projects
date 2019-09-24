﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szemely_osztaly;

namespace Metodusok
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

            for (int i = 0; i < elemszam; i++)
            {
                ember[i].Novel(15000);
                Console.WriteLine(ember[i].ToString());
            }

            ember[0].Vezeteknev = chars[rnd.Next(0, chars.Length)].ToString().ToUpper() + chars[rnd.Next(0, chars.Length)] + chars[rnd.Next(0, chars.Length)];
            Console.WriteLine(ember[0].ToString());

            for (int i = 0; i < elemszam; i++)
            {
                if (ember[i].FizetesIntervalluma(80000, 150000))
                {
                    Console.WriteLine(ember[i].Vezeteknev + " fizetése az intervallumba esik.");
                }
                
            }

            for (int i = 0; i < elemszam; i++)
            {
                Console.WriteLine(ember[i].ToString() + " Adó: " + ember[i].Ado(16));
            }

            for (int i = 0; i < elemszam-1; i++)
            {
                if (Szemely.NagyobbE(ember[i].Fizetes,ember[i+1].Fizetes))
                {
                    Console.WriteLine(i + ". ember fizetése nagyobb mint " + (i+1) + ". emberé.");
                }
                else
                {
                    Console.WriteLine(i + ". ember fizetése NEM nagyobb mint " + (i + 1) + ". emberé.");
                }
            }

            Console.ReadKey();
        }
    }
}