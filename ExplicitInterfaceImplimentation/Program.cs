using ExplicitInterface;

/*I1 i1 = new Person();
I2 i2 = new Person();

i1.Calculate();
i2.Calculate();*/
Person p = new Person();
((I1)p).Calculate();
((I2)p).Calculate();