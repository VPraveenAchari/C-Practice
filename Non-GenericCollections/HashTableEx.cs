using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsExample
{
    public class HashTableEx
    {
        public int id = 1209;
        public string name = "Praveen",address="Kurnool";
        public long phone = 7809363659;
        public double salary = 45000;
        public void Display()
        {
            Hashtable ht = new Hashtable();
            ht.Add("id", id);
            ht.Add("name",name);
            ht.Add("phone",phone);
            ht.Add("salary",salary);
            ht.Add("address", address);
            ICollection key = ht.Keys;
            foreach (var k in key)
            {
                Console.WriteLine(k + ": " + ht[k]);
            }          
        }
    }
}
