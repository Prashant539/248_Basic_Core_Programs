using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class FlipCoin
    {
        int headcount = 0;
        int tailcount = 0;
        double headpercentage = 0;
        double tailpercentage = 0;
        public void Flip()
        {
           Console.WriteLine("Enter the value for Number of flips: ");
           int numberofFlip = Convert.ToInt32(Console.ReadLine());

            if (numberofFlip > 0)
            {
                for (int i = 0; i < numberofFlip; i++)
                {
                    Random random = new Random();
                    int number = random.Next(0, 2);

                    if (number == 0)
                    {
                        tailcount++;
                    }
                    else
                    {
                        headcount++;
                    }
                    Console.WriteLine("Tailcount:{0} Headcount:{1}", tailcount, headcount);

                }
                headpercentage = headcount + 100 / numberofFlip;
                tailpercentage = tailcount + 100 / numberofFlip;
                Console.WriteLine("Head Percentage % ==> " + headpercentage);
                Console.WriteLine("Tail Percentage % ==>" + tailpercentage);
            }
            else
            {
                Console.WriteLine("The number of Flip is not Valid");
                Console.ReadLine();
            }

        }
    }
}
