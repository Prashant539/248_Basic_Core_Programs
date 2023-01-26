using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class QuotientAndReminder
    {
        public void QuotientReminderPrint()
        {
            Console.WriteLine("Enter Divident Value: ");
            int Divident = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Divisor Value: ");
            int Divisor = Convert.ToInt32(Console.ReadLine());

            int quotient = Divident / Divisor;
            int reminder = Divident % Divisor;

            Console.WriteLine("Divident is: " + Divident);
            Console.WriteLine("Divisor is: " + Divisor);
            Console.WriteLine("Quotent is: " + quotient);
            Console.WriteLine("Reminder is: " + reminder); 
        }
    }
}
