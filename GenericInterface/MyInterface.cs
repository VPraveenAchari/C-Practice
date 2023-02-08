using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassExample1
{
    public interface MyInterface<T>
    {
        void Area(T a);
        void Perimeter(T a);
    }

}
