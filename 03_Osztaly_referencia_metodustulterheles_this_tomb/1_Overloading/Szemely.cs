using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szemely_osztaly
{
    class Szemely
    {
        private string keresztnev;
        private DateTime szuletesIdeje;
        private long fizetes;
        private double magassag;
        private bool hazas;

        public Szemely(string vezeteknev, string keresztnev, DateTime szuletesIdeje, long fizetes, double magassag, bool hazas)
        {
            this.vezeteknev = vezeteknev;
            this.keresztnev = keresztnev;
            this.szuletesIdeje = szuletesIdeje;
            this.fizetes = fizetes;
            this.magassag = magassag;
            this.hazas = hazas;
        }

        public Szemely(long fizetes, double magassag, bool hazas):base()
        {
            vezeteknev = "Próba";
            keresztnev = "Péter";
            szuletesIdeje = DateTime.Now;
            this.fizetes = fizetes;
            this.magassag = magassag;
            this.hazas = hazas;
        }

        public Szemely()
        {
            vezeteknev = "Abc";
            keresztnev = "Zxy";
            szuletesIdeje = DateTime.Now;
            fizetes = 0;
            magassag = 0;
            hazas = false;
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

        public long Fizetes
        {
            get { return fizetes; }
            set { fizetes = value; }
        }

        public double Magassag
        {
            get { return magassag; }
            set { magassag = value; }
        }
        
        public static bool NagyobbE(Szemely egyik, Szemely masik)
        {
            if (egyik.Magassag>masik.Magassag)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Kiir()
        {
            return Vezeteknev + keresztnev;
        }

        public override string ToString()
        {
            string hazasE = "";
            if (hazas)
            {
                hazasE = "házas";
            }
            else
            {
                hazasE = "nem házas";
            }
            return "Név: " + Vezeteknev + " " + Keresztnev + ", Születési idő: " + szuletesIdeje + ", Fizetés: " + Fizetes + " Ft, Magasság: " + Magassag + " m, " + hazasE;
        }

        public void NevValtoztatas(string vezetek,string kereszt)
        {
            vezeteknev = vezetek;
            keresztnev = kereszt;
        }

        public void NevValtoztatas2(string nevek)
        {
            vezeteknev = nevek;
            keresztnev = nevek;
        }

        public static bool EgyenloE(Szemely egyik,Szemely masik)
        {
            if (egyik.Equals(masik))
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