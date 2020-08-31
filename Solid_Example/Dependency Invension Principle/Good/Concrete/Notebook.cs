using Solid_Example.DIP.Good.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Example.DIP.Good.Concrete
{
    public class Notebook : IProduct
    {
        public string GetSellingIntroduction()
        {
            return "3 alana 1 bedava";
        }

        
    }
}
