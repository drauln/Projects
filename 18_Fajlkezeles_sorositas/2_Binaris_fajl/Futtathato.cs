using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szemely_osztaly;
using System.IO;

namespace Binaris_fajl
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

            Console.WriteLine("\nSzöveges fájlal.");

            string fajlNev = "adat.dat";
            
            Stream bemenetiAdatfolyam = new FileStream(fajlNev, FileMode.Create);
            BinaryWriter binarisIras = new BinaryWriter(bemenetiAdatfolyam);

            binarisIras.Write(ember[0].vezeteknev);
            binarisIras.Write(ember[0].keresztnev);
            binarisIras.Write(ember[0].szuletesIdeje.Year);
            binarisIras.Write(ember[0].szuletesIdeje.Month);
            binarisIras.Write(ember[0].szuletesIdeje.Day);
            binarisIras.Write(ember[0].magassag);
            binarisIras.Write(ember[0].fizetes);
            binarisIras.Write(ember[0].hazas);

            binarisIras.Close();
            bemenetiAdatfolyam.Close();


            
            Stream kimenoAdatfolyam = new FileStream(fajlNev, FileMode.Open);
            BinaryReader binarisOlvasas = new BinaryReader(kimenoAdatfolyam);

            Console.WriteLine("Kiolvasott Vezetéknév: " + binarisOlvasas.ReadString());
            Console.WriteLine("Kiolvasott Keresztnév: " + binarisOlvasas.ReadString());
            Console.WriteLine("Kiolvasott Születési év: " + binarisOlvasas.ReadInt32());
            Console.WriteLine("Kiolvasott Születési hónap: " + binarisOlvasas.ReadInt32());
            Console.WriteLine("Kiolvasott Születési nap: " + binarisOlvasas.ReadInt32());
            Console.WriteLine("Kiolvasott Magasság: " + binarisOlvasas.ReadDouble());
            Console.WriteLine("Kiolvasott Fizetés: " + binarisOlvasas.ReadInt64());
            Console.WriteLine("Kiolvasott Házasság: " + binarisOlvasas.ReadBoolean());

            binarisOlvasas.Close();
            kimenoAdatfolyam.Close();

            Console.ReadKey();
        }
    }
}
