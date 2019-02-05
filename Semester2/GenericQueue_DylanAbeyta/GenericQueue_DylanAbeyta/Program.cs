using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericQueue_DylanAbeyta
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericQueue<int> myQueue = new GenericQueue<int>();
            GenericQueue<Currencies> currencies = new GenericQueue<Currencies>();

            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                currencies.EnQueue(new currencies(rand.Next(0, 100), rand.Next(0, 100)));
            }

            int input;
            do
            {
                Console.WriteLine("***************");
                Console.WriteLine("** 1) EnQueue");
                Console.WriteLine("** 2) DeQueue");
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

                    myQueue.EnQueue(num);
                }

                if (input == 2)
                {
                    int temp = myQueue.DeQueue();
                    if (temp == 0)
                    {
                        Console.WriteLine("there are no numbers in the list. Press 1 and DeQueue a value.");
                    }
                    else
                        Console.WriteLine("Number removed: " + temp);
                }

                if (input == 3)
                {
                    int temp = myQueue.Peek();
                    Console.WriteLine("Number at the top of the list: " + temp);
                }

                if (input == 4)
                {
                    myQueue.Print();
                }

                if (input == 5)
                {
                    Console.WriteLine("What number would you like to find?");
                    int val = int.Parse(Console.ReadLine());
                    int num = myQueue.Search(val);
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
