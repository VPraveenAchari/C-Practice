using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClassExample
{
    /*public class Student:Employee*/
    public class Student:Human
    {
        public int marks;
        public void display()
        {
            Console.WriteLine("marks="+marks);
        }
    }
}
