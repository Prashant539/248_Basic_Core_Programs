using System;
namespace BasicCoreProgram
{
   internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Core Program");
            Console.WriteLine("Choose Any Options to Perform");
            Console.WriteLine("1:Flipcoin\n11:Exit");
            int Option = Convert.ToInt32(Console.ReadLine());
            switch(Option)
            {
                case 1:
                    FlipCoin flipCoin = new FlipCoin();
                    flipCoin.Flip();
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
