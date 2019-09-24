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
        const int maxGyerekSzam = 5;
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
            return base.ToString()+" Gyerekek száma: " + GyerekekSzama;
        }

        public int GyerekekSzama
        {
            get{return gyerekekSzama;}
        }

        public void GyerekekKivetel()
        {
            try
            {
                if (GyerekekSzama > maxGyerekSzam)
                {
                    throw new GyerekszamException.MagasGyerekszamException(GyerekekSzama);
                }
                if (GyerekekSzama < 0)
                {
                    throw new GyerekszamException.NegativGyerekszamException(GyerekekSzama);
                }
            }
            catch (GyerekszamException.MagasGyerekszamException mgye)
            {
                Console.WriteLine(mgye.ToString());
            }
            catch (GyerekszamException.NegativGyerekszamException ngye)
            {
                Console.WriteLine(ngye.ToString());
            }
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