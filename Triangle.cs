using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    class Rectangle : Shape
    {
        public int GetArea()
        {
            return(width * height);

        }
        public double GetTriangleArea()
        {
            return(0.5*width*height);
        }
    }
}
