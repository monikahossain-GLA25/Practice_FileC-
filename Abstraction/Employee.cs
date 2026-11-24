using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Abstraction
{
    public abstract class Employee
    {
        public string Name { get; set; }

     protected Employee(string name)
        {
            Name = name;
        }
        public abstract decimal EmployeeSalary();

        public void ShowCompany()
        {
            Console.WriteLine("The company name is Square Informatix");
        }

    }
    public class PermanentEmployee : Employee
    {
        public PermanentEmployee(string name) : base(name)
        {
        }
        public override decimal EmployeeSalary()
        {
            return 500000m;
        }
    }
    public class ContractualEmployee : Employee
    {
        public ContractualEmployee(string name) : base(name)
        {
        }
        public override decimal EmployeeSalary()
        {
            return 300000m;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            PermanentEmployee permanentEmployee = new PermanentEmployee("John Doe");
            Console.WriteLine($"Permanent Employee: {permanentEmployee.Name}, Salary: {permanentEmployee.EmployeeSalary()}");
            permanentEmployee.ShowCompany();
            ContractualEmployee contractualEmployee = new ContractualEmployee("Jane Smith");
            Console.WriteLine($"Contractual Employee: {contractualEmployee.Name}, Salary: {contractualEmployee.EmployeeSalary()}");
            contractualEmployee.ShowCompany();
        }               
    }
    

}
