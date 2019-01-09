using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintMethod_DylanAbeyta
{
    class Program
    {
        static int a = 5;
        static int[] array = new int[4] { 1, 2, 3, 4 };
        static int[,] array2 = new int[3, 5] { { 1, 3, 4, 6, 7 }, { 5, 2, 7, 4, 9 }, { 1, 2, 3, 4, 5 } };
        static int[][] jarray = new int[5][];
        

        static void Main(string[] args)
        {
            jarray[0] = new int[5];
            jarray[1] = new int[2];
            jarray[2] = new int[4];
            jarray[3] = new int[6];
            jarray[4] = new int[9];

            jarray[0] = new int[] { 1, 3, 5, 7, 9 };
            jarray[1] = new int[] { 0, 2, };
            jarray[2] = new int[] { 0, 2, 4, 6 };
            jarray[3] = new int[] { 0, 2, 4, 6, 8 };
            jarray[4] = new int[] { 0, 2, 4, 6, 4, 5, 8, 1, 7 };

            print();
           // print(a);
            Console.WriteLine();
           // print(array);
            Console.WriteLine();
           // print(array2);
            Console.WriteLine();
           // print(jarray);
            Console.ReadKey();
        }
        static void print(int a)
        {
            Console.WriteLine("Integer " + a);
        }
        static void print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("|" + array[i] + "|");
            }
            Console.WriteLine();
        }
        static void print(int[,] array2)
        {
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    Console.Write("|" + array2[i, j] + "|");
                }
                Console.WriteLine();
            }
        }
        static void print(int[][] jarray)
        {
            for (int i = 0; i < jarray.GetLength(0); i++)
            {
                for (int j = 0; j < jarray[i].Length; j++)
                {
                    Console.Write("|" + jarray[i][j] + "|");
                }
                Console.WriteLine();
            }
        }
        static void print()
        {
            double x = Math.PI;
            string num2 = "0.";
            string printval = x.ToString("0.##");         
            Console.WriteLine("what is the precision parameter");
            int num = int.Parse(Console.ReadLine());
            if (num < 2)
            {
                num = 2;
            }
            for (int i = 0; i < num; i++)
            {
                num2 += ('#');
            }                   
            Console.Write(x.ToString(num2));
        }
    }
}
