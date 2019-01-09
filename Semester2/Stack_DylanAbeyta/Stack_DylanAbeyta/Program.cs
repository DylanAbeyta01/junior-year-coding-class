using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_DylanAbeyta
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();
            
            int input;
            do
            {
                Console.WriteLine("***************");
                Console.WriteLine("** 1) Push");
                Console.WriteLine("** 2) Pop");
                Console.WriteLine("** 3) Peek");
                Console.WriteLine("** 4) Print");
                Console.WriteLine("** 5) search");
                Console.WriteLine("** 6) quit");
                Console.WriteLine("***************");
                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    Console.WriteLine("What number would you like to input?");
                    int num = int.Parse(Console.ReadLine());
                    
                    myStack.Push(num);
                }

                if (input == 2)
                {
                   int temp = myStack.Pop();
                   Console.WriteLine("Number removed: " + temp);
                }

                if (input == 3)
                {
                    int temp = myStack.Peek();
                    Console.WriteLine("Number at the top of the list: " + temp);
                }

                if (input == 4)
                {
                    myStack.Print();
                }

                if (input == 5)
                {
                    Console.WriteLine("What number would you like to find?");
                    int val = int.Parse(Console.ReadLine());
                    int num = myStack.Search(val);
                    if (num == -1)
                    {
                        Console.WriteLine("Your Number Does not exists");
                    }
                      else      
                    Console.WriteLine("your number is in the " + num + " place");


                }

            } while (input != 6);
            Console.ReadKey();
                      
        }
    }
}
