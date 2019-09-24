using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using konyves;
using Szemely_osztaly;

namespace ujkonyves.futo
{
    class KonyvProba
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Adja meg, hogy hány Könyv adatait szeretné eltárolni.");
            int elemszam = int.Parse(Console.ReadLine());
            List<string> lista = new List<string>();
            lista.Add("Scifi");
            lista.Add("Thriler");
            lista.Add("Fantasi");

            ujkonyves.KonyvStilussal[] konyvek = new ujkonyves.KonyvStilussal[elemszam];

            for (int i = 0; i < elemszam; i++)
            {
                konyvek[i] = new ujkonyves.KonyvStilussal(new Szemely(), "asdfgh" + rnd.Next(1, 11),rnd.Next(200,701), rnd.Next(1, 9) * 1000,lista[rnd.Next(0,lista.Count())]);
            }

            for (int i = 0; i < elemszam; i++)
            {
                Console.WriteLine(konyvek[i].ToString());
            }

            int index = 0;
            
            for (int i = 0; i < elemszam-1; i++)
            {
                if (konyvek[index].OldalankentiAr(konyvek[i+1]))
                {
                    index = 0;
                }
                else
                {
                    index = i + 1;
                }
            }
            
            Console.WriteLine("\nLegmagasabb oldalárú könyv: " + konyvek[index].ToString());

            Console.WriteLine("Hosszabb könyv adatai: " + konyves.alap.Konyv.Hosszabb(konyvek[0], konyvek[1]).ToString());

            Console.WriteLine("\nScifi stílusú könyvek: ");
            for (int i = 0; i < elemszam; i++)
            {
                if (konyvek[i].Stilus().Equals("Scifi"))
                {
                    Console.WriteLine(konyvek[i].ToString());
                }
            }
            

            Console.ReadKey();
        }
    }
}
