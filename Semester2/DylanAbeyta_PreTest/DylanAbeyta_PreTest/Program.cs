using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DylanAbeyta_PreTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            do
            {
                Console.WriteLine("********************************");
                Console.WriteLine("1)  Print Hello World");
                Console.WriteLine("2)  Add two user input integers together");
                Console.WriteLine("3)  Calulcate the area of a circle \n given just the radius from user input");
                Console.WriteLine("4)  Calculate the area of a triangle \n given the length of all three sides from user input");
                Console.WriteLine("5)  Given an integer n from user input, \n draw a square using the ASCII character 'X' that has the width of n");
                Console.WriteLine("6)  Given an integer n from user input, \n draw a hollow square using the ASCII character 'X' that has a width of n");
                Console.WriteLine("7)  Given two integer variables from user \n input, swap their values");
                Console.WriteLine("8)  Reverse a string from user input using a for loop");
                Console.WriteLine("9)  End the program");
                Console.WriteLine("********************************* ");
                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    print1();
                }

                if (input == 2)
                {
                    print2();
                }

                if (input == 3)
                {
                    print3();
                }

                if (input == 4)
                {
                    print4();
                }

                if (input == 5)
                {
                    print5();
                }

                if (input == 6)
                {
                    print6();
                }

                if (input == 7)
                {
                    print7();
                }

                if (input == 8)
                {
                    print8();
                }


            } while (input != 9);

            Console.ReadLine();
        }

        static void print1()
        {
            Console.WriteLine("Hello World");
        }

        static void print2()
        {
            Console.WriteLine("Enter first value");
            int input1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second value");
            int input2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Answer: " + (input1 + input2));
        }

        static void print3()
        {
            Console.WriteLine("Enter radius");
            int radius = int.Parse(Console.ReadLine());

            Console.WriteLine("Area of the circle: " + (Math.PI * Math.Pow(radius, 2)));
        }

        static void print4()
        {
            Console.WriteLine("enter first side length");
            int side1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second side length");
            int side2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter third side length");
            int side3 = int.Parse(Console.ReadLine());

            int p = (side1 + side2 + side3) / 2;

            int a = p * (p - side1) * (p - side2) * (p - side3);

            double area = Math.Sqrt(a);

            Console.WriteLine(area);
        }

        static void print5()
        {
            Console.WriteLine("Enter width of desired square");
            int Width = int.Parse(Console.ReadLine());

            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
        }

        static void print6()
        {
            Console.WriteLine("Enter width of desired square");
            int Width = int.Parse(Console.ReadLine());

            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    if (i == 0 || i == Width - 1 || j == 0 || j == Width - 1)
                        Console.Write("X");                  
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        static void print7()
        {
            int temp;
            Console.WriteLine("Enter first value");
            int value1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second value");
            int value2 = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine(value1);
            Console.WriteLine(value2);

            temp = value1;
            value1 = value2;
            value2 = temp;

            Console.WriteLine(value1);
            Console.WriteLine(value2);
        }

        static void print8()
        {
            Console.WriteLine("Enter a word");
            string String = Console.ReadLine();
            for (int i = String.Length - 1; i >= 0; i--)
            {
                Console.Write(String[i]);
            }
            Console.WriteLine();
        }
    }
}
