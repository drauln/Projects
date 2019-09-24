using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szemely_osztaly
{
    abstract class Szemely
    {
        private string vezeteknev;
        private string keresztnev;
        private DateTime szuletesIdeje;
        private double magassag;

        public Szemely(string vezeteknev, string keresztnev, DateTime szuletesIdeje, double magassag)
        {
            this.vezeteknev = vezeteknev;
            this.keresztnev = keresztnev;
            this.szuletesIdeje = szuletesIdeje;
            this.magassag = magassag;
        }
        
        public abstract double EgyForeJutoJovedelem();
    }
}
