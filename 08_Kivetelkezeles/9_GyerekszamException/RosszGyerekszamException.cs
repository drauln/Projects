using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyerekszamException
{
    class RosszGyerekszamException:Exception
    {
        protected int gyerekSzam;

        public RosszGyerekszamException(string message, int gyerekSzam) : base(message)
        {
            this.gyerekSzam = gyerekSzam;
        }

        public RosszGyerekszamException(int gyerekSzam)
        {
            this.gyerekSzam = gyerekSzam;
        }

        public override string ToString()
        {
            return Message + ", Gyerekek száma: " + gyerekSzam;
        }
    }
}
