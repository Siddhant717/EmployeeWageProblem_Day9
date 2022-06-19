using System;

namespace EmployeeWageProblem
{
    internal class EmpWage
    {
        public const int IsPartTime = 2;
        public const int IsFullTime = 1;
        public const int IsAbsent = 0;


        public void ComputeEmployeeWage(string CompanyName,int WagePerHr,int MaxNummberOFDays,int MaxHrs)
        {
            int Totalwage = 0;
            int Totalhrs = 0;
            int NumberOfWorkingDays = 20;
            int PartTimeHr = 4;
            int FullTimeHr = 8;
           

            for (int i = 0; Totalhrs <= MaxHrs && i< MaxNummberOFDays; i++)
            {
                Random random = new Random();
                int number = random.Next(0, 3);
                switch (number)
                {
                    case IsFullTime:
                        Console.WriteLine("Employee is Full Time");
                        Totalwage = Totalwage + WagePerHr * FullTimeHr;
                        Totalhrs += FullTimeHr;
                       
                        break;
                    case IsPartTime:
                        Console.WriteLine("Employee is working part time");
                        Totalwage = Totalwage + WagePerHr * PartTimeHr;
                        Totalwage += WagePerHr * PartTimeHr;
                        Totalhrs += PartTimeHr;

                        break;
                    case IsAbsent:
                        Console.WriteLine("Employee is Absent");
                        break;


                }
                Console.WriteLine("Employee's Total Wage is" + Totalwage);
                Console.WriteLine("Total hours the employee worked in the month for " + CompanyName + " is " + Totalhrs);
            }
        }
    }
}
