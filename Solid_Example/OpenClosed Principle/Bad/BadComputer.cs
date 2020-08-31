using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Example.OpenClosed_Principle.Bad
{
    public enum ComputerType
    {
        X,
        XY,
        XYZ
    }
    
    
    public class BadComputer
    {
        public double GetTotalPrice(double amount, ComputerType computertype)
        {
            double totalprice = 0;
            if (computertype == ComputerType.X)
            {
                totalprice += amount * 3000;
            }
            if (computertype == ComputerType.XY)
            {
                totalprice += amount * 4500;
            }
            if (computertype == ComputerType.XYZ)
            {
                totalprice += amount * 6000;
            }
            return totalprice;
        }
    }
}
