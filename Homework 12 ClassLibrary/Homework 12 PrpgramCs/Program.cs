using System;
using Homework_12_ClassLibrary;

namespace Homework_12_PrpgramCs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department();
            string opt;
            do
            {
                Console.WriteLine("1.Isci elave et");
                Console.WriteLine("2.SalaryLimit teyin et");
                Console.WriteLine("3.EmployeeLimit teyin et");
                Console.WriteLine("0. Prosesi bitir");
                opt=Console.ReadLine();
                switch (opt)
                {
                    case "1":
                        Console.Write("Iscinin adini daxil edin: ");
                        string name=Console.ReadLine();
                        Console.Write("Iscinin soyadini daxil edin: ");
                        string surname = Console.ReadLine();
                        Console.Write("Iscinin maasini daxil edin: ");
                        string salaryStr = Console.ReadLine();
                        int salary=Convert.ToInt32(salaryStr);
                        department.AddEmployee(name,surname,salary);
                        break;
                    case "2":
                        Console.Write("SalaryLimit daxil edin: ");
                        string salaryLimitStr = Console.ReadLine();
                        int salaryLimit = Convert.ToInt32(salaryLimitStr);
                        break;
                    case "3":
                        Console.Write("EmployeeLimit daxil edin: ");
                        string employeeLimitStr = Console.ReadLine();
                        int employeeLimit = Convert.ToInt32(employeeLimitStr);
                        break;
                    case "0":
                        Console.WriteLine("Proses bitdi");
                        return;
                    default:
                        Console.WriteLine("Seciminiz yanlisdir");
                        break;
                }
            } while (opt!="0");
        }
    }
}
