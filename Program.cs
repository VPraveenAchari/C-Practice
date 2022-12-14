using System.Security.Principal;

namespace Parameters
{
    class Parameters
    {

        
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter side of a square");
            int side= Convert.ToInt32(Console.ReadLine());
            double perimeter = CalculateCircle(side, out int area);
            Console.WriteLine("Sqaure perimiter is :{0}", perimeter);
            Console.WriteLine("Square Area is :{0}", area);
            Console.ReadKey();
        }

        static int CalculateCircle(int side, out int area)
        {
            area = side * side;
             int perimeter =4*side;
            return perimeter;
        }
    }
}