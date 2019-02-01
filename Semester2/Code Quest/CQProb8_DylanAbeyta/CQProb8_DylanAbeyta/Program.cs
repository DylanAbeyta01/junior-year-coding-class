using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQProb8_DylanAbeyta
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<float>> allfloats = new List<List<float>>();

            float newNum = 0;

            string path = "C:/Users/185236/Documents/junior-year-coding-class/Semester2/Code Quest/Prob08.in.txt";

            using (StreamReader sr = new StreamReader(path))
            {
                int hold = int.Parse(sr.ReadLine());

                for (int i = 0; i < hold; i++)
                {
                    List<float> numbers1 = new List<float>();
                    allfloats.Add(numbers1);

                    string[] hold1 = (sr.ReadLine()).Split(' ');

                    for (int j = 0; j < hold1.Length; j++)
                    {
                        numbers1.Add(float.Parse(hold1[j]));
                    }
                }
            }

            for (int i = 0; i < allfloats.Count; i++)
            {
                for (int j = 0; j < allfloats[i].Count; j++)
                {
                    if (allfloats[i][j] < 180)
                    {
                        newNum = allfloats[i][j] + 180;
                    }

                    else if (allfloats[i][j] > 180)
                    {
                        newNum = allfloats[i][j] - 180;
                    }

                    Console.Write(newNum + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
