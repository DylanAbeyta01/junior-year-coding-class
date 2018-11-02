using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAbeyta_PracticeMain
{
    class Program
    {      
        static void Main(string[] args)
        {
            int input = 0;
            do
            {                
                input = promptUserForInput();

                if (input == 1)
                {
                    square3x3(3, 3);
                    Console.WriteLine();
                }
                if (input == 2)
                {
                    rectangle3x6(6, 3);
                    Console.WriteLine();
                }

                if (input == 3)
                {
                    rectangle6x3(3, 6);
                    Console.WriteLine();
                }
            } while (input != 4);
        }
        static void square3x3(int y, int x)
        {
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
            }
        }
        static void rectangle3x6(int y, int x)
        {
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
            }
        }
        static void rectangle6x3(int y, int x)
        {
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
            }
        }
        static int promptUserForInput()
        {
            Console.WriteLine("***************************");
            Console.WriteLine("**1) Print a 3x3 square ");
            Console.WriteLine("**2) Print a 3x6 Rectangle");
            Console.WriteLine("**3) Print a 6x3 Rectangle");
            Console.WriteLine("**4) quit");
            Console.WriteLine("***************************");

            int input = int.Parse(Console.ReadLine());

            return input;
        }
    }
}
