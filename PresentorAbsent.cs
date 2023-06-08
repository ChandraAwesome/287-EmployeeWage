using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRoll
{
    internal class PresentorAbsent
    {
        public static void CheckPresentAbsent()
        {
            Random check = new Random();
            int range = check.Next(0, 2);

            if (range == 0)
            {
                Console.WriteLine("Employee is Absent");
            } 
            else
                {
                    Console.WriteLine("Employee is Present");
                }
            }
        }
    }
 


