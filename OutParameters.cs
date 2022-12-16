using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersDemo
{
    class OutParameters
    {
        public void Addtion(int a,int s,out int ad)
        {
            ad = a + s;
            Console.WriteLine("Addtion is"+ad);
        }
        public void Subtraction(int a, int s,out int sub)
        {
            sub = a - s;
            Console.WriteLine("Subtraction is"+sub);
        }
    }
}
