using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeProject.Models
{
    class Employee
    {

        public static int id = 1;
        public int no;
        public string Fullname;
        public int salary;
        public string position;

        public Employee()
        {
            no = id;
            id++;
        }

    }
}
