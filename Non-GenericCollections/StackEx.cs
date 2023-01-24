using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsExample
{
    public class StackEx
    {
        public void Display()
        {
            Stack mystack = new Stack();
            mystack.Push(1);
            mystack.Push(290.5);
            mystack.Push(false);
            mystack.Push('P');
            mystack.Push(34.8f);
            mystack.Pop();
            mystack.Push(88);
            Console.WriteLine("Last element is:" + mystack.Peek());
            foreach (var item in mystack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
