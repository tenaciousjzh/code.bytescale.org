using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Org.Bytescale.Patterns.Decorator
{
    public abstract class Beverage
    {
        protected string _description = "Unknown Beverage";

        public abstract double Cost { get; }
        public virtual string Description 
        { 
            get 
            {
                return _description;
            }
        }
    }
}
