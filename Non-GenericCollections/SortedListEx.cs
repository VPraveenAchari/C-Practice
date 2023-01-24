using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsExample
{
    public class SortedListEx
    {
        public void Display()
        {
            SortedList sl = new SortedList();
            sl.Add("001", "Maharastra");
            sl.Add("002", "MadhyaPradesh");
            sl.Add("005", "Rajasthan");
            sl.Add("004", "AndhraPradesh");
            sl.Add("003", "UttarPradesh");
            ICollection key=sl.Keys;
            foreach (var item in key)
            {
                Console.WriteLine(item + ":" + sl[item]);
            }
        }
    }
}
