using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamWriting_DylanAbeyta
{
    class Program
    {
        static Random rand = new Random();
        static int[] array = new int[10];

        static void Main(string[] args)
        {          
            int input = 0;
            do
            {
                Console.WriteLine("1) save a random array to a file");
                Console.WriteLine("2) load a random array from a file");
                Console.WriteLine("3) exit");
                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    ArrayToFile();
                }
                else if (input == 2)
                {
                    LoadArray();
                }
            } while (input != 3);
        }

        static void ArrayToFile()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 10);
            }
           
            string path = AppDomain.CurrentDomain.BaseDirectory + @"Exmaple.txt";

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("hello");

                for (int i = 0; i < array.Length; i++)
                {
                    sw.Write("| " + array[i] + " |");
                }
            }
        }

        static void LoadArray()
        {
           string path = AppDomain.CurrentDomain.BaseDirectory + @"Exmaple.txt";
         
            List<string> file = new List<string>();

            using (StreamReader sr = new StreamReader(path))
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
        }
    }
}
