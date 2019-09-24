using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szemely_osztaly;

namespace konyves.alap
{
    class Konyv
    {
        private Szemely iro;
        private string cim;
        private int oldalszam;
        private int ar;

        public Konyv(Szemely iro, string cim, int oldalszam,int ar)
        {
            this.iro = iro;
            this.cim = cim;
            this.oldalszam = oldalszam;
            this.ar = ar;
        }

        public override string ToString()
        {
            return "Író: " + iro.Vezeteknev + " " + iro.Keresztnev + " Cím: " + cim + " oldalszám: " + oldalszam + " ár: " + ar;
        }

        public bool OldalankentiAr(Konyv masik)
        {
            if ((ar / oldalszam) > (masik.ar / masik.oldalszam))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Konyv Hosszabb(Konyv egyik, Konyv masik)
        {
            if (egyik.oldalszam > masik.oldalszam)
            {
                return egyik;
            }
            else
            {
                return masik;
            }
        }
    }
}