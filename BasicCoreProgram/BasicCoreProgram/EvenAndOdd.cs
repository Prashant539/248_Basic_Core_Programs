using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class EvenAndOdd
    {
        public void EvenOdd()
        {
            Console.WriteLine("Enter the Number to find Even or Odd: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int rem;

            rem = num % 2;
            if(rem == 0)
            {
                Console.WriteLine("Enter number is Even");
            }
            else
            {
                Console.WriteLine("Enter Number is Odd");
            }

        }

    }
}
