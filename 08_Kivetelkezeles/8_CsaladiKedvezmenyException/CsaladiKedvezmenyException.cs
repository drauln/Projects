using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsaladiKedvezmenyException
{
    class CsaladiKedvezmenyException:Exception
    {
        int szuksegesGyerkekSzama;
        bool hazasE;

        public CsaladiKedvezmenyException(string message,bool hazasE,int szuksegesGyerkekSzama) : base(message)
        {
            this.szuksegesGyerkekSzama = szuksegesGyerkekSzama;
            this.hazasE = hazasE;
        }

        public override string ToString()
        {
            return Message + " Házasnak kell lennie: " + hazasE + " Szükséges gyerekek száma: " + szuksegesGyerkekSzama;
        }
    }
}
