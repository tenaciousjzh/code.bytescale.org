using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Org.Bytescale.Patterns.Decorator
{
    public class Espresso : Beverage
    {
        public Espresso() {
            _description = "Espresso";
        }

        public override double Cost
        {
            get {
                return 1.99;
            }
        }
    }
}
