using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szemely_osztaly;

namespace C_Lazy_generikus_absztrakcio
{
    class Futtathato
    {
        static Szemely Inicializal()
        {
            Szemely ember = new Szemely();
            return ember;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Adja meg, hogy hány Személy adatait szeretné eltárolni.");
            int elemszam = int.Parse(Console.ReadLine());

            Szemely[] ember = new Szemely[elemszam];

            Console.WriteLine();


            // LustaTípus használata
            Lazy<Szemely> lusta = new Lazy<Szemely>(Inicializal);

            Console.WriteLine(lusta.IsValueCreated);

            for (int i = 0; i < elemszam; i++)
            {
                 ember[i] = lusta.Value;
                lusta = new Lazy<Szemely>(Inicializal);
            }

            for (int i = 0; i < elemszam; i++)
            {
                Console.WriteLine(ember[i].ToString());
            }

            Console.WriteLine(lusta.IsValueCreated);

            Console.ReadKey();
        }
    }
}
