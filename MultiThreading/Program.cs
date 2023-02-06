using System;
using System.Threading;
namespace ThreadLockingExample
{
    class ThreadLocking
    {
        public void Display()
        {
            lock (this)
            {
                Console.Write("[C# is");
                Thread.Sleep(5000);
                Console.WriteLine(" Object Oriented Programming]");
            }
        }
        public static void Main(string[]args)
        {
            ThreadLocking t = new ThreadLocking();
            Thread t1 = new Thread(t.Display);
            Thread t2 = new Thread(t.Display);
            Thread t3 = new Thread(t.Display);
            t1.Start();
            t2.Start();
            t3.Start();
        }
    }
}