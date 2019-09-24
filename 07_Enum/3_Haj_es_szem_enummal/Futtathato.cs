using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szemely_osztaly;
using szines;
using Dolgozo_osztaly;

namespace Csalados_szemely
{
    class Futtathato
    {
        static void Valami(DolgozoSzemely obj)
        {
            obj.Hajszin=obj.AlapSzin;
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
            DateTime szuletesIdeje;
            int gyerekekSzama;

            DolgozoSzemely[] dolgozo = new DolgozoSzemely[elemszam];
            CsaladosSzemely[] csalados = new CsaladosSzemely[elemszam];

            for (int i = 0; i < elemszam; i++)
            {
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

                gyerekekSzama = rnd.Next(0, 4);

                csalados[i] = new CsaladosSzemely(vezeteknev, keresztnev, szuletesIdeje, fizetes, magassag, hazas,gyerekekSzama, (Szinek)rnd.Next(0, 3), (Szinek)rnd.Next(0, 3));
                
            }

            for (int i = 0; i < elemszam; i++)
            {
                Console.WriteLine(csalados[i].ToString());
            }

            Console.WriteLine("Random Hajszín:");
            csalados[0].HajSzinValtoztat();
            Console.WriteLine("Változtatott: " + csalados[0].ToString());

            //Dolgozó
            for (int i = 0; i < elemszam; i++)
            {
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

                gyerekekSzama = rnd.Next(0, 4);

                dolgozo[i] = new DolgozoSzemely(vezeteknev, keresztnev, szuletesIdeje, fizetes, magassag, hazas, "Dunaújváros" , (Szinek)rnd.Next(0, 3), (Szinek)rnd.Next(0, 3));

            }

            Console.WriteLine("\n\n");

            for (int i = 0; i < elemszam; i++)
            {
                Console.WriteLine(dolgozo[i].ToString());
            }

            Console.WriteLine("Random hajszín:");
            dolgozo[0].HajSzinValtoztat();
            Console.WriteLine(dolgozo[0].ToString());

            Console.WriteLine("Alaphajszín:");

            dolgozo[0].Hajszin=dolgozo[0].AlapSzin;
            Console.WriteLine(dolgozo[0].ToString());

            Console.WriteLine("Alaphajszín_máshogy:");
            Valami(dolgozo[1]);
            Console.WriteLine(dolgozo[1].ToString());

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}