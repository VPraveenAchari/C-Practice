using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SealedClassExample
{
    public  class Human
    {
        public int id;
       public string name, location;
        public void Information()
        {
            Console.WriteLine("Id:" + id);
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Location:" + location);
        }
    }
}
