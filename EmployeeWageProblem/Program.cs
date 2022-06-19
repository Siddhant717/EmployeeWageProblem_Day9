using System;

namespace EmployeeWageProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpWage comapanies = new EmpWage();
            comapanies.ComputeEmployeeWage("Reliance", 30, 2, 100);
            comapanies.ComputeEmployeeWage("DMart", 35, 2, 120);
        }
    }
}
