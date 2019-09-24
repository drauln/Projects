using System;
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

            List<int> hitelLehetosegek = new List<int>();
            hitelLehetosegek.Add(150);
            hitelLehetosegek.Add(175);
            hitelLehetosegek.Add(200);

            int lehetsegesFizetesekHitelhez = 0;
            for (int i = 0; i < elemszam; i++)
            {
                if (ember[i].Fizetes>150000)
                {
                    lehetsegesFizetesekHitelhez++;
                }
                
            }
            if (lehetsegesFizetesekHitelhez == 0)
            {
                Console.WriteLine("Nincs hitelképes fizetés.\nProgram leáll.");
                Console.ReadKey();
                return;
            }
            
            int probalkozasSzama = 0;
            bool ujra = false;
            do
            {
                ujra = false;
                int probahitel = (hitelLehetosegek[rnd.Next(0, 3)] * 1000);
                for (int i = 0; i < elemszam; i++)
                {
                    Console.WriteLine("Hitel: " + probahitel + " Fizetés: " + ember[i].Fizetes);
                    probalkozasSzama++;
                    if (ember[i].HitelFelvetel(probahitel))
                    {
                        ujra = false;
                        break;
                    }
                    else
                    {
                        ujra = true;
                    }
                }

            } while (ujra);
            

            Console.WriteLine("Hitelprobálkozások száma: " + probalkozasSzama);

            Console.ReadKey();
        }
    }
}
