using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatumException_Osztaly
{
    class RosszSzuletesiDatumException : Exception
    {
        public RosszSzuletesiDatumException(): base() { }

        public RosszSzuletesiDatumException(string message):base(message) { }
    }
}