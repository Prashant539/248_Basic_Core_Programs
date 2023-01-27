using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class LargestNumber
    {
        public static void LargestNumberPrint()
        {
            Console.WriteLine("Enter the First Number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Third Number: ");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());
            if(firstNumber > secondNumber )
            {
                if(firstNumber > thirdNumber)
                {
                    Console.WriteLine("First number is the Largest number amog three: ");
                }
                else
                {
                    Console.WriteLine("Third number is the largest number among three");
                }
            }
            else if(secondNumber > thirdNumber)
            {
                Console.WriteLine("Second number is the largest number among three");
            }
            else
            {
                Console.WriteLine("Third number is the largest number among three");
            }
            Console.ReadLine();


        }
    }
}
