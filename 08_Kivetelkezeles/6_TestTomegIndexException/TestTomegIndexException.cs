using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szemely_osztaly;

namespace TestTomegIndexException
{
    class TestTomegIndexException : Exception
    {
        public Alkatok alkat;
        public double tomegDifferencia;

        public TestTomegIndexException(string message, Alkatok alkat,double tomegDifferencia) : base(message)
        {
            this.tomegDifferencia = tomegDifferencia;
            this.alkat = alkat;
        }
        
        public override string ToString()
        {
            return "Jelenlegi alkat: " + alkat + " Normális alkathoz: " + tomegDifferencia;
        }
    }
}