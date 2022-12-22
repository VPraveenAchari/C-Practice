using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHidingExample
{
    public class Father
    {
        public long Phoneno=7883703265;
        public string name="Harshavardhan", location="Bangalore";
        public void print()
        {
            Console.WriteLine("Name is:" + name);
            Console.WriteLine("aadharno is" + Phoneno);
            Console.WriteLine("location is" + location);
        }

    }
}
