using Solid_Example.Interface_Segregation_Principle.Good.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Example.Interface_Segregation_Principle.Good.Good
{
    public class Tesla : IElectric
    {
        public string Electric()
        {
            throw new NotImplementedException();
        }
    }
}
