using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jaggedArray_DylanAbeyta
{
    class Program
    {
     static int[][] jarray = new int[10][];

        static void Main(string[] args)
        {
            for (int i = 0; i < jarray.GetLength(0); i++)
            {
                jarray[i] = new int[i + 1];
                for (int j = 0; j < jarray[i].Length; j++)
                {
                    jarray[i][j] = i * j;
                }               
            }
            Print2Djarray(jarray);
            Console.ReadKey();
        }
        static void Print2Djarray(int [][] jarray)
        {
            for (int i = 0; i < jarray.GetLength(0); i++)
            {               
                for (int j = 0; j < jarray[i].Length; j++)
                {
                    Console.Write(" | " + jarray[i][j] + " | ");
                }
                Console.WriteLine();
            }
        }
    }
}
