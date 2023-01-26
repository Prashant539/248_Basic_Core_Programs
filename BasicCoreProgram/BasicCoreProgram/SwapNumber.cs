using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class SwapNumber
    {
        int a, b, temp;
        public void SwapNunberPrint()
        {
           
            Console.WriteLine("Enter the First number to Swap: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second number to Swap: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before the Swaping Number is a = {0}, b = {1}", a, b);
            temp = a;
            a = b;
            b = temp;

            Console.WriteLine("After the Swaping value of a = {0}, b = {1}", a, b);
        }
    }
}
