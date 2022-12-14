using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    internal class MainClass:MyClass
    {
        public override void call()
        {
            Console.WriteLine("Make a Call");
        }
        public override void SendSMS()
        {
            Console.WriteLine("Sending SMS");   
        }
    }
}
