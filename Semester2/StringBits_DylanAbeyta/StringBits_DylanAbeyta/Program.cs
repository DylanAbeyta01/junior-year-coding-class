using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBits_DylanAbeyta
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string example = "example";

            for (int i = 0; i < example.Length; i++)
            {
                counter++;
                if (counter == 2)
                {
                    counter = 0;
                }
                if (counter == 1)
                {
                    Console.Write(example[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
