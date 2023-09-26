using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildPattern
{
   public class SlicePizza:Pizza
    {
        public SlicePizza()
        {
        }

        public override string Name()
        {
            return "Slice of Pizza";
        }

        public override decimal Price()
        {
            return 60;
        }
    }
}
