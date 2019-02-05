using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingCoins_DylanAbeyta
{
    class Program
    {
        static List<string> file = new List<string>();
        static void Main(string[] args)
        {
            float moneyAmount = 0f;

            string path1 = AppDomain.CurrentDomain.BaseDirectory + @"Prob01.in_.txt";

            using (StreamReader sr = new StreamReader(path1))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    file.Add(line);
                }
            }

            for (int i = 0; i < file.Count; i++)
            {
                Console.WriteLine(file[i]);
            }

            for (int i = 0; i < file.Count; i++)
            {
                if (file[i].Contains("PENNY"))
                {
                    Console.WriteLine("p");
                }

                if (file[i].Contains("NICKEL"))
                {
                    Console.WriteLine("n");

                }

                if (file[i].Contains("DIME"))
                {
                    Console.WriteLine("d");

                }

                if (file[i].Contains("QUARTER"))
                {
                    Console.WriteLine("q");

                }

                if (file[i].Contains("HALFDOLLAR"))
                {
                    Console.WriteLine("h");

                }


            }




            Console.ReadLine();
        }

        static int intFinder()
        {
            int temp = 0;

            for (int i = 0; i < file.Count; i++)
            {
                for (int j = 0; j < file[i].Length; j++)
                {
                    if (int.TryParse(file[i][j].ToString, out ) == true)
                    {
                        file[i].Remove(file[j]);
                        temp = int.Parse(file[i]);
                    }
                }
            }


            return temp;
        }

    }
}
