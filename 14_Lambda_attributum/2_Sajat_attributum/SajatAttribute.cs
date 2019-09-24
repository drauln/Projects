using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sajat_attributum
{
    [AttributeUsageAttribute(AttributeTargets.Method)]
    class ParamterekSzamaAttribute : Attribute
    {
        public int egesz;

        public ParamterekSzamaAttribute(int egesz)
        {
            this.egesz = egesz;
        }
    }
}
