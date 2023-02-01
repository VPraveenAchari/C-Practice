using System;
namespace GenericsExample
{
    class Generics
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        public bool Compare<T>(T a,T b)
        {
            if(a.Equals(b)) return true;
            else return false;
        }
        public static void Main(string[] args)
        {
            Generics g=new Generics();
            g.Add(36,64);
            bool result=g.Compare<float>(10.67f, 10.67f);
            Console.WriteLine(result);
            Generics2<int> g2= new Generics2<int>();
            g2.add(10, 20);
            g2.sub(10, 20);
            g2.mul(10, 20);
            g2.div(10, 20);
            Customer c1 = new Customer() { id = 1001, name = "Ravi", city = "Mumbai", balance = 45000 }; ;
            Customer c2 = new Customer() { id = 1002, name = "Hari", city = "Chennai", balance = 38000 }; ;
            Customer c3 = new Customer() { id = 1003, name = "Venkat", city = "Bangalore", balance = 57000 }; ;
            Customer c4 = new Customer() { id = 1004, name = "Ramachandra", city = "Rajasthan", balance = 35000 }; ;
            Customer c5 = new Customer() { id = 1005, name = "Harsha", city = "Jaipur", balance = 66000 }; ;
            List<Customer> clist = new List<Customer>() { c1, c2, c3, c4, c5 };
            foreach(Customer c in clist)
            {
                Console.WriteLine(c.id+" "+c.name + " " +c.city + " " +c.balance);
            }
        }
    }
}