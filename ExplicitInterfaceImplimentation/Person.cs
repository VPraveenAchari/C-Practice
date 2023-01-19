using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterface
{
    public class Person:I1,I2
    {
      void I1.Calculate()
        {
            Console.WriteLine("Enter Cgpa");
            double cgpa = Convert.ToDouble(Console.ReadLine());

            double percentage = cgpa * 9.5;
            Console.WriteLine("Percentage is:{0}", percentage);
        }
        void I2.Calculate()
        {
            Console.WriteLine("Enter Salary");
            int salary = Convert.ToInt32(Console.ReadLine());
            int TotalSalary = salary + salary * 5 / 100;
            Console.WriteLine("TotalSalary is:{0}", TotalSalary);
        }
    }
}
