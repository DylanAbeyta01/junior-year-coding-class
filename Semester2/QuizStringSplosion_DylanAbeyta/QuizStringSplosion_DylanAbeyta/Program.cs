using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizStringSplosion_DylanAbeyta
{
    class Program
    {
        static void Main(string[] args)
        {
            string example = "hello";

            StringSplosion(example);
            Console.ReadKey();
        }

        static void StringSplosion(string example)
        {
            for (int i = 0; i < example.Length; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write(example[j]);
                }
            }
        }
    }
}
