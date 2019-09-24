using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szemely_osztaly;
using szines;
//using Csalados_szemely;

namespace Dolgozo_osztaly
{
    class DolgozoSzemely:Szemely,ISzines
    {
        private string munkahely;
        private Szinek hajSzine;
        private Szinek szemSzine;

        public DolgozoSzemely(string vezeteknev, string keresztnev, DateTime szuletesIdeje, long fizetes, double magassag, bool hazas, string munkahely, Szinek hajSzine, Szinek szemSzine):base(vezeteknev, keresztnev, szuletesIdeje, fizetes, magassag, hazas)
        {
            this.munkahely = munkahely;
            this.hajSzine = hajSzine;
            this.szemSzine = szemSzine;
        }

        public Szinek Hajszin
        {
            set { hajSzine = value; }
        }

        public Szinek AlapSzin
        {
            get { return Szinek.Barna; }
        }

        public Szinek HajSzine()
        {
            return hajSzine;
        }

        public Szinek HajSzinValtoztat()
        {
            Random rnd = new Random();
            hajSzine = (Szinek)rnd.Next(0, 3);
            return hajSzine;
        }

        public Szinek SzemSzine()
        {
            return szemSzine;
        }
        
        public override string ToString()
        {
            return base.ToString()+" Munkahely: " + munkahely + " Hajszíne: " + hajSzine + " Szemszíne: " + szemSzine;
        }
    }
}