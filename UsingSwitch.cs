using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRoll
{
    internal class UsingSwitch
    {
        public static void CalculateWageUsingSwitch()
        {
            int EmpWage = 0;
            int Wage_per_hour = 20;
            int Work_Hours = 0;
            Random check = new Random();
            int range = check.Next(0, 3);

            switch (range)
            {
                case 0:
                    Console.WriteLine("Employee is Absent");

                    Console.WriteLine("Wage is = " + EmpWage);

                    break;
                case 1:
                    Work_Hours = 4;
                    EmpWage = Wage_per_hour * Work_Hours;
                    Console.WriteLine("Part Time Wage is " + EmpWage);
                    break;
                case 2:
                    Console.WriteLine("Employee is Present");
                    Work_Hours = 8;
                    EmpWage = Wage_per_hour * Work_Hours;
                    Console.WriteLine("FullWage is = " + EmpWage);
                    break;

                default: Console.WriteLine("Attendance error");
                    break;
            }
        }

        public static void CalculateMonthlyWage()
        {
            int EmpWage = 0;
            int Wage_per_hour = 20;
            int Work_Hours = 0;
            int totalwage = 0;
            for (int i = 0; i < 20; i++)
            {
                Random check = new Random();
                int range = check.Next(0, 3);

                switch (range)
                {
                    case 0:
                        Console.WriteLine("Employee is Absent");

                        Console.WriteLine("Wage is = " + EmpWage);

                        break;
                    case 1:
                        Work_Hours = 4;
                        Console.WriteLine("Employee is Present");
                        break;
                    case 2:
                        Console.WriteLine("Employee is Present");
                        Work_Hours = 8;
                        
                        break;

                    default:
                        Console.WriteLine("Attendance error");
                        break;
                }

                EmpWage = Wage_per_hour * Work_Hours;
                totalwage += EmpWage;
                Console.WriteLine("Wage of the day " + EmpWage);
            }
            Console.WriteLine("Total Monthly age is "+totalwage);
        }
    } 
}
