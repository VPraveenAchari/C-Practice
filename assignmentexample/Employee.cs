using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.Model;

namespace Assignment
{
    public class Employee
    {
        List<EmployeeModel> emp=new List<EmployeeModel>();
        public void AddEmployee(EmployeeModel employee)
        {
            emp.Add(employee);
        }
        public void DeleteEmployee(EmployeeModel employee)
        {
            emp.Remove(employee);

        }
    }
}
