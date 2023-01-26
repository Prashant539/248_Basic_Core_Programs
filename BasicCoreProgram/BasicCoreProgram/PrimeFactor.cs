using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class PrimeFactor
    {
        public void Factor()
        {
            int a, b;
            Console.WriteLine("Plese Enter the Number for Prime Factor: ");
            a = Convert.ToInt32(Console.ReadLine());

            for (b = 2; a > 1; b++)
            {
                if (a % b == 0)
                {
                    int x = 0;
                    while (a % b == 0)
                    {
                        a /= b;
                        x++;
                    }
                    Console.WriteLine($"{b} is a prime factor {x} Times");

                }
            }
        }
    }
}
           