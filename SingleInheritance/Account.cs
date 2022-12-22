using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class Account
    {
        protected int _accid, _accBalance;
        protected string _name, _email;
        protected string _password;
        public int Id
        {
            get { return _accid; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public void Deposit()
        {
            int amount;
            Console.WriteLine("Enter the amount to deposit");
            amount = Convert.ToInt32(Console.ReadLine());
            _accBalance = _accBalance + amount;
            Console.WriteLine("Available Balance is:{0}", _accBalance);
        }
        public void DisplayDetails()
        {
            Console.WriteLine("AccountId is {0} and Account Name is {1}",_accid, _name);
            Console.WriteLine("Account Holder emailid is {0}", _email);
            Console.WriteLine("Account Balance is {0}",_accBalance);
        }
    }
}
