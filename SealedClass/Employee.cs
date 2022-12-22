using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClassExample
{
    public sealed class Employee:Human
    {
        
        public int salary;
        public void print()
        {
            Console.WriteLine("salray is:"+salary);
        }
    }
}
