using System;
using System.Collections.Generic;

namespace Homework_12_ClassLibrary
{
    public class Employee
    {
        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                if (IsNameTrue(value))
                    _name = value;
            }
        }
        private string _surname;
        public string FullName
        {
            get => _surname;
            set
            {
                if (IsNameTrue(value))
                    _surname = value;
            }
        }
        private int _salary;
        public int Salary
        {
            get => _salary;
            set
            {
                if (Salary >= 250)
                {
                    _salary = value;
                }
            }
        }
        public Employee(string name, string surname, int salary)
        {
            _name = name;
            _surname = surname;
            _salary = salary;
        }

        public bool IsNameTrue(string name)
        {
            bool isName = true;
            bool IsDigit = false;
            bool IsUpper = false;
            bool IsLower = false;
            if (char.IsUpper(name[0]))
            {
                IsUpper = true;
                for (int i = 1; i < name.Length; i++)
                {
                    if (char.IsDigit(name[i]))
                    {
                        IsDigit = true;
                    }
                    if (char.IsLower(name[i]))
                    {
                        IsLower = true;
                    }
                    else
                    {
                        IsLower = false;
                        break;
                    }
                }
                if (IsDigit == false && IsUpper == true && IsLower == true)
                    return isName;
                else
                    return false;
            }
            else return false;
        }
    }

    public class Department
    {
        public string Name;
        public int EmployeeLimit;
        public int SalaryLimit;
        List<Employee> Employees;

        public void AddEmployee(string name, string surname, int salary)
        {
            if(SalaryLimitMethod()+salary<=SalaryLimit && EmployeeLimitMethod() < EmployeeLimit)
            {
                Employee emp = new Employee(name, surname, salary);
                Employees.Add(emp);
            }
        }

        public int SalaryLimitMethod()
        {
            int salarySum = 0;
            foreach(var emp in Employees)
            {
                salarySum += emp.Salary;
            }
            return salarySum;
        }

        public int EmployeeLimitMethod()
        {
            int employeeSum = 0;
            foreach (var emp in Employees)
            {
                employeeSum += 1;
            }
            return employeeSum;
        }
    }
}