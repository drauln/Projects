using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sajat.elso;   //névtér probléma egyszerű megoldása

namespace sajat.masik
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
            long fizetes;
            double magassag;
            bool hazas;
            string chars = "abcdefghijklmnopqrstuvwxyz";
            Random rnd = new Random();
            double min = 1.5;
            double max = 2.2;
            
            vezeteknev = chars[rnd.Next(0, chars.Length)].ToString().ToUpper() + chars[rnd.Next(0, chars.Length)] + chars[rnd.Next(0, chars.Length)];

            keresztnev = chars[rnd.Next(0, chars.Length)].ToString().ToUpper() + chars[rnd.Next(0, chars.Length)] + chars[rnd.Next(0, chars.Length)];

            ev = rnd.Next(1940, 2011);

            honap = rnd.Next(1, 13);

            nap = rnd.Next(1, 28);
            DateTime szuletesIdeje = new DateTime(ev, honap, nap);

            fizetes = rnd.Next(120000, 990001);

            magassag = Math.Round(rnd.NextDouble() * (max - min) + min, 1); //Kerekítés 1 tizedesjegyre

            if (rnd.Next(0, 1) == 0)
            {
                hazas = false;
            }
            else
            {
                hazas = true;
            }
            
            Szemely ember = new Szemely(vezeteknev, keresztnev, szuletesIdeje, fizetes, magassag, hazas); //sajat.elso.Szemely ember = new sajat.elso.Szemely(....); ha nem használtuk volna a "using sajat.elso"-t;

            
            Console.WriteLine(ember.ToString());
            

            Console.WriteLine();

            int index = 0;
            for (int i = 0; i < 2; i++)
            {
                i--;
                index++;
                int randomSzam = rnd.Next(120000, 990001);
                Console.WriteLine(randomSzam);
                if (ember.EgyezikE(randomSzam))
                {
                    Console.WriteLine("Az " + index + ". elem fért bele a tűrésbe.");
                    break;
                }
            }

            ember.Fizetes = 150000;
            Console.WriteLine(ember.ToString());

            Console.ReadKey();
        }
    }
}
