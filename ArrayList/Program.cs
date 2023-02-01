using System;
using System.Collections;

class Program
{
    public static void Main(string[] args)
    {
        Program p=new Program();
        ArrayList al = new ArrayList();
        al.Add(10);
        al.Add(20);
        al.Add(30);
        al.Add(40);/*[10,20,30,40]*/
        ArrayList al1 = new ArrayList() { 6, 12, 18, 24, 30 };
        int[] ar = { 12, 24, 36, 48 };
        Console.WriteLine(al.Capacity);
        al.AddRange(al1);/*[10,20,30,40,6,12,18,24,30]*/
        Console.WriteLine("AddrangeMethod"); 
        al.Insert(2, 35);
        p.Print(al);/*[10,20,35,30,40,6,12,18,24,30]*/
        al.InsertRange(4, ar);
       p.Print(al);/*[10,20,35,30,12,24,36,48,40,6,12,18,24,30]*/
        Console.WriteLine("Index of 48:" + al.IndexOf(48));
        Console.WriteLine("Last Index of 24 is" + al.LastIndexOf(24));
        al.Remove(12);
        al.RemoveAt(7);
        //p.Print(al);
        /*[10,20,35,30,24,36,48,6,12,18,24,30]*/
        al.RemoveRange(3, 5);
        p.Print(al); /*[10,20,35,12,18,24,30]*/
    }
    public void Print(ArrayList al)
    {
        foreach (int i in al)
            Console.Write(i + "\t");
    }
}