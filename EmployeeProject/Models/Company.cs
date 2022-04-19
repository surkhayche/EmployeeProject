using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeProject.Models
{
    class Company
    {

        private string _name;

        public string Name
        {
            get => _name;
            set
            {
                bool check = true;
                while (check)
                {
                    bool checksymbol = false;

                    if (char.IsUpper(value[0]))
                    {
                        foreach (char item in value)
                        {

                            if (char.IsSymbol(item))
                            {
                                checksymbol = true;
                            }
                            else
                            {
                                Console.WriteLine("Sirket adi simvollardan ibaret ola bilmez");
                            }
                            check = false;
                            _name = value;

                        }
                    }
                    else
                    {
                        Console.WriteLine("Sirket adinin ilk herfi boyuk olmalidir");
                        break;
                    }

                }


            }
        }
        public int limit;
        public Employee[] Employees;
        public Company()
        {
            Employees = new Employee[0];
        }
        public void AddEmployee(Employee employee)
        {
            if (Employees.Length > limit)
            {
                Array.Resize(ref Employees, Employees.Length + 1);
                Employees[Employees.Length - 1] = employee;
                return;
            }
            else
            {
                Console.WriteLine("Hal-hazirda bos vakansiya yoxdu. En qisa zamanda sizle elaqe saxlanilacaq");
            }

        }
        public Employee[] GetEmployees() => Employees;


    }
}

    