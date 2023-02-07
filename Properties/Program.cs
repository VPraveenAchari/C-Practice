using System;
using CustomerProperties;

namespace CustomerProperties
{
    class TestCustomer
    {
       public static void Main(string[] args)
        {
            Customer c = new Customer(101,"Praveen",false,5000.00,Cities.Delhi);
            Console.WriteLine("Customer id:"+c.Custid);
            c.Status = true;
            if(c.Status==true)
            {
                Console.WriteLine("Status is in Active");
            }
            else
            {
                Console.WriteLine("Status is in InActive");
            }
            c.Balance = c.Balance - 4600;
            Console.WriteLine("Customer Name is:"+c.Cname);
            Console.WriteLine("Available Balance"+c.Balance);
            Console.WriteLine("Current City"+c.City);
            c.City=Cities.Hyderabad;
            Console.WriteLine("Modified City" + c.City);
        }
    }
}