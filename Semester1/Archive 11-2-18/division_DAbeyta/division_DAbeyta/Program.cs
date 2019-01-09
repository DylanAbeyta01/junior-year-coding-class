using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace division_DAbeyta
{
    class Program
    {
        static int input = 0;
        static int radix = 0;       
        
        static void Main(string[] args)
        {
            bool negative = true;

            Console.WriteLine("what number would you like to input?");
            input = int.Parse(Console.ReadLine());
            if (input < 0)
            {
                negative = false;              
            }
          
            Console.WriteLine("what would you like the base of your number to be? ");
            radix = int.Parse(Console.ReadLine());

            if (negative == false)
            {
                Console.Write("-");
                negative = true;
                input = input * input / input;
            }

            allRadixPrint();

            Console.WriteLine();
            Console.ReadKey();

        }
        static void allRadixPrint()
        {           
            int product = input / radix;
            int remainder = input - (product * radix);
            input = product;
       
            if (product!= 0)
            {
                allRadixPrint();
            }           
            Console.Write(remainder);           
        }
    }
}
