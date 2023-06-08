using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRoll
{
    internal class Wage
    {
        public static void CalculateWage()
        {
            int EmpWage = 0;
            int Wage_per_hour = 20;
            int Work_Hours = 8;
            Random check = new Random();
            int range = check.Next(0, 2);

            if (range == 0)
            {
                Console.WriteLine("Employee is Absent");

                Console.WriteLine("Wage is = " + EmpWage);
            }
            else
            {
                Console.WriteLine("Employee is Present");

                EmpWage = Wage_per_hour * Work_Hours;
                Console.WriteLine("Wage is = "+ EmpWage);
            }
        }

        public static void AddPartTime()
        {
            int EmpWage = 0;
            int Wage_per_hour = 20;
            int Work_Hours = 0;
            Random check = new Random();
            int range = check.Next(0, 3);

            if (range == 0)
            {
                Console.WriteLine("Employee is Absent");

                Console.WriteLine("Wage is = " + EmpWage);
            }
            else if (range == 1) 
            {
                Work_Hours = 4;
                EmpWage = Wage_per_hour * Work_Hours;
                Console.WriteLine("Part Time Wage is " + EmpWage);
            }
            else
            {
                Console.WriteLine("Employee is Present");
                Work_Hours = 8;
                EmpWage = Wage_per_hour * Work_Hours;
                Console.WriteLine("FullWage is = " + EmpWage);
            }
        }
    }
    
}
