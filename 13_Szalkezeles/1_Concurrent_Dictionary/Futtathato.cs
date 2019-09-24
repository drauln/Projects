using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Szemely_osztaly;
using System.Collections.Concurrent;

namespace Szalkezeles_Concurrent_Dictionary
{
    class Futtathato
    {
        static Dictionary<int, Szemely> szotar = new Dictionary<int, Szemely>();

        static ConcurrentDictionary<int,Szemely> concurrentSzotar = new ConcurrentDictionary<int,Szemely>();
        
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
            
            Thread szal1 = new Thread(new ThreadStart(Segitseg));
            Thread szal2 = new Thread(new ThreadStart(Segitseg));
            szal1.Start(); szal2.Start();
            szal1.Join(); szal2.Join();

            szal1 = new Thread(new ThreadStart(Segitseg2));
            szal2 = new Thread(new ThreadStart(Segitseg2));
            szal1.Start(); szal2.Start();
            szal1.Join(); szal2.Join();
            Thread.Sleep(1000);

            var lista = concurrentSzotar.ToArray();
            foreach (var elem in lista)
            {
                Console.WriteLine(elem);
            }

            var lista2 = szotar.ToArray();
            foreach (var elem in lista)
            {
                Console.WriteLine(elem);
            }

            Console.ReadKey();

            void Segitseg()
            {
                for (int i = 0; i < elemszam; i++)
                {
                    try
                    {
                        szotar.Add(i, ember[i]);
                    }
                    catch (NullReferenceException)
                    {
                        Console.WriteLine("Null Reference Exception szótár feltöltésénél");
                    }
                    catch (ArgumentException)
                    {

                        Console.WriteLine("Argument Exception szótár feltöltésénél");
                    }
                }
            }

            void Segitseg2()
            {
                for (int i = 0; i < elemszam; i++)
                {
                    concurrentSzotar.TryAdd(i, ember[i]);
                }
            }
        }
    }
}