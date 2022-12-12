using System;
using FirstOne;

class MainRunner
{

    static void Main(string[] args)
    {
      NamedParameters nm=new NamedParameters();
        OptionalParameters optional=new OptionalParameters();
        Swap s=new Swap();
       int i= nm.addtion(12, 10);
        int j = nm.addtion(firstnumber: 120, secondnumber: 80);
        Console.WriteLine(i+"\t"+j);
        string a = nm.FullName("Praveen", "Achari");
        string b = nm.FullName(lastname: "Chittari", firstname: "Dinesh");
        Console.WriteLine(a+"\t"+b);
        int result = optional.multiplication(12, 33);
        Console.WriteLine("Result={0}",result);
        s.swapping(10, 20);
        
    }



}




