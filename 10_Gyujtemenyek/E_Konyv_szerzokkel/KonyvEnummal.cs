using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szemely_osztaly;
using konyves.alap;

namespace enumkonyves
{
    class KonyvEnummal:Konyv
    {
        public enum Stilus{ REGÉNY, SCIFI, EGYEB};
        public List<string> szerzok = new List<string>();
        private Stilus stilus;
        
        public KonyvEnummal(Szemely iro, string cim, int oldalszam, int ar,Stilus stilus):base(iro, cim, oldalszam, ar)
        {
            if (!szerzok.Contains(iro.Nev))
            {
                szerzok.Add(iro.Nev);
            }
            this.stilus = stilus;
        }

        public Stilus KonyvStilus
        {
            get { return stilus; }
        }

        public override string ToString()
        {
            foreach (object elem in szerzok)
            {
                return base.ToString() + " Stílus: " + stilus + " Szerző: " + elem ;
            }
            return "ajjaj.";
        }
    }
}
/*Készítsen C# nyelvű osztályt enumkonyves.KonyvEnummal néven a korábbi konyves.alap.Konyv (4.sol.3.proj.)
osztály leszármazottjaként!
Legyen egy publikus beágyazott felsorolás típus Stilus néven a következő konstansokkal:
REGÉNY, SCIFI, EGYEB!
Legyen új adattagja "stilus", ami legyen Stilus típusú,
- legyen konstruktora, amely minden adattagot paraméterben kapott értékekkel inicializálja,
- legyen felüldefiniálva a ToString metódusa úgy, hogy az ősbelihez még fűzze hozzá a stílust,
- legyen getter metódusa és tulajdonséga a stílusra!
*/