using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    public abstract class MyClass
    {
        string brand = "VIVO";
        int price = 50000;
        public abstract void call();
        public abstract void SendSMS();
    }
}
