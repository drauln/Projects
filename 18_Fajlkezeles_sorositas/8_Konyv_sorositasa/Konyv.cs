using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Konyv;
using Szemely_osztaly;

namespace konyves.alap
{
    [Serializable]
    public class Konyv
    {
        public Szemely iro;
        public string cim;
        public int oldalszam;
        public int ar;

        public Konyv(Szemely iro, string cim, int oldalszam,int ar)
        {
            this.iro = iro;
            this.cim = cim;
            this.oldalszam = oldalszam;
            this.ar = ar;
        }

        public Konyv() { }

        public override string ToString()
        {
            return "Író: " + iro.Vezeteknev + " " + iro.Keresztnev + " Cím: " + cim + " oldalszám: " + oldalszam + " ár: " + ar;
        }

        public bool OldalankentiAr(Konyv masik)
        {
            if ((this.ar / this.oldalszam) > (masik.ar / masik.oldalszam))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Konyv Hosszabb(Konyv egyik, Konyv masik)
        {
            if (egyik.oldalszam > masik.oldalszam)
            {
                return egyik;
            }
            else
            {
                return masik;
            }
        }
    }
}
/*
Készítsen egy konyves.alap.Konyv osztályt
- legyen adattagja iro(Szemely), cím, oldalszám és ár adatok tárolására,
- legyen konstruktora, amely paraméterként kapott értékekkel inicializálja az adattagokat,
- legyen metódusa, amely string-ben összefűzve adja vissza a könyv adatait(írónal csak a teljes név),
- legyen metódusa, amely igazat ad ha a könyv oldalankénti ára nagyobb, mint egy paraméterként kapott könyvvé,
- legyen metódusa, amely két paraméterként kapott könyv közül a hosszabbat adja vissza!

Készítsen egy konyves.KonyvProba futtatható osztályt, amelyben beolvas elemszam darab könyvet egy tömbbe és meghatározza a legkisebb oldalárú, valamint a leghosszabb könyvet!
*/