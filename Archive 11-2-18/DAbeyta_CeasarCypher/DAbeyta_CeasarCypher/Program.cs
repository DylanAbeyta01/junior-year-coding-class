using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAbeyta_CeasarCypher
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            do
            {               
                Console.WriteLine("***************************************************");
                Console.WriteLine("**1) print lower case alphabets and their numbers**");
                Console.WriteLine("**2) print all 13000 characters** ");
                Console.WriteLine("**3) quit");
                Console.WriteLine("****************************************************");
                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    alphabet();
                }

                if (input == 2)
                {
                    allSymbols();
                }
            } while (input != 3);            
        }
        static void alphabet()
        {
            string alpha = "abcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < alpha.Length; i++)
            {
                int v = alpha[i];
                Console.WriteLine(v + " = " + alpha[i]);
            }
        }
        static void allSymbols()
        {
            for (int i = 0; i < 13000; i++)
            {
                int num = i;
                char c = (char)num;
                Console.Write(c);
            }
            Console.WriteLine();
        }
    }
}
