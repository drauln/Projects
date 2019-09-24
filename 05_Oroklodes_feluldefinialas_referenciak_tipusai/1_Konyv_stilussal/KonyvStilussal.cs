using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using konyves;
using konyves.alap;
using Szemely_osztaly;

namespace ujkonyves
{
    class KonyvStilussal:Konyv
    {
        private string stilus;

        public KonyvStilussal(Szemely iro, string cim, int oldalszam, int ar,string stilus):base(iro, cim, oldalszam, ar)
        {
            this.stilus = stilus;
        }

        public string Stilus()
        {
            return stilus;
        }

        public override string ToString()
        {
            return base.ToString()+" stílus: " + stilus;
        }
    }
}
/*
Készítsen C# nyelvű osztályt ujkonyves.KonyvStilussal néven a korábbi konyves.alap.Konyv 
osztály kiterjesztésére!
Legyen még stílus(szöveg) adata,
legyen konstruktora, amely minden adatát paraméterben kapott adatokkal inicializálja,
legyen metódusa, amely visszaadja a stílust,
legyen metódusa, amely felüldefiniálja a string-et visszadó metódust úgy, hogy az ősbeli
stringhez még fűzze hozzá a stílust is!

Készítsen egy futtatható osztályt az ujkonyves.futo névtérben, amelyben beolvas elemszam darab könyvet
egy tömbbe és kiírja a legkisebb oldalárút valamint a "Scifi" stílusú könyveket!
*/