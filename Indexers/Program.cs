using System;
namespace IndexersExample
{
    class Indexers
    {
        public static void Main(string[] args)
        {
            Employee idx = new Employee(1001, "SaiKiran", "Manager", "Hyderabad",45000);
            idx[3] = "Clerk";
            Console.WriteLine("Employee NO:" + idx[1]);
            Console.WriteLine("Employee Name:" + idx[2]);
            Console.WriteLine("Employee Job:" + idx[3]);
            Console.WriteLine("Employee Location:" + idx[4]);
            Console.WriteLine("Employee Salary:" + idx[5]);
        }
    }
}