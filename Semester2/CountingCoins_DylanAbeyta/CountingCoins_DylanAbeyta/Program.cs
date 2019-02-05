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
        static int startInt = 0;
        static int temp = 0;
        static List<string> file = new List<string>();

        static void Main(string[] args)
        {
            float moneyAmount = 0f;
            float qMoney = 0f;
            float dMoney = 0f;
            float nMoney = 0f;
            float pMoney = 0f;
            float hMoney = 0f;


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
                    startInt = 6;
                    temp = intFinder(file[i], startInt);                
                    pMoney = temp * .01f;
                    moneyAmount += pMoney;
                }

                if (file[i].Contains("NICKEL"))
                {
                    startInt = 7;
                    temp = intFinder(file[i], startInt);
                    nMoney = temp * .05f;
                    moneyAmount += nMoney;
                }

                if (file[i].Contains("DIME"))
                {
                    startInt = 5;
                    temp = intFinder(file[i], startInt);
                    dMoney = temp * .1f;
                    moneyAmount += dMoney;

                }

                if (file[i].Contains("QUARTER"))
                {
                    startInt = 8;
                    temp = intFinder(file[i], startInt);
                    qMoney = temp * .25f;
                    moneyAmount += qMoney;

                }

                if (file[i].Contains("HALFDOLLAR"))
                {
                    startInt = 11;
                    temp = intFinder(file[i], startInt);
                    hMoney = temp * .50f;
                    moneyAmount += hMoney;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Total Money Of Amount: $" + moneyAmount.ToString("0.00"));
            Console.ReadLine();
        }

        //this makes it so the only thing read is are the intergers
        static int intFinder(string file, int startInt)
        {
            temp = 0;

            temp = int.Parse(file.Substring(startInt));

            return temp;
        }

    }
}
