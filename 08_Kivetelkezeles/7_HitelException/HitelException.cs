using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HitelException
{
    class HitelException : Exception
    {
        int hitelDifferencia;

        public HitelException(string message,int hitelDifferencia) : base(message)
        {
            this.hitelDifferencia = hitelDifferencia;
        }

        public override string ToString()
        {
            return "Szükséges fizetés még: " + hitelDifferencia;
        }
    }
}
