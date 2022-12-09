// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace Assignment
{
    class Practice
    {
        List<Employee> list = new List<Employee>();
        void AddEmployees()
        {
            Console.Write("Enter Employee Id:");
            int Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Name:");
            string Name =Console.ReadLine();
            Console.Write("Enter Employee Salary:");
            int Salary =Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Gender:");
            string Gender =Console.ReadLine();
            Employee emp = new Employee();
            emp.AddEmployee(new Model.EmployeeModel
            {
                Id = Id,
                Name = Name,
                Salary = Salary,
                Gender = Gender
            });
            Console.WriteLine("Employee Added Successfully");
        }
        
        void DeleteEmployee()
        {

        }
        

        void Sample()
        {
            while (true)
            {
                Console.WriteLine("Select any one option");
                Console.WriteLine("1.Add an Employee");
                Console.WriteLine("2.Delete an Employee");
                Console.WriteLine("3.Display all Employees");
                Console.WriteLine("4.Exit");
                string input = Console.ReadLine();
                if (input == "4") break;
                switch (input)
                {
                     case "1":
                           Console.WriteLine("Add Employee");
                           AddEmployees();
                           break;
                    case "2":
                           Console.WriteLine("Delete Employee");
                           //DeleteEmployees();
                           break;
                    case "3":
                           Console.WriteLine("Print All Employees");
                          // PrintEmployees();
                          // PrintEmployees();
                           break;
                }
            }
        }
        static void Main(String[] args)
        {
           Practice p = new Practice();  
            p.Sample();
        }
    }
}