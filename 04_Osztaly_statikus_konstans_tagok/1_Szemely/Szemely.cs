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
        private int nyugdijKorhatar = 65;

        public Szemely(string vezeteknev, string keresztnev, DateTime szuletesIdeje, long fizetes, double magassag, bool hazas)
        {
            this.vezeteknev = vezeteknev;
            this.keresztnev = keresztnev;
            this.szuletesIdeje = szuletesIdeje;
            this.fizetes = fizetes;
            this.magassag = magassag;
            this.hazas = hazas;
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
        
        public int NyugdijKorhatar
        {
            get { return nyugdijKorhatar; }
            set { nyugdijKorhatar = value; }
        }
        
        public int Nyugdijig()
        {
            int eletkor = DateTime.Now.Year - szuletesIdeje.Year;
            if (nyugdijKorhatar-eletkor>0)
            {
                return nyugdijKorhatar - eletkor;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return "Vezetéknév: " + Vezeteknev + " Keresztnév: " + Keresztnev + " Fizetés: " + Fizetes + " Magasság: " + Magassag + " m Nyugdíjig: " + Nyugdijig() + " Életkora: " + (DateTime.Now.Year - szuletesIdeje.Year);
        }

        public void KorhatarAllito(int ujKorhatar)
        {
            nyugdijKorhatar = ujKorhatar;
        }

        public static Szemely NagyobbFizetesu(Szemely egyik, Szemely masik)
        {
            if (egyik.fizetes>masik.fizetes)
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
