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

        public DateTime SzuletesIdeje
        {
            get { return szuletesIdeje; }
            set { szuletesIdeje = value; }
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
        
        public void Novel(int ertek)
        {
            fizetes += ertek;
        }
        
        public bool FizetesIntervalluma(int minimum,int maximum)
        {
            if (minimum < fizetes && fizetes < maximum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public long Ado(int szazalek)
        {
            return (fizetes * szazalek / 100);
        }

        public static bool NagyobbE(long egyik,long masik)
        {
            if (egyik>masik)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Szemely operator + (Szemely egyik, Szemely masik)
        {

            Szemely gyerek = new Szemely("X", "Y", DateTime.Now, egyik.Fizetes + masik.Fizetes, egyik.Magassag + masik.Magassag, false);
            return gyerek;
        }

        public static Szemely operator - (Szemely egyik, Szemely masik)
        {

            Szemely gyerek = new Szemely("X", "Y", DateTime.Now, Math.Abs(egyik.Fizetes - masik.Fizetes), Math.Abs(egyik.Magassag - masik.Magassag), false);
            return gyerek;
        }

        public static Szemely operator ++ (Szemely ember)
        {
            ember.szuletesIdeje = ember.szuletesIdeje.AddDays(1); //AddHours(24)
            
            return ember;
        }

        public static Szemely operator -- (Szemely ember)
        {
            ember.szuletesIdeje = ember.szuletesIdeje.AddHours(-24); //AddDays(-1)

            return ember;
        }

        public static implicit operator long(Szemely ember)
        {
            return ember.Fizetes;
        }

        public static implicit operator DateTime(Szemely ember)
        {
            return ember.szuletesIdeje;
        }

        public static implicit operator double(Szemely ember)
        {
            return ember.Magassag;
        }

        public static implicit operator bool(Szemely ember)
        {
            return ember.hazas;
        }

        public static implicit operator string(Szemely ember)
        {
            return ember.Keresztnev;
        }

        public static bool operator == (Szemely egyik, Szemely masik)
        {
            if (egyik.Fizetes==masik.Fizetes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator != (Szemely egyik, Szemely masik)
        {
            if (egyik.Fizetes != masik.Fizetes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return "Vezetéknév: " + Vezeteknev + " Keresztnév: " + Keresztnev + " Született: " + szuletesIdeje + " Fizetés: " + Fizetes + " Magasság: " + Magassag + " házas: " + hazas;
        }
    }
}
