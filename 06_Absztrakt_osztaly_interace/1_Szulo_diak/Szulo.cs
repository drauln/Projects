using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szemely_osztaly;

namespace Szulo_osztaly
{
    class Szulo:Szemely
    {
        private string keresztnev;
        private DateTime szuletesIdeje;
        private double magassag;
        private long fizetes;
        private bool hazas;
        private int gyerekekSzama;

        public Szulo(string vezeteknev, string keresztnev, DateTime szuletesIdeje, double magassag,long fizetes,bool hazas,int gyerekekSzama) : base(vezeteknev, keresztnev, szuletesIdeje, magassag)
        {
            this.vezeteknev = vezeteknev;
            this.keresztnev = keresztnev;
            this.szuletesIdeje = szuletesIdeje;
            this.magassag = magassag;
            this.fizetes = fizetes;
            this.hazas = hazas;
            this.gyerekekSzama = gyerekekSzama;
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

        public double Magassag
        {
            get { return magassag; }
            set { magassag = value; }
        }

        public override double EgyForeJutoJovedelem()
        {
            int x = 0;
            if (hazas)
            {
                x = 2;
            }
            else
            {
                x = 1;
            }
            
            return (fizetes/(gyerekekSzama+x));
        }

        public override string ToString()
        {
            return "Vezetéknév: " + Vezeteknev + " Keresztnév: " + Keresztnev  + " Magasság: " + Magassag + " Egy főre jutó jövedelem: " + EgyForeJutoJovedelem();
        }
    }
}
