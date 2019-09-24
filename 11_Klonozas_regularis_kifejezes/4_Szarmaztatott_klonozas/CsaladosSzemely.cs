using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szemely_osztaly;

namespace Csalados_szemely
{
    class CsaladosSzemely:Szemely
    {
        private int gyerekekSzama;

        public CsaladosSzemely(string vezeteknev,string keresztnev,DateTime szuletesIdeje,long fizetes,double magassag,bool hazas,int gyerekekSzama) : base(vezeteknev, keresztnev, szuletesIdeje, fizetes, magassag, hazas)
        {
            this.gyerekekSzama = gyerekekSzama;
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
            return base.ToString()+" egy főre jutó jövedelem: " + EgyForeJutoJovedelem;
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