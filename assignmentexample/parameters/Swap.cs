using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstOne
{
    public class Swap
    {
       public void swapping(int a,int b)
        {
            int temp = a;
            a = b;  
            b = temp;
            Console.WriteLine("a=" + a + "\t" + "b=" + b);
        }
    }
}
