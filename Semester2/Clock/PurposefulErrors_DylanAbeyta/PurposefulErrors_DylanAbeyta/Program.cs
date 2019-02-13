using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurposefulErrors_DylanAbeyta
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> new1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            List<int> new2 = new List<int>() { 7, 6, 5, 4, 3, 2, 1 };
            List<int> new3 = new List<int>();

            //unsolved problem
            for (int i = 0; i < new1.Count; i++)
            {
                new3.Add(new1[i]);
            }

            for (int i = 0; i < new2.Count; i++)
            {
                new3.Add(new2[i]);
            }

            for (int i = 0; i < new3.Count; i++)
            {
                Console.Write(new3[i] + ", ");
            }

            // solved problem
            Console.WriteLine();
            List<int> new4 = new1.Concat(new2).ToList();

            for (int i = 0; i < new4.Count; i++)
            {
                Console.Write(new4[i] + ", ");
            }

            Console.ReadLine();
        }
    }
}
