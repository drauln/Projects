using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szemely_osztaly;

namespace Hanglemez
{
    class Hanglemez : Szemely
    {
        Szemely eloado;
        string cim;
        int hossz;

        public Hanglemez(Szemely eloado,string cim,int hossz)
        {
            this.eloado = eloado; //.Vezeteknev+" "+eloado.Keresztnev;
            this.cim = cim;
            this.hossz = hossz;
        }

        public int Hossz
        {
            get { return hossz; }
        }

        public override string ToString()
        {
            return "Előadó: " + eloado.Vezeteknev + " " + eloado.Keresztnev + " Cím: " + cim + " Hossz: " + hossz + " perc.";
        }

        public int HosszabbE(Hanglemez lemez)
        {
            if (hossz>lemez.hossz)
            {
                return 1;
            }
            else
            {
                if (hossz==lemez.hossz)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
        }

        public bool EgyezikE(string nev)
        {
            string eloadoNeve = eloado.Vezeteknev + " " + eloado.Keresztnev;
            if (eloadoNeve.Equals(nev))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
/*
 Készítsen egy Hanglemez osztályt!
Legyen adattagja az elõadó(Szemely), a cím(string) és a hossz(egész) tárolására!
Legyen konstruktora, amely paraméterként kapott értékekkel inicializálja az adattagokat!
Legyen metódusa, amely egy string-ben összefűzve adja vissza a lemez adatait a következő alakban "Elõdó: Cim, hossz perc"! (az előadónak csak a teljes neve kell)
- Legyen metódusa, amely 1-t ad vissza, ha a lemez hosszabb, mint a paraméterként kapott lemez, -1-et ad vissza, ha a paraméterként kapott a hosszabb és 0-t ad, ha egyforma hosszúak.
- Legyen egy metódusa, amely paraméterként egy előadót kap (string) és igazat ad, ha a a lemeznek õ az elõadója. (A string-ek tartalmi egyezõségének vizsgálatára használja a string osztály equals() metódusát!)
*/