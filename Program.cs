using ParametersDemo;

namespace DemoClass
{
    class DemoClass
    {
        public static void Main(string[] args)
        {
            int a = 100, s = 90;
            Testing ac = new Testing();
            ac.paramsdemo(12, 10, 30, 40, 50);
            OutParameters o = new OutParameters();
            o.Addtion(a, s, out ad);
            o.Subtraction(a,s,out sub);
        }
    }
}