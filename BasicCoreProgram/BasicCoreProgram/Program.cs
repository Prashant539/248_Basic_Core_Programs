using System;
namespace BasicCoreProgram
{
   internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Core Program");
            Console.WriteLine("Choose Any Options to Perform");
            Console.WriteLine("1:Flipcoin\n2:LeapYear\n3:PowerOf2\n4:HarmonicNumber\n5:PrimeFactor\n6:QuotientReminder\n7:SwapNumber\n8:EvenOdd\n9:VowelConsonant\n10:LargestNumber\n11:Exit");
            int Option = Convert.ToInt32(Console.ReadLine());
            switch(Option)
            {
                case 1:
                    FlipCoin flipCoin = new FlipCoin();
                    flipCoin.Flip();
                    break;
                case 2:
                    LeapYear leapYear = new LeapYear();
                    leapYear.LeapYearCheck();
                    break;
                case 3:
                    PowerOfTwo.PowerCheck();
                    break;
                case 4:
                    HarmonicNumber harmonicNumber = new HarmonicNumber();
                    harmonicNumber.HarmonicSeries();
                    break;
                case 5:
                    PrimeFactor primeFactor = new PrimeFactor();
                    primeFactor.Factor();
                    break;
                case 6:
                    QuotientAndReminder quotientAndReminder = new QuotientAndReminder();
                    quotientAndReminder.QuotientReminderPrint();
                    break;
                case 7:
                        SwapNumber swapNumber = new SwapNumber();
                    swapNumber.SwapNunberPrint();
                    break; 
                case 8:
                    EvenAndOdd evenAndOdd = new EvenAndOdd();
                    evenAndOdd.EvenOdd();
                    break;
                case 9:
                    VowelOrConsonant.VowelConsonant();
                    break;
                case 10:
                    LargestNumber.LargestNumberPrint();
                    break;

                case 11:
                    Console.WriteLine("Press 11 For exit: ");
                    break;
                default:
                    Console.WriteLine("Choose Vailed Options:");
                    break;
            }
           

        }
    }
}
