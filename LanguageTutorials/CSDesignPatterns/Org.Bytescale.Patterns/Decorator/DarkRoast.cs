using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Org.Bytescale.Patterns.Decorator
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            _description = "Dark Roast";
        }

        public override double Cost
        {
            get { return .99; }
        }
    }
}
