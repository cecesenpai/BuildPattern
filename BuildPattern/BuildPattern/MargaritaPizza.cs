using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildPattern
{
    class MargaritaPizza:Pizza
    {
        public MargaritaPizza()
        {
        }

        public override string Name()
        {
            return "Margarita Pizza";
        }

        public override decimal Price()
        {
            return 150;
        }
    }
}
