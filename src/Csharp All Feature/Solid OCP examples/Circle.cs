using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_OCP_examples
{
    internal class Circle : Shape
    {
        double radius;
        public override double Area()
        {
            return radius * radius * radius * Math.PI;
        }
    }
}
