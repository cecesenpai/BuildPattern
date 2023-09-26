using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildPattern
{
    public class MixedPizza : Pizza
    {
        public MixedPizza()
        {
        }

        public override string Name()
        {
            return "Mixed Pizza";
        }

        public override decimal Price()
        {
            return 200;
        }
    }
}
