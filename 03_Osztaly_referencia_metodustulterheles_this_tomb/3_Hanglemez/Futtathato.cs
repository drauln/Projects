using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szemely_osztaly;

namespace Hanglemez
{
    class Futtathato
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elemszám: ");
            int elemszam=0;
            elemszam = int.Parse(Console.ReadLine());

            string cim;
            int hossz;

            Hanglemez[] lemezek = new Hanglemez[elemszam];

            Szemely[] ember = new Szemely[elemszam];

            for (int i = 0; i < elemszam; i++)
            {
                ember[i] = new Szemely();
            }

            for (int i = 0; i < elemszam; i++)
            {
                Console.WriteLine("Adja meg a címet.");
                cim = Console.ReadLine();
                Console.WriteLine("Adja meg a hosszt.");
                hossz = int.Parse(Console.ReadLine());
                lemezek[i] = new Hanglemez(ember[i],cim, hossz);
            }

            for (int i = 0; i < elemszam; i++)
            {
                Console.WriteLine(lemezek[i].ToString());
            }

            int index = 0;
            int leghosszabb=lemezek[0].Hossz;
            for (int i = 1; i < elemszam; i++)
            {
                if (leghosszabb<lemezek[i].Hossz)
                {
                    leghosszabb = lemezek[i].Hossz;
                    index = i;
                }
            }

            Console.WriteLine("Leghosszabb lemez adatai: " + lemezek[index].ToString());

            Console.WriteLine("Adjon meg egy előadót: ");
            string eloado=Console.ReadLine();
            for (int i = 0; i < elemszam; i++)
            {
                if ((lemezek[i].Vezeteknev + " " + lemezek[i].Keresztnev) == eloado)
                {
                    Console.WriteLine(lemezek[i].ToString());
                }
                else
                {
                    Console.WriteLine("Nincs ilyen nevű előadó.");
                }
            }

            Console.ReadKey();
        }
    }
}
//Készítsen egy Lemezek futtatható osztály, amelyben létrehoz és tömbben tárol beolvasott számú beolvasott adatú hanglemezt! Majd írja ki a leghosszabb lemez adatait! Majd írja ki a egy beolvasott nevű előadó lemezeit!