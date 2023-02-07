using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerProperties
{
    public class Customer
    {
        int _Custid;
        string _Cname;
        bool _Status;
        double _Balance;
        Cities _City;
        public Customer(int custid, string cname, bool status, double balance,Cities City)
        {
            _Custid = custid;
            _Cname = cname;
            _Status = status;
            _Balance = balance;
            _City= City;
        }
        public int Custid
        {
            get { return _Custid; }
        }
        public bool Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
        public string Cname
        {
            get { return _Cname; }
            set { _Cname = value; }
        }
        public double Balance
        {
            get { return _Balance; }
            set {
                if (value>=500)
                {
                    _Balance = value;
                }
                 }
        }
       public Cities City
        {
            get { return _City; }
            set { 
                if(_Status==true)
                {
                    _City = value;
                }
            }
        }
    }
}
