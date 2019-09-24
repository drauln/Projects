using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using konyves.alap;
using Szemely_osztaly;

namespace Konyv
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Adja meg, hogy hány Könyv adatait szeretné eltárolni.");
            int elemszam = int.Parse(Console.ReadLine());

            konyves.alap.Konyv[] konyvek = new konyves.alap.Konyv[elemszam];

            for (int i = 0; i < elemszam; i++)
            {
                konyvek[i] = new konyves.alap.Konyv(new Szemely(), "asdfgh" + rnd.Next(1, 11),rnd.Next(200,701), rnd.Next(1, 9) * 1000);
            }

            for (int i = 0; i < elemszam; i++)
            {
                Console.WriteLine(konyvek[i].ToString());
            }

            if (konyvek[0].OldalankentiAr(konyvek[1]))
            {
                Console.WriteLine("0. indexű könyv oldalankénti ára nagyobb.");
            }
            else
            {
                Console.WriteLine("1. indexű könyv oldalankénti ára nagyobb.");
            }

            Console.WriteLine("Hosszabb könyv adatai: " + konyves.alap.Konyv.Hosszabb(konyvek[0], konyvek[1]).ToString());
            
                

            Console.ReadKey();
        }
    }
}
