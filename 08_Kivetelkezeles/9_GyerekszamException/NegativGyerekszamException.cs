using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyerekszamException
{
    class NegativGyerekszamException : RosszGyerekszamException
    {
        public NegativGyerekszamException(int gyerekSzam) : base(gyerekSzam) { }

        public override string Message => "Negatív gyerekszám.";

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
