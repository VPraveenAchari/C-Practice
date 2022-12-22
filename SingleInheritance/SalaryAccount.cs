using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class SalaryAccount:Account
    {
        public SalaryAccount(int initialbalance,string name,string emailid)
        {
            _accid = 9836765;
            _accBalance= initialbalance;
            _name = name;
            _email= emailid;
        }
        public void Wthdraw()
        {
            int amount;
            Console.WriteLine("Withdraw in SalaryAccount Class");
            _password = "12345";
            Console.WriteLine("Enter the password");
            string? pwd = Console.ReadLine();
            if (pwd=="12345")
            {
             Console.WriteLine("Enter the amount to withdraw");
            amount = Convert.ToInt32(Console.ReadLine());
            if(_accBalance<amount)
                {
                    Console.WriteLine("InvalidFunds");
                }
                else
                {
                    _accBalance = _accBalance - amount;
                    Console.WriteLine("Available Balance is:{0}", _accBalance);
                }
            }
            else
            {
                Console.WriteLine("Invalid Password");
            }
        }
        public void Transfer()
        {
            int amount;
            Console.WriteLine("Tranfer Method in SalaryAccount");
            _password = "12345";
            Console.WriteLine("Enter the password");
            string? pwd = Console.ReadLine();
            if (pwd == "12345")
            {
                Console.WriteLine("Enter the amount to transfer");
                amount = Convert.ToInt32(Console.ReadLine());
                if (_accBalance < amount)
                {
                    Console.WriteLine("InvalidFunds");
                }
                else
                {
                    _accBalance = _accBalance - amount;
                    Console.WriteLine("Amount is transfered");
                    Console.WriteLine("Available Balance is:{0}", _accBalance);
                }
            }
            else
            {
                Console.WriteLine("Invalid Password");
            }
        }
    }
}
