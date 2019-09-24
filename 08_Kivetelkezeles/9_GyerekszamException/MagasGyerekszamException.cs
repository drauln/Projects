using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyerekszamException
{
    class MagasGyerekszamException:RosszGyerekszamException
    {
        public MagasGyerekszamException(int gyerekSzam) : base(gyerekSzam) { }

        public override string Message => "Magas gyerekszám.";

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
