using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Example.Liskov_Substution_Principle.Bad
{
    public class BadAreaCalculator
    {
        public static double CalculateArea(BadRetangle retangle)
        {
            return retangle.Height * retangle.Width;


        }

        public static double CalculateArea(BadSquare square)
        {
            return square.Width * square.Height;

        }

    }
}
