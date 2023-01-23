using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class LeapYear
    {
        int year;
        public void LeapYearCheck()
        {
            Console.WriteLine("Enter the Year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            if (((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0)))
            {
                Console.WriteLine("The Year is a Leap Year");
            }
            else
            {
                Console.WriteLine("The Year in not a Leap Year");
            }
        }
    }
}
                    

          
