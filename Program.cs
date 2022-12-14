// See https://aka.ms/new-console-template for more information
using System;
namespace Inheritance1
{
    class MainRun
    {
        private static void Main(string[] args)
        {
            Rectangle tr = new Rectangle();
            Console.WriteLine("Enter m and n value");
            int m = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            tr.SetWidth(m);
            tr.SetHeight(n);
            Console.WriteLine("Rectangle Area is" + tr.GetArea());
            Console.WriteLine("Triangle Area is" + tr.GetTriangleArea());
            MainClass m1=new MainClass();
            m1.call();
            m1.SendSMS();
            Console.ReadKey();
        }
    }

}
