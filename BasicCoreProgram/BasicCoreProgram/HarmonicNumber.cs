using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class HarmonicNumber
    {
        int n;
        float sum = 0;
        
        public void HarmonicSeries()
        {
            Console.WriteLine("Enter the value of n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("1/" + i + " + ");
                sum = sum + (float)1 / i;
         
            }
            Console.WriteLine("Sum of Harmonic Series is: " + sum);
            Console.ReadLine();
        }
            

    }
}
