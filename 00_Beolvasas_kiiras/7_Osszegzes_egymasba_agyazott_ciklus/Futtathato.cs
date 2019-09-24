using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szemely_osztaly;

namespace Osszegzes
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
            //long havi_fizetes;
            int honapok;
            long osszes;

            Szemely[] ember = new Szemely[elemszam];

            for (int i = 0; i < elemszam; i++)
            {
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
                DateTime szuletesIdeje = new DateTime(ev, honap, nap);

                /*Console.WriteLine("Adja meg a Hónapok számát.");
                honapok = int.Parse(Console.ReadLine());*/

                Console.WriteLine("Adja meg a Fizetését.");
                /*havi_*/fizetes = long.Parse(Console.ReadLine());
                //fizetes = honapok * havi_fizetes;

                Console.WriteLine("Adja meg a Magasságát méterben.");
                magassag = double.Parse(Console.ReadLine());

                hazas = false;
                Console.WriteLine("Adja meg, hogy Házas-e írja be 'igen' vagy 'nem'.");
                switch (System.Console.ReadLine())
                {
                    case "igen": { hazas = true; break; }
                    case "nem": { hazas = false; break; }
                }

                ember[i] = new Szemely(vezeteknev, keresztnev, szuletesIdeje, fizetes, magassag, hazas);
            }
            
            /*for (int i = 0; i < elemszam; i++)
            {
                Console.WriteLine("Az " +  i + ". ember fizetése: " + ember[i].Fizetes);
            }*/

            
            for (int i = 0; i < elemszam; i++)
            {
                Console.WriteLine(i + ". ember hány hónapot dolgozott?");
                honapok = int.Parse(Console.ReadLine());
                osszes = 0;
                for (int k = 0; k < honapok; k++)
                {
                    osszes += ember[i].Fizetes;
                }
                Console.WriteLine(i + ". ember fizetése összesen: " + osszes);
            }

            Console.ReadKey();
        }
    }
}
