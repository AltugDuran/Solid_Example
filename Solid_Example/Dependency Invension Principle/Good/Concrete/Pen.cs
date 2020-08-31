using Solid_Example.DIP.Good.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Example.DIP.Good.Concrete
{
    public class Pen : IProduct
    {
        public string GetSellingIntroduction()
        {
            return " 2 alana kalem hediye";
        }
    }
}
