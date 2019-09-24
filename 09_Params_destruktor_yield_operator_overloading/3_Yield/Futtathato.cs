using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szemely_osztaly;

namespace Yield
{
    class Futtathato
    {
        static IEnumerable<int> HazasE(List<Szemely> lista)
        {
            for(int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Hazas)
                {
                    yield return i;
                }
            }
            
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

            for (int i = 0; i < elemszam; i++)
            {
                Console.WriteLine("Sorszám: " + (i+1) + " " + ember[i].ToString() + " Házas:" + ember[i].Hazas);
            }

            Console.WriteLine("Legidősebb személy sorszáma: " + (Szemely.Index(ember, elemszam) +1) + " " + "indexe: " + Szemely.Index(ember, elemszam));

            Console.WriteLine("\nYield használata");

            List<Szemely> lista = new List<Szemely>();
            for (int i = 0; i < elemszam; i++)
            {
                lista.Add(ember[i]);
            }
            
            foreach (int i in HazasE(lista))
            {
                Console.WriteLine(ember[i].ToString());
            }

            Console.ReadKey();
        }
    }
}
/*A futtatható osztályban hozzon létre egy 5 elemű Dolgozok nevű tömböt, majd egy statikus metódus segítségével szűrje le a házasokat,
 * és yield returnnel adja vissza a szemelyeket, és írassa ki a fizetéseket és a magasságukat!
*/