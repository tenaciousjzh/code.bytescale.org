using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Org.Bytescale.Patterns.Decorator
{
    public abstract class CondimentDecorator : Beverage
    {
        public override abstract string Description { get; }
    }
}
