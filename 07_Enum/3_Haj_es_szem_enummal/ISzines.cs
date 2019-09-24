using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Csalados_szemely;

namespace szines
{
    public enum Szinek { Barna, Kék, Fekete , Zöld};
    interface ISzines
    {
        Szinek HajSzine();

        Szinek HajSzinValtoztat();

        Szinek SzemSzine();
        
        Szinek AlapSzin
        {
            get;
        }
    }
}