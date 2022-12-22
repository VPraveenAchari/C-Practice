using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingExample
{
    public class Triangle:Rectangle
    {
        const float c = 0.5f;
     public  override void Area(int a,int b)
        {
            float ar = a * b * c;
            Console.WriteLine("Area of the Triangle is:" + ar);
        }
    }
}
