using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderOfNumbers_DylanAbeyta
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            int result;
            bool Valid = true;
            

            List<List<int>> file = new List<List<int>>();
            List<string> num = new List<string>();
            List<string> strings = new List<string>();


            string path2 = AppDomain.CurrentDomain.BaseDirectory + @"Prob02.in_.txt";

            using (StreamReader sr = new StreamReader(path2))
            {

                while ((line = sr.ReadLine()) != null)
                {
                    strings = line.Split(' ').ToList();
                    List<int> ints = new List<int>();
                    for (int i = 0; i < strings.Count; i++)
                    {
                        if (int.TryParse(strings[i], out result) == true)
                        {
                            ints.Add(int.Parse(strings[i]));
                        }
                        else
                            Valid = false;
                    }
                    file.Add(ints);
                }
            }

            for (int i = 0; i < file.Count; i++)
            {
                Console.WriteLine(file[i]);
            }

            for (int i = 0; i < num.Count; i++)
            {
                for (int j = 0; j < num[i].Length; j++)
                {
                    if (num[i][j] > num[i][j + 1] || num[i][j] == num[i][j + 1])
                    {
                        Console.WriteLine("it is ascending");
                    }

                    if (num[i][j] < num[i][j + 1] || num[i][j] == num[i][j + 1])
                    {
                        Console.WriteLine("it is desending");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
