using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Org.Bytescale.Patterns.Decorator
{
    public class Whip : CondimentDecorator
    {
        private Beverage _beverage;
        public Whip(Beverage beverage) {
            _beverage = beverage;
        }

        public override string Description
        {
            get { return _beverage.Description + ", Whip"; }
        }

        public override double Cost
        {
            get { return _beverage.Cost + .35; }
        }
    }
}
