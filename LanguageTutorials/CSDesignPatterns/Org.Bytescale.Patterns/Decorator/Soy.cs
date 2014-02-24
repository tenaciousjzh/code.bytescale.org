using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Org.Bytescale.Patterns.Decorator
{
    public class Soy : CondimentDecorator
    {
        private Beverage _beverage;

        public Soy(Beverage beverage) {
            _beverage = beverage;
        }

        public override string Description
        {
            get { return _beverage.Description + ", Soy"; }
        }

        public override double Cost
        {
            get { return _beverage.Cost + .15; }
        }
    }
}
