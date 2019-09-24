using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szemely_osztaly;
using konyves.alap;
using enumkonyves;

namespace enumkonyves
{
    class KonyvProba
    {
        static void Kiirat(KonyvEnummal[] obj)
        {
            for (int i = 0; i < obj.Length; i++)
            {
                Console.WriteLine(obj[i].ToString());
            }
        }
        static KonyvEnummal[] MilyenStilus(KonyvEnummal[] obj, KonyvEnummal.Stilus stilus)
        {
            int[] ujIndex= new int[obj.Length];
            int db = 0;

            for (int i = 0; i < obj.Length; i++)
            {
                if (obj[i].KonyvStilus==stilus)
                {
                    ujIndex[db] = i;
                    db++;
                }
                
            }
            KonyvEnummal[] ujTomb = new KonyvEnummal[db];
            for (int i = 0; i < db; i++)
            {
                ujTomb[i]=obj[ujIndex[i]];
                
            }
            return ujTomb;

        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Adja meg, hogy hány Könyv adatait szeretné eltárolni.");
            int elemszam = int.Parse(Console.ReadLine());
            
            KonyvEnummal[] konyvek = new KonyvEnummal[elemszam];
           
            for (int i = 0; i < elemszam; i++)
            {
                konyvek[i] = new KonyvEnummal(new Szemely(), "asdfgh" + rnd.Next(1, 11), rnd.Next(200, 701), rnd.Next(1, 9) * 1000, (KonyvEnummal.Stilus)rnd.Next(0,3));
            }

            for (int i = 0; i < elemszam; i++)
            {
                Console.WriteLine(konyvek[i].ToString());
            }

            Console.WriteLine("\nScifi könyvek:");
            Kiirat(MilyenStilus(konyvek, KonyvEnummal.Stilus.SCIFI));
            
            Console.ReadKey();

        }
    }
}
/*Készítsen egy futtaható osztályt enumkonyves.KonyvProba néven, amelyben
- legyen egy osztályszintű metódus, amely megkap egy Konyv tömböt és minden könyvet kiír a
konzolra,
- legyen egy osztályszintű metódus, amely megkap egy KonyvEnummal tömböt és egy Stilus-t és
visszaadja azon könyvek tömbjét (KonyvEnummal tömb), amelyek a megadott stílusúak,
- legyen egy Main metódusa, amelyben hasraütésszerű véletlen adatokkal létrehoz egy tömböt,
kiírja, majd meghatározza a scifi-ket és kiírja!
*/