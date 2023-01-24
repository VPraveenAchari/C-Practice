using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsExample
{
    public class ArrayListEx
    {
        public void Display()
        {
            var list1 = new ArrayList();
            list1.Add(12);
            list1.Add(true);
            list1.Add(232.5f);
            list1.Add(9047506454);
            list1.Add(52.5);
            list1.Add("Praveen");
            var list2 = new ArrayList() { 50, 33.9, "list2" };
            list1.InsertRange(4, list2);
            
            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }           
        }
    }
}
