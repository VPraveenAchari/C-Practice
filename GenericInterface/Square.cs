using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassExample1
{
    public class Square : MyInterface<int>
    {
        public void Area(int a)
        {
            Console.WriteLine("Area is:"+(a*a));
        }

        public void Perimeter(int a)
        {
            Console.WriteLine("Perimeter is"+(4*a));
        }
    }
}
