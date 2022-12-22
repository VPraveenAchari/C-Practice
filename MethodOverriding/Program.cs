using MethodOverridingExample;
Triangle t=new Triangle();
t.a=Convert.ToInt32(Console.ReadLine());
t.b=Convert.ToInt32(Console.ReadLine());
Rectangle r = new Rectangle();
//r.Area(r.a, r.b);
t.Area(t.a,t.b);