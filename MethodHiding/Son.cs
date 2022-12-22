using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MethodHidingExample
{
    public class Son : Father
    {
        public new void print()
        {
            Console.WriteLine("Name is:" + name);
            Console.WriteLine("aadharno is" + Phoneno);
            Console.WriteLine("location is" + location);
        }
    }
}
