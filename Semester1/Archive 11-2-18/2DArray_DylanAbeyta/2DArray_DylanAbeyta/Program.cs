﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArray_DylanAbeyta
{
    class Program
    {
        static int[,] array = new int[10, 5];
        static void Main(string[] args)
        {          
            for (int i  = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = i * j; 
                }              
            }
            Print2DArray(array);
            Console.ReadKey();
        }
        static void Print2DArray(int [,] array)
        {          
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {                   
                    Console.Write("| " + array[i, j] + " | ");
                }
                Console.WriteLine();
            }
        }
    }
}
