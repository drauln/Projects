using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szemely_osztaly;

namespace Overloading
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
            DateTime szuletesIdeje;
            long fizetes;
            double magassag;
            bool hazas;
            string chars = "abcdefghijklmnopqrstuvwxyz";
            Random rnd = new Random();
            double min = 1.5;
            double max = 2.2;

            Szemely[] ember = new Szemely[11];

            for (int i = 0; i < 10; i++)
            {
                vezeteknev = Szemely.NevGenerator(chars, 3);

                keresztnev = Szemely.NevGenerator(chars, 3);

                ev = rnd.Next(1940, 2011);

                honap = rnd.Next(1, 13);

                nap = rnd.Next(1, 29);
                szuletesIdeje = new DateTime(ev, honap, nap);

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

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(ember[i].ToString());
            }

            int index = 0;
            double legmagasabb = ember[0].Magassag;
            for (int i = 1; i < 10; i++)
            {
                if (legmagasabb<ember[i].Magassag)
                {
                    legmagasabb = ember[i].Magassag;
                    index = i;
                }
            }

            Console.WriteLine();

            Console.WriteLine("Legmagasabb adatai: " + ember[index].ToString());

            Console.WriteLine("Adja meg a Vezetéknevét.");
            vezeteknev = Console.ReadLine();

            Console.WriteLine("Adja meg a Keresztnevét.");
            keresztnev = Console.ReadLine();

            Console.WriteLine("Adja meg a Születési Évét.");
            ev = int.Parse(Console.ReadLine());

            Console.WriteLine("Adja meg a Születési Hónapot.");
            honap = int.Parse(Console.ReadLine());

            Console.WriteLine("Adja meg a Születési Napot.");
            nap = int.Parse(Console.ReadLine());
            szuletesIdeje = new DateTime(ev, honap, nap);

            Console.WriteLine("Adja meg a Fizetését.");
            fizetes = long.Parse(Console.ReadLine());

            Console.WriteLine("Adja meg a Magasságát méterben.");
            magassag = double.Parse(Console.ReadLine());

            hazas = false;
            Console.WriteLine("Adja meg, hogy Házas-e írja be 'igen' vagy 'nem'.");
            switch (System.Console.ReadLine())
            {
                case "igen": { hazas = true; break; }
                case "nem": { hazas = false; break; }
            }

            ember[10] = new Szemely(vezeteknev, keresztnev, szuletesIdeje, fizetes, magassag, hazas);
            Console.WriteLine("\nA beolvasott embernél alacsonyabb személyek\n");
            for (int i = 0; i < 10; i++)
            {
                if (ember[10].Magassag>ember[i].Magassag)
                {
                    Console.WriteLine(ember[i].ToString());
                }
            }
            
            int egyezesekSzama = 0;
            for (int i = 0; i < 10; i++)
            {
                if (Szemely.EgyenloE(ember[10], ember[i]))
                {
                    Console.WriteLine("Az első egyező személy indexe: " + i);
                    egyezesekSzama++;
                    break;
                }
            }
            if (egyezesekSzama == 0)
            {
                Console.WriteLine("Nem volt egyezés.");
            }

            /*ember[10] = ember[2];     //Biztos egyezés legyen.
            egyezesekSzama = 0;
            for (int i = 0; i < 10; i++)
            {
                if (Szemely.EgyenloE(ember[10],ember[i]))
                {
                    Console.WriteLine("Az első egyező személy indexe: " + i);
                    egyezesekSzama++;
                    break;
                }
            }
            if (egyezesekSzama == 0)
            {
                Console.WriteLine("Nem volt egyezés.");
            }*/

            Console.ReadKey();
        }
    }
}