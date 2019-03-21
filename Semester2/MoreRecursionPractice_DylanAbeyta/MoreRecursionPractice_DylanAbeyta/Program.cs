using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreRecursionPractice_DylanAbeyta
{
    class Program
    {
        static Random rand = new Random(1234);
        static void Main(string[] args)
        {
            bool result = true;
            List<int> integers = new List<int>();
            for (int i = 0; i < 1000; i++)
                integers.Add(rand.Next(0, 1000));

            integers.Sort();
            result = SearchIntList(integers, 10);

            Console.Write(result);
            Console.ReadLine();
        }

        public static bool SearchIntList(List<int> integers, int n)
        {
            return SearchIntListRecursive(integers, n, 0, integers.Count - 1);
        }

        private static bool SearchIntListRecursive(List<int> integers, int n, int lowerBound, int upperBound)
        {
            if (lowerBound == upperBound)
                return false;

            int midpoint = ((upperBound - lowerBound) / 2) + lowerBound;

            if (integers[midpoint] == n)
                return true;

            if (lowerBound + 1 == upperBound)
                return false;

            if (integers[midpoint] > n)
                return SearchIntListRecursive(integers, n, lowerBound, midpoint);
            
            if (integers[midpoint] < n)
                return SearchIntListRecursive(integers, n, midpoint, upperBound);

            return false;
        }
    }
}
