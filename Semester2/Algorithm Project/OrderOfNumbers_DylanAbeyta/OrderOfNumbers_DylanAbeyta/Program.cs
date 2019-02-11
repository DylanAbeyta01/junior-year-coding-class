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

            List<List<int>> file = new List<List<int>>();
            List<string> strings = new List<string>();

            string path2 = AppDomain.CurrentDomain.BaseDirectory + @"Prob02.in_.txt";

            using (StreamReader sr = new StreamReader(path2))
            {

                while ((line = sr.ReadLine()) != null)
                {                   
                    strings = line.Split(' ').ToList();
                    bool valid = true;
                    List<int> ints = new List<int>();

                    for (int i = 0; i < strings.Count; i++)
                    {
                        if (int.TryParse(strings[i], out result) == true)
                        {
                            ints.Add(int.Parse(strings[i]));
                        }
                        else
                        {
                            Console.WriteLine("input was invalid");
                            valid = false;
                        }                            
                    }
                    
                    if (valid == true)
                    {
                        bool Acc = true;
                        bool Decc = true;

                        for (int i = 1; i < ints.Count; i++)
                        {
                            if (ints[i - 1] > ints[i])
                            {
                                Acc = false;
                                break;
                            }     
                        }

                        for (int i = 1; i < ints.Count; i++)
                        {
                            if (ints[i - 1] < ints[i])
                            {
                                Decc = false;
                                break;
                            }
                        }

                        if (Acc == true)
                        {
                            Console.WriteLine("is Accending");
                        }

                        if (Decc == true)
                        {
                            Console.WriteLine("is Deccending");
                        }

                        if (Decc == false && Acc == false && valid == true)
                        {
                            Console.WriteLine("the order is random");
                        }
                    }
                }
            }          
            Console.ReadLine();
        }
    }
}
