using System;
namespace ExceptionHandlingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b;
                Console.WriteLine("Enter the First number");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Second Number");
                b = Convert.ToInt32(Console.ReadLine());
                int c = a / b;
                Console.WriteLine("Result is" + a / b);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}