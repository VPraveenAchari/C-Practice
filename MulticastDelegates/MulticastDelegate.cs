using System;
using System.Security.Cryptography.X509Certificates;

namespace MyProject1
{
   // public delegate void RectDelegate(int x,int y);
    public class MulticastDelegate
    {
        public void GetArea(int x, int y)
        {
            Console.WriteLine("Area of a Rectangle is:{0}", x * y);
        }
        public void GetPerimeter(int x, int y)
        {
            Console.WriteLine("Perimeter of Rectangle is:{0}", 2 * (x + y));
        }
    }
}
