﻿using Solid_Example.Liskov_Substution_Principle.Good.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Example.Liskov_Substution_Principle.Good.Concrete
{
   public class Retangle : Shape
    {
        public int Height { get; set; }
        public int Width  { get; set; }


        public double RetangleArea()
        {
            return Width * Height;
        }
    }
}
