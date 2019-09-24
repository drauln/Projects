using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szemely_osztaly;

namespace Sekely_masolas
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
                vezeteknev = Szemely.NevGenerator(chars, 3);

                keresztnev = Szemely.NevGenerator(chars, 3); 

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
                Console.WriteLine("Sorszám: " + (i+1) + " \n" + ember[i].ToString());
            }

            Szemely masoltEmber = ember[0].SekelyMasolas();
            Console.WriteLine("Másolat: \n" + masoltEmber.ToString());

            Console.WriteLine("\nÚj fizetés megadása");
            ember[0].HaviFizetes.Fizetes = rnd.Next(70000, 200001);
            Console.WriteLine(ember[0].ToString());
            Console.WriteLine("Másolat: \n" + masoltEmber.ToString());

            Szemely masoltEmber2 = ember[0].MelyMasolas();
            Console.WriteLine("\nMély másolat adatai: \n" + masoltEmber2.ToString());
            ember[0].HaviFizetes.Fizetes = rnd.Next(70000, 200001);
            Console.WriteLine(ember[0].ToString());
            Console.WriteLine("Másolat: \n" + masoltEmber.ToString());
            Console.WriteLine("2. másolat: \n" + masoltEmber2.ToString());

            Console.ReadKey();
        }
    }
}
