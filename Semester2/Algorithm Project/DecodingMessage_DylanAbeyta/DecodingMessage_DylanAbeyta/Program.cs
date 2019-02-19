using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecodingMessage_DylanAbeyta
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> counter = new List<char>();

            List<string> strings = new List<string>();
            List<char> key = new List<char>();
            List<int> ints = new List<int>();
            List<string> number = new List<string>();

            string path3 = AppDomain.CurrentDomain.BaseDirectory + @"Prob03.in_.txt";

            using (StreamReader sr = new StreamReader(path3))
            {
                key = sr.ReadLine().ToCharArray().ToList();
               
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    List<string> x = line.Split(' ').ToList();
                    for (int i = 0; i < x.Count; i++)
                    {
                        number = x[i].Split('-').ToList();
                        for (int j = 0; j < number.Count; j++)
                        {
                            for (int k = 0; k < key.Count; k++)
                            {
                                Console.Write(key[int.Parse(number[j]) - 1]);
                                break;
                            }                      
                        }
                        Console.Write(" ");
                    }
                  
                    Console.WriteLine();                                
                }
            }
            Console.ReadLine();
        }
    }
}
