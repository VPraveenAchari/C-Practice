using System;
using System.Security.Cryptography.X509Certificates;

namespace PredifinedDelegates
{
    class Program
    {
        public double AddNums(int a,double b,float d)
        {
            return a+ b + d;  
        }
        public void AddNums1(int a,double b,float d)
        {
            Console.WriteLine(a + b + d);
        }
        public bool Getting(string name)
        {
            if(name.Length>5)
                return false;
            return true;
        }
        static void Main(string[] args)
        {
            Program p=new Program();
            Func<int,double,float,double> ad1 = p.AddNums;
            double result=ad1(12, 10.5, 10.2f);
            Console.WriteLine(result);
            Action<int,double,float> ad2 = p.AddNums1;
            ad2(12, 10.5, 10.2f); 
            Predicate<string> ad3 = p.Getting;
            bool val=ad3("Praveen");
            Console.WriteLine(val);
        }
    }
}