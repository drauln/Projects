using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szemely_osztaly;

namespace Diak_osztaly
{
    class Diak:Szemely
    {
        private string keresztnev;
        private DateTime szuletesIdeje;
        private double magassag;
        private long zsebpenz;

        public Diak(string vezeteknev, string keresztnev, DateTime szuletesIdeje, double magassag,long zsebpenz) : base(vezeteknev, keresztnev, szuletesIdeje, magassag)
        {
            this.vezeteknev = vezeteknev;
            this.keresztnev = keresztnev;
            this.szuletesIdeje = szuletesIdeje;
            this.magassag = magassag;
            this.zsebpenz = zsebpenz;
        }
        
        private string vezeteknev; //propfull

        public string Vezeteknev
        {
            get
            {
                return vezeteknev;
            }
            set
            {
                Console.WriteLine("Az értéket megváltoztatták.");
                vezeteknev = value;
            }
        }
        
        public string Keresztnev
        {
            get { return keresztnev; }
            set { keresztnev = value; }
        }

        public override double EgyForeJutoJovedelem()
        {
            return zsebpenz;
        }

        public override string ToString()
        {
            return "Vezetéknév: " + Vezeteknev + " Keresztnév: " + Keresztnev  + " Magasság: " + Magassag + " Zsebpenz: " + EgyForeJutoJovedelem();
        }
    }
}
/*
  Készítsen egy Diak osztályt, amely a Szemely leszármazottja
- legyen zsebpenz adattagja,
- legyen konstruktora, amely paraméterben kapott értékekkel inicializálja az objektumot,
- legyen felüldefiniálva az örökölt egy főre jutó jövedelmet visszaadó metódus (visszaadja a zsebpénzt),
- legyen metódusa, amely string-be összefűzve adja vissza: név, magasság, zsebpénz!
*/