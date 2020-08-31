using Solid_Example.DIP.Good.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Example.DIP.Good.Concrete
{
    public class Stationery 
    {
        List<IProduct> products;
        
        public Stationery()
        {
            products = new List<IProduct>();
        }
        
        public string GenerateInstruction()
        {
            string instruction = string.Empty;
            foreach (var item in products)
            {
                instruction += " " + item.GetSellingIntroduction();
            }
            return instruction;
        }




    }
}
