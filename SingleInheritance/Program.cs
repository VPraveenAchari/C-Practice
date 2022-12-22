using InheritanceExample;

SalaryAccount sl = new SalaryAccount(5000, "Praveen", "praveen@gmail.com");
while(true)
{
    Console.WriteLine("Please Choose the Option");
    Console.WriteLine("1.Deposit\t2.Withdraw\t3.DisplayDetails\t4.Transfer\t5.Exit");
    int i = Convert.ToInt32(Console.ReadLine());
    if (i == 5)
        break;
    switch (i)
    {
        case 1:
            sl.Deposit();
            break;
        case 2:
            sl.Wthdraw();
            break;
        case 3:
            sl.DisplayDetails();
            break;
        case 4:
            sl.Transfer();
            break;
        default:
            Console.WriteLine("Choose correct option");
            break;
    }

}