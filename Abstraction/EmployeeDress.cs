using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    public abstract class EmployeeDress
    {
        public abstract void DressCode();


        //non abstract method 
        public void DressColor()
        {
            Console.WriteLine("The dress color is black");
        }
    }
    public class PermanentEmployee : EmployeeDress
    {
        public override void DressCode()
        {
            Console.WriteLine("The permanent employee dress code is Formal Dress");
        }
    }
    public class ContractualEmployee : EmployeeDress
    {
        public override void DressCode()
        {
            Console.WriteLine("The contractual employee dress code is Casual Dress");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            PermanentEmployee permanentEmployee = new PermanentEmployee();
            permanentEmployee.DressCode();
            permanentEmployee.DressColor();
            ContractualEmployee contractualEmployee = new ContractualEmployee();
            contractualEmployee.DressCode();
            contractualEmployee.DressColor();
        }
    }
}
