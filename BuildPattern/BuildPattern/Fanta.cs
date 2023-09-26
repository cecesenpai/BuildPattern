using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildPattern
{
    class Fanta : ColdDrink
    {
        public Fanta()
        {

        }

        public override string Name()
        {
            return "Fanta";
        }

        public override decimal Price()
        {
            return 35;
        }
    }
}
