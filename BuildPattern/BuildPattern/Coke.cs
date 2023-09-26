using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildPattern
{
    class Coke : ColdDrink
    {
        public Coke()
        {
        }

        public override string Name()
        {
            return "Coke";
        }

        public override decimal Price()
        {
            return 35;
        }
    }
}
