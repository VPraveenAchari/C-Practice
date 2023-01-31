using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexersExample
{
    public class Employee
    {
        int empid,salary;
        string ename, job, location;
        public Employee(int empid, string ename, string job, string location, int salary)
        {
            this.empid = empid;
            this.ename= ename;
            this.job = job;
            this.location = location;
            this.salary = salary;
        }
        public object this[int index]
        {
            get { if (index == 1)
                    return empid;
                else if (index == 2)
                    return ename;
                else if (index == 3)
                    return job;
                else if (index == 4)
                    return location;
                else if (index == 5) 
                    return salary;
                   return null;
            }
            set
            {
                if (index == 1)
                    empid = (int)value;
                else if(index==2)
                    ename =(string) value;
                else if(index==3)
                    job=(string) value;
                else if(index==4)
                    location=(string) value;
                else if(index==5)
                    salary=(int) value;
            }
        }
    }
}
