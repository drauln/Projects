using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using konyves.alap;
using Szemely_osztaly;
using System.Xml.Serialization;
using System.IO;

namespace Konyv
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int elemszam;
            do
            {
                Console.WriteLine("Adja meg, hogy hány Könyv adatait szeretné eltárolni.(legalább 2.)");
                elemszam = int.Parse(Console.ReadLine());
            } while (elemszam<2);
            
            

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


            Console.WriteLine("\nXML Konyv\n");
            XmlSerializer szerializalo = new XmlSerializer(typeof(konyves.alap.Konyv[]));
            var fajl = new FileInfo("konyv.xml");
            fajl.Delete();

            Stream kimenoAdatfolyam = fajl.OpenWrite();
            szerializalo.Serialize(kimenoAdatfolyam, konyvek);
            kimenoAdatfolyam.Close();

            konyves.alap.Konyv[] tesztKonyv = new konyves.alap.Konyv[elemszam];

            Stream bemenoAdatfolyam = fajl.OpenRead();
            tesztKonyv = (konyves.alap.Konyv[])szerializalo.Deserialize(bemenoAdatfolyam);
            bemenoAdatfolyam.Close();

            for (int i = 0; i < elemszam; i++)
            {
                Console.WriteLine(tesztKonyv[i].ToString());
            }

            Console.ReadKey();
        }
    }
}
