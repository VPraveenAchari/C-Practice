using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersDemo
{
    public class Testing
    {
        public void paramsdemo(int a, int b, params int[] val)
        {
            int c = a + b;
            Console.WriteLine("addtion of a and b="+c);
            for(int i= 0; i < val.Length; i++)
            {
                Console.WriteLine(val[i]);
            }
        }
            
    }
}
