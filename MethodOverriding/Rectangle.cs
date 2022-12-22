using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingExample
{
    public class Rectangle
    {
        public int a,b;
        public virtual void Area(int a,int b)
        {
            int ar = a * b;
            Console.WriteLine("Area of the rectangle is:"+ar);
        }
    }
}
