using EmployeeProject.Models;
using System;

namespace EmployeeProject
{
    class Program
    {
        static void Main(string[] args)
        {


            Employee fehle = new Employee
            {
                Fullname = "Aslan Akbey",
                salary = 2020,
                position = "HR Manager",

            };

            Company company = new Company
            {
                Name = "Casanostra",
                limit = 20,
            };
            company.AddEmployee(fehle);

        }
    }
}
