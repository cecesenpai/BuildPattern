using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildPattern
{
    class Wrapper : Packing
    {
        public Wrapper()
        {
        }

        public string Pack()
        {
            return "Wrapper";
        }
    }
}
