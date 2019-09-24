using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szemely_osztaly;
using szines;

namespace Dolgozo_osztaly
{
    class DolgozoSzemely:Szemely,ISzines
    {
        private string munkahely;
        private string hajSzine;
        private string szemSzine;

        public DolgozoSzemely(string vezeteknev, string keresztnev, DateTime szuletesIdeje, long fizetes, double magassag, bool hazas, string munkahely, string hajSzine, string szemSzine):base(vezeteknev, keresztnev, szuletesIdeje, fizetes, magassag, hazas)
        {
            this.munkahely = munkahely;
            this.hajSzine = hajSzine;
            this.szemSzine = szemSzine;
        }

        public string Hajszin
        {
            set { hajSzine = value; }
        }

        public string AlapSzin
        {
            get { return "barna"; }
        }

        public string HajSzine()
        {
            return hajSzine;
        }

        public string HajSzinValtoztat()
        {
            Console.WriteLine("Adja meg a hajszínt.");
            hajSzine = Convert.ToString(Console.ReadLine());
            return hajSzine;
        }

        public string SzemSzine()
        {
            return szemSzine;
        }

        public override string ToString()
        {
            return base.ToString()+" Munkahely: " + munkahely + " Hajszíne: " + hajSzine + " Szemszíne: " + szemSzine;
        }
    }
}