﻿using System;
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

            string path3 = AppDomain.CurrentDomain.BaseDirectory + @"Prob03.in_.txt";

            using (StreamReader sr = new StreamReader(path3))
            {
                key = sr.ReadLine().ToCharArray().ToList();

                string line;

                while ((line = sr.ReadLine()) != null)
                {
                  string[] x = line.Split(' ');
                    for (int i = 0; i < x.Length; i++)
                    {
                        string[] number = x[i].Split('-');
                        for (int j = 0; j < number.Length; j++)
                        {
                            Console.Write(number[j]);
                        }
                    }                                   

                    for (int i = 0; i < strings.Count; i++)
                    {
                        ints.Add(int.Parse(strings[i]));
                    }
                }
     
                for (int i = 0; i < key.Count; i++)
                {
                    counter.Add(key[i]);
                    Console.WriteLine(counter[i]);
                }                              
            }
            Console.ReadLine();
        }
    }
}
