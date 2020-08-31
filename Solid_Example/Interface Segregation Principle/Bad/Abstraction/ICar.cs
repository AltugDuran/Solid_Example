using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Example.Interface_Segregation_Principle.Bad.Abstraction
{
    public interface ICar
    {
        string Electric();
        string Gasoline();
    }
}
