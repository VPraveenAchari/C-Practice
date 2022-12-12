using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstOne
{
   public class NamedParameters
    {
        public int addtion(int firstnumber,int secondnumber)
        {
            return firstnumber + secondnumber;
        }
        public string FullName(string firstname,string lastname)
        {
            return firstname + lastname;
        }
    }
}
