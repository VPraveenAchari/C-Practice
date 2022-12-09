using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewConsoleApp
{
    public class Shape
    {
       public int a, b,area=0;
        public int SquareArea()
        {
            area = a * a;
            return area;
        }
        public int RectangleArea()
        {
            area = a * b;
            return area;
        }
    }
}
