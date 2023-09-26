using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildPattern
{
    class Sprite : ColdDrink
    {
        public Sprite()
        {
        }

        public override string Name()
        {
            return "Sprite";
        }

        public override decimal Price()
        {
            return 35;
        }
    }
}
