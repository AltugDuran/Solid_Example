using Solid_Example.Interface_Segregation_Principle.Bad.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Example.Interface_Segregation_Principle.Bad.Concrete
{
    public class BMW : ICar
    {
        public string Electric()
        {
            return "Her Bmw elektrikli değildir.";
        }

        public string Gasoline()
        {
            return "Her bmw benzin ile çalışır.";
        }
    }
}
