using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class VowelOrConsonant
    {
        public static void VowelConsonant()
        {
            Console.WriteLine("Enter the Alphabet between A to Z: ");
            char alphabet = Convert.ToChar(Console.ReadLine());
            switch(alphabet)
            {
                case 'a':
                    Console.WriteLine("{0} is vowel", alphabet);
                    break;
                case 'e':
                    Console.WriteLine("{0} is vowel", alphabet);
                    break;
                case 'i':
                    Console.WriteLine("{0} is vowel", alphabet);
                    break;
                case 'o':
                    Console.WriteLine("{0} is vowel", alphabet);
                    break;
                case 'u':
                    Console.WriteLine("{0} is vowel", alphabet);
                    break;
                default:
                    Console.WriteLine("Enter alphabet is Consonant");
                    break;
            }

            
        }

    }
}
