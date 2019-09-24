using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szemely_osztaly;
using szines;

namespace Csalados_szemely
{
    class CsaladosSzemely:Szemely,ISzines
    {
        private int gyerekekSzama;
        private Szinek hajSzine;
        private Szinek szemSzine;

        public CsaladosSzemely(string vezeteknev,string keresztnev,DateTime szuletesIdeje,long fizetes,double magassag,bool hazas,int gyerekekSzama, Szinek hajSzine, Szinek szemSzine) : base(vezeteknev, keresztnev, szuletesIdeje, fizetes, magassag, hazas)
        {
            this.gyerekekSzama = gyerekekSzama;
            this.hajSzine = hajSzine;
            this.szemSzine = szemSzine;
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

        private double egyForeJutoJovedelem;

        public double EgyForeJutoJovedelem
        {            
            get
            {
                int x = 1;
                if (Hazas)
                {
                    x = 2;
                }
                egyForeJutoJovedelem = (Fizetes / (gyerekekSzama + x));
                return egyForeJutoJovedelem;
            }
            set { egyForeJutoJovedelem = value; }
        }

        public override string ToString()
        {
            return base.ToString()+" egy főre jutó jövedelem: " + EgyForeJutoJovedelem + " Hajszíne: " + hajSzine + " Szemszíne: " + szemSzine;
        }

        public int GyerekekSzama()
        {
            return gyerekekSzama;
        }

        public static bool NagyobbEgyForeJutoJovedelem(CsaladosSzemely egyik,CsaladosSzemely masik)
        {
            if (egyik.egyForeJutoJovedelem>masik.egyForeJutoJovedelem)
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