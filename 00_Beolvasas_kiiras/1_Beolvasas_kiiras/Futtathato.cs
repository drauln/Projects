using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szemely_osztaly;

namespace Beolvasas_kiiras
{
    class Futtathato
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adja meg a Vezetéknevét.");
            string vezeteknev = Console.ReadLine();

            Console.WriteLine("Adja meg a Keresztnevét.");
            string keresztnev = Console.ReadLine();

            Console.WriteLine("Adja meg a Születési Évét.");
            int ev = int.Parse(Console.ReadLine());

            Console.WriteLine("Adja meg a Születési Hónapot.");
            int honap = int.Parse(Console.ReadLine());

            Console.WriteLine("Adja meg a Születési Napot.");
            int nap = int.Parse(Console.ReadLine());
            DateTime szuletesIdeje = new DateTime(ev, honap, nap);

            Console.WriteLine("Adja meg a Fizetését.");
            long fizetes = long.Parse(Console.ReadLine());

            Console.WriteLine("Adja meg a Magasságát méterben.");
            double magassag = double.Parse(Console.ReadLine());

            bool hazas = false;
            Console.WriteLine("Adja meg, hogy Házas-e írja be 'igen' vagy 'nem'.");
            switch (System.Console.ReadLine())
            {
                case "igen": { hazas = true; break; }
                case "nem": { hazas = false; break; }
            }

            Szemely ember = new Szemely(vezeteknev, keresztnev, szuletesIdeje, fizetes, magassag, hazas);

            Console.WriteLine(ember.ToString());

            Console.ReadKey();

        }
    }
}
