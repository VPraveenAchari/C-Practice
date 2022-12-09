using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewConsoleApp
{
    public class Vegitable
    {
        public int vegitablecount;
        public string vegitablename;
        public string cityname;
        public void category()
        {
            Console.WriteLine("Understanding the concept of Class and Object");
            Console.WriteLine("New vegitable category:{0}",vegitablename);
        }
        public void Citydetails()
        {
            Console.WriteLine("Vegitables by city category");
            Console.WriteLine("CityName is {0} and Vegitablename is {1}", cityname, vegitablename);
        }
    }
}
