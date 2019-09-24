using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szemely_osztaly;
using System.Reflection;

namespace Sajat_attributum
{
    class Futtathato
    {
        static void Main(string[] args)
        {
            Szemely[] ember = new Szemely[3];
            ember[0] = new Szemely();
            ember[1] = new Szemely();
            ember[2] = ember[0];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(ember[i].ToString());
            }

            ember[0].NevValtoztatas2("Asd");

            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(ember[i].ToString());
            }

            Console.WriteLine();

            ember[0].Vezeteknev = ember[1].Vezeteknev;
            ember[0].Keresztnev = ember[1].Keresztnev;

            Console.WriteLine(ember[0]==ember[1]);
            Console.WriteLine(ember[0] == ember[2]);

            if (Szemely.NagyobbE(ember[0],ember[1]))
            {
                if (Szemely.NagyobbE(ember[0], ember[2]))
                {
                    Console.WriteLine("Az első személy a legmagasabb.");
                }
                else
                {
                    Console.WriteLine("A második személy a legmagasabb.");
                }
            }
            else
            {
                if (Szemely.NagyobbE(ember[1], ember[2]))
                {
                    Console.WriteLine("A második személy a legmagasabb.");
                }
                else
                {
                    Console.WriteLine("A harmadik személy a legmagasabb.");
                }
            }

            if (Szemely.EgyenloE(ember[0], ember[2]))
            {
                Console.WriteLine("Megyeznek.");
            }
            else
            {
                Console.WriteLine("Nem egyeznek meg.");
            }

            Console.WriteLine("Adjon meg egy egészet.");
            int egesz = int.Parse(Console.ReadLine());


            foreach (MethodInfo metodusInformacio in typeof(Szemely).GetMethods())
            {
                //Console.WriteLine("Metódus neve: " + metodusInformacio);

                foreach (Attribute jellemzo in metodusInformacio.GetCustomAttributes(true))
                {
                    //Console.WriteLine("\t" + jellemzo);

                    ParamterekSzamaAttribute sajatAttributum = jellemzo as ParamterekSzamaAttribute;

                    if (sajatAttributum != null && egesz == sajatAttributum.egesz)
                    {
                        Console.WriteLine("Metódus neve: " + metodusInformacio);
                    }
                }
            }


            Console.WriteLine("Nyomj meg egy gombot.");
            Console.ReadKey();
        }
    }
}