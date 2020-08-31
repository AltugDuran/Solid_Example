using Solid_Example.Interface_Segregation_Principle.Bad.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Example.Interface_Segregation_Principle.Bad.Concrete
{
    public class Tesla : ICar
    {
        public string Electric()
        {
            return "Her Tesla elektriklidir.";
        }

        public string Gasoline()
        {
            return "Her Tesla benzin ile çalışabilir";
        }
    }
}
