using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szemely_osztaly;

namespace Do_while_ciklus
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

            Szemely[] ember = new Szemely[elemszam];

            int i = 0;
            do
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

                ember[i] = new Szemely(vezeteknev, keresztnev, szuletesIdeje, fizetes, magassag, hazas);
                i++;
            } while (i < elemszam);

            i = 0;
            do
            {
                Console.WriteLine(ember[i].ToString());
                i++;
            } while (i < elemszam);

                Console.ReadKey();
        }
    }
}
