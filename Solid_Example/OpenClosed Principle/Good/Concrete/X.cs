using Solid_Example.OpenClosed_Principle.Good.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Example.OpenClosed_Principle.Good.Concrete
{
    public class X : GoodComputer
    {
        public override double GetTotalPrice(double amount)
        {
            return amount * 3000;
        }
    }
}
