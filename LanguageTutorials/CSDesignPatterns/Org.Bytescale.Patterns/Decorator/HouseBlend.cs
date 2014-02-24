using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Org.Bytescale.Patterns.Decorator
{
    public class HouseBlend : Beverage
    {
        public HouseBlend() {
            _description = "House Blend Coffee";
        }

        public override double Cost
        {
            get { return .89; }
        }
    }
}
