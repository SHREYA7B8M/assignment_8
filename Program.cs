using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_8
{
    class salaryCalc
    {
        public void CalculateSalary(int wHour, int nWDays, int projectHandles = 0, int extras = 0)
        {
            int salary = wHour * nWDays * 100 + projectHandles * 3000 + extras * 2000;
            Console.WriteLine($"Monthly Salary: ${salary}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            int deptType;
            int workHours;
            int workDays;
            int projectHandles;
            int extras;
            Console.WriteLine("Department Dependent Salary Calculation System");
            Console.WriteLine("Choose Employee Type:");
            Console.WriteLine("1. HR");
            Console.WriteLine("2. Admin");
            Console.WriteLine("3. Software Developer");
            deptType = int.Parse(Console.ReadLine());

            salaryCalc salC = new salaryCalc();

            Console.Write("Enter working Hour: ");
            workHours = int.Parse(Console.ReadLine());
            Console.Write("Enter Number Of working Days: ");
            workDays = int.Parse(Console.ReadLine());
            projectHandles = 0;
            extras = 0;

            switch (deptType)
            {
                case 2:
                    Console.Write("Enter Project Handles: ");
                    projectHandles = int.Parse(Console.ReadLine());
                    break;

                case 3:
                    Console.Write("Enter Project Handles: ");
                    projectHandles = int.Parse(Console.ReadLine());
                    Console.Write("Enter Extras: ");
                    extras = int.Parse(Console.ReadLine());
                    break;

                default:
                    break;
            }

            salC.CalculateSalary(workHours, workDays, projectHandles, extras);
        }
    }
}
