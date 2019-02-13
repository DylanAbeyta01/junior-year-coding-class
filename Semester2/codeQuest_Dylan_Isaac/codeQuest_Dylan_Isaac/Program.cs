using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeQuest_Dylan_Isaac
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> file = new List<int>();
          
            string path3 = AppDomain.CurrentDomain.BaseDirectory + @"Prob01.in.txt";

            using (StreamReader sr = new StreamReader(path3))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    List<string> commas = line.Split(',').ToList();

                    commas.Add(line);


                    for (int i = 0; i < commas.Count; i++)
                    {
                        Console.Write(commas[i]);
                    }
                    commas = int.Parse(commas);

                    List<int> final = commas.OrderBy(x => x.).ToList();
                }
            }

            Console.ReadLine();
            
        }
    }
}
