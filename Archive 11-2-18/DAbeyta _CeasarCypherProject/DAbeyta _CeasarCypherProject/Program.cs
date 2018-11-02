using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAbeyta__CeasarCypherProject
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
                Console.WriteLine("**3) encrypt");
                Console.WriteLine("**4) decrypt");
                Console.WriteLine("**5) brute force");
                Console.WriteLine("**6) quit");
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
                if (input == 3)
                {
                    encrypt();

                }
                if (input == 4)
                {
                    decrypt();
                }
                if (input == 5)
                {
                    brute();
                }

            } while (input != 6);
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
        static void encrypt()
        {
            string word = "";
            int shift = 0;
            Console.WriteLine("What value would you like me to shift by");
            shift = int.Parse(Console.ReadLine());
            Console.WriteLine("what word you like to input");
            word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                int v = (word[i] + shift);
                if (v > 122)
                {
                    v = ((word[i] + shift) - 26);
                }

                char CharValue = ((char)v);
                Console.Write(CharValue);

            }
            Console.WriteLine();
        }
        static void decrypt()
        {
            string word = "";
            int shift = 0;
            Console.WriteLine("What value would you like me to shift by");
            shift = int.Parse(Console.ReadLine());
            Console.WriteLine("what word you like to input");
            word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                int v = (word[i] - shift);
                if (v < 97)
                {
                    v = ((word[i] - shift) + 26);
                }

                char CharValue = ((char)v);
                Console.Write(CharValue);

            }
            Console.WriteLine();
        }
        static void brute()
        {
            string word = "";
            int num = 0;
            Console.WriteLine("What word would you like me to use brute force to decode");
            word = Console.ReadLine();
            for (int j = 1; j < 26; j++)
            {

                for (int i = 0; i < word.Length; i++)
                {
                    int v = word[i];
                    num = (v + j);
                    if (num > 122)
                    {
                        num = (num - 26);
                    }
                    char charValue = ((char)num);
                    Console.Write(charValue);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

    }
}
