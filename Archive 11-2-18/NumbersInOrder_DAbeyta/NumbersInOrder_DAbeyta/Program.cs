using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersInOrder_DAbeyta
{
    class Program
    {
        static int[] array = new int[10];
        static int seed = 123456789;
        static Random rand = new Random(seed);

        static void Main(string[] args)
        {          
            // creates a random order of 10 numbers
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 10);
                Console.Write(array[i]);
            }
            LowToHigh();
            HighToLow();
                                       
            Console.ReadKey();
        }   
        static void LowToHigh()
        {
            Console.WriteLine();
            Console.Write("Number Order from low to high: ");
            // fixes the order of the numbers
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        int k = array[i];
                        array[i] = array[j];
                        array[j] = k;

                    }
                }
            }
            // write the order to the user
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
        }
        static void HighToLow()
        {
            Console.WriteLine();
            Console.Write("Number Order from High to Low: ");
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int k = array[i];
                        array[i] = array[j];
                        array[j] = k;

                    }
                }
            }
            // write the order to the user
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
        }
    }
}
