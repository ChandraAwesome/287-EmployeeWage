using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRoll
{
    internal class Wagefor100Hours
    {
        public static void HunderedHours()
        {
            int EmpWage = 0;
            int Wage_per_hour = 20;
            int Work_Hours = 0;
            int totalwage = 0;
            int max_hours_work = 100;

            int empHrs = 0, totalempHrs = 0, totalWorkingDays = 0;

            while (totalempHrs<=max_hours_work && totalWorkingDays<20)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case 1:
                        empHrs = 4; break;
                    case 2:
                        empHrs = 8; break;
                    default: empHrs = 0; break;
                }
                totalempHrs += empHrs;
                Console.WriteLine("Days" + (totalWorkingDays + 1) + "Emp Hrs :" + empHrs);
            }
            int totalempWage = totalempHrs * Wage_per_hour;
            Console.WriteLine("totalwage per month is : " + totalempWage);

        }
        
    }
}
