using System;
using System.Collections;
using System.Net.Http.Headers;

namespace MyProject1
{
    public delegate void RectDelegate(int x, int y);
    class Sample
    {
        public void GetArea(int x, int y)
        {
            Console.WriteLine("Area of a Rectangle is:{0}",x * y);
        }
        public void GetPerimeter(int x, int y)
        {
            Console.WriteLine("Perimeter of Rectangle is:{0}",2 * (x + y));
        }
        public static void Main(string[] args)
        {
           Sample rect= new Sample();
            
            RectDelegate obj = rect.GetArea;
            obj += rect.GetPerimeter;
            obj.Invoke(12, 10);
            obj.Invoke(19,8);
        }
    }
}